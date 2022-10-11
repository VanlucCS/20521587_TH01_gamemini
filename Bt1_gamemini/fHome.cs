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

    public partial class fhome : Form
    {
        public fhome()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        }


       private void button6_Click(object sender, EventArgs e)
        {
            fVoc f2 = new fVoc();
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new fTopic();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void cbutton9_MouseHover(object sender, EventArgs e)
        {
            cbutton9.BorderColor = Color.Yellow;
            cbutton9.BackColor = Color.Violet;
        }

        private void cbutton9_MouseLeave(object sender, EventArgs e)
        {
            cbutton9.BorderColor = Color.White;
        }

        private void cbutton9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát trò chơi hay không ?", "Thông báo !", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void cbutton1_Click(object sender, EventArgs e)
        {
            fVoc f2 = new fVoc();
            this.Hide();
            f2.ShowDialog();
            this.Show();

        }

        private void cbutton2_Click(object sender, EventArgs e)
        {
            franking f2 = new franking();
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }

        private void fhome_Load(object sender, EventArgs e)
        {

        }

        private void cbutton14_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Bài Thực Hành 01 Game mimi học từ vựng tiếng anh theo chủ đề \n Sinh viên thực hiện : Trần Văn Lực \n MSSV: 20521587", "Thông tin phầm mềm !", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }
    }
}
