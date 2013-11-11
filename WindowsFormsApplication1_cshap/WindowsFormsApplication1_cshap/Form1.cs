using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1_cshap
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "[GUI]  Android Kernel easy flasher with ADB";
            choseflashinglocation frm2 = new choseflashinglocation();
            frm2.Owner = this;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           if (radioButton1.Checked == true )
           {
                sendlocate.Text = "/sdcard/";
            }
           else if (radioButton1.Checked == false)
            {
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                sendlocate.Text = "/sdcard/external_sd/";
            }
            else if (radioButton2.Checked == false)
            {
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "플래싱할 파일을 선택하십시오";
            openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               string a = openFileDialog1.FileName;
                textBox1.Text = a;
            }
            
            //MessageBox.Show("test", "bar_test", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

       /* private void button2_Click(object sender, EventArgs e)
        {
        if (textBox1.Text == "")
        {
            MessageBox.Show("플래싱할 파일을 선택하세요!", "파일을 선택해주세요", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            if (System.IO.File.Exists("adb\\adb.exe"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();

                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();

                startInfo.FileName = @"cmd.exe";
                string cudir = System.Environment.CurrentDirectory;
                startInfo.WorkingDirectory = @cudir;



                startInfo.UseShellExecute = false;

                startInfo.RedirectStandardInput = true;

                startInfo.RedirectStandardOutput = true;

                startInfo.RedirectStandardError = true;



                process.EnableRaisingEvents = false;

                process.StartInfo = startInfo;

                process.Start();
                string name1 = startInfo.FileName;
                string name2 = textBox1.Text;
                string send_location= sendlocate.Text;
                string path = send_location;
                string set_adb = @"adb\adb.exe";
                string name3 = set_adb + " push " + name2 + " " + path + " " + send_location;
                string devices = set_adb + " devices > a.txt";
                string devices2 = set_adb + " devices > b.txt";
                process.StandardInput.Write( devices + Environment.NewLine);
               // process.StandardInput.Write(devices2 + Environment.NewLine);
                process.StandardInput.WriteLine(devices2 + Environment.NewLine);

                process.StandardInput.Close();



                string result = process.StandardOutput.ReadToEnd();

                string error = process.StandardError.ReadToEnd();

                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                sb.Append("[ Result Info ]\r\n");

                sb.Append(result);

                sb.Append("\r\n");

                sb.Append("[ Error Info ]\r\n");

                sb.Append(error);





                this.richTextBox1.Text = sb.ToString();



                process.WaitForExit();

                process.Close();
               /*string oriadb = "adb\\adb.exe";
                string tb1 = textBox1.Text;
                string tb2 = tb1 + textBox1.Text;
        Process.Start(@oriadb, "push "+ @tb2);

            }
            else
            {
                if (MessageBox.Show("실행파일의 폴터에 ADB파일이 없습니다\nadb의 경로를 지정하시겠습니까?", "ADB 실행 파일이 없습니다", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    if (openFileDialog2.ShowDialog() == DialogResult.OK)
                    {
                         //string oriadb = openFileDialog2.FileName;
                    }
                    string oriadb = openFileDialog2.FileName;
                    string tb1 = textBox1.Text;
        Process.Start(@oriadb, "push "+ @tb1);
                }
                else //(MessageBox.Show("실행파일의 폴터에 ADB파일이 없습니다\nadb의 경로를 지정하시겠습니까?", "ADB 실행 파일이 없습니다", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                {
                    MessageBox.Show("ADB가 프로그램 실행폴터에 없는 상태에서 ADB의 올바른 실행경로를 지정하지 않았으므로 제대로 실행될 수 없습니다\n따라서 커널플래싱을 취소합니다", "플래싱을 취소하셨습니다", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
          
        }
        }*/

        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 form = new AboutBox1();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                blocksizenumber.Enabled = true;
            }
            else
            { blocksizenumber.Enabled = false; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                countnumber.Enabled = true;
            }
            else
            { countnumber.Enabled = false; }
        }

        private void blocksizenumber_EnabledChanged(object sender, EventArgs e)
        {
            if (blocksizenumber.Enabled == true) { }
            else { blocksizenumber.Text = null; }
        }

        private void countnumber_EnabledChanged(object sender, EventArgs e)
        {
            if (countnumber.Enabled == true) { }
            else { countnumber.Text = null; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            choseflashinglocation cfl = new choseflashinglocation(this);
           // cfl.StartPosition = FormStartPosition.CenterScreen;//FormStartPosition.Manual;
            //cfl.StartPo
           // cfl.Location = new Point(50, 50);
            cfl.Show();
        }

        private void blocksizenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || // 숫자만 입력

     e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(Keys.M)))
            {

                e.Handled = true; // 이조건문으로 들어오는것은 키가 안먹게 하는부분

            }

        }

        private void countnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || // 숫자만 입력

     e.KeyChar == Convert.ToChar(Keys.Back)))
            {

                e.Handled = true; // 이조건문으로 들어오는것은 키가 안먹게 하는부분

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                //MessageBox.Show("success", "success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form1.ActiveForm.Width = Form1.ActiveForm.Width + 550;
            }
            else if (e.KeyCode == Keys.F6)
            { 
                Form1.ActiveForm.Width = Form1.ActiveForm.Width - 550;
            }
            else { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           string a = System.Environment.CurrentDirectory;
            string b = a + "\\";
           MessageBox.Show(b, "test", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("플래싱할 파일을 선택하세요!", "파일을 선택해주세요", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (System.IO.File.Exists("adb\\adb.exe"))
                {
                    string sentfilename = label9.Text;
                    string sendcommand1 = "adb\\adb.exe" + " push " + textBox1.Text + " " + sendlocate.Text;
                    string flashcommand1 = "adb\\adb.exe" + " shell su -c dd if=" + sendlocate.Text+ sentfilename +  " " + "of=/dev/block/" + indeviceflashlocate.Text;
                   
                   
                    if (checkBox1.Checked == false && checkBox2.Checked == false && blocksizenumber.Enabled == false && countnumber.Enabled == false)
                    {
                       // richTextBox1.Text = null;
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


                process1.StandardInput.Write( sendcommand1 + Environment.NewLine);
                System.Threading.Thread.Sleep(2000);
                process1.StandardInput.Write(flashcommand1 + Environment.NewLine);

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





                        this.richTextBox1.Text = sb.ToString();
                        process1.WaitForExit();
                        process1.Close();
                    }
                    if (checkBox1.Checked == true && checkBox2.Checked == false && blocksizenumber.Text != "" && blocksizenumber.Enabled == true)
                    {
                      //  richTextBox1.Text = null;
                        System.Diagnostics.Process process2 = new System.Diagnostics.Process();

                        System.Diagnostics.ProcessStartInfo startInfo2 = new System.Diagnostics.ProcessStartInfo();

                        startInfo2.FileName = @"cmd.exe";
                        string cudir = System.Environment.CurrentDirectory;
                        startInfo2.WorkingDirectory = @cudir;



                        startInfo2.UseShellExecute = false;

                        startInfo2.RedirectStandardInput = true;
                        startInfo2.RedirectStandardOutput = true;

                        startInfo2.RedirectStandardError = true;



                        process2.EnableRaisingEvents = false;

                        process2.StartInfo = startInfo2;

                        process2.Start();
                        string flashcommand2 = flashcommand1 + " bs=" + blocksizenumber.Text;
                        process2.StandardInput.Write( sendcommand1 + Environment.NewLine);
                System.Threading.Thread.Sleep(1000);
                process2.StandardInput.Write(flashcommand2 + Environment.NewLine);

                        process2.StandardInput.Close();
                        string result = process2.StandardOutput.ReadToEnd();

                        string error = process2.StandardError.ReadToEnd();

                        System.Text.StringBuilder sb = new System.Text.StringBuilder();

                        //sb.Clear();

                        sb.Append("[ Result Info ]\r\n");

                        sb.Append(result);

                        sb.Append("\r\n");


                        sb.Append("[ Error Info ]\r\n");

                        sb.Append(error);





                        this.richTextBox1.Text = sb.ToString();
                        process2.WaitForExit();

                        process2.Close();
                    }
                    if (checkBox1.Checked == false && checkBox2.Checked == true && blocksizenumber.Enabled == false && countnumber.Text != "" && countnumber.Enabled == true)
                    {
                        System.Diagnostics.Process process3 = new System.Diagnostics.Process();

                        System.Diagnostics.ProcessStartInfo startInfo3 = new System.Diagnostics.ProcessStartInfo();

                        startInfo3.FileName = @"cmd.exe";
                        string cudir = System.Environment.CurrentDirectory;
                        startInfo3.WorkingDirectory = @cudir;



                        startInfo3.UseShellExecute = false;

                        startInfo3.RedirectStandardInput = true;
                        startInfo3.RedirectStandardOutput = true;

                        startInfo3.RedirectStandardError = true;



                        process3.EnableRaisingEvents = false;

                        process3.StartInfo = startInfo3;

                        process3.Start();

                        string flashcommand3 = flashcommand1 + " count=" + countnumber.Text;
                        process3.StandardInput.Write( sendcommand1 + Environment.NewLine);
                System.Threading.Thread.Sleep(1000);
                process3.StandardInput.Write(flashcommand3 + Environment.NewLine);

                        process3.StandardInput.Close();
                        string result = process3.StandardOutput.ReadToEnd();

                        string error = process3.StandardError.ReadToEnd();

                        System.Text.StringBuilder sb = new System.Text.StringBuilder();

                        //sb.Clear();

                        sb.Append("[ Result Info ]\r\n");

                        sb.Append(result);

                        sb.Append("\r\n");


                        sb.Append("[ Error Info ]\r\n");

                        sb.Append(error);





                        this.richTextBox1.Text = sb.ToString();
                        process3.WaitForExit();

                        process3.Close();
                    }
                    if (checkBox1.Checked == true && checkBox2.Checked == true && blocksizenumber.Text != "" && countnumber.Text != "" && blocksizenumber.Enabled == true && countnumber.Enabled == true)
                    {
                        //richTextBox1.Text = null;
                        System.Diagnostics.Process process4 = new System.Diagnostics.Process();

                        System.Diagnostics.ProcessStartInfo startInfo4 = new System.Diagnostics.ProcessStartInfo();

                        startInfo4.FileName = @"cmd.exe";
                        string cudir4 = System.Environment.CurrentDirectory;
                        startInfo4.WorkingDirectory = @cudir4;



                        startInfo4.UseShellExecute = false;

                        startInfo4.RedirectStandardInput = true;
                        startInfo4.RedirectStandardOutput = true;

                        startInfo4.RedirectStandardError = true;



                        process4.EnableRaisingEvents = false;

                        process4.StartInfo = startInfo4;

                        process4.Start();

                        string flashcommand4 = flashcommand1 + " bs=" + blocksizenumber.Text + " count=" + countnumber.Text;
                        process4.StandardInput.Write( sendcommand1 + Environment.NewLine);
                System.Threading.Thread.Sleep(2000);
                process4.StandardInput.Write(flashcommand4 + Environment.NewLine);

                        process4.StandardInput.Close();
                         string result = process4.StandardOutput.ReadToEnd();

            string error = process4.StandardError.ReadToEnd();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            //sb.Clear();

            sb.Append("[ Result Info ]\r\n");

            sb.Append(result);

            sb.Append("\r\n");
            

            sb.Append("[ Error Info ]\r\n");

            sb.Append(error);





            this.richTextBox1.Text = sb.ToString();
        
                        process4.WaitForExit();

                        process4.Close();
                    }
                    
                     //string tb1 = textBox1.Text;
                    // string tb2 = tb1 + textBox1.Text;
                     /*System.Diagnostics.Process process = new System.Diagnostics.Process();

                     System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();

                     startInfo.FileName = @"cmd.exe";
                     string cudir = System.Environment.CurrentDirectory;
                     startInfo.WorkingDirectory = @cudir;



                     startInfo.UseShellExecute = false;

                     startInfo.RedirectStandardInput = true;
                     startInfo.RedirectStandardOutput = true;

                     startInfo.RedirectStandardError = true;



                     process.EnableRaisingEvents = false;

                     process.StartInfo = startInfo;

                     process.Start();

                   //  string name1 = startInfo.FileName;
                     //string name2 = textBox1.Text;
                     //string send_location = sendlocate.Text;
                    // string path = send_location;
                     string set_adb = @"adb\adb.exe";
                     //string name3 = set_adb + " push " + name2 + " " + path + " " + send_location;
                     string devices = set_adb + " devices > a.txt";
                     process.StandardInput.Write( devices + Environment.NewLine);

                     process.StandardInput.Close();
                     process.WaitForExit();

                     process.Close();
                     /*System.Diagnostics.ProcessStartInfo run = new System.Diagnostics.ProcessStartInfo();
                     string a = System.Environment.CurrentDirectory;
                     string b = a + "\\" + oriadb;
                     string c = " " + "devices " + ">" + " a.txt";
                     run.FileName = @"cmd.exe";

                     System.Diagnostics.Process.Start(run);*/

             //Process.Start(oriadb,"devices");*/

                }
                else
                {
                    if (MessageBox.Show("실행파일의 폴터에 ADB파일이 없습니다\nadb의 경로를 지정하시겠습니까?", "ADB 실행 파일이 없습니다", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        if (openFileDialog2.ShowDialog() == DialogResult.OK)
                        {
                            //string oriadb = openFileDialog2.FileName;
                        }
                        string oriadb = openFileDialog2.FileName;
                        string tb1 = textBox1.Text;
                        Process.Start(@oriadb, "push " + @tb1);
                    }
                    else //(MessageBox.Show("실행파일의 폴터에 ADB파일이 없습니다\nadb의 경로를 지정하시겠습니까?", "ADB 실행 파일이 없습니다", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                    {
                        MessageBox.Show("ADB가 프로그램 실행폴터에 없는 상태에서 ADB의 올바른 실행경로를 지정하지 않았으므로 제대로 실행될 수 없습니다\n따라서 커널플래싱을 취소합니다", "플래싱을 취소하셨습니다", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }

        private void uSB디버깅유무확인바람ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("기능이용시 루팅은 필수이며,\nUSB디버깅에 체크가 되어있으신지 확인해주세요", "USB디버깅 유무 확인바람", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            { //string sdcard = "/sdcard/";
                textBox2.Enabled = true;
            }
            else if (radioButton3.Checked == false)
            {
                textBox2.Text = null;
                textBox2.Enabled = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            { //string sdcard = "/sdcard/";
                textBox3.Enabled = true;
            }
            else if (radioButton5.Checked == false)
            {
                textBox3.Text = null;
                textBox3.Enabled = false;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (!(Char.IsLetter(e.KeyChar)) && !(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }*/
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            /*Regex emailregex = new Regex(@"[a-zA-Z0-9]");
            Boolean ismatch = emailregex.IsMatch(textBox2.Text);
            if (!ismatch)
            {
                MessageBox.Show("영문자또는 숫자만 입력해 주세요.","오류",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }*/



        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.button7.Visible = false;
            this.button10.Visible = true;
            this.Width = this.Width + 500;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.button7.Visible = true;
            this.button10.Visible = false;
            this.Width = this.Width - 500;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process processd = new System.Diagnostics.Process();

            System.Diagnostics.ProcessStartInfo startInfod = new System.Diagnostics.ProcessStartInfo();

            startInfod.FileName = @"cmd.exe";
            string cudir = System.Environment.CurrentDirectory;
            startInfod.WorkingDirectory = @cudir;



            startInfod.UseShellExecute = false;

            startInfod.RedirectStandardInput = true;
            startInfod.RedirectStandardOutput = true;

            startInfod.RedirectStandardError = true;



            processd.EnableRaisingEvents = false;

            processd.StartInfo = startInfod;

            processd.Start();

            //  string name1 = startInfo.FileName;
            //string name2 = textBox1.Text;
            //string send_location = sendlocate.Text;
            // string path = send_location;
            string set_adb3 = @"adb\adb.exe";
            //string name3 = set_adb + " push " + name2 + " " + path + " " + send_location;
            string devices3 = set_adb3 +" devices";
            processd.StandardInput.Write(devices3 + Environment.NewLine);

            processd.StandardInput.Close();
            string result = processd.StandardOutput.ReadToEnd();

            string error = processd.StandardError.ReadToEnd();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            //sb.Clear();

            sb.Append("[ Result Info ]\r\n");

            sb.Append(result);

            sb.Append("\r\n");
            

            sb.Append("[ Error Info ]\r\n");

            sb.Append(error);





            this.richTextBox1.Text = sb.ToString();
            processd.WaitForExit();

            processd.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("전송하려는 파일을 선택하십시오", "파일 선택 필수", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (radioButton3.Checked == true && textBox2.Text != "" && textBox2.Enabled == true)
                {
                    System.Diagnostics.Process processs = new System.Diagnostics.Process();

                    System.Diagnostics.ProcessStartInfo startInfos = new System.Diagnostics.ProcessStartInfo();

                    startInfos.FileName = @"cmd.exe";
                    string cudir = System.Environment.CurrentDirectory;
                    startInfos.WorkingDirectory = @cudir;



                    startInfos.UseShellExecute = false;

                    startInfos.RedirectStandardInput = true;
                    startInfos.RedirectStandardOutput = true;

                    startInfos.RedirectStandardError = true;



                    processs.EnableRaisingEvents = false;

                    processs.StartInfo = startInfos;

                    processs.Start();

                    //  string name1 = startInfo.FileName;
                    //string name2 = textBox1.Text;
                    //string send_location = sendlocate.Text;
                    // string path = send_location;
                    string set_adb3 = @"adb\adb.exe";
                    //string name3 = set_adb + " push " + name2 + " " + path + " " + send_location;
                    string devices3 = set_adb3 + " push "+ textBox5.Text + " " + label6.Text;
                    processs.StandardInput.Write(devices3 + Environment.NewLine);

                    processs.StandardInput.Close();
                    string result = processs.StandardOutput.ReadToEnd();

                    string error = processs.StandardError.ReadToEnd();

                    System.Text.StringBuilder sb = new System.Text.StringBuilder();

                    //sb.Clear();

                    sb.Append("[ Result Info ]\r\n");

                    sb.Append(result);

                    sb.Append("\r\n");


                    sb.Append("[ Error Info ]\r\n");

                    sb.Append(error);





                    this.richTextBox1.Text = sb.ToString();
                    processs.WaitForExit();

                    processs.Close();
                }
                else if (radioButton3.Checked == true && textBox2.Text == "")
                {
                    MessageBox.Show("전송하려는 위치를 입력하십시오", "전송될 경로 입력 필수", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (radioButton4.Checked == true && textBox2.Text == "" && textBox2.Enabled == false && textBox3.Text == "" && textBox3.Enabled == false)
                {
                    System.Diagnostics.Process processs = new System.Diagnostics.Process();

                    System.Diagnostics.ProcessStartInfo startInfos = new System.Diagnostics.ProcessStartInfo();

                    startInfos.FileName = @"cmd.exe";
                    string cudir = System.Environment.CurrentDirectory;
                    startInfos.WorkingDirectory = @cudir;



                    startInfos.UseShellExecute = false;

                    startInfos.RedirectStandardInput = true;
                    startInfos.RedirectStandardOutput = true;

                    startInfos.RedirectStandardError = true;



                    processs.EnableRaisingEvents = false;

                    processs.StartInfo = startInfos;

                    processs.Start();

                    //  string name1 = startInfo.FileName;
                    //string name2 = textBox1.Text;
                    //string send_location = sendlocate.Text;
                    // string path = send_location;
                    string set_adb3 = @"adb\adb.exe";
                    //string name3 = set_adb + " push " + name2 + " " + path + " " + send_location;
                    string devices3 = set_adb3+ " push "+ textBox5.Text + " " + label6.Text;
                    processs.StandardInput.Write(devices3 + Environment.NewLine);

                    processs.StandardInput.Close();
                    string result = processs.StandardOutput.ReadToEnd();

                    string error = processs.StandardError.ReadToEnd();

                    System.Text.StringBuilder sb = new System.Text.StringBuilder();

                    //sb.Clear();

                   // sb.Append("[ Result Info ]\r\n");

                    //sb.Append(result);

                    sb.Append("\r\n");


                    sb.Append("[ Error Info(?) -간혹 정상 메세지가 이쪽으로 처리될 수 있음 ]\r\n");

                    sb.Append(error);





                    this.richTextBox1.Text = sb.ToString();
                    processs.WaitForExit();

                    processs.Close();
                }
                /*else if (radioButton4.Checked == true)
                {
                    
                }*/
                else if (radioButton5.Checked == true && textBox3.Text != "" && textBox3.Enabled == true)
                {
                    System.Diagnostics.Process processs = new System.Diagnostics.Process();

                    System.Diagnostics.ProcessStartInfo startInfos = new System.Diagnostics.ProcessStartInfo();

                    startInfos.FileName = @"cmd.exe";
                    string cudir = System.Environment.CurrentDirectory;
                    startInfos.WorkingDirectory = @cudir;



                    startInfos.UseShellExecute = false;

                    startInfos.RedirectStandardInput = true;
                    startInfos.RedirectStandardOutput = true;

                    startInfos.RedirectStandardError = true;



                    processs.EnableRaisingEvents = false;

                    processs.StartInfo = startInfos;

                    processs.Start();

                    //  string name1 = startInfo.FileName;
                    //string name2 = textBox1.Text;
                    //string send_location = sendlocate.Text;
                    // string path = send_location;
                    string set_adb3 = @"adb\adb.exe";
                    //string name3 = set_adb + " push " + name2 + " " + path + " " + send_location;
                    string devices3 = set_adb3 + " push " + textBox5.Text + " " + label6.Text;
                    processs.StandardInput.Write(devices3 + Environment.NewLine);

                    processs.StandardInput.Close();
                    string result = processs.StandardOutput.ReadToEnd();

                    string error = processs.StandardError.ReadToEnd();

                    System.Text.StringBuilder sb = new System.Text.StringBuilder();

                    //sb.Clear();

                    sb.Append("[ Result Info ]\r\n");

                    sb.Append(result);

                    sb.Append("\r\n");


                    sb.Append("[ Error Info ]\r\n");

                    sb.Append(error);





                    this.richTextBox1.Text = sb.ToString();
                    processs.WaitForExit();

                    processs.Close();
                }

                else if (radioButton5.Checked == true && textBox3.Text == "")
                {
                    MessageBox.Show("전송하려는 위치를 입력하십시오", "전송될 경로 입력 필수", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {   openFileDialog1.Title = "디바이스로 전송될 파일을 선택하십시오";
            openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = openFileDialog3.FileName;
            }
                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string sdcard ="/sdcard/";
            label6.Text = sdcard + textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string root = "/";
            label6.Text = root + textBox3.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if ( radioButton4.Checked == true){
                label6.Text = "/sdcard/";
            }
            else if (radioButton4.Checked == false ){
            }
        }

        private void 일반모드로재부팅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/F:OFF /C adb\\adb.exe shell su -c reboot");
        }

        private void 연결된기기확인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/E:OFF /F:OFF /Q /K adb\\adb.exe devices");
            
        }

        private void 리커버리모드로재부팅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/F:OFF /C adb\\adb.exe shell su -c reboot recovery");
        }

        private void 다운로드모드로재부팅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/F:OFF /C adb\\adb.exe shell su -c reboot download");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label9.Text = openFileDialog1.SafeFileName.ToString();
        }

        private void wIFI로ADB연결ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enablewificonnect frm3 = new enablewificonnect();
            frm3.Show();
        }

        private void 프로그램정보ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutBox1 ab1 = new AboutBox1();
            ab1.Show();
        }

        private void aDB서버ONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/E:OFF /F:OFF /C adb\\adb.exe start-server");
        }

        private void aDB서버OFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/E:OFF /F:OFF /C adb\\adb.exe stop-server");
        }

        private void 컴퓨터정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infocomputer infoc = new infocomputer();
            infoc.Show();
        }




    }
}
