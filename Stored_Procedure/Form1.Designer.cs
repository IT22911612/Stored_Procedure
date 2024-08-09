namespace Stored_Procedure
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox7 = new TextBox();
            insert_btn = new Button();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            update_btn = new Button();
            delete_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 27);
            label1.Name = "label1";
            label1.Size = new Size(333, 31);
            label1.TabIndex = 0;
            label1.Text = "Stored Procedure Check";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F);
            label2.Location = new Point(105, 110);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 1;
            label2.Text = "Employee_ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F);
            label3.Location = new Point(105, 145);
            label3.Name = "label3";
            label3.Size = new Size(158, 21);
            label3.TabIndex = 2;
            label3.Text = "Employee Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F);
            label4.Location = new Point(105, 180);
            label4.Name = "label4";
            label4.Size = new Size(140, 21);
            label4.TabIndex = 3;
            label4.Text = "Employee City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F);
            label5.Location = new Point(105, 215);
            label5.Name = "label5";
            label5.Size = new Size(143, 21);
            label5.TabIndex = 4;
            label5.Text = "Employee Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F);
            label6.Location = new Point(105, 251);
            label6.Name = "label6";
            label6.Size = new Size(40, 21);
            label6.TabIndex = 5;
            label6.Text = "Sex";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F);
            label7.Location = new Point(105, 290);
            label7.Name = "label7";
            label7.Size = new Size(120, 21);
            label7.TabIndex = 6;
            label7.Text = "Joining Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F);
            label8.Location = new Point(105, 330);
            label8.Name = "label8";
            label8.Size = new Size(161, 21);
            label8.TabIndex = 7;
            label8.Text = "Contact Number";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(305, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 31);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(305, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 31);
            textBox2.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(305, 210);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(213, 31);
            textBox4.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(305, 325);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(213, 31);
            textBox7.TabIndex = 14;
            // 
            // insert_btn
            // 
            insert_btn.BackColor = Color.Black;
            insert_btn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insert_btn.ForeColor = Color.White;
            insert_btn.Location = new Point(107, 381);
            insert_btn.Name = "insert_btn";
            insert_btn.Size = new Size(138, 35);
            insert_btn.TabIndex = 15;
            insert_btn.Text = "INSERT";
            insert_btn.UseVisualStyleBackColor = false;
            insert_btn.Click += insert_btn_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Piliyandala", "Colombo", "Moratuwa", "Anuradhapura", "Wellawatte" });
            comboBox1.Location = new Point(305, 174);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 33);
            comboBox1.TabIndex = 16;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(305, 247);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 29);
            radioButton1.TabIndex = 17;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(405, 247);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 29);
            radioButton2.TabIndex = 18;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(308, 285);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(210, 31);
            dateTimePicker1.TabIndex = 19;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 435);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(884, 183);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.Black;
            update_btn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_btn.ForeColor = Color.White;
            update_btn.Location = new Point(281, 381);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(138, 35);
            update_btn.TabIndex = 21;
            update_btn.Text = "UPDATE";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.Black;
            delete_btn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.ForeColor = Color.White;
            delete_btn.Location = new Point(461, 381);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(138, 35);
            delete_btn.TabIndex = 22;
            delete_btn.Text = "DELETE";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(908, 644);
            Controls.Add(delete_btn);
            Controls.Add(update_btn);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(insert_btn);
            Controls.Add(textBox7);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox7;
        private Button insert_btn;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Button update_btn;
        private Button delete_btn;
    }
}
