namespace MyMiniGamePlatform
{
    partial class GamePlatformInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePlatformInterface));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.memoryColorButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.mastermindButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tictactoeButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.mastermindTwoPlayersButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.mastermindTwoPlayersButton);
            this.layoutControl1.Controls.Add(this.tictactoeButton);
            this.layoutControl1.Controls.Add(this.mastermindButton);
            this.layoutControl1.Controls.Add(this.memoryColorButton);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(420, 188);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(420, 188);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(400, 84);
            this.layoutControlGroup2.Text = "One player games";
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 84);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(400, 84);
            this.layoutControlGroup3.Text = "Two players games";
            // 
            // memoryColorButton
            // 
            this.memoryColorButton.Image = ((System.Drawing.Image)(resources.GetObject("memoryColorButton.Image")));
            this.memoryColorButton.Location = new System.Drawing.Point(24, 42);
            this.memoryColorButton.Name = "memoryColorButton";
            this.memoryColorButton.Size = new System.Drawing.Size(184, 38);
            this.memoryColorButton.StyleController = this.layoutControl1;
            this.memoryColorButton.TabIndex = 4;
            this.memoryColorButton.Text = "Memory Color";
            this.memoryColorButton.Click += new System.EventHandler(this.memoryColorButton_Click);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.memoryColorButton;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(188, 42);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // mastermindButton
            // 
            this.mastermindButton.Image = ((System.Drawing.Image)(resources.GetObject("mastermindButton.Image")));
            this.mastermindButton.Location = new System.Drawing.Point(212, 42);
            this.mastermindButton.Name = "mastermindButton";
            this.mastermindButton.Size = new System.Drawing.Size(184, 38);
            this.mastermindButton.StyleController = this.layoutControl1;
            this.mastermindButton.TabIndex = 5;
            this.mastermindButton.Text = "Mastermind";
            this.mastermindButton.Click += new System.EventHandler(this.mastermindButton_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.mastermindButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(188, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(188, 42);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // tictactoeButton
            // 
            this.tictactoeButton.Image = ((System.Drawing.Image)(resources.GetObject("tictactoeButton.Image")));
            this.tictactoeButton.Location = new System.Drawing.Point(24, 126);
            this.tictactoeButton.Name = "tictactoeButton";
            this.tictactoeButton.Size = new System.Drawing.Size(184, 38);
            this.tictactoeButton.StyleController = this.layoutControl1;
            this.tictactoeButton.TabIndex = 6;
            this.tictactoeButton.Text = "Tic Tac Toe";
            this.tictactoeButton.Click += new System.EventHandler(this.tictactoeButton_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tictactoeButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(188, 42);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // mastermindTwoPlayersButton
            // 
            this.mastermindTwoPlayersButton.Image = ((System.Drawing.Image)(resources.GetObject("mastermindTwoPlayersButton.Image")));
            this.mastermindTwoPlayersButton.Location = new System.Drawing.Point(212, 126);
            this.mastermindTwoPlayersButton.Name = "mastermindTwoPlayersButton";
            this.mastermindTwoPlayersButton.Size = new System.Drawing.Size(184, 38);
            this.mastermindTwoPlayersButton.StyleController = this.layoutControl1;
            this.mastermindTwoPlayersButton.TabIndex = 7;
            this.mastermindTwoPlayersButton.Text = "Mastermind";
            this.mastermindTwoPlayersButton.Click += new System.EventHandler(this.mastermindTwoPlayersButton_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.mastermindTwoPlayersButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(188, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(188, 42);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // GamePlatformInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 188);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GamePlatformInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My mini game platform";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton mastermindTwoPlayersButton;
        private DevExpress.XtraEditors.SimpleButton tictactoeButton;
        private DevExpress.XtraEditors.SimpleButton mastermindButton;
        private DevExpress.XtraEditors.SimpleButton memoryColorButton;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}

