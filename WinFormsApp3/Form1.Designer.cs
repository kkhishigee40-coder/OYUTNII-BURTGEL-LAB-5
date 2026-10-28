namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ListViewGroup listViewGroup4 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup5 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup6 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewItem listViewItem2 = new ListViewItem("Б.Хишигжаргал");
            TreeNode treeNode7 = new TreeNode("Программ хангамж");
            TreeNode treeNode8 = new TreeNode("Мэдээллийн технологи", new TreeNode[] { treeNode7 });
            TreeNode treeNode9 = new TreeNode("Компьютерын ухаан", new TreeNode[] { treeNode8 });
            TreeNode treeNode10 = new TreeNode("Математик");
            TreeNode treeNode11 = new TreeNode("Физик");
            TreeNode treeNode12 = new TreeNode("Байгалийн ухаан", new TreeNode[] { treeNode10, treeNode11 });
            textBox1 = new TextBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            textBox2 = new TextBox();
            button1 = new Button();
            checkedListBox1 = new CheckedListBox();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            richTextBox1 = new RichTextBox();
            progressBar1 = new ProgressBar();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            treeView1 = new TreeView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "M.IT24D009";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 15);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 1;
            label1.Text = "Нийт";
            label1.Click += Нийт_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(407, 15);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(59, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Цэвэрлэх";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(12, 41);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(91, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Тэтгэлэгтэй";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(12, 75);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(113, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Өдрийн сургалт";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 254);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.Tag = "";
            numericUpDown1.Value = new decimal(new int[] { 21, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 312);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 13;
            textBox2.Text = "80197484";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(20, 407);
            button1.Name = "button1";
            button1.Size = new Size(105, 48);
            button1.TabIndex = 15;
            button1.Text = "Бүртгэх";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.AllowDrop = true;
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Програмчлал", "Өгөгдлийн бүтэц", "Алгоритм", "Өгөгдлийн сан", "Сүлжээ" });
            checkedListBox1.Location = new Point(12, 119);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 16;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Монгол", "Англи", "Орос", "Хятад", "Япон", "Солонгос" });
            listBox1.Location = new Point(161, 54);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 17;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(161, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(12, 341);
            dateTimePicker1.MaxDate = new DateTime(2006, 1, 23, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(143, 23);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.Value = new DateTime(2006, 1, 23, 0, 0, 0, 0);
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(161, 359);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(347, 173);
            richTextBox1.TabIndex = 21;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.FromArgb(0, 64, 0);
            progressBar1.Cursor = Cursors.IBeam;
            progressBar1.ForeColor = Color.FromArgb(0, 64, 0);
            progressBar1.Location = new Point(12, 538);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(515, 21);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 22;
            progressBar1.Value = 100;
            progressBar1.Click += progressBar1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader4, columnHeader5 });
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "listViewGroup1";
            listViewGroup5.Footer = "80197484";
            listViewGroup5.Header = "ListViewGroup";
            listViewGroup5.Name = "listViewGroup2";
            listViewGroup6.Header = "ListViewGroup";
            listViewGroup6.Name = "listViewGroup3";
            listView1.Groups.AddRange(new ListViewGroup[] { listViewGroup4, listViewGroup5, listViewGroup6 });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listView1.Location = new Point(328, 51);
            listView1.Name = "listView1";
            listView1.ShowGroups = false;
            listView1.Size = new Size(199, 97);
            listView1.TabIndex = 23;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Овог нэр";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Утас";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Нас";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(345, 180);
            treeView1.Name = "treeView1";
            treeNode7.Name = "Node2";
            treeNode7.Text = "Программ хангамж";
            treeNode8.Name = "Node1";
            treeNode8.Text = "Мэдээллийн технологи";
            treeNode9.Name = "Node0";
            treeNode9.Text = "Компьютерын ухаан";
            treeNode10.Name = "Node4";
            treeNode10.Text = "Математик";
            treeNode11.Name = "Node5";
            treeNode11.Text = "Физик";
            treeNode12.Name = "Node3";
            treeNode12.Text = "Байгалийн ухаан";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode9, treeNode12 });
            treeView1.Size = new Size(182, 115);
            treeView1.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 561);
            Controls.Add(treeView1);
            Controls.Add(listView1);
            Controls.Add(progressBar1);
            Controls.Add(richTextBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(numericUpDown1);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private Button button1;
        private CheckedListBox checkedListBox1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private RichTextBox richTextBox1;
        private ProgressBar progressBar1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TreeView treeView1;
    }
}
