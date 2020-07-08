namespace Counter
{
    partial class Form1
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
            this.Count_up_button = new System.Windows.Forms.Button();
            this.Count_down = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Correct_answer_number_textbox = new System.Windows.Forms.TextBox();
            this.Load_value_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Number_of_questions_textbox = new System.Windows.Forms.TextBox();
            this.Max_score_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Point_value_textbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Error_message = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Count_up_button
            // 
            this.Count_up_button.Location = new System.Drawing.Point(34, 26);
            this.Count_up_button.Name = "Count_up_button";
            this.Count_up_button.Size = new System.Drawing.Size(80, 41);
            this.Count_up_button.TabIndex = 0;
            this.Count_up_button.Text = "Count up";
            this.Count_up_button.UseVisualStyleBackColor = true;
            this.Count_up_button.Click += new System.EventHandler(this.Count_up_button_Click);
            // 
            // Count_down
            // 
            this.Count_down.Location = new System.Drawing.Point(34, 98);
            this.Count_down.Name = "Count_down";
            this.Count_down.Size = new System.Drawing.Size(80, 41);
            this.Count_down.TabIndex = 1;
            this.Count_down.Text = "Count down";
            this.Count_down.UseVisualStyleBackColor = true;
            this.Count_down.Click += new System.EventHandler(this.Count_down_button_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(34, 167);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(80, 41);
            this.Clear_button.TabIndex = 2;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(22, 61);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(80, 41);
            this.Load.TabIndex = 3;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // Correct_answer_number_textbox
            // 
            this.Correct_answer_number_textbox.Location = new System.Drawing.Point(169, 72);
            this.Correct_answer_number_textbox.Name = "Correct_answer_number_textbox";
            this.Correct_answer_number_textbox.ReadOnly = true;
            this.Correct_answer_number_textbox.Size = new System.Drawing.Size(100, 20);
            this.Correct_answer_number_textbox.TabIndex = 4;
            // 
            // Load_value_textbox
            // 
            this.Load_value_textbox.Location = new System.Drawing.Point(146, 59);
            this.Load_value_textbox.Name = "Load_value_textbox";
            this.Load_value_textbox.Size = new System.Drawing.Size(100, 20);
            this.Load_value_textbox.TabIndex = 5;
            this.Load_value_textbox.TextChanged += new System.EventHandler(this.Load_value_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số câu đúng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số câu đúng ban đầu :";
            // 
            // Number_of_questions_textbox
            // 
            this.Number_of_questions_textbox.Location = new System.Drawing.Point(146, 201);
            this.Number_of_questions_textbox.Name = "Number_of_questions_textbox";
            this.Number_of_questions_textbox.Size = new System.Drawing.Size(100, 20);
            this.Number_of_questions_textbox.TabIndex = 8;
            // 
            // Max_score_textbox
            // 
            this.Max_score_textbox.Location = new System.Drawing.Point(146, 130);
            this.Max_score_textbox.Name = "Max_score_textbox";
            this.Max_score_textbox.Size = new System.Drawing.Size(100, 20);
            this.Max_score_textbox.TabIndex = 9;
            this.Max_score_textbox.TextChanged += new System.EventHandler(this.Max_score_textbox_TextChanged);
            this.Max_score_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Max_score_textbox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tổng số câu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Điểm tối đa :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Điểm :";
            // 
            // Point_value_textbox
            // 
            this.Point_value_textbox.Location = new System.Drawing.Point(169, 167);
            this.Point_value_textbox.Name = "Point_value_textbox";
            this.Point_value_textbox.ReadOnly = true;
            this.Point_value_textbox.Size = new System.Drawing.Size(100, 20);
            this.Point_value_textbox.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Point_value_textbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Correct_answer_number_textbox);
            this.groupBox1.Controls.Add(this.Clear_button);
            this.groupBox1.Controls.Add(this.Count_down);
            this.groupBox1.Controls.Add(this.Count_up_button);
            this.groupBox1.Location = new System.Drawing.Point(24, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 239);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tính điểm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Error_message);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Max_score_textbox);
            this.groupBox2.Controls.Add(this.Number_of_questions_textbox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Load_value_textbox);
            this.groupBox2.Controls.Add(this.Load);
            this.groupBox2.Location = new System.Drawing.Point(361, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 238);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông số đề bài";
            // 
            // Error_message
            // 
            this.Error_message.Location = new System.Drawing.Point(22, 160);
            this.Error_message.Name = "Error_message";
            this.Error_message.ReadOnly = true;
            this.Error_message.Size = new System.Drawing.Size(100, 20);
            this.Error_message.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 300);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tính điểm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Count_up_button;
        private System.Windows.Forms.Button Count_down;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.TextBox Correct_answer_number_textbox;
        private System.Windows.Forms.TextBox Load_value_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Number_of_questions_textbox;
        private System.Windows.Forms.TextBox Max_score_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Point_value_textbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Error_message;
    }
}

