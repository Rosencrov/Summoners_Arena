namespace WindowsFormsApp5
{
    partial class TicTacToe
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
            this.components = new System.ComponentModel.Container();
            this.btnTopLeft = new System.Windows.Forms.Button();
            this.btnTopMid = new System.Windows.Forms.Button();
            this.btnTopRight = new System.Windows.Forms.Button();
            this.btnMidLeft = new System.Windows.Forms.Button();
            this.btnMidMid = new System.Windows.Forms.Button();
            this.btnMidRight = new System.Windows.Forms.Button();
            this.btnBottomLeft = new System.Windows.Forms.Button();
            this.btnBottomMid = new System.Windows.Forms.Button();
            this.btnBottomRight = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRestart = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblp1scoreIndicator = new System.Windows.Forms.Label();
            this.lblp2scoreIndicator = new System.Windows.Forms.Label();
            this.lblp1score = new System.Windows.Forms.Label();
            this.lblp2score = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lblp1score1 = new System.Windows.Forms.Label();
            this.lblp2score1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTopLeft
            // 
            this.btnTopLeft.BackColor = System.Drawing.Color.Linen;
            this.btnTopLeft.Location = new System.Drawing.Point(195, 66);
            this.btnTopLeft.Name = "btnTopLeft";
            this.btnTopLeft.Size = new System.Drawing.Size(85, 85);
            this.btnTopLeft.TabIndex = 0;
            this.btnTopLeft.UseVisualStyleBackColor = false;
            this.btnTopLeft.Click += new System.EventHandler(this.btnTopLeft_Click);
            // 
            // btnTopMid
            // 
            this.btnTopMid.BackColor = System.Drawing.Color.Linen;
            this.btnTopMid.Location = new System.Drawing.Point(280, 66);
            this.btnTopMid.Name = "btnTopMid";
            this.btnTopMid.Size = new System.Drawing.Size(85, 85);
            this.btnTopMid.TabIndex = 1;
            this.btnTopMid.UseVisualStyleBackColor = false;
            this.btnTopMid.Click += new System.EventHandler(this.btnTopMid_Click);
            // 
            // btnTopRight
            // 
            this.btnTopRight.BackColor = System.Drawing.Color.Linen;
            this.btnTopRight.Location = new System.Drawing.Point(365, 66);
            this.btnTopRight.Name = "btnTopRight";
            this.btnTopRight.Size = new System.Drawing.Size(85, 85);
            this.btnTopRight.TabIndex = 2;
            this.btnTopRight.UseVisualStyleBackColor = false;
            this.btnTopRight.Click += new System.EventHandler(this.btnTopRight_Click);
            // 
            // btnMidLeft
            // 
            this.btnMidLeft.BackColor = System.Drawing.Color.Linen;
            this.btnMidLeft.Location = new System.Drawing.Point(195, 151);
            this.btnMidLeft.Name = "btnMidLeft";
            this.btnMidLeft.Size = new System.Drawing.Size(85, 85);
            this.btnMidLeft.TabIndex = 3;
            this.btnMidLeft.UseVisualStyleBackColor = false;
            this.btnMidLeft.Click += new System.EventHandler(this.btnMidLeft_Click);
            // 
            // btnMidMid
            // 
            this.btnMidMid.BackColor = System.Drawing.Color.Linen;
            this.btnMidMid.Location = new System.Drawing.Point(280, 151);
            this.btnMidMid.Name = "btnMidMid";
            this.btnMidMid.Size = new System.Drawing.Size(85, 85);
            this.btnMidMid.TabIndex = 4;
            this.btnMidMid.UseVisualStyleBackColor = false;
            this.btnMidMid.Click += new System.EventHandler(this.btnMidMid_Click);
            // 
            // btnMidRight
            // 
            this.btnMidRight.BackColor = System.Drawing.Color.Linen;
            this.btnMidRight.Location = new System.Drawing.Point(365, 151);
            this.btnMidRight.Name = "btnMidRight";
            this.btnMidRight.Size = new System.Drawing.Size(85, 85);
            this.btnMidRight.TabIndex = 5;
            this.btnMidRight.UseVisualStyleBackColor = false;
            this.btnMidRight.Click += new System.EventHandler(this.btnMidRight_Click);
            // 
            // btnBottomLeft
            // 
            this.btnBottomLeft.BackColor = System.Drawing.Color.Linen;
            this.btnBottomLeft.Location = new System.Drawing.Point(195, 236);
            this.btnBottomLeft.Name = "btnBottomLeft";
            this.btnBottomLeft.Size = new System.Drawing.Size(85, 85);
            this.btnBottomLeft.TabIndex = 6;
            this.btnBottomLeft.UseVisualStyleBackColor = false;
            this.btnBottomLeft.Click += new System.EventHandler(this.btnBottomLeft_Click);
            // 
            // btnBottomMid
            // 
            this.btnBottomMid.BackColor = System.Drawing.Color.Linen;
            this.btnBottomMid.Location = new System.Drawing.Point(280, 236);
            this.btnBottomMid.Name = "btnBottomMid";
            this.btnBottomMid.Size = new System.Drawing.Size(85, 85);
            this.btnBottomMid.TabIndex = 7;
            this.btnBottomMid.UseVisualStyleBackColor = false;
            this.btnBottomMid.Click += new System.EventHandler(this.btnBottomMid_Click);
            // 
            // btnBottomRight
            // 
            this.btnBottomRight.BackColor = System.Drawing.Color.Linen;
            this.btnBottomRight.Location = new System.Drawing.Point(365, 236);
            this.btnBottomRight.Name = "btnBottomRight";
            this.btnBottomRight.Size = new System.Drawing.Size(85, 85);
            this.btnBottomRight.TabIndex = 8;
            this.btnBottomRight.UseVisualStyleBackColor = false;
            this.btnBottomRight.Click += new System.EventHandler(this.btnBottomRight_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.PeachPuff;
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRestart.Location = new System.Drawing.Point(37, 150);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(109, 42);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "Next round";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.RosyBrown;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.txtResult.Location = new System.Drawing.Point(202, 6);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(241, 41);
            this.txtResult.TabIndex = 10;
            this.txtResult.Text = "WINNER";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // lblp1scoreIndicator
            // 
            this.lblp1scoreIndicator.AutoSize = true;
            this.lblp1scoreIndicator.BackColor = System.Drawing.Color.Transparent;
            this.lblp1scoreIndicator.Font = new System.Drawing.Font("Lucida Calligraphy", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp1scoreIndicator.Location = new System.Drawing.Point(2, 30);
            this.lblp1scoreIndicator.Name = "lblp1scoreIndicator";
            this.lblp1scoreIndicator.Size = new System.Drawing.Size(158, 21);
            this.lblp1scoreIndicator.TabIndex = 11;
            this.lblp1scoreIndicator.Text = "Score of player 1: ";
            // 
            // lblp2scoreIndicator
            // 
            this.lblp2scoreIndicator.AutoSize = true;
            this.lblp2scoreIndicator.BackColor = System.Drawing.Color.Transparent;
            this.lblp2scoreIndicator.Font = new System.Drawing.Font("Lucida Calligraphy", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp2scoreIndicator.Location = new System.Drawing.Point(2, 78);
            this.lblp2scoreIndicator.Name = "lblp2scoreIndicator";
            this.lblp2scoreIndicator.Size = new System.Drawing.Size(160, 21);
            this.lblp2scoreIndicator.TabIndex = 12;
            this.lblp2scoreIndicator.Text = "Score of player 2: ";
            // 
            // lblp1score
            // 
            this.lblp1score.AutoSize = true;
            this.lblp1score.Location = new System.Drawing.Point(723, 71);
            this.lblp1score.Name = "lblp1score";
            this.lblp1score.Size = new System.Drawing.Size(0, 20);
            this.lblp1score.TabIndex = 13;
            // 
            // lblp2score
            // 
            this.lblp2score.AutoSize = true;
            this.lblp2score.Location = new System.Drawing.Point(723, 119);
            this.lblp2score.Name = "lblp2score";
            this.lblp2score.Size = new System.Drawing.Size(0, 20);
            this.lblp2score.TabIndex = 14;
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnRestartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRestartGame.Location = new System.Drawing.Point(28, 201);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(132, 40);
            this.btnRestartGame.TabIndex = 15;
            this.btnRestartGame.Text = "Restart game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.LightGray;
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.No;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(26, 251);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(134, 37);
            this.btnMainMenu.TabIndex = 16;
            this.btnMainMenu.Text = "Main menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // lblp1score1
            // 
            this.lblp1score1.AutoSize = true;
            this.lblp1score1.BackColor = System.Drawing.Color.Transparent;
            this.lblp1score1.Font = new System.Drawing.Font("Lucida Calligraphy", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp1score1.Location = new System.Drawing.Point(156, 30);
            this.lblp1score1.Name = "lblp1score1";
            this.lblp1score1.Size = new System.Drawing.Size(21, 21);
            this.lblp1score1.TabIndex = 17;
            this.lblp1score1.Text = "0";
            // 
            // lblp2score1
            // 
            this.lblp2score1.AutoSize = true;
            this.lblp2score1.BackColor = System.Drawing.Color.Transparent;
            this.lblp2score1.Font = new System.Drawing.Font("Lucida Calligraphy", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp2score1.Location = new System.Drawing.Point(156, 78);
            this.lblp2score1.Name = "lblp2score1";
            this.lblp2score1.Size = new System.Drawing.Size(21, 21);
            this.lblp2score1.TabIndex = 18;
            this.lblp2score1.Text = "0";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(484, 336);
            this.Controls.Add(this.lblp2score1);
            this.Controls.Add(this.lblp1score1);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.lblp2score);
            this.Controls.Add(this.lblp1score);
            this.Controls.Add(this.lblp2scoreIndicator);
            this.Controls.Add(this.lblp1scoreIndicator);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnBottomRight);
            this.Controls.Add(this.btnBottomMid);
            this.Controls.Add(this.btnBottomLeft);
            this.Controls.Add(this.btnMidRight);
            this.Controls.Add(this.btnMidMid);
            this.Controls.Add(this.btnMidLeft);
            this.Controls.Add(this.btnTopRight);
            this.Controls.Add(this.btnTopMid);
            this.Controls.Add(this.btnTopLeft);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTopLeft;
        private System.Windows.Forms.Button btnTopMid;
        private System.Windows.Forms.Button btnTopRight;
        private System.Windows.Forms.Button btnMidLeft;
        private System.Windows.Forms.Button btnMidMid;
        private System.Windows.Forms.Button btnMidRight;
        private System.Windows.Forms.Button btnBottomLeft;
        private System.Windows.Forms.Button btnBottomMid;
        private System.Windows.Forms.Button btnBottomRight;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblp1scoreIndicator;
        private System.Windows.Forms.Label lblp2scoreIndicator;
        private System.Windows.Forms.Label lblp1score;
        private System.Windows.Forms.Label lblp2score;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label lblp1score1;
        private System.Windows.Forms.Label lblp2score1;
    }
}

