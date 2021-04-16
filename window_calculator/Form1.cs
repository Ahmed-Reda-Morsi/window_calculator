using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace window_calculator
{
    public partial class Form1 : Form
    {
        double number_1, number_2, operation_result;
        string user_operator = "";
        bool one_click_equal = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void delete_all_Click(object sender, EventArgs e)
        {
            user_operator = label.Text = "";
            user_input.Text = "0";
            number_1 = number_2 = operation_result = 0.0;

        }

        private void clear_display_Click(object sender, EventArgs e)
        {
            user_operator = "";
            user_input.Text = "0";
            number_1 = number_2 = 0.0;
        }

        private void delete_element_Click(object sender, EventArgs e)
        {
            user_input.Text = user_input.Text.Remove(user_input.Text.Length - 1);

        }

        private void sign_button_Click(object sender, EventArgs e)
        {
            var sign = -1 * (Convert.ToDouble(user_input.Text));
            user_input.Text = sign.ToString();
        }

        private void Equal_button_Click(object sender, EventArgs e)
        {

            if (operation_result.ToString() != user_input.Text)
            {
                number_2 = Convert.ToDouble(user_input.Text);

            }
            label.Text = number_1.ToString() + " " + user_operator + " " + number_2.ToString() + "=";

            switch (user_operator)
            {
                case "+":
                    operation_result = number_1 + number_2;
                    break;
                case "-":
                    operation_result = number_1 - number_2;
                    break;
                case "/":
                    operation_result = number_1 / number_2;
                    break;
                case "X":
                    operation_result = number_1 * number_2;
                    break;
                default:
                    break;

            }
            one_click_equal = true;
            number_1 = operation_result;
            user_input.Text = operation_result.ToString();

        }

        private void Num_Click(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            if (user_input.Text == "0") { user_input.Text = button.Text; }
            else { user_input.Text += button.Text; }

        }

        private void operation_Click(object sender, EventArgs e)
        {
            label.Text = user_input.Text;
            number_1 = Convert.ToDouble(label.Text);
            Button button = (Button)sender;
            user_operator = button.Text;
            label.Text += " " + button.Text + " ";
            user_input.Text = "";
        }
    }
}
