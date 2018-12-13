using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Memory_Color
{
    public partial class MemoryColor : XtraForm
    {
        private int level = 1;
        private int missed = 0;
        private Color previous;
        private Color[] colorsCollection = { Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Purple };
        private Random rand = new Random();

        public MemoryColor()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            redButton.Visible = false;
            blueButton.Visible = false;
            yellowButton.Visible = false;
            greenButton.Visible = false;
            purpleButton.Visible = false;
            colorDisplayer.BackColor = colorsCollection[rand.Next(5)];
            previous = colorDisplayer.BackColor;
        }

        private void SetNewDifferentColor()
        {
            do
            {
                colorDisplayer.BackColor = colorsCollection[rand.Next(5)];
            } while (colorDisplayer.BackColor == previous);
        }

        private string GetPreviousColorName()
        {
            int i = 0;
            var name = new StringBuilder();

            foreach (char c in previous.ToString())
            {
                i++;
                if (i > 7 && c != ']')
                    name.Append(c);
            }
            return (name.ToString());
        }

        private void ChoiceValidation(SimpleButton button)
        {
            if (button.Text != GetPreviousColorName())
                missed++;
            level++;
            label1.Text = "Level : " + level.ToString();
            label2.Text = "Missed : " + missed.ToString();
            previous = colorDisplayer.BackColor;
            SetNewDifferentColor();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (level < 100)
                ChoiceValidation((SimpleButton)sender);
            else
                XtraMessageBox.Show("Game finished ! You missed " + missed.ToString() + " colors out of 100 !");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            label3.Text = "Which was the previous color ?";
            redButton.Visible = true;
            blueButton.Visible = true;
            yellowButton.Visible = true;
            greenButton.Visible = true;
            purpleButton.Visible = true;
            SetNewDifferentColor();
        }
    }
}
