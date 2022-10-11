
namespace Bt1_gamemini
{
    partial class fplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fplay));
            this.tbans = new System.Windows.Forms.TextBox();
            this.pbshow = new System.Windows.Forms.PictureBox();
            this.lPoint = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lcRight = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.circButton1 = new Bt1_gamemini.CircButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pbsoundon = new System.Windows.Forms.PictureBox();
            this.pbsoundoff = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ltime = new System.Windows.Forms.Label();
            this.lans = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbutton9 = new Bt1_gamemini.cbutton();
            this.cbutton2 = new Bt1_gamemini.cbutton();
            this.cbutton1 = new Bt1_gamemini.cbutton();
            this.cbutton3 = new Bt1_gamemini.cbutton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.wmpwrong = new AxWMPLib.AxWindowsMediaPlayer();
            this.wmpRightsound = new AxWMPLib.AxWindowsMediaPlayer();
            this.wmpsound = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pbshow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsoundon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsoundoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpwrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpRightsound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpsound)).BeginInit();
            this.SuspendLayout();
            // 
            // tbans
            // 
            this.tbans.AcceptsTab = true;
            this.tbans.BackColor = System.Drawing.Color.Honeydew;
            this.tbans.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbans.Location = new System.Drawing.Point(602, 183);
            this.tbans.Multiline = true;
            this.tbans.Name = "tbans";
            this.tbans.Size = new System.Drawing.Size(141, 28);
            this.tbans.TabIndex = 1;
            this.tbans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbshow
            // 
            this.pbshow.BackColor = System.Drawing.Color.Transparent;
            this.pbshow.Location = new System.Drawing.Point(259, 84);
            this.pbshow.Name = "pbshow";
            this.pbshow.Size = new System.Drawing.Size(260, 262);
            this.pbshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbshow.TabIndex = 0;
            this.pbshow.TabStop = false;
            // 
            // lPoint
            // 
            this.lPoint.AutoSize = true;
            this.lPoint.BackColor = System.Drawing.Color.Transparent;
            this.lPoint.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPoint.Location = new System.Drawing.Point(865, 155);
            this.lPoint.Name = "lPoint";
            this.lPoint.Size = new System.Drawing.Size(85, 22);
            this.lPoint.TabIndex = 8;
            this.lPoint.Text = "Điểm số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(890, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(884, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "0 / ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lcRight
            // 
            this.lcRight.AutoSize = true;
            this.lcRight.BackColor = System.Drawing.Color.Transparent;
            this.lcRight.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcRight.Location = new System.Drawing.Point(844, 214);
            this.lcRight.Name = "lcRight";
            this.lcRight.Size = new System.Drawing.Size(127, 22);
            this.lcRight.TabIndex = 10;
            this.lcRight.Text = "Số câu đúng";
            // 
            // circButton1
            // 
            this.circButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circButton1.FlatAppearance.BorderSize = 0;
            this.circButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circButton1.Image = global::Bt1_gamemini.Properties.Resources.accept;
            this.circButton1.Location = new System.Drawing.Point(640, 225);
            this.circButton1.Name = "circButton1";
            this.circButton1.Size = new System.Drawing.Size(63, 63);
            this.circButton1.TabIndex = 14;
            this.circButton1.UseVisualStyleBackColor = true;
            this.circButton1.Click += new System.EventHandler(this.circButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Bt1_gamemini.Properties.Resources.heartpic;
            this.pictureBox4.Location = new System.Drawing.Point(598, 51);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Padding = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Bt1_gamemini.Properties.Resources.heartpic;
            this.pictureBox1.Location = new System.Drawing.Point(775, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Bt1_gamemini.Properties.Resources.heartpic;
            this.pictureBox2.Location = new System.Drawing.Point(716, 51);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Bt1_gamemini.Properties.Resources.heartpic;
            this.pictureBox3.Location = new System.Drawing.Point(657, 51);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Bt1_gamemini.Properties.Resources.heartpic;
            this.pictureBox5.Location = new System.Drawing.Point(539, 51);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Padding = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pbsoundon
            // 
            this.pbsoundon.BackColor = System.Drawing.Color.Transparent;
            this.pbsoundon.Image = global::Bt1_gamemini.Properties.Resources.sound;
            this.pbsoundon.Location = new System.Drawing.Point(197, 319);
            this.pbsoundon.Name = "pbsoundon";
            this.pbsoundon.Size = new System.Drawing.Size(40, 40);
            this.pbsoundon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsoundon.TabIndex = 26;
            this.pbsoundon.TabStop = false;
            this.pbsoundon.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pbsoundoff
            // 
            this.pbsoundoff.BackColor = System.Drawing.Color.Transparent;
            this.pbsoundoff.Image = global::Bt1_gamemini.Properties.Resources.no_sound;
            this.pbsoundoff.Location = new System.Drawing.Point(197, 319);
            this.pbsoundoff.Name = "pbsoundoff";
            this.pbsoundoff.Size = new System.Drawing.Size(40, 40);
            this.pbsoundoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsoundoff.TabIndex = 27;
            this.pbsoundoff.TabStop = false;
            this.pbsoundoff.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(614, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Điểm số :";
            // 
            // ltime
            // 
            this.ltime.AutoSize = true;
            this.ltime.BackColor = System.Drawing.Color.Transparent;
            this.ltime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltime.ForeColor = System.Drawing.Color.Purple;
            this.ltime.Location = new System.Drawing.Point(712, 141);
            this.ltime.Name = "ltime";
            this.ltime.Size = new System.Drawing.Size(21, 22);
            this.ltime.TabIndex = 31;
            this.ltime.Text = "0";
            this.ltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lans
            // 
            this.lans.BackColor = System.Drawing.Color.Transparent;
            this.lans.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lans.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lans.Location = new System.Drawing.Point(294, 55);
            this.lans.Name = "lans";
            this.lans.Size = new System.Drawing.Size(198, 38);
            this.lans.TabIndex = 32;
            this.lans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 38);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nhấn START để chơi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbutton9
            // 
            this.cbutton9.BackColor = System.Drawing.Color.SandyBrown;
            this.cbutton9.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.cbutton9.BorderColor = System.Drawing.Color.White;
            this.cbutton9.BorderRadius = 27;
            this.cbutton9.BorderSize = 0;
            this.cbutton9.FlatAppearance.BorderSize = 0;
            this.cbutton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbutton9.Font = new System.Drawing.Font("Space Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbutton9.ForeColor = System.Drawing.Color.White;
            this.cbutton9.Image = global::Bt1_gamemini.Properties.Resources.back;
            this.cbutton9.Location = new System.Drawing.Point(32, 201);
            this.cbutton9.Name = "cbutton9";
            this.cbutton9.Size = new System.Drawing.Size(53, 53);
            this.cbutton9.TabIndex = 46;
            this.cbutton9.TextColor = System.Drawing.Color.White;
            this.cbutton9.UseVisualStyleBackColor = false;
            this.cbutton9.Click += new System.EventHandler(this.cbutton9_Click);
            // 
            // cbutton2
            // 
            this.cbutton2.BackColor = System.Drawing.Color.Violet;
            this.cbutton2.BackgroundColor = System.Drawing.Color.Violet;
            this.cbutton2.BorderColor = System.Drawing.Color.Transparent;
            this.cbutton2.BorderRadius = 10;
            this.cbutton2.BorderSize = 2;
            this.cbutton2.FlatAppearance.BorderSize = 0;
            this.cbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbutton2.Font = new System.Drawing.Font("Space Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbutton2.ForeColor = System.Drawing.Color.White;
            this.cbutton2.Image = global::Bt1_gamemini.Properties.Resources.e4;
            this.cbutton2.Location = new System.Drawing.Point(1095, 3);
            this.cbutton2.Name = "cbutton2";
            this.cbutton2.Size = new System.Drawing.Size(59, 58);
            this.cbutton2.TabIndex = 48;
            this.cbutton2.TextColor = System.Drawing.Color.White;
            this.cbutton2.UseVisualStyleBackColor = false;
            this.cbutton2.Click += new System.EventHandler(this.cbutton2_Click);
            // 
            // cbutton1
            // 
            this.cbutton1.BackColor = System.Drawing.Color.SandyBrown;
            this.cbutton1.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.cbutton1.BorderColor = System.Drawing.Color.White;
            this.cbutton1.BorderRadius = 10;
            this.cbutton1.BorderSize = 0;
            this.cbutton1.FlatAppearance.BorderSize = 0;
            this.cbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbutton1.Font = new System.Drawing.Font("Space Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbutton1.ForeColor = System.Drawing.Color.White;
            this.cbutton1.Image = global::Bt1_gamemini.Properties.Resources.house2;
            this.cbutton1.Location = new System.Drawing.Point(1037, 234);
            this.cbutton1.Name = "cbutton1";
            this.cbutton1.Size = new System.Drawing.Size(50, 54);
            this.cbutton1.TabIndex = 47;
            this.cbutton1.TextColor = System.Drawing.Color.White;
            this.cbutton1.UseVisualStyleBackColor = false;
            this.cbutton1.Click += new System.EventHandler(this.cbutton1_Click);
            // 
            // cbutton3
            // 
            this.cbutton3.BackColor = System.Drawing.Color.Turquoise;
            this.cbutton3.BackgroundColor = System.Drawing.Color.Turquoise;
            this.cbutton3.BorderColor = System.Drawing.Color.Transparent;
            this.cbutton3.BorderRadius = 30;
            this.cbutton3.BorderSize = 2;
            this.cbutton3.FlatAppearance.BorderSize = 0;
            this.cbutton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbutton3.Font = new System.Drawing.Font("Space Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbutton3.ForeColor = System.Drawing.Color.White;
            this.cbutton3.Image = global::Bt1_gamemini.Properties.Resources.start__1_;
            this.cbutton3.Location = new System.Drawing.Point(321, 194);
            this.cbutton3.Name = "cbutton3";
            this.cbutton3.Size = new System.Drawing.Size(130, 60);
            this.cbutton3.TabIndex = 51;
            this.cbutton3.TextColor = System.Drawing.Color.White;
            this.cbutton3.UseVisualStyleBackColor = false;
            this.cbutton3.Click += new System.EventHandler(this.cbutton3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 52;
            this.label5.Text = "Câu :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(209, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 22);
            this.label6.TabIndex = 53;
            this.label6.Text = "0";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // wmpwrong
            // 
            this.wmpwrong.Enabled = true;
            this.wmpwrong.Location = new System.Drawing.Point(143, 455);
            this.wmpwrong.Name = "wmpwrong";
            this.wmpwrong.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpwrong.OcxState")));
            this.wmpwrong.Size = new System.Drawing.Size(13, 10);
            this.wmpwrong.TabIndex = 34;
            this.wmpwrong.Visible = false;
            // 
            // wmpRightsound
            // 
            this.wmpRightsound.Enabled = true;
            this.wmpRightsound.Location = new System.Drawing.Point(545, 471);
            this.wmpRightsound.Name = "wmpRightsound";
            this.wmpRightsound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpRightsound.OcxState")));
            this.wmpRightsound.Size = new System.Drawing.Size(17, 10);
            this.wmpRightsound.TabIndex = 29;
            this.wmpRightsound.Visible = false;
            // 
            // wmpsound
            // 
            this.wmpsound.Enabled = true;
            this.wmpsound.Location = new System.Drawing.Point(202, 471);
            this.wmpsound.Name = "wmpsound";
            this.wmpsound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpsound.OcxState")));
            this.wmpsound.Size = new System.Drawing.Size(16, 10);
            this.wmpsound.TabIndex = 28;
            this.wmpsound.Visible = false;
            // 
            // fplay
            // 
            this.AcceptButton = this.circButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bt1_gamemini.Properties.Resources.bglast;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1160, 589);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbutton3);
            this.Controls.Add(this.cbutton2);
            this.Controls.Add(this.cbutton1);
            this.Controls.Add(this.cbutton9);
            this.Controls.Add(this.wmpwrong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lans);
            this.Controls.Add(this.ltime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wmpRightsound);
            this.Controls.Add(this.wmpsound);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.circButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lcRight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lPoint);
            this.Controls.Add(this.tbans);
            this.Controls.Add(this.pbshow);
            this.Controls.Add(this.pbsoundon);
            this.Controls.Add(this.pbsoundoff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.fplay_Load);
            this.Enter += new System.EventHandler(this.fplay_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pbshow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsoundon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsoundoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpwrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpRightsound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpsound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbshow;
        private System.Windows.Forms.TextBox tbans;
        private System.Windows.Forms.Label lPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lcRight;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CircButton circButton1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pbsoundon;
        private System.Windows.Forms.PictureBox pbsoundoff;
        private AxWMPLib.AxWindowsMediaPlayer wmpsound;
        private AxWMPLib.AxWindowsMediaPlayer wmpRightsound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ltime;
        private System.Windows.Forms.Label lans;
        private System.Windows.Forms.Label label4;
        private AxWMPLib.AxWindowsMediaPlayer wmpwrong;
        private cbutton cbutton9;
        private cbutton cbutton2;
        private cbutton cbutton1;
        private cbutton cbutton3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}