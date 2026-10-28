using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private IEnumerable<T> GetAll<T>(Control parent) where T : Control
        {
            foreach (Control c in parent.Controls)
            {
                if (c is T t) yield return t;
                if (c is NumericUpDown) continue;
                foreach (var child in GetAll<T>(c)) yield return child;
            }
        }

        private TextBox CodeBox => GetAll<TextBox>(this).OrderBy(t => t.Top).First();
        private TextBox PhoneBox => GetAll<TextBox>(this).OrderBy(t => t.Top).Skip(1).First();
        private ComboBox DeptBox => GetAll<ComboBox>(this).First();
        private DateTimePicker BirthPicker => GetAll<DateTimePicker>(this).First();
        private Label TotalLabel => GetAll<Label>(this).First(l => l.Text.Contains("ийт"));

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            TotalLabel.Text = "Нийт: 0";

            listView1.View = View.Details;
            listView1.ShowGroups = false;

            foreach (var btn in GetAll<Button>(this))
            {
                btn.Click -= BurtgekhClick;
                btn.Click += BurtgekhClick;
            }

            foreach (var link in GetAll<LinkLabel>(this))
            {
                link.LinkClicked -= TsewerlekhClick;
                link.LinkClicked += TsewerlekhClick;
            }

            foreach (var tree in GetAll<TreeView>(this))
            {
                tree.AfterSelect -= TreeAfterSelect;
                tree.AfterSelect += TreeAfterSelect;
            }

            foreach (var pic in GetAll<PictureBox>(this))
            {
                pic.Click -= PictureClick;
                pic.Click += PictureClick;
            }
        }

        private void AddLine(string label, string value)
        {
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.SelectionLength = 0;
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
            richTextBox1.AppendText(label + ": ");

            richTextBox1.SelectionColor = Color.Green;
            richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            richTextBox1.AppendText(value + "\n");
        }

        private void BurtgekhClick(object? sender, EventArgs e)
        {
            richTextBox1.Clear();

            richTextBox1.SelectionFont = new Font("Segoe UI", 16, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.DarkBlue;
            richTextBox1.AppendText("ОЮУТНЫ БҮРТГЭЛ\n\n");

            AddLine("Код", CodeBox.Text);
            AddLine("Утас", PhoneBox.Text);
            AddLine("Нас", numericUpDown1.Value.ToString());
            AddLine("Төрсөн өдөр", BirthPicker.Value.ToString("yyyy-MM-dd"));
            AddLine("Сургалт", radioButton1.Checked ? "Өдрийн" : "Оройн");
            AddLine("Тэнхим", DeptBox.Text);
            AddLine("Тэтгэлэг", checkBox1.Checked ? "Тийм" : "Үгүй");
            AddLine("Хичээл", string.Join(", ", checkedListBox1.CheckedItems.Cast<object>()));
            AddLine("Хэл", listBox1.SelectedItem?.ToString() ?? "");

            var item = new ListViewItem(CodeBox.Text);
            item.SubItems.Add(PhoneBox.Text);
            item.SubItems.Add(numericUpDown1.Value.ToString());
            listView1.Items.Add(item);

            TotalLabel.Text = "Нийт: " + listView1.Items.Count;

            progressBar1.Value = Math.Min(progressBar1.Value + 10, progressBar1.Maximum);
        }

        private void TsewerlekhClick(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            listView1.Items.Clear();
            richTextBox1.Clear();
            TotalLabel.Text = "Нийт: 0";
            progressBar1.Value = 0;
            CodeBox.Clear();
            PhoneBox.Clear();
        }

        private void TreeAfterSelect(object? sender, TreeViewEventArgs e)
        {
            if (e.Node != null && e.Node.Parent != null)
                DeptBox.Text = e.Node.Text;
        }

        private void PictureClick(object? sender, EventArgs e)
        {
            if (sender is not PictureBox pic) return;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Зураг|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    pic.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Нийт_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}