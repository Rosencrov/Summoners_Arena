namespace WindowsFormsApp5
{
    partial class RPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPS));
            this.gbPlayer1 = new System.Windows.Forms.GroupBox();
            this.rbtnPaper1 = new System.Windows.Forms.RadioButton();
            this.rbtnSci1 = new System.Windows.Forms.RadioButton();
            this.rbtnRock1 = new System.Windows.Forms.RadioButton();
            this.lblVS = new System.Windows.Forms.Label();
            this.rbtnRock2 = new System.Windows.Forms.RadioButton();
            this.rbtnSci2 = new System.Windows.Forms.RadioButton();
            this.rbtnPaper2 = new System.Windows.Forms.RadioButton();
            this.gbPlayer2 = new System.Windows.Forms.GroupBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnLock1 = new System.Windows.Forms.Button();
            this.btnLock2 = new System.Windows.Forms.Button();
            this.lblP1scoreShow = new System.Windows.Forms.Label();
            this.lblP2scoreShow = new System.Windows.Forms.Label();
            this.lblP1score = new System.Windows.Forms.Label();
            this.lblP2score = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.pbRock1_1 = new System.Windows.Forms.PictureBox();
            this.pbRock2_1 = new System.Windows.Forms.PictureBox();
            this.pbPaper1_1 = new System.Windows.Forms.PictureBox();
            this.pbScissors1_1 = new System.Windows.Forms.PictureBox();
            this.pbPaper2_1 = new System.Windows.Forms.PictureBox();
            this.pbScissors2_1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbRock1_2 = new System.Windows.Forms.PictureBox();
            this.pbRock2_2 = new System.Windows.Forms.PictureBox();
            this.gbPlayer1.SuspendLayout();
            this.gbPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScissors1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScissors2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock2_2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPlayer1
            // 
            this.gbPlayer1.Controls.Add(this.rbtnPaper1);
            this.gbPlayer1.Controls.Add(this.rbtnSci1);
            this.gbPlayer1.Controls.Add(this.rbtnRock1);
            this.gbPlayer1.Location = new System.Drawing.Point(94, 48);
            this.gbPlayer1.Name = "gbPlayer1";
            this.gbPlayer1.Size = new System.Drawing.Size(200, 429);
            this.gbPlayer1.TabIndex = 3;
            this.gbPlayer1.TabStop = false;
            this.gbPlayer1.Text = "Choose your weapon";
            this.gbPlayer1.Enter += new System.EventHandler(this.gbPlayer1_Enter);
            // 
            // rbtnPaper1
            // 
            this.rbtnPaper1.AutoSize = true;
            this.rbtnPaper1.Image = ((System.Drawing.Image)(resources.GetObject("rbtnPaper1.Image")));
            this.rbtnPaper1.Location = new System.Drawing.Point(57, 150);
            this.rbtnPaper1.Name = "rbtnPaper1";
            this.rbtnPaper1.Size = new System.Drawing.Size(98, 64);
            this.rbtnPaper1.TabIndex = 1;
            this.rbtnPaper1.TabStop = true;
            this.rbtnPaper1.Text = "\r\n";
            this.rbtnPaper1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtnPaper1.UseVisualStyleBackColor = true;
            this.rbtnPaper1.CheckedChanged += new System.EventHandler(this.rbtnPaper1_CheckedChanged);
            // 
            // rbtnSci1
            // 
            this.rbtnSci1.AutoSize = true;
            this.rbtnSci1.Image = ((System.Drawing.Image)(resources.GetObject("rbtnSci1.Image")));
            this.rbtnSci1.Location = new System.Drawing.Point(57, 278);
            this.rbtnSci1.Name = "rbtnSci1";
            this.rbtnSci1.Size = new System.Drawing.Size(98, 64);
            this.rbtnSci1.TabIndex = 2;
            this.rbtnSci1.TabStop = true;
            this.rbtnSci1.Text = "\r\n";
            this.rbtnSci1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtnSci1.UseVisualStyleBackColor = true;
            this.rbtnSci1.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbtnRock1
            // 
            this.rbtnRock1.AutoSize = true;
            this.rbtnRock1.Image = ((System.Drawing.Image)(resources.GetObject("rbtnRock1.Image")));
            this.rbtnRock1.Location = new System.Drawing.Point(57, 43);
            this.rbtnRock1.Name = "rbtnRock1";
            this.rbtnRock1.Size = new System.Drawing.Size(98, 64);
            this.rbtnRock1.TabIndex = 0;
            this.rbtnRock1.TabStop = true;
            this.rbtnRock1.Text = "\r\n";
            this.rbtnRock1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtnRock1.UseVisualStyleBackColor = true;
            this.rbtnRock1.CheckedChanged += new System.EventHandler(this.rbtnRock1_CheckedChanged);
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVS.Location = new System.Drawing.Point(526, 229);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(74, 46);
            this.lblVS.TabIndex = 5;
            this.lblVS.Text = "VS";
            this.lblVS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtnRock2
            // 
            this.rbtnRock2.AutoSize = true;
            this.rbtnRock2.Image = ((System.Drawing.Image)(resources.GetObject("rbtnRock2.Image")));
            this.rbtnRock2.Location = new System.Drawing.Point(57, 43);
            this.rbtnRock2.Name = "rbtnRock2";
            this.rbtnRock2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnRock2.Size = new System.Drawing.Size(98, 64);
            this.rbtnRock2.TabIndex = 0;
            this.rbtnRock2.TabStop = true;
            this.rbtnRock2.Text = "\r\n";
            this.rbtnRock2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtnRock2.UseVisualStyleBackColor = true;
            this.rbtnRock2.CheckedChanged += new System.EventHandler(this.rbtnRock2_CheckedChanged);
            // 
            // rbtnSci2
            // 
            this.rbtnSci2.AutoSize = true;
            this.rbtnSci2.Image = ((System.Drawing.Image)(resources.GetObject("rbtnSci2.Image")));
            this.rbtnSci2.Location = new System.Drawing.Point(57, 278);
            this.rbtnSci2.Name = "rbtnSci2";
            this.rbtnSci2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnSci2.Size = new System.Drawing.Size(98, 64);
            this.rbtnSci2.TabIndex = 2;
            this.rbtnSci2.TabStop = true;
            this.rbtnSci2.Text = "\r\n";
            this.rbtnSci2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtnSci2.UseVisualStyleBackColor = true;
            this.rbtnSci2.CheckedChanged += new System.EventHandler(this.rbtnSci2_CheckedChanged);
            // 
            // rbtnPaper2
            // 
            this.rbtnPaper2.AutoSize = true;
            this.rbtnPaper2.Image = ((System.Drawing.Image)(resources.GetObject("rbtnPaper2.Image")));
            this.rbtnPaper2.Location = new System.Drawing.Point(57, 150);
            this.rbtnPaper2.Name = "rbtnPaper2";
            this.rbtnPaper2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnPaper2.Size = new System.Drawing.Size(98, 64);
            this.rbtnPaper2.TabIndex = 1;
            this.rbtnPaper2.TabStop = true;
            this.rbtnPaper2.Text = "\r\n";
            this.rbtnPaper2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtnPaper2.UseVisualStyleBackColor = true;
            this.rbtnPaper2.CheckedChanged += new System.EventHandler(this.rbtnPaper2_CheckedChanged);
            // 
            // gbPlayer2
            // 
            this.gbPlayer2.Controls.Add(this.rbtnPaper2);
            this.gbPlayer2.Controls.Add(this.rbtnSci2);
            this.gbPlayer2.Controls.Add(this.rbtnRock2);
            this.gbPlayer2.Location = new System.Drawing.Point(849, 48);
            this.gbPlayer2.Name = "gbPlayer2";
            this.gbPlayer2.Size = new System.Drawing.Size(200, 428);
            this.gbPlayer2.TabIndex = 4;
            this.gbPlayer2.TabStop = false;
            this.gbPlayer2.Text = "Choose your weapon";
            this.gbPlayer2.Enter += new System.EventHandler(this.gbPlayer2_Enter);
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnResult.Location = new System.Drawing.Point(525, 326);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 35);
            this.btnResult.TabIndex = 6;
            this.btnResult.Text = "Reveal";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnLock1
            // 
            this.btnLock1.Location = new System.Drawing.Point(124, 483);
            this.btnLock1.Name = "btnLock1";
            this.btnLock1.Size = new System.Drawing.Size(113, 34);
            this.btnLock1.TabIndex = 7;
            this.btnLock1.Text = "Lock-in";
            this.btnLock1.UseVisualStyleBackColor = true;
            this.btnLock1.Click += new System.EventHandler(this.btnLock1_Click);
            // 
            // btnLock2
            // 
            this.btnLock2.Location = new System.Drawing.Point(894, 482);
            this.btnLock2.Name = "btnLock2";
            this.btnLock2.Size = new System.Drawing.Size(113, 35);
            this.btnLock2.TabIndex = 8;
            this.btnLock2.Text = "Lock-in";
            this.btnLock2.UseVisualStyleBackColor = true;
            this.btnLock2.Click += new System.EventHandler(this.btnLock2_Click);
            // 
            // lblP1scoreShow
            // 
            this.lblP1scoreShow.AutoSize = true;
            this.lblP1scoreShow.Location = new System.Drawing.Point(133, 22);
            this.lblP1scoreShow.Name = "lblP1scoreShow";
            this.lblP1scoreShow.Size = new System.Drawing.Size(55, 20);
            this.lblP1scoreShow.TabIndex = 9;
            this.lblP1scoreShow.Text = "Score:";
            // 
            // lblP2scoreShow
            // 
            this.lblP2scoreShow.AutoSize = true;
            this.lblP2scoreShow.Location = new System.Drawing.Point(890, 22);
            this.lblP2scoreShow.Name = "lblP2scoreShow";
            this.lblP2scoreShow.Size = new System.Drawing.Size(55, 20);
            this.lblP2scoreShow.TabIndex = 10;
            this.lblP2scoreShow.Text = "Score:";
            // 
            // lblP1score
            // 
            this.lblP1score.AutoSize = true;
            this.lblP1score.Location = new System.Drawing.Point(195, 22);
            this.lblP1score.Name = "lblP1score";
            this.lblP1score.Size = new System.Drawing.Size(18, 20);
            this.lblP1score.TabIndex = 11;
            this.lblP1score.Text = "0";
            // 
            // lblP2score
            // 
            this.lblP2score.AutoSize = true;
            this.lblP2score.Location = new System.Drawing.Point(951, 22);
            this.lblP2score.Name = "lblP2score";
            this.lblP2score.Size = new System.Drawing.Size(18, 20);
            this.lblP2score.TabIndex = 12;
            this.lblP2score.Text = "0";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(511, 395);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(105, 35);
            this.btnMainMenu.TabIndex = 13;
            this.btnMainMenu.Text = "Main menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // pbRock1_1
            // 
            this.pbRock1_1.Image = ((System.Drawing.Image)(resources.GetObject("pbRock1_1.Image")));
            this.pbRock1_1.Location = new System.Drawing.Point(479, 175);
            this.pbRock1_1.Name = "pbRock1_1";
            this.pbRock1_1.Size = new System.Drawing.Size(100, 100);
            this.pbRock1_1.TabIndex = 3;
            this.pbRock1_1.TabStop = false;
            this.pbRock1_1.Visible = false;
            // 
            // pbRock2_1
            // 
            this.pbRock2_1.Image = ((System.Drawing.Image)(resources.GetObject("pbRock2_1.Image")));
            this.pbRock2_1.Location = new System.Drawing.Point(572, 175);
            this.pbRock2_1.Name = "pbRock2_1";
            this.pbRock2_1.Size = new System.Drawing.Size(100, 100);
            this.pbRock2_1.TabIndex = 14;
            this.pbRock2_1.TabStop = false;
            this.pbRock2_1.Visible = false;
            // 
            // pbPaper1_1
            // 
            this.pbPaper1_1.Image = ((System.Drawing.Image)(resources.GetObject("pbPaper1_1.Image")));
            this.pbPaper1_1.Location = new System.Drawing.Point(479, 175);
            this.pbPaper1_1.Name = "pbPaper1_1";
            this.pbPaper1_1.Size = new System.Drawing.Size(100, 100);
            this.pbPaper1_1.TabIndex = 15;
            this.pbPaper1_1.TabStop = false;
            this.pbPaper1_1.Visible = false;
            // 
            // pbScissors1_1
            // 
            this.pbScissors1_1.Image = ((System.Drawing.Image)(resources.GetObject("pbScissors1_1.Image")));
            this.pbScissors1_1.Location = new System.Drawing.Point(479, 175);
            this.pbScissors1_1.Name = "pbScissors1_1";
            this.pbScissors1_1.Size = new System.Drawing.Size(100, 100);
            this.pbScissors1_1.TabIndex = 16;
            this.pbScissors1_1.TabStop = false;
            this.pbScissors1_1.Visible = false;
            // 
            // pbPaper2_1
            // 
            this.pbPaper2_1.Image = ((System.Drawing.Image)(resources.GetObject("pbPaper2_1.Image")));
            this.pbPaper2_1.Location = new System.Drawing.Point(572, 175);
            this.pbPaper2_1.Name = "pbPaper2_1";
            this.pbPaper2_1.Size = new System.Drawing.Size(100, 100);
            this.pbPaper2_1.TabIndex = 17;
            this.pbPaper2_1.TabStop = false;
            this.pbPaper2_1.Visible = false;
            // 
            // pbScissors2_1
            // 
            this.pbScissors2_1.Image = ((System.Drawing.Image)(resources.GetObject("pbScissors2_1.Image")));
            this.pbScissors2_1.Location = new System.Drawing.Point(572, 175);
            this.pbScissors2_1.Name = "pbScissors2_1";
            this.pbScissors2_1.Size = new System.Drawing.Size(100, 100);
            this.pbScissors2_1.TabIndex = 18;
            this.pbScissors2_1.TabStop = false;
            this.pbScissors2_1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbRock1_2
            // 
            this.pbRock1_2.Image = ((System.Drawing.Image)(resources.GetObject("pbRock1_2.Image")));
            this.pbRock1_2.Location = new System.Drawing.Point(479, 175);
            this.pbRock1_2.Name = "pbRock1_2";
            this.pbRock1_2.Size = new System.Drawing.Size(100, 100);
            this.pbRock1_2.TabIndex = 19;
            this.pbRock1_2.TabStop = false;
            this.pbRock1_2.Visible = false;
            // 
            // pbRock2_2
            // 
            this.pbRock2_2.Image = ((System.Drawing.Image)(resources.GetObject("pbRock2_2.Image")));
            this.pbRock2_2.Location = new System.Drawing.Point(572, 175);
            this.pbRock2_2.Name = "pbRock2_2";
            this.pbRock2_2.Size = new System.Drawing.Size(100, 100);
            this.pbRock2_2.TabIndex = 20;
            this.pbRock2_2.TabStop = false;
            this.pbRock2_2.Visible = false;
            // 
            // RPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1127, 566);
            this.Controls.Add(this.pbRock2_2);
            this.Controls.Add(this.pbRock1_2);
            this.Controls.Add(this.pbRock1_1);
            this.Controls.Add(this.pbScissors2_1);
            this.Controls.Add(this.pbScissors1_1);
            this.Controls.Add(this.pbPaper2_1);
            this.Controls.Add(this.pbPaper1_1);
            this.Controls.Add(this.pbRock2_1);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.lblP2score);
            this.Controls.Add(this.lblP1score);
            this.Controls.Add(this.lblP2scoreShow);
            this.Controls.Add(this.lblP1scoreShow);
            this.Controls.Add(this.btnLock2);
            this.Controls.Add(this.btnLock1);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.gbPlayer2);
            this.Controls.Add(this.gbPlayer1);
            this.Name = "RPS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPS";
            this.Load += new System.EventHandler(this.RPS_Load);
            this.gbPlayer1.ResumeLayout(false);
            this.gbPlayer1.PerformLayout();
            this.gbPlayer2.ResumeLayout(false);
            this.gbPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScissors1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScissors2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock2_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnRock1;
        private System.Windows.Forms.RadioButton rbtnPaper1;
        private System.Windows.Forms.RadioButton rbtnSci1;
        private System.Windows.Forms.GroupBox gbPlayer1;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.RadioButton rbtnRock2;
        private System.Windows.Forms.RadioButton rbtnSci2;
        private System.Windows.Forms.RadioButton rbtnPaper2;
        private System.Windows.Forms.GroupBox gbPlayer2;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnLock1;
        private System.Windows.Forms.Button btnLock2;
        private System.Windows.Forms.Label lblP1scoreShow;
        private System.Windows.Forms.Label lblP2scoreShow;
        private System.Windows.Forms.Label lblP1score;
        private System.Windows.Forms.Label lblP2score;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.PictureBox pbRock1_1;
        private System.Windows.Forms.PictureBox pbPaper1_1;
        private System.Windows.Forms.PictureBox pbScissors1_1;
        private System.Windows.Forms.PictureBox pbPaper2_1;
        private System.Windows.Forms.PictureBox pbScissors2_1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbRock2_1;
        private System.Windows.Forms.PictureBox pbRock1_2;
        private System.Windows.Forms.PictureBox pbRock2_2;
    }
}