using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bt1_gamemini
{
    public partial class fTopic : Form
    {
        string Gamemode = "de";
        string Game = "v";
        string name = "Đoánxem";
        public fTopic()
        {
            InitializeComponent();
        }
        private void cbutton9_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
                name = textBox1.Text.Replace(" ", string.Empty);
            this.Hide();
            var form2 = new fplay(Game,Gamemode,name);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

           
        private void cbutton2_Click(object sender, EventArgs e)
        {
            Game = "v";
            cbutton2.BorderColor = Color.Red;
            cbutton3.BorderColor = Color.White;
            cbutton4.BorderColor = Color.White;
            cbutton8.BorderColor = Color.White;
        }
        private void cbutton3_Click(object sender, EventArgs e)
        {
            Game = "p";

            cbutton2.BorderColor = Color.White;
            cbutton3.BorderColor = Color.Red;
            cbutton4.BorderColor = Color.White;
            cbutton8.BorderColor = Color.White;
        }

        private void cbutton4_Click(object sender, EventArgs e)
        {
            Game = "f";

            cbutton2.BorderColor = Color.White;
            cbutton3.BorderColor = Color.White;
            cbutton4.BorderColor = Color.Red;
            cbutton8.BorderColor = Color.White;
        }

        private void cbutton8_Click(object sender, EventArgs e)
        {
            Game = "a";

            cbutton2.BorderColor = Color.White;
            cbutton3.BorderColor = Color.White;
            cbutton4.BorderColor = Color.White;
            cbutton8.BorderColor = Color.Red;
        }
        private void cbutton5_Click(object sender, EventArgs e)
        {
            Gamemode = "de";
            cbutton5.BorderColor = Color.SpringGreen;
            cbutton1.BorderColor = Color.White;
            cbutton6.BorderColor = Color.White;
            cbutton7.BorderColor = Color.White;
        }

        private void cbutton1_Click(object sender, EventArgs e)
        {
            Gamemode = "thuong";
            cbutton5.BorderColor = Color.White;
            cbutton1.BorderColor = Color.SpringGreen;
            cbutton6.BorderColor = Color.White;
            cbutton7.BorderColor = Color.White;
        }

        private void cbutton6_Click(object sender, EventArgs e)
        {
            Gamemode = "kho";
            cbutton5.BorderColor = Color.White;
            cbutton1.BorderColor = Color.White;
            cbutton6.BorderColor = Color.SpringGreen;
            cbutton7.BorderColor = Color.White;
        }

        private void cbutton7_Click(object sender, EventArgs e)
        {
            Gamemode = "siucap";
            cbutton5.BorderColor = Color.White;
            cbutton1.BorderColor = Color.White;
            cbutton6.BorderColor = Color.White;
            cbutton7.BorderColor = Color.SpringGreen;
        }

        private void cbutton9_MouseHover(object sender, EventArgs e)
        {
            cbutton9.BorderColor = Color.SpringGreen;
        }

        private void cbutton9_MouseLeave(object sender, EventArgs e)
        {
            cbutton9.BorderColor = Color.White;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbutton10_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new fhome();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void cbutton11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát trò chơi hay không ?", "Thông báo !", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
