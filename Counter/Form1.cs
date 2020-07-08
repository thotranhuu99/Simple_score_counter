using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter
{
    public partial class Form1 : Form
    {
        uint Correct_answer = 0;
        double Max_score = 10;
        uint Number_of_questions = 100;

        public Form1()
        {
            InitializeComponent();
            Correct_answer_number_textbox.Text = Correct_answer.ToString();
            Load_value_textbox.Text = "0";
        }

        private void Count_up_button_Click(object sender, EventArgs e)
        { 
            if (Correct_answer < Number_of_questions)
            {
                Correct_answer++;
            }
            Correct_answer_number_textbox.Text = Correct_answer.ToString();
            Point_value_textbox.Text = ((double) ((uint) ((((double)Correct_answer) * (Max_score) / ((double)Number_of_questions))*100 + 0.5))/100).ToString();
        }

        private void Count_down_button_Click(object sender, EventArgs e)
        {
            if (Correct_answer > 0)
            {
                Correct_answer--;
            }
            else
            {
                Correct_answer = 0;
            }
            Correct_answer_number_textbox.Text = Correct_answer.ToString();
            Point_value_textbox.Text = ((double)((uint)((((double)Correct_answer) * (Max_score) / ((double)Number_of_questions)) * 100 + 0.5)) / 100).ToString();
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Correct_answer = 0;
            Correct_answer_number_textbox.Text = Correct_answer.ToString();
            Point_value_textbox.Text = (((double)Correct_answer) * (Max_score) / ((double)Number_of_questions)).ToString();
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            try
            {
                Correct_answer = uint.Parse(Load_value_textbox.Text);
                Error_message.Text = "No error";
            }
            catch (Exception expt)
            {
                Error_message.Text = "Check input";
            }

            try
            {
                Number_of_questions = uint.Parse(Number_of_questions_textbox.Text);
            }
            catch (Exception expt)
            {
                Error_message.Text = "Check input";
            }

            try
            {
                Max_score = double.Parse(Max_score_textbox.Text);
            }
            catch (Exception expt)
            {
                Error_message.Text = "Check input";
            }

            if (Correct_answer > Number_of_questions)
            {
                Error_message.Text = "Check input";
            }
            if (Error_message.Text == "No error")
            {
                Correct_answer_number_textbox.Text = Correct_answer.ToString();

                try
                {
                    Point_value_textbox.Text = ((double)((uint)((((double)Correct_answer) * (Max_score) / ((double)Number_of_questions)) * 100 + 0.5)) / 100).ToString();
                }
                catch (Exception expt)
                {

                }
            }
            Count_down.Enabled = true;
            Count_up_button.Enabled = true;
            Clear_button.Enabled = true;
        }

        private void Load_value_TextChanged(object sender, EventArgs e)
        {

        }

        private void Max_score_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Max_score_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Number_of_questions_textbox.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

        }

        private void Number_of_questions_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Load_button_Click(this, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Load_value_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Max_score_textbox.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
