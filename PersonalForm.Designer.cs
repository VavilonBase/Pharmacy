namespace Pharmacy
{
    partial class PersonalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalForm));
            this.addPersonalBtn = new System.Windows.Forms.Button();
            this.changePersonlInfo = new System.Windows.Forms.Button();
            this.dismissPersonal = new System.Windows.Forms.Button();
            this.salaryPerson = new System.Windows.Forms.Button();
            this.refreshPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.personalDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addPersonalBtn
            // 
            this.addPersonalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPersonalBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addPersonalBtn.Location = new System.Drawing.Point(0, 0);
            this.addPersonalBtn.Name = "addPersonalBtn";
            this.addPersonalBtn.Size = new System.Drawing.Size(223, 53);
            this.addPersonalBtn.TabIndex = 8;
            this.addPersonalBtn.Text = "Добавить сотрудника";
            this.addPersonalBtn.UseVisualStyleBackColor = true;
            this.addPersonalBtn.Click += new System.EventHandler(this.addPersonalBtn_Click);
            // 
            // changePersonlInfo
            // 
            this.changePersonlInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePersonlInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.changePersonlInfo.Location = new System.Drawing.Point(223, 0);
            this.changePersonlInfo.Name = "changePersonlInfo";
            this.changePersonlInfo.Size = new System.Drawing.Size(284, 53);
            this.changePersonlInfo.TabIndex = 9;
            this.changePersonlInfo.Text = "Изменить данные о сотруднике";
            this.changePersonlInfo.UseVisualStyleBackColor = true;
            this.changePersonlInfo.Click += new System.EventHandler(this.changePersonlInfo_Click);
            // 
            // dismissPersonal
            // 
            this.dismissPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dismissPersonal.Dock = System.Windows.Forms.DockStyle.Left;
            this.dismissPersonal.Location = new System.Drawing.Point(507, 0);
            this.dismissPersonal.Name = "dismissPersonal";
            this.dismissPersonal.Size = new System.Drawing.Size(220, 53);
            this.dismissPersonal.TabIndex = 10;
            this.dismissPersonal.Text = "Уволить сотрудника";
            this.dismissPersonal.UseVisualStyleBackColor = true;
            this.dismissPersonal.Click += new System.EventHandler(this.dismissPersonal_Click);
            // 
            // salaryPerson
            // 
            this.salaryPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salaryPerson.Dock = System.Windows.Forms.DockStyle.Left;
            this.salaryPerson.Location = new System.Drawing.Point(727, 0);
            this.salaryPerson.Name = "salaryPerson";
            this.salaryPerson.Size = new System.Drawing.Size(223, 53);
            this.salaryPerson.TabIndex = 11;
            this.salaryPerson.Text = "Выплатить запрлату";
            this.salaryPerson.UseVisualStyleBackColor = true;
            this.salaryPerson.Click += new System.EventHandler(this.salaryPerson_Click);
            // 
            // refreshPictureBox
            // 
            this.refreshPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("refreshPictureBox.Image")));
            this.refreshPictureBox.Location = new System.Drawing.Point(956, 12);
            this.refreshPictureBox.Name = "refreshPictureBox";
            this.refreshPictureBox.Size = new System.Drawing.Size(49, 37);
            this.refreshPictureBox.TabIndex = 12;
            this.refreshPictureBox.TabStop = false;
            this.refreshPictureBox.Click += new System.EventHandler(this.refreshPictureBox_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refreshPictureBox);
            this.panel1.Controls.Add(this.salaryPerson);
            this.panel1.Controls.Add(this.dismissPersonal);
            this.panel1.Controls.Add(this.changePersonlInfo);
            this.panel1.Controls.Add(this.addPersonalBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 53);
            this.panel1.TabIndex = 2;
            // 
            // personalDataGridView
            // 
            this.personalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personalDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personalDataGridView.Location = new System.Drawing.Point(0, 53);
            this.personalDataGridView.Name = "personalDataGridView";
            this.personalDataGridView.ReadOnly = true;
            this.personalDataGridView.RowHeadersWidth = 51;
            this.personalDataGridView.RowTemplate.Height = 24;
            this.personalDataGridView.Size = new System.Drawing.Size(1171, 394);
            this.personalDataGridView.TabIndex = 3;
            this.personalDataGridView.SelectionChanged += new System.EventHandler(this.personalDataGridView_SelectionChanged);
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 447);
            this.Controls.Add(this.personalDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "PersonalForm";
            this.Text = "PesonalForm";
            ((System.ComponentModel.ISupportInitialize)(this.refreshPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personalDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addPersonalBtn;
        private System.Windows.Forms.Button changePersonlInfo;
        private System.Windows.Forms.Button dismissPersonal;
        private System.Windows.Forms.Button salaryPerson;
        private System.Windows.Forms.PictureBox refreshPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView personalDataGridView;
    }
}