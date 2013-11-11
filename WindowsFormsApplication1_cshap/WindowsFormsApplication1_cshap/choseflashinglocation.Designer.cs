namespace WindowsFormsApplication1_cshap
{
    partial class choseflashinglocation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choseflashinglocation));
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.common1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.common1,
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("listView1.Groups"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("listView1.Groups1"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("listView1.Groups2"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("listView1.Groups3"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("listView1.Groups4")))});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listView1.Items"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listView1.Items1"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listView1.Items2"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listView1.Items3"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listView1.Items4"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listView1.Items5"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listView1.Items6"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listView1.Items7"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listView1.Items8"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listView1.Items9"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listView1.Items10"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listView1.Items11"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listView1.Items12"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listView1.Items13")))});
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.ShowItemToolTips = true;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // common1
            // 
            resources.ApplyResources(this.common1, "common1");
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // choseflashinglocation
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "choseflashinglocation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.choseflashinglocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ColumnHeader common1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}