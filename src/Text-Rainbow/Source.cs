using System;
using System.Drawing;
using System.Windows.Forms;

namespace Text_Rainbow
{
    public partial class Source : Form
    {
        public Source()
        {
            InitializeComponent();

            //Timer Setting
            this.ColorTimer.Start();
            this.ColorSet.Stop();
            this.ColorTimer.Interval = 1;
            this.ColorSet.Interval = 1;
        }

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            int red = (int)this.numericUpDownRed.Value;
            int green = (int)this.numericUpDownGreen.Value;
            int blue = (int)this.numericUpDownBlue.Value;
            Color color = Color.FromArgb(red, green, blue);
            string text = ColorTranslator.ToHtml(color);
            this.HTMLCodeTextBox.Text = text;
        }

        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            int red = (int)this.numericUpDownRed.Value;
            int green = (int)this.numericUpDownGreen.Value;
            int blue = (int)this.numericUpDownBlue.Value;
            Color color = Color.FromArgb(red, green, blue);
            string text = ColorTranslator.ToHtml(color);
            this.HTMLCodeTextBox.Text = text;
        }

        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            int red = (int)this.numericUpDownRed.Value;
            int green = (int)this.numericUpDownGreen.Value;
            int blue = (int)this.numericUpDownBlue.Value;
            Color color = Color.FromArgb(red, green, blue);
            string text = ColorTranslator.ToHtml(color);
            this.HTMLCodeTextBox.Text = text;
        }

        private void HTMLCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            Color color = ColorTranslator.FromHtml(HTMLCodeTextBox.Text);
            var Value = this.HTMLCodeTextBox.Text;
            HTMLCodeLabel.Text = Value;
            this.BackColor = color;
        }

        private void HTMLCodeLabel_Click(object sender, EventArgs e)
        {
          /*var N = Environment.NewLine;
            string YourMessage = "";
            MessageBox.Show(YourMessage, "Text Rainbow", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);*/
        }

        private void ColorTimer_Tick(object sender, EventArgs e)
        {
            //Convert Text to Value
            int Red = Convert.ToInt32(numericUpDownRed.Value);
            int Green = Convert.ToInt32(numericUpDownGreen.Value);
            int Blue = Convert.ToInt16(numericUpDownBlue.Value);

            try
            {
                numericUpDownGreen.Value = Green + 1;
                return;
            }
            catch (Exception)
            {
                try
                {
                    numericUpDownRed.Value = Red - 1;
                    return;
                }
                catch (Exception)
                {
                    try
                    {
                        numericUpDownBlue.Value = Blue + 1;
                    }
                    catch (Exception)
                    {
                        ColorTimer.Stop();
                        numericUpDownGreen.Value = Green - 1;
                        ColorSet.Start();
                    }
                }
            }
        }

        private void ColorSet_Tick(object sender, EventArgs e)
        {
            //Convert Text to Value
            int Red = Convert.ToInt32(numericUpDownRed.Value);
            int Green = Convert.ToInt32(numericUpDownGreen.Value);
            int Blue = Convert.ToInt16(numericUpDownBlue.Value);

            try
            {
                numericUpDownGreen.Value = Green - 1;
            }
            catch (Exception)
            {
                try
                {
                    numericUpDownRed.Value = Red + 1;
                }
                catch (Exception)
                {
                    try
                    {
                        numericUpDownBlue.Value = Blue - 1;
                    }
                    catch (Exception)
                    {
                        ColorSet.Stop();
                        ColorTimer.Start();
                    }
                }
            }
        }
    }
}
