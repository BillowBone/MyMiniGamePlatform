using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Mastermind
{
    public partial class PlayerChooseCode : XtraForm
    {
        private MasterColors[] masterCode = new MasterColors[5];

        public PlayerChooseCode()
        {
            InitializeComponent();
        }

        //Calls the SelectColor class/form to let the user select a ci=olor to fill the current cell with
        private void ManageColorChoice(Button button)
        {
            SelectColor f = new SelectColor();
            if (f.ShowDialog() == DialogResult.OK)
                button.BackColor = SelectColor.selectedColor;
        }

        //Happens when the user click on any colorable button
        private void clickEvent(object sender, EventArgs e)
        {
            ManageColorChoice((Button)sender);
        }

        private bool allColorsSelected()
        {
            if (button1.BackColor != Color.Gainsboro && button2.BackColor != Color.Gainsboro
                && button3.BackColor != Color.Gainsboro && button4.BackColor != Color.Gainsboro
                && button5.BackColor != Color.Gainsboro) {
                return (true);
            } else {
                XtraMessageBox.Show("You must set a color for each cell !");
                return (false);
            }
        }

        //Fills the player's code tab depending on the color he chose
        private MasterColors AdaptColorChoice(Button button)
        {
            if (button.BackColor == Color.Red)
                return (MasterColors.Red);
            else if (button.BackColor == Color.Yellow)
                return (MasterColors.Yellow);
            else if (button.BackColor == Color.Lime)
                return (MasterColors.Green);
            else if (button.BackColor == Color.Blue)
                return (MasterColors.Blue);
            else if (button.BackColor == Color.DarkViolet)
                return (MasterColors.Purple);
            else if (button.BackColor == Color.DarkOrange)
                return (MasterColors.Orange);
            else if (button.BackColor == Color.Magenta)
                return (MasterColors.Pink);
            else
                return (MasterColors.Brown);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (allColorsSelected())
            {
                masterCode[0] = AdaptColorChoice(button1);
                masterCode[1] = AdaptColorChoice(button2);
                masterCode[2] = AdaptColorChoice(button3);
                masterCode[3] = AdaptColorChoice(button4);
                masterCode[4] = AdaptColorChoice(button5);
                this.Close();
            }
        }

        public MasterColors[] GetMasterCode()
        {
            return (masterCode);
        }
    }
}