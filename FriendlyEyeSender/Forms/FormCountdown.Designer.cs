namespace FriendlyEyeSender.Forms
{
    partial class FormCountdown
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
            this.panelDisarm = new System.Windows.Forms.Panel();
            this.labelCountdown = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDisarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDisarm
            // 
            this.panelDisarm.BackColor = System.Drawing.Color.Black;
            this.panelDisarm.Controls.Add(this.labelCountdown);
            this.panelDisarm.Controls.Add(this.textBoxPassword);
            this.panelDisarm.Controls.Add(this.label1);
            this.panelDisarm.Location = new System.Drawing.Point(433, 245);
            this.panelDisarm.Name = "panelDisarm";
            this.panelDisarm.Size = new System.Drawing.Size(1031, 664);
            this.panelDisarm.TabIndex = 23;
            // 
            // labelCountdown
            // 
            this.labelCountdown.AutoSize = true;
            this.labelCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountdown.ForeColor = System.Drawing.Color.Red;
            this.labelCountdown.Location = new System.Drawing.Point(447, 379);
            this.labelCountdown.Name = "labelCountdown";
            this.labelCountdown.Size = new System.Drawing.Size(185, 181);
            this.labelCountdown.TabIndex = 2;
            this.labelCountdown.Text = "X";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(182, 221);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(726, 128);
            this.textBoxPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(101, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(807, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Password";
            // 
            // FormCountdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelDisarm);
            this.Name = "FormCountdown";
            this.Text = "FormCountdown";
            this.panelDisarm.ResumeLayout(false);
            this.panelDisarm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDisarm;
        private System.Windows.Forms.Label labelCountdown;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
    }
}