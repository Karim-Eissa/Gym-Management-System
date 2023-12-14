namespace OOP_Project
{
    partial class search
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
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button6 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton3 = new RadioButton();
            name = new DataGridViewTextBoxColumn();
            age = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            months = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            Salary = new DataGridViewTextBoxColumn();
            FeesPerMonth = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(370, 24);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 52;
            label2.Text = "Search:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Cursor = Cursors.IBeam;
            pictureBox2.Image = Properties.Resources.E0E0E0_png;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(972, 366);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 59;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Cursor = Cursors.IBeam;
            pictureBox1.Image = Properties.Resources._2021_05_Healhtfix_Copyright_Franck_Gazzola_WEB_263;
            pictureBox1.Location = new Point(1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1006, 401);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(224, 224, 224);
            button6.BackgroundImage = Properties.Resources.search_icon_png_9996__1_;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Black;
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.Location = new Point(624, 22);
            button6.Name = "button6";
            button6.Size = new Size(27, 23);
            button6.TabIndex = 60;
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(434, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 23);
            textBox1.TabIndex = 61;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, age, gender, StartDate, months, Position, Salary, FeesPerMonth, type });
            dataGridView1.Location = new Point(33, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(933, 291);
            dataGridView1.TabIndex = 62;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.FromArgb(224, 224, 224);
            radioButton2.Location = new Point(500, 51);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(49, 19);
            radioButton2.TabIndex = 64;
            radioButton2.TabStop = true;
            radioButton2.Text = "Staff";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.FromArgb(224, 224, 224);
            radioButton1.Location = new Point(424, 51);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 19);
            radioButton1.TabIndex = 63;
            radioButton1.TabStop = true;
            radioButton1.Text = "Member";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.FromArgb(224, 224, 224);
            radioButton3.Location = new Point(555, 51);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(59, 19);
            radioButton3.TabIndex = 65;
            radioButton3.TabStop = true;
            radioButton3.Text = "Coach";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "Name";
            name.Name = "name";
            // 
            // age
            // 
            age.DataPropertyName = "age";
            age.HeaderText = "Age";
            age.Name = "age";
            // 
            // gender
            // 
            gender.DataPropertyName = "gender";
            gender.HeaderText = "Gender";
            gender.Name = "gender";
            // 
            // StartDate
            // 
            StartDate.DataPropertyName = "StartDate";
            StartDate.HeaderText = "Start Date";
            StartDate.Name = "StartDate";
            // 
            // months
            // 
            months.DataPropertyName = "months";
            months.HeaderText = "Sub Plan";
            months.Name = "months";
            // 
            // Position
            // 
            Position.DataPropertyName = "Position";
            Position.HeaderText = "Position";
            Position.Name = "Position";
            // 
            // Salary
            // 
            Salary.DataPropertyName = "Salary";
            Salary.HeaderText = "Salary";
            Salary.Name = "Salary";
            // 
            // FeesPerMonth
            // 
            FeesPerMonth.DataPropertyName = "FeesPerMonth";
            FeesPerMonth.HeaderText = "Fees Per Month";
            FeesPerMonth.Name = "FeesPerMonth";
            // 
            // type
            // 
            type.DataPropertyName = "type";
            type.HeaderText = "Type";
            type.Name = "type";
            // 
            // search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 404);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "search";
            Text = "Search";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button6;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn months;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Salary;
        private DataGridViewTextBoxColumn FeesPerMonth;
        private DataGridViewTextBoxColumn type;
    }
}