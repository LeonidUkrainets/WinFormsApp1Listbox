namespace WinFormsApp1Listbox
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
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            btnRemoveCheked = new Button();
            btnRemoveSelected = new Button();
            checkedListBox1 = new CheckedListBox();
            textBox1 = new TextBox();
            btnAdd = new Button();
            comboBox1 = new ComboBox();
            progressBar1 = new ProgressBar();
            numericUpDown1 = new NumericUpDown();
            statusStrip1 = new StatusStrip();
            timer1 = new System.Windows.Forms.Timer(components);
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Артем", "Владислав", "Павло" });
            listBox1.Location = new Point(52, 96);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(120, 109);
            listBox1.Sorted = true;
            listBox1.TabIndex = 0;
            // 
            // btnRemoveCheked
            // 
            btnRemoveCheked.Location = new Point(357, 255);
            btnRemoveCheked.Name = "btnRemoveCheked";
            btnRemoveCheked.Size = new Size(75, 23);
            btnRemoveCheked.TabIndex = 1;
            btnRemoveCheked.Text = "Вилучити";
            btnRemoveCheked.UseVisualStyleBackColor = true;
            btnRemoveCheked.Click += btnRemoveCheked_Click;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.Location = new Point(52, 255);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(75, 23);
            btnRemoveSelected.TabIndex = 2;
            btnRemoveSelected.Text = "Вилучити";
            btnRemoveSelected.UseVisualStyleBackColor = true;
            btnRemoveSelected.Click += btnRemoveSelected_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(357, 96);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 112);
            checkedListBox1.Sorted = true;
            checkedListBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(252, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(527, 31);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Долучити";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(633, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 6;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(52, 319);
            progressBar1.Maximum = 8;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(211, 23);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Location = new Point(636, 149);
            numericUpDown1.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.ThousandsSeparator = true;
            numericUpDown1.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(565, 255);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.TabIndex = 10;
            trackBar1.Value = 5;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(565, 306);
            trackBar2.Maximum = 255;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(104, 45);
            trackBar2.TabIndex = 11;
            trackBar2.Value = 10;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(565, 357);
            trackBar3.Maximum = 255;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(104, 45);
            trackBar3.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(statusStrip1);
            Controls.Add(numericUpDown1);
            Controls.Add(progressBar1);
            Controls.Add(comboBox1);
            Controls.Add(btnAdd);
            Controls.Add(textBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(btnRemoveSelected);
            Controls.Add(btnRemoveCheked);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Списки";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnRemoveCheked;
        private Button btnRemoveSelected;
        private CheckedListBox checkedListBox1;
        private TextBox textBox1;
        private Button btnAdd;
        private ComboBox comboBox1;
        private ProgressBar progressBar1;
        private NumericUpDown numericUpDown1;
        private StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
    }
}