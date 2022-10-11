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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bt1_gamemini
{
    public partial class fVoc : Form
    {
        ResourceManager rm = new ResourceManager("Bt1_gamemini.Properties.Resources",
            Assembly.GetExecutingAssembly());
        public fVoc()
        {
            InitializeComponent();
            var imageList = new ImageList();
            imageList.ImageSize = new Size(100, 100);
            listView1.View = View.LargeIcon;
            imageList.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.p1);
            imageList.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.p2);
            imageList.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.p3);
            imageList.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.p4);
            imageList.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.p5);
            imageList.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.p6);
            imageList.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.p7);
            imageList.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.p8);
            imageList.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.p9);
            imageList.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.p10);
            imageList.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.p11);
            imageList.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.p12);
            imageList.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.p13);
            imageList.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.p14);
            imageList.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.p15);
            imageList.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.p16);
            imageList.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.p17);
            imageList.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.p18);
            imageList.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.p19);
            imageList.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.p20);
            listView1.LargeImageList = imageList;
            string[] ans;
            ans = File.ReadAllLines("./foodVO.txt");
            for (int i =0; i<20;i++)
                this.listView1.Items.Add(ans[i],i);

            //2
            var imageList2 = new ImageList();
            imageList2.ImageSize = new Size(100, 100);
            listView2.View = View.LargeIcon;
            imageList2.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.v1);
            imageList2.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.v2);
            imageList2.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.v3);
            imageList2.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.v4);
            imageList2.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.v5);
            imageList2.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.v6);
            imageList2.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.v7);
            imageList2.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.v8);
            imageList2.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.v9);
            imageList2.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.v10);
            imageList2.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.v11);
            imageList2.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.v12);
            imageList2.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.v13);
            imageList2.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.v14);
            imageList2.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.v15);
            imageList2.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.v16);
            imageList2.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.v17);
            imageList2.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.v18);
            imageList2.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.v19);
            imageList2.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.v20);
            listView2.LargeImageList = imageList2;
            string[] ans2;
            ans2 = File.ReadAllLines("./VegetablesVO.txt");
            for (int i = 0; i < 20; i++)
                this.listView2.Items.Add(ans2[i], i);
            //3
            var imageList3 = new ImageList();
            imageList3.ImageSize = new Size(100,100);
            listView3.View = View.LargeIcon;
            imageList3.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.a1);
            imageList3.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.a2);
            imageList3.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.a3);
            imageList3.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.a4);
            imageList3.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.a5);
            imageList3.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.a6);
            imageList3.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.a7);
            imageList3.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.a8);
            imageList3.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.a9);
            imageList3.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.a10);
            imageList3.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.a11);
            imageList3.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.a12);
            imageList3.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.a13);
            imageList3.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.a14);
            imageList3.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.a15);
            imageList3.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.a16);
            imageList3.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.a17);
            imageList3.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.a18);
            imageList3.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.a19);
            imageList3.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.a20);
            listView3.LargeImageList = imageList3;
            string[] ans3;
            ans3 = File.ReadAllLines("./animakVO.txt");
            for (int i = 0; i < 20; i++)
                this.listView3.Items.Add(ans3[i], i);
            //4
            var imageList4 = new ImageList();
            imageList4.ImageSize = new Size(100, 100);
            listView4.View = View.LargeIcon;
            imageList4.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.f1);
            imageList4.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.f2);
            imageList4.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.f3);
            imageList4.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.f4);
            imageList4.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.f5);
            imageList4.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.f6);
            imageList4.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.f7);
            imageList4.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.f8);
            imageList4.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.f9);
            imageList4.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.f10);
            imageList4.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.f11);
            imageList4.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.f12);
            imageList4.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.f13);
            imageList4.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.f14);
            imageList4.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.f15);
            imageList4.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.f16);
            imageList4.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.f17);
            imageList4.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.f18);
            imageList4.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.f19);
            imageList4.Images.Add("itemImageKey", Bt1_gamemini.Properties.Resources.f20);
            listView4.LargeImageList = imageList4;
            string[] ans4;
            ans4 = File.ReadAllLines("./fruitVO.txt");
            for (int i = 0; i < 20; i++)
                this.listView4.Items.Add(ans4[i], i);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("En", typeof(string));
            dt.Columns.Add("Vn", typeof(string));



            dt.Rows.Add("1", "Apple", "Quá Táo");
            dt.Rows.Add("2", "", "");
            dt.Rows.Add("3", "", "");
            dt.Rows.Add("4", "", "");
            dt.Rows.Add("5", "", "");
            dt.Rows.Add("6", "", "");
            dt.Rows.Add("7", "", "");
            dt.Rows.Add("8", "", "");
            dt.Rows.Add("9", "", "");
            dt.Rows.Add("10", "", "");



            //dataGridView1.DataSource = dt;

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
