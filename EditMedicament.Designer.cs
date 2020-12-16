namespace Pharmacy
{
    partial class EditMedicament
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
            this.medicamentNameLabel = new System.Windows.Forms.Label();
            this.medicamentNameTextBox = new System.Windows.Forms.TextBox();
            this.brandNameTextBox = new System.Windows.Forms.TextBox();
            this.brandNameLabel = new System.Windows.Forms.Label();
            this.countryNameTextBox = new System.Windows.Forms.TextBox();
            this.countryNameLabel = new System.Windows.Forms.Label();
            this.withRecipeLabel = new System.Windows.Forms.Label();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.dateProducingTextBox = new System.Windows.Forms.TextBox();
            this.dateProducingLabel = new System.Windows.Forms.Label();
            this.withRecipeYes = new System.Windows.Forms.RadioButton();
            this.withRecipeNo = new System.Windows.Forms.RadioButton();
            this.dateStorageLifeTextBox = new System.Windows.Forms.TextBox();
            this.dateStorageLifeLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.editMedicamentData = new System.Windows.Forms.Button();
            this.errorMedicamentNameLabel = new System.Windows.Forms.Label();
            this.errorBrandNameLabel = new System.Windows.Forms.Label();
            this.errorCountryNameLabel = new System.Windows.Forms.Label();
            this.errorCategoryNameLabel = new System.Windows.Forms.Label();
            this.errorDateProducingLabel = new System.Windows.Forms.Label();
            this.errorDateStorageLifeLabel = new System.Windows.Forms.Label();
            this.errorPriceLabel = new System.Windows.Forms.Label();
            this.errorDescriptionLabel = new System.Windows.Forms.Label();
            this.descriptionExplanationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // medicamentNameLabel
            // 
            this.medicamentNameLabel.AutoSize = true;
            this.medicamentNameLabel.Location = new System.Drawing.Point(12, 23);
            this.medicamentNameLabel.Name = "medicamentNameLabel";
            this.medicamentNameLabel.Size = new System.Drawing.Size(330, 17);
            this.medicamentNameLabel.TabIndex = 0;
            this.medicamentNameLabel.Text = "Название медикамента(не больше 30 символов)";
            // 
            // medicamentNameTextBox
            // 
            this.medicamentNameTextBox.Location = new System.Drawing.Point(359, 23);
            this.medicamentNameTextBox.Name = "medicamentNameTextBox";
            this.medicamentNameTextBox.Size = new System.Drawing.Size(207, 22);
            this.medicamentNameTextBox.TabIndex = 1;
            // 
            // brandNameTextBox
            // 
            this.brandNameTextBox.Location = new System.Drawing.Point(359, 50);
            this.brandNameTextBox.Name = "brandNameTextBox";
            this.brandNameTextBox.Size = new System.Drawing.Size(207, 22);
            this.brandNameTextBox.TabIndex = 3;
            // 
            // brandNameLabel
            // 
            this.brandNameLabel.AutoSize = true;
            this.brandNameLabel.Location = new System.Drawing.Point(13, 50);
            this.brandNameLabel.Name = "brandNameLabel";
            this.brandNameLabel.Size = new System.Drawing.Size(290, 17);
            this.brandNameLabel.TabIndex = 2;
            this.brandNameLabel.Text = "Название бренда(не больше 30 символов)";
            // 
            // countryNameTextBox
            // 
            this.countryNameTextBox.Location = new System.Drawing.Point(359, 78);
            this.countryNameTextBox.Name = "countryNameTextBox";
            this.countryNameTextBox.Size = new System.Drawing.Size(207, 22);
            this.countryNameTextBox.TabIndex = 5;
            // 
            // countryNameLabel
            // 
            this.countryNameLabel.AutoSize = true;
            this.countryNameLabel.Location = new System.Drawing.Point(13, 74);
            this.countryNameLabel.Name = "countryNameLabel";
            this.countryNameLabel.Size = new System.Drawing.Size(294, 17);
            this.countryNameLabel.TabIndex = 4;
            this.countryNameLabel.Text = "Название страны (не больше 30 символов)";
            // 
            // withRecipeLabel
            // 
            this.withRecipeLabel.AutoSize = true;
            this.withRecipeLabel.Location = new System.Drawing.Point(13, 107);
            this.withRecipeLabel.Name = "withRecipeLabel";
            this.withRecipeLabel.Size = new System.Drawing.Size(227, 17);
            this.withRecipeLabel.TabIndex = 6;
            this.withRecipeLabel.Text = "Нужна ли консультация у врача?";
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(359, 137);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(207, 22);
            this.categoryNameTextBox.TabIndex = 9;
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Location = new System.Drawing.Point(13, 137);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(309, 17);
            this.categoryNameLabel.TabIndex = 8;
            this.categoryNameLabel.Text = "Название категории(не больше 20 символов)";
            // 
            // dateProducingTextBox
            // 
            this.dateProducingTextBox.Location = new System.Drawing.Point(359, 169);
            this.dateProducingTextBox.Name = "dateProducingTextBox";
            this.dateProducingTextBox.Size = new System.Drawing.Size(207, 22);
            this.dateProducingTextBox.TabIndex = 11;
            // 
            // dateProducingLabel
            // 
            this.dateProducingLabel.AutoSize = true;
            this.dateProducingLabel.Location = new System.Drawing.Point(13, 169);
            this.dateProducingLabel.Name = "dateProducingLabel";
            this.dateProducingLabel.Size = new System.Drawing.Size(187, 17);
            this.dateProducingLabel.TabIndex = 10;
            this.dateProducingLabel.Text = "Дата производства(Д-М-Г)";
            // 
            // withRecipeYes
            // 
            this.withRecipeYes.AutoSize = true;
            this.withRecipeYes.Location = new System.Drawing.Point(246, 108);
            this.withRecipeYes.Name = "withRecipeYes";
            this.withRecipeYes.Size = new System.Drawing.Size(48, 21);
            this.withRecipeYes.TabIndex = 20;
            this.withRecipeYes.TabStop = true;
            this.withRecipeYes.Text = "Да";
            this.withRecipeYes.UseVisualStyleBackColor = true;
            // 
            // withRecipeNo
            // 
            this.withRecipeNo.AutoSize = true;
            this.withRecipeNo.Location = new System.Drawing.Point(300, 108);
            this.withRecipeNo.Name = "withRecipeNo";
            this.withRecipeNo.Size = new System.Drawing.Size(54, 21);
            this.withRecipeNo.TabIndex = 21;
            this.withRecipeNo.TabStop = true;
            this.withRecipeNo.Text = "Нет";
            this.withRecipeNo.UseVisualStyleBackColor = true;
            // 
            // dateStorageLifeTextBox
            // 
            this.dateStorageLifeTextBox.Location = new System.Drawing.Point(359, 197);
            this.dateStorageLifeTextBox.Name = "dateStorageLifeTextBox";
            this.dateStorageLifeTextBox.Size = new System.Drawing.Size(207, 22);
            this.dateStorageLifeTextBox.TabIndex = 23;
            // 
            // dateStorageLifeLabel
            // 
            this.dateStorageLifeLabel.AutoSize = true;
            this.dateStorageLifeLabel.Location = new System.Drawing.Point(13, 197);
            this.dateStorageLifeLabel.Name = "dateStorageLifeLabel";
            this.dateStorageLifeLabel.Size = new System.Drawing.Size(279, 17);
            this.dateStorageLifeLabel.TabIndex = 22;
            this.dateStorageLifeLabel.Text = "Срок годности(Д-М-Г), можно не вводить";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(359, 225);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(207, 22);
            this.priceTextBox.TabIndex = 25;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(13, 225);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(179, 17);
            this.priceLabel.TabIndex = 24;
            this.priceLabel.Text = "Цена(не больше 99 999р)";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 290);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(554, 148);
            this.descriptionTextBox.TabIndex = 27;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(13, 253);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(256, 17);
            this.descriptionLabel.TabIndex = 26;
            this.descriptionLabel.Text = "Описание(не больше 1000 символов)";
            // 
            // editMedicamentData
            // 
            this.editMedicamentData.Location = new System.Drawing.Point(636, 414);
            this.editMedicamentData.Name = "editMedicamentData";
            this.editMedicamentData.Size = new System.Drawing.Size(150, 23);
            this.editMedicamentData.TabIndex = 28;
            this.editMedicamentData.Text = "Изменить данные";
            this.editMedicamentData.UseVisualStyleBackColor = true;
            this.editMedicamentData.Click += new System.EventHandler(this.editMedicamentData_Click);
            // 
            // errorMedicamentNameLabel
            // 
            this.errorMedicamentNameLabel.AutoSize = true;
            this.errorMedicamentNameLabel.Location = new System.Drawing.Point(573, 27);
            this.errorMedicamentNameLabel.Name = "errorMedicamentNameLabel";
            this.errorMedicamentNameLabel.Size = new System.Drawing.Size(0, 17);
            this.errorMedicamentNameLabel.TabIndex = 29;
            // 
            // errorBrandNameLabel
            // 
            this.errorBrandNameLabel.AutoSize = true;
            this.errorBrandNameLabel.Location = new System.Drawing.Point(573, 54);
            this.errorBrandNameLabel.Name = "errorBrandNameLabel";
            this.errorBrandNameLabel.Size = new System.Drawing.Size(0, 17);
            this.errorBrandNameLabel.TabIndex = 30;
            // 
            // errorCountryNameLabel
            // 
            this.errorCountryNameLabel.AutoSize = true;
            this.errorCountryNameLabel.Location = new System.Drawing.Point(572, 83);
            this.errorCountryNameLabel.Name = "errorCountryNameLabel";
            this.errorCountryNameLabel.Size = new System.Drawing.Size(0, 17);
            this.errorCountryNameLabel.TabIndex = 31;
            // 
            // errorCategoryNameLabel
            // 
            this.errorCategoryNameLabel.AutoSize = true;
            this.errorCategoryNameLabel.Location = new System.Drawing.Point(572, 137);
            this.errorCategoryNameLabel.Name = "errorCategoryNameLabel";
            this.errorCategoryNameLabel.Size = new System.Drawing.Size(0, 17);
            this.errorCategoryNameLabel.TabIndex = 32;
            // 
            // errorDateProducingLabel
            // 
            this.errorDateProducingLabel.AutoSize = true;
            this.errorDateProducingLabel.Location = new System.Drawing.Point(572, 169);
            this.errorDateProducingLabel.Name = "errorDateProducingLabel";
            this.errorDateProducingLabel.Size = new System.Drawing.Size(0, 17);
            this.errorDateProducingLabel.TabIndex = 33;
            // 
            // errorDateStorageLifeLabel
            // 
            this.errorDateStorageLifeLabel.AutoSize = true;
            this.errorDateStorageLifeLabel.Location = new System.Drawing.Point(572, 197);
            this.errorDateStorageLifeLabel.Name = "errorDateStorageLifeLabel";
            this.errorDateStorageLifeLabel.Size = new System.Drawing.Size(0, 17);
            this.errorDateStorageLifeLabel.TabIndex = 34;
            // 
            // errorPriceLabel
            // 
            this.errorPriceLabel.AutoSize = true;
            this.errorPriceLabel.Location = new System.Drawing.Point(572, 228);
            this.errorPriceLabel.Name = "errorPriceLabel";
            this.errorPriceLabel.Size = new System.Drawing.Size(0, 17);
            this.errorPriceLabel.TabIndex = 35;
            // 
            // errorDescriptionLabel
            // 
            this.errorDescriptionLabel.AutoSize = true;
            this.errorDescriptionLabel.Location = new System.Drawing.Point(572, 273);
            this.errorDescriptionLabel.Name = "errorDescriptionLabel";
            this.errorDescriptionLabel.Size = new System.Drawing.Size(0, 17);
            this.errorDescriptionLabel.TabIndex = 36;
            // 
            // descriptionExplanationLabel
            // 
            this.descriptionExplanationLabel.AutoSize = true;
            this.descriptionExplanationLabel.Location = new System.Drawing.Point(16, 272);
            this.descriptionExplanationLabel.Name = "descriptionExplanationLabel";
            this.descriptionExplanationLabel.Size = new System.Drawing.Size(548, 17);
            this.descriptionExplanationLabel.TabIndex = 37;
            this.descriptionExplanationLabel.Text = "Если оставить пустое поле, оно автоматически будет заменено на нет описания";
            // 
            // EditMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.descriptionExplanationLabel);
            this.Controls.Add(this.errorDescriptionLabel);
            this.Controls.Add(this.errorPriceLabel);
            this.Controls.Add(this.errorDateStorageLifeLabel);
            this.Controls.Add(this.errorDateProducingLabel);
            this.Controls.Add(this.errorCategoryNameLabel);
            this.Controls.Add(this.errorCountryNameLabel);
            this.Controls.Add(this.errorBrandNameLabel);
            this.Controls.Add(this.errorMedicamentNameLabel);
            this.Controls.Add(this.editMedicamentData);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.dateStorageLifeTextBox);
            this.Controls.Add(this.dateStorageLifeLabel);
            this.Controls.Add(this.withRecipeNo);
            this.Controls.Add(this.withRecipeYes);
            this.Controls.Add(this.dateProducingTextBox);
            this.Controls.Add(this.dateProducingLabel);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.categoryNameLabel);
            this.Controls.Add(this.withRecipeLabel);
            this.Controls.Add(this.countryNameTextBox);
            this.Controls.Add(this.countryNameLabel);
            this.Controls.Add(this.brandNameTextBox);
            this.Controls.Add(this.brandNameLabel);
            this.Controls.Add(this.medicamentNameTextBox);
            this.Controls.Add(this.medicamentNameLabel);
            this.Name = "EditMedicament";
            this.Text = "EditMedicament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox medicamentNameTextBox;
        private System.Windows.Forms.TextBox brandNameTextBox;
        private System.Windows.Forms.Label brandNameLabel;
        private System.Windows.Forms.TextBox countryNameTextBox;
        private System.Windows.Forms.Label countryNameLabel;
        private System.Windows.Forms.Label withRecipeLabel;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.TextBox dateProducingTextBox;
        private System.Windows.Forms.Label dateProducingLabel;
        private System.Windows.Forms.Label medicamentNameLabel;
        private System.Windows.Forms.RadioButton withRecipeYes;
        private System.Windows.Forms.RadioButton withRecipeNo;
        private System.Windows.Forms.TextBox dateStorageLifeTextBox;
        private System.Windows.Forms.Label dateStorageLifeLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button editMedicamentData;
        private System.Windows.Forms.Label errorMedicamentNameLabel;
        private System.Windows.Forms.Label errorBrandNameLabel;
        private System.Windows.Forms.Label errorCountryNameLabel;
        private System.Windows.Forms.Label errorCategoryNameLabel;
        private System.Windows.Forms.Label errorDateProducingLabel;
        private System.Windows.Forms.Label errorDateStorageLifeLabel;
        private System.Windows.Forms.Label errorPriceLabel;
        private System.Windows.Forms.Label errorDescriptionLabel;
        private System.Windows.Forms.Label descriptionExplanationLabel;
    }
}