namespace pc_service_calc.NewObjectForms
{
    partial class NewZamow
    {
     
        private System.ComponentModel.IContainer components = null;

       
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
            this.label1 = new System.Windows.Forms.Label();
            this.addressNameTextBox = new System.Windows.Forms.TextBox();
            this.addressDescriptionTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa";
            // 
            // addressNameTextBox
            // 
            this.addressNameTextBox.Location = new System.Drawing.Point(16, 37);
            this.addressNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressNameTextBox.Name = "addressNameTextBox";
            this.addressNameTextBox.Size = new System.Drawing.Size(535, 22);
            this.addressNameTextBox.TabIndex = 2;
            // 
            // addressDescriptionTextBox2
            // 
            this.addressDescriptionTextBox2.Location = new System.Drawing.Point(16, 84);
            this.addressDescriptionTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.addressDescriptionTextBox2.Name = "addressDescriptionTextBox2";
            this.addressDescriptionTextBox2.Size = new System.Drawing.Size(535, 22);
            this.addressDescriptionTextBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informacje Dodatkowe";
            // 
            // NewZamow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 181);
            this.Controls.Add(this.addressDescriptionTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addressNameTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "NewZamow";
            this.Text = "Nowe Zamowienie";
            this.Load += new System.EventHandler(this.NewZamow_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.addressNameTextBox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.addressDescriptionTextBox2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressNameTextBox;
        private System.Windows.Forms.TextBox addressDescriptionTextBox2;
        private System.Windows.Forms.Label label2;
    }
}