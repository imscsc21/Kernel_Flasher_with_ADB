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
    public partial class infocomputer : Form
    {
        public infocomputer()
        {
            InitializeComponent();
        }
        public enum OSVersion
        { 
            None,
            Windows95,
            Windows98,
            WindowsMe,
            WindowsNT,
            Windows2000,
            WindowsXP,
            WindowsServer2003,
            WindowsVista,
            Windows7,
            Windows8
        }
        

        private void infocomputer_Load(object sender, EventArgs e)
        {
            if( System.Environment.Is64BitOperatingSystem == true ){
                label1.Text = "운영체제 타입: 64비트(X64)운영체제";}
            else if( System.Environment.Is64BitOperatingSystem == false ){
                label1.Text = "운영체제 타입: 32비트(X86)운영체제";
            }

            label2.Text = "빌드번호: " + System.Environment.Version.Build.ToString();
            label3.Text = "OS버전: " + System.Environment.OSVersion.VersionString.ToString();
            label4.Text = "서비스팩: " + System.Environment.OSVersion.ServicePack.ToString();
            label5.Text = "PC이름: " + System.Environment.MachineName.ToString();
            label6.Text = "시스템 디렉토리: " + System.Environment.SystemDirectory.ToString();
        }

    }
}
