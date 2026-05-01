namespace WindowsFormsApp5
{
    partial class DTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DTT));
            this.pbLost = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.txtTick = new System.Windows.Forms.TextBox();
            this.btnTick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLost)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLost
            // 
            this.pbLost.BackColor = System.Drawing.Color.Transparent;
            this.pbLost.Image = ((System.Drawing.Image)(resources.GetObject("pbLost.Image")));
            this.pbLost.Location = new System.Drawing.Point(474, 240);
            this.pbLost.Name = "pbLost";
            this.pbLost.Size = new System.Drawing.Size(764, 755);
            this.pbLost.TabIndex = 0;
            this.pbLost.TabStop = false;
            this.pbLost.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TNT Destroyed:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Explosions:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.BackColor = System.Drawing.Color.Transparent;
            this.lblResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult1.ForeColor = System.Drawing.Color.White;
            this.lblResult1.Location = new System.Drawing.Point(624, 61);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(865, 79);
            this.lblResult1.TabIndex = 3;
            this.lblResult1.Text = "Click the TNT to destroy it";
            // 
            // x
            // 
            this.x.BackColor = System.Drawing.Color.Transparent;
            this.x.Cursor = System.Windows.Forms.Cursors.Cross;
            this.x.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.x.Image = ((System.Drawing.Image)(resources.GetObject("x.Image")));
            this.x.Location = new System.Drawing.Point(389, 59);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(81, 86);
            this.x.TabIndex = 4;
            this.x.Text = "           \r\n           \r\n           ";
            this.x.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.x.Click += new System.EventHandler(this.x_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 26);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "0";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(16, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(149, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 43);
            this.button2.TabIndex = 8;
            this.button2.Text = "Main menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTick
            // 
            this.txtTick.Location = new System.Drawing.Point(146, 116);
            this.txtTick.Name = "txtTick";
            this.txtTick.Size = new System.Drawing.Size(167, 26);
            this.txtTick.TabIndex = 9;
            this.txtTick.Text = "Seconds";
            this.txtTick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTick.Click += new System.EventHandler(this.txtTick_Click);
            // 
            // btnTick
            // 
            this.btnTick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTick.Location = new System.Drawing.Point(12, 111);
            this.btnTick.Name = "btnTick";
            this.btnTick.Size = new System.Drawing.Size(128, 37);
            this.btnTick.TabIndex = 10;
            this.btnTick.Text = "Set tick speed";
            this.btnTick.UseVisualStyleBackColor = true;
            this.btnTick.Click += new System.EventHandler(this.btnTick_Click);
            // 
            // DTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1202, 944);
            this.Controls.Add(this.btnTick);
            this.Controls.Add(this.txtTick);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.x);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLost);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DTT";
            this.Text = "DESTROY THE TNT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DTT_Load);
            this.Click += new System.EventHandler(this.DTT_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbLost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTick;
        private System.Windows.Forms.Button btnTick;
    }
}