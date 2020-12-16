namespace Pharmacy
{
    partial class MedicamentDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicamentDescription));
            this.medicamentName = new System.Windows.Forms.Label();
            this.medicamentQuantity = new System.Windows.Forms.TextBox();
            this.medicamentBuy = new System.Windows.Forms.Button();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.labelHaveMedicament = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.pictureBoxHaveMedicament = new System.Windows.Forms.PictureBox();
            this.medicamentPrice = new System.Windows.Forms.Label();
            this.desctiptoinPanel = new System.Windows.Forms.Panel();
            this.medicamentDescriptoin = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.withRecipeLabel = new System.Windows.Forms.Label();
            this.dateProducingLabel = new System.Windows.Forms.Label();
            this.dateStorageLifeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editInfo = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHaveMedicament)).BeginInit();
            this.desctiptoinPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // medicamentName
            // 
            this.medicamentName.AutoSize = true;
            this.medicamentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.medicamentName.Location = new System.Drawing.Point(378, 27);
            this.medicamentName.Name = "medicamentName";
            this.medicamentName.Size = new System.Drawing.Size(64, 25);
            this.medicamentName.TabIndex = 4;
            this.medicamentName.Text = "label1";
            // 
            // medicamentQuantity
            // 
            this.medicamentQuantity.Location = new System.Drawing.Point(813, 24);
            this.medicamentQuantity.Name = "medicamentQuantity";
            this.medicamentQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.medicamentQuantity.Size = new System.Drawing.Size(24, 22);
            this.medicamentQuantity.TabIndex = 5;
            this.medicamentQuantity.Text = "1";
            this.medicamentQuantity.TextChanged += new System.EventHandler(this.medicamentQuantity_TextChanged);
            // 
            // medicamentBuy
            // 
            this.medicamentBuy.Location = new System.Drawing.Point(867, 23);
            this.medicamentBuy.Name = "medicamentBuy";
            this.medicamentBuy.Size = new System.Drawing.Size(87, 29);
            this.medicamentBuy.TabIndex = 6;
            this.medicamentBuy.Text = "Купить";
            this.medicamentBuy.UseVisualStyleBackColor = true;
            this.medicamentBuy.Click += new System.EventHandler(this.medicamentBuy_Click);
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Location = new System.Drawing.Point(16, 13);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(46, 17);
            this.categoryNameLabel.TabIndex = 7;
            this.categoryNameLabel.Text = "label1";
            // 
            // headerPanel
            // 
            this.headerPanel.AutoScroll = true;
            this.headerPanel.Controls.Add(this.labelHaveMedicament);
            this.headerPanel.Controls.Add(this.btnOrder);
            this.headerPanel.Controls.Add(this.pictureBoxHaveMedicament);
            this.headerPanel.Controls.Add(this.medicamentPrice);
            this.headerPanel.Controls.Add(this.categoryNameLabel);
            this.headerPanel.Controls.Add(this.medicamentBuy);
            this.headerPanel.Controls.Add(this.medicamentQuantity);
            this.headerPanel.Controls.Add(this.medicamentName);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(982, 100);
            this.headerPanel.TabIndex = 0;
            // 
            // labelHaveMedicament
            // 
            this.labelHaveMedicament.AutoSize = true;
            this.labelHaveMedicament.Location = new System.Drawing.Point(409, 70);
            this.labelHaveMedicament.Name = "labelHaveMedicament";
            this.labelHaveMedicament.Size = new System.Drawing.Size(46, 17);
            this.labelHaveMedicament.TabIndex = 11;
            this.labelHaveMedicament.Text = "label1";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(606, 63);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(84, 30);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "Заказать";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.ClickBtnOrder);
            // 
            // pictureBoxHaveMedicament
            // 
            this.pictureBoxHaveMedicament.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHaveMedicament.Image")));
            this.pictureBoxHaveMedicament.Location = new System.Drawing.Point(377, 70);
            this.pictureBoxHaveMedicament.Name = "pictureBoxHaveMedicament";
            this.pictureBoxHaveMedicament.Size = new System.Drawing.Size(25, 30);
            this.pictureBoxHaveMedicament.TabIndex = 9;
            this.pictureBoxHaveMedicament.TabStop = false;
            // 
            // medicamentPrice
            // 
            this.medicamentPrice.AutoSize = true;
            this.medicamentPrice.Location = new System.Drawing.Point(813, 77);
            this.medicamentPrice.Name = "medicamentPrice";
            this.medicamentPrice.Size = new System.Drawing.Size(46, 17);
            this.medicamentPrice.TabIndex = 8;
            this.medicamentPrice.Text = "label1";
            // 
            // desctiptoinPanel
            // 
            this.desctiptoinPanel.AutoScroll = true;
            this.desctiptoinPanel.Controls.Add(this.medicamentDescriptoin);
            this.desctiptoinPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.desctiptoinPanel.Location = new System.Drawing.Point(0, 300);
            this.desctiptoinPanel.Name = "desctiptoinPanel";
            this.desctiptoinPanel.Size = new System.Drawing.Size(982, 153);
            this.desctiptoinPanel.TabIndex = 1;
            // 
            // medicamentDescriptoin
            // 
            this.medicamentDescriptoin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.medicamentDescriptoin.Location = new System.Drawing.Point(3, 6);
            this.medicamentDescriptoin.Multiline = true;
            this.medicamentDescriptoin.Name = "medicamentDescriptoin";
            this.medicamentDescriptoin.ReadOnly = true;
            this.medicamentDescriptoin.Size = new System.Drawing.Size(976, 147);
            this.medicamentDescriptoin.TabIndex = 0;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(13, 14);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(46, 17);
            this.countryLabel.TabIndex = 0;
            this.countryLabel.Text = "label1";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(13, 44);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(46, 17);
            this.brandLabel.TabIndex = 1;
            this.brandLabel.Text = "label2";
            // 
            // withRecipeLabel
            // 
            this.withRecipeLabel.AutoSize = true;
            this.withRecipeLabel.Location = new System.Drawing.Point(13, 76);
            this.withRecipeLabel.Name = "withRecipeLabel";
            this.withRecipeLabel.Size = new System.Drawing.Size(46, 17);
            this.withRecipeLabel.TabIndex = 2;
            this.withRecipeLabel.Text = "label3";
            // 
            // dateProducingLabel
            // 
            this.dateProducingLabel.AutoSize = true;
            this.dateProducingLabel.Location = new System.Drawing.Point(13, 104);
            this.dateProducingLabel.Name = "dateProducingLabel";
            this.dateProducingLabel.Size = new System.Drawing.Size(46, 17);
            this.dateProducingLabel.TabIndex = 3;
            this.dateProducingLabel.Text = "label4";
            // 
            // dateStorageLifeLabel
            // 
            this.dateStorageLifeLabel.AutoSize = true;
            this.dateStorageLifeLabel.Location = new System.Drawing.Point(13, 134);
            this.dateStorageLifeLabel.Name = "dateStorageLifeLabel";
            this.dateStorageLifeLabel.Size = new System.Drawing.Size(46, 17);
            this.dateStorageLifeLabel.TabIndex = 4;
            this.dateStorageLifeLabel.Text = "label5";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.editInfo);
            this.panel1.Controls.Add(this.dateStorageLifeLabel);
            this.panel1.Controls.Add(this.dateProducingLabel);
            this.panel1.Controls.Add(this.withRecipeLabel);
            this.panel1.Controls.Add(this.brandLabel);
            this.panel1.Controls.Add(this.countryLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 200);
            this.panel1.TabIndex = 2;
            // 
            // editInfo
            // 
            this.editInfo.Location = new System.Drawing.Point(696, 14);
            this.editInfo.Name = "editInfo";
            this.editInfo.Size = new System.Drawing.Size(258, 25);
            this.editInfo.TabIndex = 9;
            this.editInfo.Text = "Редактировать информацию";
            this.editInfo.UseVisualStyleBackColor = true;
            this.editInfo.Click += new System.EventHandler(this.editInfo_Click);
            // 
            // MedicamentDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.desctiptoinPanel);
            this.Controls.Add(this.headerPanel);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "MedicamentDescription";
            this.Text = "MedicamentDescription";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHaveMedicament)).EndInit();
            this.desctiptoinPanel.ResumeLayout(false);
            this.desctiptoinPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label medicamentName;
        private System.Windows.Forms.TextBox medicamentQuantity;
        private System.Windows.Forms.Button medicamentBuy;
        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel desctiptoinPanel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label withRecipeLabel;
        private System.Windows.Forms.Label dateProducingLabel;
        private System.Windows.Forms.Label dateStorageLifeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox medicamentDescriptoin;
        private System.Windows.Forms.Label medicamentPrice;
        private System.Windows.Forms.Button editInfo;
        private System.Windows.Forms.Label labelHaveMedicament;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.PictureBox pictureBoxHaveMedicament;
    }
}