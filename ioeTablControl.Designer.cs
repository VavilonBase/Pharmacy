namespace Pharmacy
{
    partial class ioeTablControl
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
            this.ioeTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewIncome = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewExpenditure = new System.Windows.Forms.DataGridView();
            this.ioeTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncome)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenditure)).BeginInit();
            this.SuspendLayout();
            // 
            // ioeTabControl
            // 
            this.ioeTabControl.Controls.Add(this.tabPage1);
            this.ioeTabControl.Controls.Add(this.tabPage2);
            this.ioeTabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ioeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ioeTabControl.Location = new System.Drawing.Point(0, 0);
            this.ioeTabControl.Name = "ioeTabControl";
            this.ioeTabControl.SelectedIndex = 0;
            this.ioeTabControl.Size = new System.Drawing.Size(800, 450);
            this.ioeTabControl.TabIndex = 10;
            this.ioeTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.ioeTabControl_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewIncome);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewIncome
            // 
            this.dataGridViewIncome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIncome.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewIncome.Name = "dataGridViewIncome";
            this.dataGridViewIncome.RowHeadersWidth = 51;
            this.dataGridViewIncome.RowTemplate.Height = 24;
            this.dataGridViewIncome.Size = new System.Drawing.Size(786, 415);
            this.dataGridViewIncome.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewExpenditure);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewExpenditure
            // 
            this.dataGridViewExpenditure.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExpenditure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExpenditure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExpenditure.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewExpenditure.Name = "dataGridViewExpenditure";
            this.dataGridViewExpenditure.RowHeadersWidth = 51;
            this.dataGridViewExpenditure.RowTemplate.Height = 24;
            this.dataGridViewExpenditure.Size = new System.Drawing.Size(786, 415);
            this.dataGridViewExpenditure.TabIndex = 0;
            // 
            // ioeTablControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ioeTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ioeTablControl";
            this.Text = "ioeTablControl";
            this.ioeTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncome)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenditure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ioeTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewIncome;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewExpenditure;
    }
}