namespace pc_service_calc.NewObjectForms
{
    partial class AbstractNew
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
            this.readyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // readyButton
            // 
            this.readyButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.readyButton.Location = new System.Drawing.Point(0, 286);
            this.readyButton.Margin = new System.Windows.Forms.Padding(4);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(568, 41);
            this.readyButton.TabIndex = 0;
            this.readyButton.Text = "Готово";
            this.readyButton.UseVisualStyleBackColor = true;
            this.readyButton.Click += new System.EventHandler(this.ReadyButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(0, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "label1";
            this.label3.Visible = false;
            // 
            // AbstractNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 327);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.readyButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AbstractNew";
            this.Text = "new_room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readyButton;
        private System.Windows.Forms.Label label3;
    }
}