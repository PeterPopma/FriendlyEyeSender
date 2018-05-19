namespace FriendlyEyeSender.Forms
{
    partial class FormSetup
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
            this.buttonReady = new System.Windows.Forms.Button();
            this.pictureBoxCamera = new System.Windows.Forms.PictureBox();
            this.numericUpDownThreshold = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRemoveRegion = new System.Windows.Forms.Button();
            this.buttonNextRegion = new System.Windows.Forms.Button();
            this.buttonPreviousRegion = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.buttonExclude = new System.Windows.Forms.Button();
            this.buttonWatch = new System.Windows.Forms.Button();
            this.outlineLabelCurrentObject = new FriendlyEyeSender.CustomControls.OutlineLabel();
            this.outlineLabelThreshold = new FriendlyEyeSender.CustomControls.OutlineLabel();
            this.outlineLabelDanger = new FriendlyEyeSender.CustomControls.OutlineLabel();
            this.outlineLabelDangerValue = new FriendlyEyeSender.CustomControls.OutlineLabel();
            this.buttonHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReady
            // 
            this.buttonReady.BackColor = System.Drawing.Color.Black;
            this.buttonReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReady.ForeColor = System.Drawing.Color.Yellow;
            this.buttonReady.Location = new System.Drawing.Point(517, 755);
            this.buttonReady.Name = "buttonReady";
            this.buttonReady.Size = new System.Drawing.Size(373, 217);
            this.buttonReady.TabIndex = 0;
            this.buttonReady.Text = "Ready!";
            this.buttonReady.UseVisualStyleBackColor = false;
            this.buttonReady.Click += new System.EventHandler(this.buttonSetup_Click);
            // 
            // pictureBoxCamera
            // 
            this.pictureBoxCamera.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCamera.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCamera.Name = "pictureBoxCamera";
            this.pictureBoxCamera.Size = new System.Drawing.Size(1904, 1041);
            this.pictureBoxCamera.TabIndex = 1;
            this.pictureBoxCamera.TabStop = false;
            this.pictureBoxCamera.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxCamera_Paint);
            this.pictureBoxCamera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCamera_MouseDown);
            this.pictureBoxCamera.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCamera_MouseMove);
            this.pictureBoxCamera.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCamera_MouseUp);
            // 
            // numericUpDownThreshold
            // 
            this.numericUpDownThreshold.AutoSize = true;
            this.numericUpDownThreshold.BackColor = System.Drawing.Color.Black;
            this.numericUpDownThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownThreshold.ForeColor = System.Drawing.Color.Yellow;
            this.numericUpDownThreshold.Location = new System.Drawing.Point(335, 29);
            this.numericUpDownThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownThreshold.Name = "numericUpDownThreshold";
            this.numericUpDownThreshold.Size = new System.Drawing.Size(137, 71);
            this.numericUpDownThreshold.TabIndex = 2;
            this.numericUpDownThreshold.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownThreshold.ValueChanged += new System.EventHandler(this.numericUpDownThreshold_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(1415, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(474, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reset Reference";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRemoveRegion
            // 
            this.buttonRemoveRegion.BackColor = System.Drawing.Color.Black;
            this.buttonRemoveRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveRegion.ForeColor = System.Drawing.Color.Yellow;
            this.buttonRemoveRegion.Location = new System.Drawing.Point(1504, 688);
            this.buttonRemoveRegion.Name = "buttonRemoveRegion";
            this.buttonRemoveRegion.Size = new System.Drawing.Size(335, 121);
            this.buttonRemoveRegion.TabIndex = 12;
            this.buttonRemoveRegion.Text = "Remove";
            this.buttonRemoveRegion.UseVisualStyleBackColor = false;
            this.buttonRemoveRegion.Click += new System.EventHandler(this.buttonRemoveRegion_Click);
            // 
            // buttonNextRegion
            // 
            this.buttonNextRegion.BackColor = System.Drawing.Color.Black;
            this.buttonNextRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextRegion.ForeColor = System.Drawing.Color.Yellow;
            this.buttonNextRegion.Location = new System.Drawing.Point(1721, 825);
            this.buttonNextRegion.Name = "buttonNextRegion";
            this.buttonNextRegion.Size = new System.Drawing.Size(118, 121);
            this.buttonNextRegion.TabIndex = 13;
            this.buttonNextRegion.Text = ">";
            this.buttonNextRegion.UseVisualStyleBackColor = false;
            this.buttonNextRegion.Click += new System.EventHandler(this.buttonNextRegion_Click);
            // 
            // buttonPreviousRegion
            // 
            this.buttonPreviousRegion.BackColor = System.Drawing.Color.Black;
            this.buttonPreviousRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreviousRegion.ForeColor = System.Drawing.Color.Yellow;
            this.buttonPreviousRegion.Location = new System.Drawing.Point(1504, 825);
            this.buttonPreviousRegion.Name = "buttonPreviousRegion";
            this.buttonPreviousRegion.Size = new System.Drawing.Size(119, 121);
            this.buttonPreviousRegion.TabIndex = 14;
            this.buttonPreviousRegion.Text = "<";
            this.buttonPreviousRegion.UseVisualStyleBackColor = false;
            this.buttonPreviousRegion.Click += new System.EventHandler(this.buttonPreviousRegion_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Black;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.Yellow;
            this.radioButton3.Location = new System.Drawing.Point(1440, -361);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(464, 68);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Exclude Regions";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // buttonExclude
            // 
            this.buttonExclude.BackColor = System.Drawing.Color.Black;
            this.buttonExclude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExclude.ForeColor = System.Drawing.Color.LightGray;
            this.buttonExclude.Location = new System.Drawing.Point(1415, 137);
            this.buttonExclude.Name = "buttonExclude";
            this.buttonExclude.Size = new System.Drawing.Size(474, 68);
            this.buttonExclude.TabIndex = 15;
            this.buttonExclude.Text = "Exclude Regions";
            this.buttonExclude.UseVisualStyleBackColor = false;
            this.buttonExclude.Click += new System.EventHandler(this.buttonExclude_Click);
            // 
            // buttonWatch
            // 
            this.buttonWatch.BackColor = System.Drawing.Color.Black;
            this.buttonWatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWatch.ForeColor = System.Drawing.Color.Lime;
            this.buttonWatch.Location = new System.Drawing.Point(1415, 45);
            this.buttonWatch.Name = "buttonWatch";
            this.buttonWatch.Size = new System.Drawing.Size(474, 68);
            this.buttonWatch.TabIndex = 16;
            this.buttonWatch.Text = "Include Regions";
            this.buttonWatch.UseVisualStyleBackColor = false;
            this.buttonWatch.Click += new System.EventHandler(this.buttonWatch_Click);
            // 
            // outlineLabelCurrentObject
            // 
            this.outlineLabelCurrentObject.AutoSize = true;
            this.outlineLabelCurrentObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outlineLabelCurrentObject.ForeColor = System.Drawing.Color.Yellow;
            this.outlineLabelCurrentObject.Location = new System.Drawing.Point(1643, 855);
            this.outlineLabelCurrentObject.Name = "outlineLabelCurrentObject";
            this.outlineLabelCurrentObject.OutlineForeColor = System.Drawing.Color.Black;
            this.outlineLabelCurrentObject.OutlineWidth = 2F;
            this.outlineLabelCurrentObject.Size = new System.Drawing.Size(65, 64);
            this.outlineLabelCurrentObject.TabIndex = 17;
            this.outlineLabelCurrentObject.Text = "X";
            // 
            // outlineLabelThreshold
            // 
            this.outlineLabelThreshold.AutoSize = true;
            this.outlineLabelThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outlineLabelThreshold.ForeColor = System.Drawing.Color.Yellow;
            this.outlineLabelThreshold.Location = new System.Drawing.Point(30, 31);
            this.outlineLabelThreshold.Name = "outlineLabelThreshold";
            this.outlineLabelThreshold.OutlineForeColor = System.Drawing.Color.Black;
            this.outlineLabelThreshold.OutlineWidth = 2F;
            this.outlineLabelThreshold.Size = new System.Drawing.Size(293, 64);
            this.outlineLabelThreshold.TabIndex = 9;
            this.outlineLabelThreshold.Text = "Threshold:";
            // 
            // outlineLabelDanger
            // 
            this.outlineLabelDanger.AutoSize = true;
            this.outlineLabelDanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outlineLabelDanger.ForeColor = System.Drawing.Color.Yellow;
            this.outlineLabelDanger.Location = new System.Drawing.Point(91, 117);
            this.outlineLabelDanger.Name = "outlineLabelDanger";
            this.outlineLabelDanger.OutlineForeColor = System.Drawing.Color.Black;
            this.outlineLabelDanger.OutlineWidth = 2F;
            this.outlineLabelDanger.Size = new System.Drawing.Size(227, 64);
            this.outlineLabelDanger.TabIndex = 8;
            this.outlineLabelDanger.Text = "Danger:";
            // 
            // outlineLabelDangerValue
            // 
            this.outlineLabelDangerValue.AutoSize = true;
            this.outlineLabelDangerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outlineLabelDangerValue.ForeColor = System.Drawing.Color.Yellow;
            this.outlineLabelDangerValue.Location = new System.Drawing.Point(324, 117);
            this.outlineLabelDangerValue.Name = "outlineLabelDangerValue";
            this.outlineLabelDangerValue.OutlineForeColor = System.Drawing.Color.Black;
            this.outlineLabelDangerValue.OutlineWidth = 2F;
            this.outlineLabelDangerValue.Size = new System.Drawing.Size(176, 64);
            this.outlineLabelDangerValue.TabIndex = 7;
            this.outlineLabelDangerValue.Text = "XXXX";
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Black;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.Yellow;
            this.buttonHome.Location = new System.Drawing.Point(82, 755);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(373, 217);
            this.buttonHome.TabIndex = 18;
            this.buttonHome.Text = "< Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // FormSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.outlineLabelCurrentObject);
            this.Controls.Add(this.buttonWatch);
            this.Controls.Add(this.buttonExclude);
            this.Controls.Add(this.buttonPreviousRegion);
            this.Controls.Add(this.buttonNextRegion);
            this.Controls.Add(this.buttonRemoveRegion);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.outlineLabelThreshold);
            this.Controls.Add(this.outlineLabelDanger);
            this.Controls.Add(this.outlineLabelDangerValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownThreshold);
            this.Controls.Add(this.buttonReady);
            this.Controls.Add(this.pictureBoxCamera);
            this.Name = "FormSetup";
            this.Text = "FormSetup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReady;
        private System.Windows.Forms.PictureBox pictureBoxCamera;
        private System.Windows.Forms.NumericUpDown numericUpDownThreshold;
        private System.Windows.Forms.Button button1;
        private CustomControls.OutlineLabel outlineLabelDanger;
        private CustomControls.OutlineLabel outlineLabelThreshold;
        private System.Windows.Forms.Button buttonRemoveRegion;
        private System.Windows.Forms.Button buttonNextRegion;
        private System.Windows.Forms.Button buttonPreviousRegion;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button buttonExclude;
        private System.Windows.Forms.Button buttonWatch;
        private CustomControls.OutlineLabel outlineLabelCurrentObject;
        private System.Windows.Forms.Button buttonHome;
        internal CustomControls.OutlineLabel outlineLabelDangerValue;
    }
}