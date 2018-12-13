using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MyMiniGamePlatform
{
    public partial class GamePlatformInterface : XtraForm
    {
        public GamePlatformInterface()
        {
            InitializeComponent();
        }

        private void memoryColorButton_Click(object sender, EventArgs e)
        {
            Memory_Color.MemoryColor memory = new Memory_Color.MemoryColor();
            this.Visible = false;
            memory.ShowDialog();
            this.Visible = true;
        }

        private void mastermindButton_Click(object sender, EventArgs e)
        {
            Mastermind.ChooseMode choose = new Mastermind.ChooseMode();
            this.Visible = false;
            if (choose.ShowDialog() == DialogResult.OK)
            {
                Mastermind.Game master = new Mastermind.Game(true);
                master.ShowDialog();
            }
            this.Visible = true;
        }

        private void tictactoeButton_Click(object sender, EventArgs e)
        {
            TicTacToe.Register register = new TicTacToe.Register();
            this.Visible = false;
            register.ShowDialog();
            this.Visible = true;
        }

        private void mastermindTwoPlayersButton_Click(object sender, EventArgs e)
        {
            Mastermind.ChooseMode choose = new Mastermind.ChooseMode();
            this.Visible = false;
            if (choose.ShowDialog() == DialogResult.OK)
            {
                Mastermind.Game master = new Mastermind.Game(false);
                master.ShowDialog();
            }
            this.Visible = true;
        }
    }
}
