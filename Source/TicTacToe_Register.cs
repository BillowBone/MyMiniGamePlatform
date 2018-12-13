using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TicTacToe
{
    public partial class Register : XtraForm
    {
        public static string player1 = null;
        public static string player2 = null;

        public Register()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && player1 == null && textBox1.Text.Length < 17)
            {
                player1 = textBox1.Text;
                textBox1.Text = "";
                labelControl1.Text = "Enter the name of the player 2";
            }
            else if (textBox1.Text.Length > 0 && player1 != null && player1 != textBox1.Text && textBox1.Text.Length < 17)
            {
                player2 = textBox1.Text;
                Game game = new Game(this);
                game.ShowDialog();
            }
        }
    }
}
