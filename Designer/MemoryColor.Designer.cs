namespace Memory_Color
{
    partial class MemoryColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryColor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDisplayer = new System.Windows.Forms.Button();
            this.redButton = new DevExpress.XtraEditors.SimpleButton();
            this.blueButton = new DevExpress.XtraEditors.SimpleButton();
            this.yellowButton = new DevExpress.XtraEditors.SimpleButton();
            this.greenButton = new DevExpress.XtraEditors.SimpleButton();
            this.purpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.startButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level : 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Missed : 0";
            // 
            // colorDisplayer
            // 
            this.colorDisplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorDisplayer.Location = new System.Drawing.Point(182, 82);
            this.colorDisplayer.Name = "colorDisplayer";
            this.colorDisplayer.Size = new System.Drawing.Size(323, 242);
            this.colorDisplayer.TabIndex = 2;
            this.colorDisplayer.UseVisualStyleBackColor = true;
            // 
            // redButton
            // 
            this.redButton.Location = new System.Drawing.Point(50, 441);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(75, 35);
            this.redButton.TabIndex = 3;
            this.redButton.Text = "Red";
            this.redButton.Click += new System.EventHandler(this.button_Click);
            // 
            // blueButton
            // 
            this.blueButton.Location = new System.Drawing.Point(175, 441);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(75, 35);
            this.blueButton.TabIndex = 4;
            this.blueButton.Text = "Blue";
            this.blueButton.Click += new System.EventHandler(this.button_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.Location = new System.Drawing.Point(300, 441);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(75, 35);
            this.yellowButton.TabIndex = 5;
            this.yellowButton.Text = "Yellow";
            this.yellowButton.Click += new System.EventHandler(this.button_Click);
            // 
            // greenButton
            // 
            this.greenButton.Location = new System.Drawing.Point(425, 441);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(75, 35);
            this.greenButton.TabIndex = 6;
            this.greenButton.Text = "Green";
            this.greenButton.Click += new System.EventHandler(this.button_Click);
            // 
            // purpleButton
            // 
            this.purpleButton.Location = new System.Drawing.Point(550, 441);
            this.purpleButton.Name = "purpleButton";
            this.purpleButton.Size = new System.Drawing.Size(75, 35);
            this.purpleButton.TabIndex = 7;
            this.purpleButton.Text = "Purple";
            this.purpleButton.Click += new System.EventHandler(this.button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Click on start when you\'re ready";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(300, 441);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 35);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // MemoryColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 511);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.purpleButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.colorDisplayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemoryColor";
            this.Text = "Memory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button colorDisplayer;
        private DevExpress.XtraEditors.SimpleButton redButton;
        private DevExpress.XtraEditors.SimpleButton blueButton;
        private DevExpress.XtraEditors.SimpleButton yellowButton;
        private DevExpress.XtraEditors.SimpleButton greenButton;
        private DevExpress.XtraEditors.SimpleButton purpleButton;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton startButton;
    }
}

