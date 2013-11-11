namespace WindowsFormsApplication1_cshap
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.기능ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDB기능ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSB디버깅유무확인바람ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.일반모드로재부팅ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.리커버리모드로재부팅ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다운로드모드로재부팅ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.연결된기기확인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wIFI로ADB연결ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDB서버ONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDB서버OFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.컴퓨터정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.indeviceflashlocate = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.countnumber = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.blocksizenumber = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.sendlocate = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(6, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "파일 선택";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "img";
            this.openFileDialog1.Filter = "normalboot.img|normalboot.img|zimage|zimage|zImage|zImage|boot.img|boot.img|recov" +
    "ery.img|recovery.img|*.*(all_files)|*.*";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(87, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(395, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.기능ToolStripMenuItem,
            this.정보ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(549, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 기능ToolStripMenuItem
            // 
            this.기능ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDB기능ToolStripMenuItem});
            this.기능ToolStripMenuItem.Name = "기능ToolStripMenuItem";
            this.기능ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.기능ToolStripMenuItem.Text = "기능";
            // 
            // aDB기능ToolStripMenuItem
            // 
            this.aDB기능ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSB디버깅유무확인바람ToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.일반모드로재부팅ToolStripMenuItem,
            this.리커버리모드로재부팅ToolStripMenuItem,
            this.다운로드모드로재부팅ToolStripMenuItem,
            this.toolStripSeparator3,
            this.연결된기기확인ToolStripMenuItem,
            this.wIFI로ADB연결ToolStripMenuItem,
            this.aDB서버ONToolStripMenuItem,
            this.aDB서버OFFToolStripMenuItem});
            this.aDB기능ToolStripMenuItem.Name = "aDB기능ToolStripMenuItem";
            this.aDB기능ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aDB기능ToolStripMenuItem.Text = "ADB 기능";
            // 
            // uSB디버깅유무확인바람ToolStripMenuItem
            // 
            this.uSB디버깅유무확인바람ToolStripMenuItem.Name = "uSB디버깅유무확인바람ToolStripMenuItem";
            this.uSB디버깅유무확인바람ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.uSB디버깅유무확인바람ToolStripMenuItem.Text = "USB디버깅 유무 확인바람";
            this.uSB디버깅유무확인바람ToolStripMenuItem.Click += new System.EventHandler(this.uSB디버깅유무확인바람ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // 일반모드로재부팅ToolStripMenuItem
            // 
            this.일반모드로재부팅ToolStripMenuItem.Name = "일반모드로재부팅ToolStripMenuItem";
            this.일반모드로재부팅ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.일반모드로재부팅ToolStripMenuItem.Text = "일반 모드로 재부팅";
            this.일반모드로재부팅ToolStripMenuItem.Click += new System.EventHandler(this.일반모드로재부팅ToolStripMenuItem_Click);
            // 
            // 리커버리모드로재부팅ToolStripMenuItem
            // 
            this.리커버리모드로재부팅ToolStripMenuItem.Name = "리커버리모드로재부팅ToolStripMenuItem";
            this.리커버리모드로재부팅ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.리커버리모드로재부팅ToolStripMenuItem.Text = "리커버리 모드로 재부팅";
            this.리커버리모드로재부팅ToolStripMenuItem.Click += new System.EventHandler(this.리커버리모드로재부팅ToolStripMenuItem_Click);
            // 
            // 다운로드모드로재부팅ToolStripMenuItem
            // 
            this.다운로드모드로재부팅ToolStripMenuItem.Name = "다운로드모드로재부팅ToolStripMenuItem";
            this.다운로드모드로재부팅ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.다운로드모드로재부팅ToolStripMenuItem.Text = "다운로드 모드로 재부팅";
            this.다운로드모드로재부팅ToolStripMenuItem.Click += new System.EventHandler(this.다운로드모드로재부팅ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(209, 6);
            // 
            // 연결된기기확인ToolStripMenuItem
            // 
            this.연결된기기확인ToolStripMenuItem.Name = "연결된기기확인ToolStripMenuItem";
            this.연결된기기확인ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.연결된기기확인ToolStripMenuItem.Text = "연결된 기기확인";
            this.연결된기기확인ToolStripMenuItem.Click += new System.EventHandler(this.연결된기기확인ToolStripMenuItem_Click);
            // 
            // wIFI로ADB연결ToolStripMenuItem
            // 
            this.wIFI로ADB연결ToolStripMenuItem.Name = "wIFI로ADB연결ToolStripMenuItem";
            this.wIFI로ADB연결ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.wIFI로ADB연결ToolStripMenuItem.Text = "WI-FI로 ADB연결";
            this.wIFI로ADB연결ToolStripMenuItem.Click += new System.EventHandler(this.wIFI로ADB연결ToolStripMenuItem_Click);
            // 
            // aDB서버ONToolStripMenuItem
            // 
            this.aDB서버ONToolStripMenuItem.Name = "aDB서버ONToolStripMenuItem";
            this.aDB서버ONToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.aDB서버ONToolStripMenuItem.Text = "ADB 서버 ON";
            this.aDB서버ONToolStripMenuItem.Click += new System.EventHandler(this.aDB서버ONToolStripMenuItem_Click);
            // 
            // aDB서버OFFToolStripMenuItem
            // 
            this.aDB서버OFFToolStripMenuItem.Name = "aDB서버OFFToolStripMenuItem";
            this.aDB서버OFFToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.aDB서버OFFToolStripMenuItem.Text = "ADB 서버 OFF";
            this.aDB서버OFFToolStripMenuItem.Click += new System.EventHandler(this.aDB서버OFFToolStripMenuItem_Click);
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프로그램정보ToolStripMenuItem,
            this.컴퓨터정보ToolStripMenuItem});
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.정보ToolStripMenuItem.Text = "정보";
            // 
            // 프로그램정보ToolStripMenuItem
            // 
            this.프로그램정보ToolStripMenuItem.Name = "프로그램정보ToolStripMenuItem";
            this.프로그램정보ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.프로그램정보ToolStripMenuItem.Text = "프로그램 정보";
            this.프로그램정보ToolStripMenuItem.Click += new System.EventHandler(this.프로그램정보ToolStripMenuItem_Click_1);
            // 
            // 컴퓨터정보ToolStripMenuItem
            // 
            this.컴퓨터정보ToolStripMenuItem.Name = "컴퓨터정보ToolStripMenuItem";
            this.컴퓨터정보ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.컴퓨터정보ToolStripMenuItem.Text = "컴퓨터 정보";
            this.컴퓨터정보ToolStripMenuItem.Click += new System.EventHandler(this.컴퓨터정보ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "프로그램을 이용하기전 환경설정-개발자옵션-USB디버깅에 체크가 되어있는지 \r\n확인해주세요";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.DefaultExt = "exe";
            this.openFileDialog2.FileName = "adb.exe";
            this.openFileDialog2.Title = "adb실행파일을 지정하십시오";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.indeviceflashlocate);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(18, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 257);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "기본설정";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 12);
            this.label9.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(193, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 44);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(144, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(139, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "/sdcard/external_sd";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "/sdcard";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // indeviceflashlocate
            // 
            this.indeviceflashlocate.Location = new System.Drawing.Point(127, 107);
            this.indeviceflashlocate.MaxLength = 70;
            this.indeviceflashlocate.Name = "indeviceflashlocate";
            this.indeviceflashlocate.ReadOnly = true;
            this.indeviceflashlocate.Size = new System.Drawing.Size(353, 21);
            this.indeviceflashlocate.TabIndex = 4;
            this.indeviceflashlocate.Text = "mmcblk0p5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.countnumber);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.blocksizenumber);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(8, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "고급설정";
            // 
            // countnumber
            // 
            this.countnumber.Enabled = false;
            this.countnumber.Location = new System.Drawing.Point(202, 53);
            this.countnumber.Name = "countnumber";
            this.countnumber.Size = new System.Drawing.Size(217, 22);
            this.countnumber.TabIndex = 3;
            this.countnumber.EnabledChanged += new System.EventHandler(this.countnumber_EnabledChanged);
            this.countnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countnumber_KeyPress);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox2.ForeColor = System.Drawing.Color.Black;
            this.checkBox2.Location = new System.Drawing.Point(6, 58);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(181, 16);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "횟수(?)(count)를 설정합니다";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // blocksizenumber
            // 
            this.blocksizenumber.Enabled = false;
            this.blocksizenumber.Location = new System.Drawing.Point(202, 18);
            this.blocksizenumber.Name = "blocksizenumber";
            this.blocksizenumber.Size = new System.Drawing.Size(217, 22);
            this.blocksizenumber.TabIndex = 1;
            this.blocksizenumber.EnabledChanged += new System.EventHandler(this.blocksizenumber_EnabledChanged);
            this.blocksizenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blocksizenumber_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(6, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(190, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "블록 사이즈(BS)를 설정합니다";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "플래싱될 경로";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "컴퓨터에서 파일이 전송될 경로: ";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox2.Location = new System.Drawing.Point(96, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 21);
            this.textBox2.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBox2, "폴터명만 입력하실 경우 폴터이름 맨뒤에 / 를 붙여주세요");
            this.textBox2.WordWrap = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(53, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(267, 21);
            this.textBox3.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textBox3, "폴터명만 입력하실 경우 폴터이름 맨뒤에 / 를 붙여주세요");
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(526, 48);
            this.label3.TabIndex = 7;
            this.label3.Text = "잘못된 파일 혹은 잘못된 경로에 플래싱하므로써 생기는 문제는\r\n개발자가 책임지지 않으며 이 프로그램을 이용한다는 것은 사용자가\r\n자신에게 책임이 " +
    "있다는 것을 동의하는 것입니다";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(549, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(493, 404);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // sendlocate
            // 
            this.sendlocate.AutoSize = true;
            this.sendlocate.Location = new System.Drawing.Point(457, 60);
            this.sendlocate.Name = "sendlocate";
            this.sendlocate.Size = new System.Drawing.Size(56, 12);
            this.sendlocate.TabIndex = 9;
            this.sendlocate.Text = "/sdcard/";
            this.sendlocate.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(946, 434);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 22);
            this.button4.TabIndex = 10;
            this.button4.Text = "디바이스 확인";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(384, 391);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 32);
            this.button6.TabIndex = 12;
            this.button6.Text = "커널 플래싱하기";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 458);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.sendlocate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kernel Flasher with ADB";
            this.tabPage1.ToolTipText = "커널을 쉽게 플래슁할수 있도록 돕는 탭입니다";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(542, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "File sender with ADB";
            this.tabPage2.ToolTipText = "파일을 컴퓨터에서 사용하시는 기기로 전송할 수 있습니다";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(201, 376);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(143, 32);
            this.button10.TabIndex = 17;
            this.button10.Text = "전송 진행 확인창 닫기";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(201, 376);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(143, 32);
            this.button7.TabIndex = 7;
            this.button7.Text = "전송 진행 확인창 열기";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "/sdcard/";
            this.label6.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("궁서", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(-3, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(545, 34);
            this.label4.TabIndex = 13;
            this.label4.Text = "프로그램을 이용하기전 환경설정-개발자옵션-USB디버깅에 체크가\r\n되어있는지 확인해주세요";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Location = new System.Drawing.Point(8, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(525, 235);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "기본설정";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.radioButton5);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.radioButton3);
            this.groupBox5.Controls.Add(this.radioButton4);
            this.groupBox5.Location = new System.Drawing.Point(193, 48);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(326, 156);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "┗ /";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(17, 82);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(201, 16);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "완전한 커스텀(사용자 정의) 경로";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "┗ /sdcard/";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(17, 39);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(136, 16);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Text = "/sdcard의 추가 경로";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(17, 17);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(68, 16);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "/sdcard";
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "컴퓨터에서 파일이 전송될 경로: ";
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Location = new System.Drawing.Point(6, 18);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 0;
            this.button8.Text = "파일 선택";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox5.Location = new System.Drawing.Point(87, 20);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.ShortcutsEnabled = false;
            this.textBox5.Size = new System.Drawing.Size(432, 21);
            this.textBox5.TabIndex = 2;
            this.textBox5.TabStop = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(391, 376);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(126, 32);
            this.button9.TabIndex = 15;
            this.button9.Text = "파일 전송하기";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            this.openFileDialog3.Filter = "어플 파일|*.apk;*.gpk|이미지 파일|*.png;*.jpg;*.bmp;*.jpeg;*gif|동영상파일|*.avi;*.wav;*.h264;*" +
    ".mkv;*.mp4|압축파일|*.zip;*.egg;*.7z;|모든 파일|*.*";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(549, 483);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox countnumber;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox blocksizenumber;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label sendlocate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.TextBox indeviceflashlocate;
        private System.Windows.Forms.ToolStripMenuItem 기능ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDB기능ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 컴퓨터정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSB디버깅유무확인바람ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 일반모드로재부팅ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 리커버리모드로재부팅ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다운로드모드로재부팅ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton3;
        public System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 연결된기기확인ToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem wIFI로ADB연결ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDB서버ONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDB서버OFFToolStripMenuItem;
    }
}

