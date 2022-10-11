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
    public partial class franking : Form
    {
        string chedo = "de";
        string chude = "v";
        public franking()
        {
            InitializeComponent();
            ranking();
        }
                    
        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void cbutton5_Click_1(object sender, EventArgs e)
        {

        }

        private void cbutton10_Click(object sender, EventArgs e)
        {
            cbutton7.ForeColor = Color.White;
            cbutton8.ForeColor = Color.White;
            cbutton9.ForeColor = Color.White;
            cbutton10.ForeColor = Color.Yellow;
            chedo = "siucap";
            ranking();
        }

        private void cbutton9_Click(object sender, EventArgs e)
        {
            cbutton7.ForeColor = Color.White;
            cbutton8.ForeColor = Color.White;
            cbutton9.ForeColor = Color.Yellow;
            cbutton10.ForeColor = Color.White;
            chedo = "thuong";
            ranking();

        }

        private void cbutton8_Click(object sender, EventArgs e)
        {
            cbutton7.ForeColor = Color.White;
            cbutton8.ForeColor = Color.Yellow;
            cbutton9.ForeColor = Color.White;
            cbutton10.ForeColor = Color.White;
            chedo = "kho";
            ranking();
        }

        private void cbutton7_Click(object sender, EventArgs e)
        {
            chedo = "de";
            cbutton7.ForeColor = Color.Yellow;
            cbutton8.ForeColor = Color.White;
            cbutton9.ForeColor = Color.White;
            cbutton10.ForeColor = Color.White;
            ranking();
        }

        public void ranking()
        {
            string rankurl = "./rank" + chude + chedo + ".txt";
            string[] Datade = System.IO.File.ReadAllLines(rankurl);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("score", typeof(double));
            for (int i = 0; i < Datade.Length; i++)
            {
                string[] a = Datade[i].Split(' ');
                dt.Rows.Add(a[0], Convert.ToDouble(a[1]));
            }
            dt.DefaultView.Sort = "score DESC";
            dt = dt.DefaultView.ToTable();
            cbutton1.Text = dt.Rows[0]["ID"] + "  " + dt.Rows[0]["score"].ToString();
            cbutton2.Text = dt.Rows[1]["ID"] + "  " + dt.Rows[1]["score"].ToString();
            cbutton3.Text = dt.Rows[2]["ID"] + "  " + dt.Rows[2]["score"].ToString();
            cbutton4.Text = dt.Rows[3]["ID"] + "  " + dt.Rows[3]["score"].ToString();
            cbutton5.Text = dt.Rows[4]["ID"] + "  " + dt.Rows[4]["score"].ToString();
        }

        private void cbutton14_Click(object sender, EventArgs e)
        {
            chude = "v";
            cbutton14.ForeColor = Color.Yellow;
            cbutton12.ForeColor = Color.White;
            cbutton13.ForeColor = Color.White;
            cbutton11.ForeColor = Color.White;
            ranking();
        }

        private void cbutton12_Click(object sender, EventArgs e)
        {
            chude = "p";
            cbutton14.ForeColor = Color.White;
            cbutton12.ForeColor = Color.Yellow;
            cbutton13.ForeColor = Color.White;
            cbutton11.ForeColor = Color.White;
            ranking();
        }

        private void cbutton13_Click(object sender, EventArgs e)
        {
            chude = "f";
            cbutton14.ForeColor = Color.White;
            cbutton12.ForeColor = Color.White;
            cbutton13.ForeColor = Color.Yellow;
            cbutton11.ForeColor = Color.White;
            ranking();
        }

        private void cbutton11_Click(object sender, EventArgs e)
        {
            chude = "a";
            cbutton14.ForeColor = Color.White;
            cbutton12.ForeColor = Color.White;
            cbutton13.ForeColor = Color.White;
            cbutton11.ForeColor = Color.Yellow;
            ranking();
        }
    }
}
