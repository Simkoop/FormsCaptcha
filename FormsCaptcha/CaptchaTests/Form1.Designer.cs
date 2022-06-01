namespace CaptchaTests
{
    partial class Form1
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
            this.captcha1 = new FormsCaptcha.Captcha();
            this.captcha2 = new FormsCaptcha.Captcha();
            this.captcha3 = new FormsCaptcha.Captcha();
            this.captcha4 = new FormsCaptcha.Captcha();
            this.captcha5 = new FormsCaptcha.Captcha();
            this.captcha6 = new FormsCaptcha.Captcha();
            this.SuspendLayout();
            // 
            // captcha1
            // 
            this.captcha1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.captcha1.CaptchaLenght = 6;
            this.captcha1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.captcha1.GeneratedTextType = FormsCaptcha.Captcha.CaptchaTextType.Numeric;
            this.captcha1.Location = new System.Drawing.Point(12, 12);
            this.captcha1.Name = "captcha1";
            this.captcha1.Size = new System.Drawing.Size(270, 120);
            this.captcha1.TabIndex = 0;
            this.captcha1.Theme = FormsCaptcha.Captcha.CaptchaTheme.Dark;
            // 
            // captcha2
            // 
            this.captcha2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.captcha2.CaptchaLenght = 6;
            this.captcha2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.captcha2.GeneratedTextType = FormsCaptcha.Captcha.CaptchaTextType.SingleCase;
            this.captcha2.Location = new System.Drawing.Point(288, 12);
            this.captcha2.Name = "captcha2";
            this.captcha2.Size = new System.Drawing.Size(270, 120);
            this.captcha2.TabIndex = 1;
            this.captcha2.Theme = FormsCaptcha.Captcha.CaptchaTheme.Dark;
            // 
            // captcha3
            // 
            this.captcha3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.captcha3.CaptchaLenght = 6;
            this.captcha3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.captcha3.GeneratedTextType = FormsCaptcha.Captcha.CaptchaTextType.MixedCase;
            this.captcha3.Location = new System.Drawing.Point(564, 12);
            this.captcha3.Name = "captcha3";
            this.captcha3.Size = new System.Drawing.Size(270, 120);
            this.captcha3.TabIndex = 2;
            this.captcha3.Theme = FormsCaptcha.Captcha.CaptchaTheme.Dark;
            // 
            // captcha4
            // 
            this.captcha4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.captcha4.CaptchaLenght = 6;
            this.captcha4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.captcha4.GeneratedTextType = FormsCaptcha.Captcha.CaptchaTextType.SingleCaseNumeric;
            this.captcha4.Location = new System.Drawing.Point(12, 138);
            this.captcha4.Name = "captcha4";
            this.captcha4.Size = new System.Drawing.Size(270, 120);
            this.captcha4.TabIndex = 3;
            this.captcha4.Theme = FormsCaptcha.Captcha.CaptchaTheme.Dark;
            // 
            // captcha5
            // 
            this.captcha5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.captcha5.CaptchaLenght = 4;
            this.captcha5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.captcha5.GeneratedTextType = FormsCaptcha.Captcha.CaptchaTextType.All;
            this.captcha5.Location = new System.Drawing.Point(288, 138);
            this.captcha5.Name = "captcha5";
            this.captcha5.Size = new System.Drawing.Size(270, 120);
            this.captcha5.TabIndex = 4;
            this.captcha5.Theme = FormsCaptcha.Captcha.CaptchaTheme.Dark;
            // 
            // captcha6
            // 
            this.captcha6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.captcha6.CaptchaLenght = 8;
            this.captcha6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.captcha6.GeneratedTextType = FormsCaptcha.Captcha.CaptchaTextType.All;
            this.captcha6.Location = new System.Drawing.Point(564, 138);
            this.captcha6.Name = "captcha6";
            this.captcha6.Size = new System.Drawing.Size(270, 120);
            this.captcha6.TabIndex = 5;
            this.captcha6.Theme = FormsCaptcha.Captcha.CaptchaTheme.Light;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 270);
            this.Controls.Add(this.captcha6);
            this.Controls.Add(this.captcha5);
            this.Controls.Add(this.captcha4);
            this.Controls.Add(this.captcha3);
            this.Controls.Add(this.captcha2);
            this.Controls.Add(this.captcha1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private FormsCaptcha.Captcha captcha1;
        private FormsCaptcha.Captcha captcha2;
        private FormsCaptcha.Captcha captcha3;
        private FormsCaptcha.Captcha captcha4;
        private FormsCaptcha.Captcha captcha5;
        private FormsCaptcha.Captcha captcha6;
    }
}

