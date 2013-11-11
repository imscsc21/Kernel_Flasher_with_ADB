using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1_cshap
{
    public partial class choseflashinglocation : Form
    {
        Form1 frm1;
        public choseflashinglocation()
        {
            InitializeComponent();

        }
        public choseflashinglocation(Form1 _form)
        {
            InitializeComponent();
          //Form1 fr1 = (Form1)this.Owner;
          frm1 = _form;
        }

        public void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

           // Form1 fr1 = (Form1)this.Owner;
            if (listView1.FocusedItem.Text == "mmcblk0p1")
                
            {
                //MessageBox.Show("1번", "t", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 //WindowsFormsApplication1_cshap.Form1.indeviceflashlocate.text = "a";
                
                frm1.indeviceflashlocate.Text = "mmcblk0p1";    
                
            }

            if (listView1.FocusedItem.Text == "mmcblk0p2")
            {
                //MessageBox.Show("2번", "t", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm1.indeviceflashlocate.Text = "mmcblk0p2";
            }
            if (listView1.FocusedItem.Text == "mmcblk0p3")
            {
               // MessageBox.Show("3번", "t", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm1.indeviceflashlocate.Text = "mmcblk0p3";
            }

            if (listView1.FocusedItem.Text == "mmcblk0p4")
            {
                //MessageBox.Show("4번", "t", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm1.indeviceflashlocate.Text = "mmcblk0p4";
            }
            if (listView1.FocusedItem.Text == "mmcblk0p5")
            {
               
                frm1.indeviceflashlocate.Text = "mmcblk0p5";
                //MessageBox.Show("5번", "t", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (listView1.FocusedItem.Text == "mmcblk0p6")
            {
                frm1.indeviceflashlocate.Text = "mmcblk0p6";
                //MessageBox.Show("6번", "t", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (listView1.FocusedItem.Text == "mmcblk0p7")
            {
                frm1.indeviceflashlocate.Text = "mmcblk0p7";
                //MessageBox.Show("7번", "t", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (listView1.FocusedItem.Text == "mmcblk0p8")
            {
                frm1.indeviceflashlocate.Text = "mmcblk0p8";
                //MessageBox.Show("8번", "t", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (listView1.FocusedItem.Text == "mmcblk0p9")
            {
                frm1.indeviceflashlocate.Text = "mmcblk0p9";
                //MessageBox.Show("9번", "t", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (listView1.FocusedItem.Text == "mmcblk0p10")
            {
                frm1.indeviceflashlocate.Text = "mmcblk0p10";
               // MessageBox.Show("10번", "t", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (listView1.FocusedItem.Text == "mmcblk0p11")
            {
                frm1.indeviceflashlocate.Text = "mmcblk0p11";
                //MessageBox.Show("11번", "t", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (listView1.FocusedItem.Text == "mmcblk0p12")
            {
                frm1.indeviceflashlocate.Text = "mmcblk0p12";
               // MessageBox.Show("12번", "t", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (listView1.FocusedItem.Text == "mmcblk0p13")
            {
                frm1.indeviceflashlocate.Text = "mmcblk0p13";
                //MessageBox.Show("13번", "t", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (listView1.FocusedItem.Text == "mmcblk0p14")
            {
                frm1.indeviceflashlocate.Text = "mmcblk0p14";
                //MessageBox.Show("14번", "t", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void choseflashinglocation_Load(object sender, EventArgs e)
        {
            this.Text = "[GUI] 커널을 플래싱할 위치를 선택하십시오";
        }



    }
}
