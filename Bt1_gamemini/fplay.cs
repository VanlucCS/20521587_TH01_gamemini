using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bt1_gamemini
{
    public partial class fplay : Form
    {
        int heso = 0;
        double Point = 0;
        int Count = 0;
        int idx = 1;
        string topic;
        string kho;
        int socau = 0;
        string[] ans;
        int num_vo = 24;
        int anstime = 5;
        string ten = "Đoán xem";
        DateTime dt;
        TimeSpan ts;
        Random rnd = new Random();
        ResourceManager rm = new ResourceManager("Bt1_gamemini.Properties.Resources",
            Assembly.GetExecutingAssembly());
        int[] values = Enumerable.Repeat(1, 21).ToArray();
        public fplay(string tp, string dokho, string name)
        {
            InitializeComponent();
            circButton1.Visible = false;

            ten = name;
            kho = dokho;
            topic = tp;
            if (dokho == "de")
            {
                anstime = 20;
                num_vo = 15;
                heso = 1;
            }
            if (dokho == "thuong")
            {
                anstime = 10;
                num_vo = 20;
                heso = 4;
            }
            if (dokho == "kho")
            {
                anstime = 5;
                num_vo = 20;
                heso = 6;
            }
            if (dokho == "siucap")
            {
                anstime = 2;
                num_vo = 20;
                heso = 200;
            }
            //pbshow.Image = global::Bt1_gamemini.Resource1.;
            dt = DateTime.Now;
            string gamepath = "v";
            if (tp == "v")
                gamepath = "./VegetablesVO.txt";
            if (tp == "p")
                gamepath = "./foodVO.txt";
            if (tp == "f")
                gamepath = "./fruitVO.txt";
            if (tp == "a")
                gamepath = "./animakVO.txt";
            ans = File.ReadAllLines(gamepath);
            wmpsound.URL = "./soundgame.mp3";
            wmpRightsound.URL = "./right.mp3";
            wmpwrong.URL = "./wrong.mp3";
            wmpwrong.Ctlcontrols.stop();
            wmpRightsound.Ctlcontrols.stop();
            wmpsound.Ctlcontrols.stop();

            ltime.Visible = false;
            pbshow.Visible = false;
            timer1.Enabled = false;
            lans.Visible = false;
            label3.Text = Count.ToString() + " / " + num_vo.ToString();
        }
        private void fplay_Load(object sender, EventArgs e)
        {

        }
        public void getansw(string s, int idx)
        {
            this.circButton1.Enabled = false;
            socau++;
            if (s == ans[idx - 1])
            {
                double temppoint = Math.Round((anstime - (DateTime.Now - dt).TotalSeconds) * heso, 1);
                Point += temppoint < 0 ? 0 : temppoint;
                Count++;
                wmpRightsound.Ctlcontrols.play();
            }
            else
            {
                wmpwrong.Ctlcontrols.play();
            }
            if (socau - 1 == num_vo)
            {
                wmpsound.Ctlcontrols.stop();
                timer1.Enabled = false;
                this.Hide();
                var form2 = new fscore(topic, kho, Point, ten);
                form2.Closed += (d, arg) => this.Close();
                form2.Show();
                string line = ten + " " + Point.ToString();
                string[] lines =
                {
                    line
                };
                string saveurl = "./rank" + topic + kho + ".txt";
                File.AppendAllLines(saveurl, lines);

                return;
            }
            label2.Text = Point.ToString();
            label3.Text = Count.ToString() + " / " + num_vo.ToString();
            lans.Text = ans[idx - 1];
            Application.DoEvents();
            Thread.Sleep(1000);
            lans.Text = "";
            label6.Text = socau.ToString();

            timer1.Start();
        }
        private void circButton1_Click(object sender, EventArgs e)
        {
            getansw(tbans.Text, idx);

            dt = DateTime.Now;
            if (socau - 1 == num_vo)
                return;
            tbans.Text = "";
            tbans.Select();
            do
            {
                idx = rnd.Next(1, num_vo + 1);
            } while (values[idx] != 1);
            values[idx] = 0;
            string id = topic + idx.ToString();
            this.circButton1.Enabled = true;
            this.AcceptButton = circButton1;

            this.pbshow.Image = (Image)rm.GetObject(id);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ts = DateTime.Now - dt;
            if (ts.TotalSeconds > anstime * 1 / 5)
                pictureBox1.Visible = false;
            if (ts.TotalSeconds > anstime * 2 / 5)
                pictureBox2.Visible = false;
            if (ts.TotalSeconds > anstime * 3 / 5)
                pictureBox3.Visible = false;
            if (ts.TotalSeconds > anstime * 4 / 5)
                pictureBox4.Visible = false;
            if (ts.TotalSeconds > anstime)
                pictureBox5.Visible = false;
            if (ts.TotalSeconds > anstime)
            {
                timer1.Stop();
                circButton1_Click(null, null);
            }
            ltime.Text = Math.Round((anstime - Math.Round(ts.TotalSeconds, 1)), 1).ToString();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pbsoundon.Visible = false;
            pbsoundoff.Visible = true;
            wmpsound.Ctlcontrols.play();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pbsoundon.Visible = true;
            pbsoundoff.Visible = false;
            wmpsound.Ctlcontrols.stop();
        }

        private void cbutton9_Click(object sender, EventArgs e)
        {
            wmpsound.Ctlcontrols.stop();
            timer1.Enabled = false;
            this.Hide();
            var form2 = new fTopic();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }


        private void cbutton1_Click(object sender, EventArgs e)
        {
            wmpsound.Ctlcontrols.stop();
            timer1.Enabled = false;
            this.Hide();
            var form3 = new fhome();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void cbutton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát trò chơi hay không ?", "Thông báo !", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void cbutton3_Click(object sender, EventArgs e)
        {
            circButton1.Visible = true;
            timer1.Enabled = true;
            label4.Visible = false;
            ltime.Visible = true;
            pbshow.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            wmpsound.Ctlcontrols.play();
            label6.Text = "1";

            tbans.Text = "";
            tbans.Select();
            do
            {
                idx = rnd.Next(1, num_vo + 1);

            } while (values[idx] != 1);
            values[idx] = 0;
            socau++;
            string id = topic + idx.ToString();
            this.pbshow.Image = (Image)rm.GetObject(id);
            lans.Visible = true;
            cbutton3.Visible = false;
            dt = DateTime.Now;
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fplay_Enter(object sender, EventArgs e)
        {
        }
    }
}
