using System.Drawing.Text;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1Listbox
{
    public partial class Form1 : Form
    {
        private ToolStripStatusLabel clocksLabel;
        public Form1()
        {
            InitializeComponent();
            List1_Load();
        }
        private void List1_Load()
        {
            //this.listBox1.Items.Add("Перший запис");
            this.listBox1.Items.AddRange(new object[] { "Микола", "Алла", "Кирило", "Андрій" });
            //this.listBox1.Items.Clear();
            this.checkedListBox1.Items.AddRange(new object[] { "Микола", "Алла", "Кирило", "Андрій", "Павло" });
            this.checkedListBox1.Items.Insert(1, "Артем");
            //this.checkedListBox1.Items.Remove("Артем");
            this.checkedListBox1.Items.RemoveAt(1);
            //this.checkedListBox1.Items.Clear();
            ToolTip tip1 = new ToolTip();
            tip1.SetToolTip(this.btnRemoveCheked, "Вилучити відмічені");
            ToolTip tip2 = new ToolTip();
            tip1.SetToolTip(this.btnRemoveSelected, "Вилучити вибрані");
            //public enum DateTimeFormat { ShowClock, ShowDate };

            timer1.Interval = 1000;
            timer1.Start();
            clocksLabel = new ToolStripStatusLabel();
            statusStrip1.Items.Add(clocksLabel);
        }


        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count != 0)
            {
                for (int i = this.listBox1.Items.Count - 1; i >= 0; i--)
                {
                    if (this.listBox1.GetSelected(i))
                    {
                        this.listBox1.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void btnRemoveCheked_Click(object sender, EventArgs e)
        {
            string item_str = "";
            if (this.checkedListBox1.Items.Count != 0)
            {
                for (int i = this.checkedListBox1.Items.Count - 1; i >= 0; i--)
                {
                    if (this.checkedListBox1.GetItemChecked(i))
                    {
                        item_str = item_str + checkedListBox1.Items[i].ToString() + " ";
                        this.checkedListBox1.Items.RemoveAt(i);
                    }
                }
                MessageBox.Show(item_str);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.textBox1.Text))
            {
                if (!this.checkedListBox1.Items.Contains(this.textBox1.Text))
                {
                    this.checkedListBox1.Items.Add(this.textBox1.Text);
                    this.listBox1.Items.Add(this.textBox1.Text);
                    this.progressBar1.PerformStep();
                }
                else
                {
                    MessageBox.Show(this.textBox1.Text + " уже є в цьому списку!");
                }

            }
            else
            {
                MessageBox.Show("Задайте ім’я для введення");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string string_date = DateTime.Now.ToShortTimeString();
            clocksLabel.Text = string_date;
            UpdateColor();
        }
        private void UpdateColor()
        {
            Color c = Color.FromArgb(this.trackBar1.Value, this.trackBar2.Value, this.trackBar3.Value);
            this.BackColor = c;
        }
    }
}