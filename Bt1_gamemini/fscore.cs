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
    public partial class fscore : Form
    {
        string c, d,ten;
        public fscore(string a ,string b,double diem,string name)
        {
            InitializeComponent();

            label2.Text = Math.Round(diem,1).ToString();
            ten = name;
            c = a;
            d = b;
        }

        private void cbutton9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát trò chơi hay không ?", "Thông báo !", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void cbutton2_Click(object sender, EventArgs e)
        {
            franking f2 = new franking();
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }

        private void cbutton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new fTopic();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void cbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new fplay(c, d,ten);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
