using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1_cshap
{
    public partial class enablewificonnect : Form
    {
        public enablewificonnect()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (Char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToInt32(Keys.Back) || (e.KeyChar == '.'))
            { }
            else
            {
                e.Handled = true; // 처리되었다실행하지말아라. 
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBox1.Checked == true){
                textBox1.Enabled = true;
                label3.Enabled = true;
            }
            else if (checkBox1.Checked == false){
                textBox1.Text = null;
                textBox1.Enabled = false;
                label3.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true && radioButton1.Checked == false)
            {
                if (checkBox1.Checked == true && textBox1.Text == "") {
                    MessageBox.Show("개별포트를 사용함에 체크하신뒤 포트번호를 입력하지 않으셨습니다\n포트를 지정해주세요","포트를 지정하세요",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                if (checkBox1.Checked == true && textBox1.Text != "") {
                    string run1 = textBox1.Text + ":" + textBox2.Text;
                    Process.Start("cmd.exe", "/E:OFF /F:OFF /C adb\\adb.exe connect " + run1);
                }
                if (checkBox1.Checked == false && textBox1.Text == "")
                {
                    string run2 = textBox1.Text + ":5555";
                    Process.Start("cmd.exe", "/E:OFF /F:OFF /C adb\\adb.exe connect " + run2);
                }
            }
            if (radioButton1.Checked == true && radioButton2.Checked == false)
            {   if (checkBox1.Checked == true && textBox1.Text == "") {
                    MessageBox.Show("개별포트를 사용함에 체크하신뒤 포트번호를 입력하지 않으셨습니다\n포트를 지정해주세요","포트를 지정하세요",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            if (checkBox1.Checked == true && textBox1.Text != "")
            {

                System.Diagnostics.Process process1 = new System.Diagnostics.Process();

                System.Diagnostics.ProcessStartInfo startInfo1 = new System.Diagnostics.ProcessStartInfo();

                startInfo1.FileName = @"cmd.exe";
                string cudir = System.Environment.CurrentDirectory;
                startInfo1.WorkingDirectory = @cudir;



                startInfo1.UseShellExecute = false;

                startInfo1.RedirectStandardInput = true;
                startInfo1.RedirectStandardOutput = true;

                startInfo1.RedirectStandardError = true;



                process1.EnableRaisingEvents = false;

                process1.StartInfo = startInfo1;

                process1.Start();
                string adb = @"adb\\adb.exe";
                string command1 = adb + " connect " + textBox2.Text + ":" + textBox1.Text;
                process1.StandardInput.Write(command1 + Environment.NewLine);

                process1.StandardInput.Close();
                string result = process1.StandardOutput.ReadToEnd();

                string error = process1.StandardError.ReadToEnd();

                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                //sb.Clear();

                sb.Append("[ Result Info ]\r\n");

                sb.Append(result);

                sb.Append("\r\n");


                sb.Append("[ Error Info ]\r\n");

                sb.Append(error);





                //this.richTextBox1.Text = sb.ToString();
                string mess = sb.ToString();
                MessageBox.Show(mess, "로그", MessageBoxButtons.OK);
                process1.WaitForExit();
                process1.Close();
                //MessageBox.Show(mess, "로그", MessageBoxButtons.OK);
            }
            if (checkBox1.Checked == false && textBox1.Text == "")
            {
                System.Diagnostics.Process process1 = new System.Diagnostics.Process();

                System.Diagnostics.ProcessStartInfo startInfo1 = new System.Diagnostics.ProcessStartInfo();

                startInfo1.FileName = @"cmd.exe";
                string cudir = System.Environment.CurrentDirectory;
                startInfo1.WorkingDirectory = @cudir;



                startInfo1.UseShellExecute = false;

                startInfo1.RedirectStandardInput = true;
                startInfo1.RedirectStandardOutput = true;

                startInfo1.RedirectStandardError = true;



                process1.EnableRaisingEvents = false;

                process1.StartInfo = startInfo1;

                process1.Start();
                string adb = @"adb\\adb.exe";
                string command1 = adb + " connect " + textBox2.Text + ":5555";
                process1.StandardInput.Write(command1 + Environment.NewLine);

                process1.StandardInput.Close();
                string result = process1.StandardOutput.ReadToEnd();

                string error = process1.StandardError.ReadToEnd();

                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                //sb.Clear();

                sb.Append("[ Result Info ]\r\n");

                sb.Append(result);

                sb.Append("\r\n");


                sb.Append("[ Error Info ]\r\n");

                sb.Append(error);





                //this.richTextBox1.Text = sb.ToString();
                string mess = sb.ToString();
                MessageBox.Show(mess, "로그", MessageBoxButtons.OK);
                process1.WaitForExit();
                process1.Close();
                //MessageBox.Show(mess, "로그", MessageBoxButtons.OK);
            }
            }
        }





        

    }
}
