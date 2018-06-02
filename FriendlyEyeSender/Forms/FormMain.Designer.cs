namespace FriendlyEyeSender.Forms
{
    partial class FormMain
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
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPurpose = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSetup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDisarmPassword = new System.Windows.Forms.TextBox();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxHouseNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(524, 129);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(419, 71);
            this.textBoxAddress.TabIndex = 15;
            this.textBoxAddress.Text = "hertenlaan";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(524, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(754, 71);
            this.textBoxName.TabIndex = 14;
            this.textBoxName.Text = "Peter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 64);
            this.label3.TabIndex = 12;
            this.label3.Text = "Danger-level:";
            // 
            // comboBoxPurpose
            // 
            this.comboBoxPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPurpose.FormattingEnabled = true;
            this.comboBoxPurpose.Items.AddRange(new object[] {
            "Nanny",
            "Prevent theft",
            "Prevent violence",
            "Watch for fire"});
            this.comboBoxPurpose.Location = new System.Drawing.Point(521, 329);
            this.comboBoxPurpose.Name = "comboBoxPurpose";
            this.comboBoxPurpose.Size = new System.Drawing.Size(505, 72);
            this.comboBoxPurpose.TabIndex = 11;
            this.comboBoxPurpose.Text = "Prevent theft";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 64);
            this.label2.TabIndex = 10;
            this.label2.Text = "Street:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 64);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // buttonSetup
            // 
            this.buttonSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetup.Location = new System.Drawing.Point(600, 638);
            this.buttonSetup.Name = "buttonSetup";
            this.buttonSetup.Size = new System.Drawing.Size(626, 316);
            this.buttonSetup.TabIndex = 8;
            this.buttonSetup.Text = "Setup";
            this.buttonSetup.UseVisualStyleBackColor = true;
            this.buttonSetup.Click += new System.EventHandler(this.buttonSetup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(11, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(495, 64);
            this.label4.TabIndex = 16;
            this.label4.Text = "Dis-arm password:";
            // 
            // textBoxDisarmPassword
            // 
            this.textBoxDisarmPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxDisarmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisarmPassword.Location = new System.Drawing.Point(521, 475);
            this.textBoxDisarmPassword.Name = "textBoxDisarmPassword";
            this.textBoxDisarmPassword.Size = new System.Drawing.Size(502, 71);
            this.textBoxDisarmPassword.TabIndex = 17;
            this.textBoxDisarmPassword.Text = "secret";
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelephone.Location = new System.Drawing.Point(524, 227);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(502, 71);
            this.textBoxTelephone.TabIndex = 19;
            this.textBoxTelephone.Text = "0621718293";
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelephone.Location = new System.Drawing.Point(182, 230);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(308, 64);
            this.labelTelephone.TabIndex = 18;
            this.labelTelephone.Text = "Telephone:";
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPostalCode.Location = new System.Drawing.Point(1549, 132);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(216, 71);
            this.textBoxPostalCode.TabIndex = 20;
            this.textBoxPostalCode.Text = "6823LE";
            // 
            // textBoxHouseNumber
            // 
            this.textBoxHouseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHouseNumber.Location = new System.Drawing.Point(1117, 129);
            this.textBoxHouseNumber.Name = "textBoxHouseNumber";
            this.textBoxHouseNumber.Size = new System.Drawing.Size(101, 71);
            this.textBoxHouseNumber.TabIndex = 21;
            this.textBoxHouseNumber.Text = "12";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1008, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 64);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nr:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1270, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 64);
            this.label6.TabIndex = 23;
            this.label6.Text = "Postcode:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxHouseNumber);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.textBoxDisarmPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPurpose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSetup);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPurpose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSetup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDisarmPassword;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Label labelTelephone;
        internal System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.TextBox textBoxHouseNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}