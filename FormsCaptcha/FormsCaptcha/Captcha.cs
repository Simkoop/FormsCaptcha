using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsCaptcha
{
    public partial class Captcha : UserControl
    {
        private Random rnd;
        private protected string CaptchaAnswer;
        public string UserAnswer = "";

        public CaptchaTextType generatedTextType;
        public CaptchaTextType GeneratedTextType
        {
            get
            {
                return generatedTextType;
            }
            set
            {
                generatedTextType = value;
                if (VerifyCaptcha() == false)
                    GenerateCaptcha();
            }
        }
        public int captchaLenght = 6;
        public int CaptchaLenght
        {
            get
            {
                return captchaLenght;
            }
            set
            {
                captchaLenght = value;
                if (VerifyCaptcha() == false)
                    GenerateCaptcha();
            }
        }

        public CaptchaTheme theme = CaptchaTheme.Light;
        public CaptchaTheme Theme
        {
            get
            {
                return theme;
            }
            set
            {
                theme = value;

                if (value == CaptchaTheme.Light)
                {
                    this.BackColor = Color.FromArgb(230, 230, 230);
                    this.ForeColor = Color.FromArgb(0, 0, 0);
                }
                else
                {
                    this.BackColor = Color.FromArgb(25, 25, 25);
                    this.ForeColor = Color.FromArgb(230, 230, 230);
                }

                panel1.BackColor = this.BackColor;
                panel2.BackColor = this.BackColor;
                pictureBox1.BackColor = this.BackColor;
                textBox1.BackColor = this.BackColor;
                label1.ForeColor = this.ForeColor;


                if (VerifyCaptcha() == false)
                    GenerateCaptcha();
            }
        }

        public bool CaptchaComplete
        {
            get
            {
                return VerifyCaptcha();
            }
        }

        public enum CaptchaTextType
        {
            Numeric,
            SingleCase,
            MixedCase,
            SingleCaseNumeric,
            All
        }

        public enum CaptchaTheme
        {
            Light,
            Dark
        }

        public Captcha()
        {
            InitializeComponent();
            rnd = new Random();
            pictureBox1.BackgroundImage = GenerateCaptcha();
        }

        private Bitmap GenerateCaptcha()
        {
            textBox1.Text = "";

            int textSize = 20;
            int charSpacing = 40;
            Bitmap bmp = new Bitmap(CaptchaLenght * charSpacing, textSize * 3);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(this.BackColor);
            string captchaText = GenerateCaptchaText(CaptchaLenght);
            CaptchaAnswer = captchaText;

            AddRandomChars(bmp, g, 40, GeneratedTextType, textSize / 2);

            Font font = new Font(FontFamily.GenericSansSerif, textSize, FontStyle.Regular);
            for (int i = 0; i < CaptchaLenght; i++) 
            {
                g.TranslateTransform(charSpacing * i, rnd.Next(0, textSize));
                g.RotateTransform(rnd.Next(-20, 20));
                g.DrawString(captchaText[i].ToString(), font, new SolidBrush(this.ForeColor), new Point(0,0));
                g.ResetTransform();
            }

            AddHorizontalLines(bmp, g, 20);
            AddColorGradient(bmp, g, 15);

            return bmp;
        }

        private void AddHorizontalLines(Bitmap bmp, Graphics g, int count)
        {
            int penSize = 1;
            Pen pen = new Pen(this.ForeColor, penSize);
            for (int i = 0; i < count; i++)
            {
                int x = rnd.Next(0, bmp.Width);
                int y = rnd.Next(0, bmp.Height);
                int halfLen = rnd.Next(0, bmp.Width / 2);
                g.DrawLine(pen, new Point(x - halfLen, y), new Point(x + halfLen, y));
            }
        }
        private void AddColorGradient(Bitmap bmp, Graphics g, int density)
        {
            int penSize = 1;
            Pen pen = new Pen(this.ForeColor, penSize);
            for (int i = 0; i < bmp.Width; i++)
            {
                if (rnd.Next(0, density) == 0) {
                    g.DrawLine(pen, new Point(i, 0), new Point(i, bmp.Height));
                }
            }
        }

        private void AddRandomChars(Bitmap bmp, Graphics g, int len, CaptchaTextType type, int size)
        {

            string captchaText = GenerateCaptchaText(len);

            Font font = new Font(FontFamily.GenericSansSerif, size, FontStyle.Regular);
            for (int i = 0; i < len; i++)
            {
                int x = rnd.Next(0, bmp.Width);
                int y = rnd.Next(0, bmp.Height);
                g.DrawString(captchaText[i].ToString(), font, new SolidBrush(Color.DarkGray), new Point(x, y));
            }
        }

        private string GenerateCaptchaText(int len)
        {
            //Generate applicable chars
            string chars = "";
            switch (GeneratedTextType)
            {
                case CaptchaTextType.Numeric:
                    chars += "1234567890";
                    break;
                case CaptchaTextType.SingleCase:
                    chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    break;
                case CaptchaTextType.MixedCase:
                    chars += "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    break;
                case CaptchaTextType.SingleCaseNumeric:
                    chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                    break;
                case CaptchaTextType.All:
                    chars += "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    break;
            }

            string result = "";

            for (int i = 0; i < len; i++)
            {
                result += GetRandomChar(chars);
            }

            return result;
        }

        public char GetRandomChar(string chars)
        {
            int num = rnd.Next(0, chars.Length);
            return chars[num];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(VerifyCaptcha() == false)
                pictureBox1.BackgroundImage = GenerateCaptcha();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserAnswer = textBox1.Text;
            VerifyCaptcha();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UserAnswer = textBox1.Text;
                VerifyCaptcha();
            }
        }

        private bool VerifyCaptcha()
        {
            if (GeneratedTextType == CaptchaTextType.SingleCase || GeneratedTextType == CaptchaTextType.SingleCaseNumeric)            
            {

                UserAnswer = UserAnswer.ToUpper();
            }

            if (UserAnswer == CaptchaAnswer)
            {
                button1.Text = "Correct";
                button1.BackColor = Color.Green;
                textBox1.Enabled = false;
                return true;
            }
            else
            {
                pictureBox1.BackgroundImage = GenerateCaptcha();
                return true;
            }
        }
    }
}
