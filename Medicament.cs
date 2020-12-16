using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Medicament : Form
    {
        private string _categoryName;

        public string CategoryName { get => _categoryName; set => _categoryName = value; }

        public Medicament(string categoryName)
        {
            InitializeComponent();
            CategoryName = categoryName;
            InitializeMedicament();
            SetSettings();
        }

        //Инициализация медикаментов и создание панели для них
        private void InitializeMedicament()
        {
            string query = $"SELECT * FROM SearchOnCategoryName(N'{CategoryName}');";
            DataSet medicamentDataSet = Info.sql.CreateDataSet(query);
            for (int i = medicamentDataSet.Tables[0].Rows.Count - 1; i >= 0; i--)
            {
                BaseMedicament medicament = new BaseMedicament(medicamentDataSet.Tables[0].Rows[i]);
                CreateMedicamentPanel(medicament);
            }
        }

        private void RefreshMedicaments()
        {
            Medicament medicament = new Medicament(CategoryName);
            //Удаляем все контролы, которые принадлежали subMenuPanel, чтобы добавить новый контрол
            Panel subMenuPanel = (Panel)this.Parent;
            DisposeSubMenuPanel(subMenuPanel);
            subMenuPanel.Controls.Add(medicament);
            subMenuPanel.Tag = medicament;
            medicament.BringToFront();
            medicament.Show();
        }

        //Начальные установки
        private void SetSettings()
        {
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //Метод клика по лекарству
        public void medicamentClick(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            byte id = (byte)panel.Tag;
            BaseMedicament medicament = new BaseMedicament(id);
            MedicamentDescription medicamentDescription = new MedicamentDescription(medicament);
            //Вычисляю панель subMenuPanel, которая является родительской для текущей формы
            Panel subMenuPanel = (Panel)this.Parent;
            DisposeSubMenuPanel(subMenuPanel);
            subMenuPanel.Controls.Add(medicamentDescription);
            subMenuPanel.Tag = medicamentDescription;
            medicamentDescription.BringToFront();
            medicamentDescription.Show();
        }

        //Метод клика по кнопке Buy
        private void ClickBtnBuy(object sender, EventArgs e)
        {
            Button btnBuy = (Button)sender;
            //Находим панель, к который принадлежит кнопка
            Panel panel = (Panel)btnBuy.Parent;
            //Вычисляем количество, которое надо купить
            var control = panel.Controls.Find($"textBoxMedicamentQuantity{(byte)panel.Tag}", false);//В panel.Tag есть информация об Id лекарства
            TextBox textBoxQuantity = (TextBox)control[0];
            int quantity = Int32.Parse(textBoxQuantity.Text);
            //Вычисляем количество в наличии
            control = panel.Controls.Find($"labelMedicamentHave{(byte)panel.Tag}", false);//В panel.Tag есть информация об Id лекарства
            Label labelHaveQuantity = (Label)control[0];
            int haveQuantity = Convert.ToInt32(labelHaveQuantity.Tag);
            if (haveQuantity >= quantity)
            {
                Info.sql.ConnectionOpen();
                string query = "BuyMedicament";
                SqlCommand command = Info.sql.CreateCommand(query);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@personalId", SqlDbType.TinyInt).Value = Info.personal.personalId;
                command.Parameters.AddWithValue("@medicamentId", (byte)btnBuy.Tag);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.ExecuteNonQuery();
                Info.sql.ConnectionClose();
                MessageBox.Show("Вы совершили покупку");
                RefreshMedicaments();
            }
            else
            {
                MessageBox.Show("Недостаточно товара в наличии");
            }
        }
        //Метод клика по кнопке Заказать
        private void ClickBtnOrder(object sender, EventArgs e)
        {
            Button btnBuy = (Button)sender;
            //Находим панель, к который принадлежит кнопка
            Panel panel = (Panel)btnBuy.Parent;
            //Вычисляем количество, которое надо заказать
            var control = panel.Controls.Find($"textBoxMedicamentQuantity{(byte)panel.Tag}", false);//В panel.Tag есть информация об Id лекарства
            TextBox textBoxQuantity = (TextBox)control[0];
            int quantity = Int32.Parse(textBoxQuantity.Text);
            //Заказ лекарства
            SqlCommand command = Info.sql.CreateCommand("OrderMedicament");
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter medicamentIdParam = new SqlParameter("@medicamentId", (byte)panel.Tag);
            SqlParameter pharmacyIdParam = new SqlParameter("@pharmacyId", Info.personal.pharmacyId);
            SqlParameter quantityParam = new SqlParameter("@quantity", quantity);
            SqlParameter errorMessageParam = new SqlParameter("@errorMessage", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Output
            };
            command.Parameters.Add(medicamentIdParam);
            command.Parameters.Add(pharmacyIdParam);
            command.Parameters.Add(quantityParam);
            command.Parameters.Add(errorMessageParam);
            string errorMessage = "";
            if (Info.sql.ConnectionOpen())
            {
                try
                {
                    command.ExecuteNonQuery();
                    errorMessage = command.Parameters["@errorMessage"].Value.ToString();
                    if (errorMessage == "OK")
                    {
                        errorMessage = "";
                    }

                }
                catch
                {
                    errorMessage = "Не получилось выполнить комманду на заказ лекарства\nОбратитесь к специалисту";
                }
                if (!Info.sql.ConnectionClose())
                {
                    errorMessage = "Не получилось закрыть соединение с сервером базы данных\nОбратитесь к специалисту";
                }
            }
            else
            {
                errorMessage = "Не получилось открыть соединения с базой данных\nОбратитесь к специалисту";
            }
            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                MessageBox.Show("Товар успешно заказан");
                RefreshMedicaments();
            }

        }

        //Метод изменения количества лекарств
        private void ChangedTextTextBox(object sender, EventArgs e)
        {
            TextBox textBoxQuantity = (TextBox)sender;
            if (textBoxQuantity.Text != "")
            {
                Regex regex = new Regex(@"^[1-9][0-9]{0,5}$");
                MatchCollection matches = regex.Matches(textBoxQuantity.Text);
                if (matches.Count > 0)
                {
                    Panel panel = (Panel)textBoxQuantity.Parent;
                    var control = panel.Controls.Find($"labelMedicamentPrice{(byte)panel.Tag}", false);
                    Label labelPrice = (Label)control[0];
                    int quantity = Convert.ToInt32(textBoxQuantity.Text);
                    decimal startPrice = Convert.ToDecimal(labelPrice.Tag);
                    decimal newPrice = startPrice * quantity;
                    labelPrice.Text = $"{newPrice}р";
                }
                else
                {
                    textBoxQuantity.Text = "1";
                }
            }
        }

        //Метод наведения на лекарство
        public void medicamentHover(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = System.Drawing.Color.Red;
        }

        //Метод отвода от лекарства
        public void medicamentLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = System.Drawing.SystemColors.Control;
        }

        //Метод очистки subMenuPanel
        private void DisposeSubMenuPanel(Panel subMenuPanel)
        {
            //Вычисляю панель subMenuPanel, которая является родительской для текущей формы
            foreach (Control control in subMenuPanel.Controls)
            {
                control.Dispose();
            }
        }

        //Создание панели с медикаментом
        private void CreateMedicamentPanel(BaseMedicament medicament)
        {
            (int, string) quantityAndError = medicament.SearchQuantityMedicament(medicament.MedicamentId, Info.personal.pharmacyId);
            string errorText = quantityAndError.Item2;
            if (errorText != "")
            {
                MessageBox.Show(errorText);
            }
            else
            {
                int quantity = quantityAndError.Item1;
                // label1
                // 
                Label labelTemplate1 = new Label();
                labelTemplate1.AutoSize = true;
                labelTemplate1.Location = new System.Drawing.Point(27, 18);
                labelTemplate1.Name = $"labelMedicamentName{medicament.MedicamentId}";
                labelTemplate1.Size = new System.Drawing.Size(46, 17);
                labelTemplate1.TabIndex = 0;
                labelTemplate1.Text = $"{medicament.MedicamentName}";
                // textBox1
                // 
                TextBox textBoxTemplate = new TextBox();
                textBoxTemplate.Location = new System.Drawing.Point(300, 15);
                textBoxTemplate.Name = $"textBoxMedicamentQuantity{medicament.MedicamentId}";
                textBoxTemplate.Size = new System.Drawing.Size(31, 22);
                textBoxTemplate.TabIndex = 2;
                textBoxTemplate.Text = "1";
                textBoxTemplate.RightToLeft = RightToLeft.Yes;
                textBoxTemplate.TextChanged += new System.EventHandler(this.ChangedTextTextBox);
                // label2
                // 
                Label labelTemplate2 = new Label();
                labelTemplate2.AutoSize = true;
                labelTemplate2.Location = new System.Drawing.Point(377, 18);
                labelTemplate2.Name = $"labelMedicamentPrice{medicament.MedicamentId}";
                labelTemplate2.Size = new System.Drawing.Size(46, 17);
                labelTemplate2.TabIndex = 1;
                labelTemplate2.Text = $"{medicament.Price}р";
                labelTemplate2.Tag = medicament.Price;
                // button1
                // 
                Button btnTemplate = new Button();
                btnTemplate.Location = new System.Drawing.Point(472, 15);
                btnTemplate.Name = $"btnMedicamentBuy{medicament.MedicamentId}";
                btnTemplate.Size = new System.Drawing.Size(75, 23);
                btnTemplate.TabIndex = 3;
                btnTemplate.Text = "Купить";
                btnTemplate.Tag = medicament.MedicamentId;
                btnTemplate.UseVisualStyleBackColor = true;
                btnTemplate.Click += new System.EventHandler(this.ClickBtnBuy);
                // label3
                //
                Label labelTemplate3 = new Label();
                labelTemplate3.AutoSize = true;
                labelTemplate3.Location = new System.Drawing.Point(585, 20);
                labelTemplate3.Name = $"labelMedicamentHave{medicament.MedicamentId}";
                labelTemplate3.Size = new System.Drawing.Size(46, 17);
                labelTemplate3.TabIndex = 1;
                labelTemplate3.Text = $"Есть в наличии: {quantity}ш.";
                labelTemplate3.Tag = quantity;
                // button2
                // 
                Button btnTemplate2 = new Button();
                btnTemplate2.Location = new System.Drawing.Point(700, 15);
                btnTemplate2.Name = $"btnMedicamentOrder{medicament.MedicamentId}";
                btnTemplate2.Size = new System.Drawing.Size(75, 23);
                btnTemplate2.TabIndex = 3;
                btnTemplate2.Text = "Заказать";
                btnTemplate2.Tag = medicament.MedicamentId;
                btnTemplate2.UseVisualStyleBackColor = true;
                btnTemplate2.Click += new System.EventHandler(this.ClickBtnOrder);
                // pictureBox1
                // 
                PictureBox pictureBoxTemplate1 = new PictureBox();
                pictureBoxTemplate1.Image = global::Pharmacy.Resource1.greenCircle;
                pictureBoxTemplate1.Location = new System.Drawing.Point(560, 19);
                pictureBoxTemplate1.Name = "haveOrNotHavePicturebox";
                pictureBoxTemplate1.Size = new System.Drawing.Size(40, 37);
                pictureBoxTemplate1.TabIndex = 0;
                pictureBoxTemplate1.TabStop = false;
                // Panel
                //
                Panel medicamentPanelTemplate = new Panel();
                medicamentPanelTemplate.Controls.Add(labelTemplate1);
                medicamentPanelTemplate.Controls.Add(labelTemplate2);
                medicamentPanelTemplate.Controls.Add(textBoxTemplate);
                medicamentPanelTemplate.Controls.Add(btnTemplate);
                medicamentPanelTemplate.Controls.Add(btnTemplate2);
                medicamentPanelTemplate.Controls.Add(labelTemplate3);
                medicamentPanelTemplate.Controls.Add(pictureBoxTemplate1);
                medicamentPanelTemplate.Dock = System.Windows.Forms.DockStyle.Top;
                medicamentPanelTemplate.Location = new System.Drawing.Point(0, 0);
                medicamentPanelTemplate.Name = $"medicamentPanel{medicament.MedicamentId}";
                medicamentPanelTemplate.Size = new System.Drawing.Size(580, 53);
                medicamentPanelTemplate.TabIndex = 0;
                medicamentPanelTemplate.Click += new System.EventHandler(this.medicamentClick);
                medicamentPanelTemplate.BorderStyle = BorderStyle.FixedSingle;
                medicamentPanelTemplate.Cursor = Cursors.Hand;
                medicamentPanelTemplate.MouseHover += new System.EventHandler(this.medicamentHover);
                medicamentPanelTemplate.MouseLeave += new System.EventHandler(this.medicamentLeave);
                medicamentPanelTemplate.Tag = medicament.MedicamentId;
                medicamentsPanel.Controls.Add(medicamentPanelTemplate);
                if (quantity == 0)
                {
                    btnTemplate.Enabled = false;
                    labelTemplate3.Text = $"Нет в наличии";
                    pictureBoxTemplate1.Image = global::Pharmacy.Resource1.redCircle;
                }
            }
            
        }
    }
}
