using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class game_form : Form
    {
        public string player1 { get; set; }
        public string player2 { get; set; }
        public int xcounter = 0;
        public int check = 0;
        
        public game_form()
        {
            InitializeComponent();
        }
        public game_form(string x, string y)
        {
            InitializeComponent();
            this.player1 = x;
            this.player2 = y;
            label1.Text = player1;
            label2.Text = player2;
        }

        private void game_form_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void checkbutton(Button btn, ref int x)
        {
            if (check < 9)
            {
                if (check % 2 == 1) { btn.Text = "X"; }
                if (check % 2 == 0) { btn.Text = "O"; }
                btn.Enabled = false;
                check++;
                checkWin();
            }
            else
            { MessageBox.Show("Draw"); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            checkbutton(button1, ref check);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkbutton(button2, ref check);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkbutton(button3, ref check);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkbutton(button4, ref check);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkbutton(button5, ref check);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkbutton(button6, ref check);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkbutton(button7, ref check);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            checkbutton(button8, ref check);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            checkbutton(button9, ref check);
        }


        public void checkdraw()
        {
            if (button1.Text != string.Empty &&
              button2.Text != string.Empty &&
              button3.Text != string.Empty &&
              button4.Text != string.Empty &&
              button5.Text != string.Empty &&
              button6.Text != string.Empty &&
              button7.Text != string.Empty &&
              button8.Text != string.Empty &&
              button9.Text != string.Empty
                ) { MessageBox.Show("DRAW"); }
        }
        public void checkWin()
        {
            
            {
                if (button1.Text == button2.Text && button2.Text == button3.Text && button3.Text != string.Empty )
                { MessageBox.Show(" Win");
                    xcounter++;
                    label3.Text = xcounter.ToString();
                   // this.Hide();
                    game_form f1 = new game_form();
                    f1.ShowDialog();
                }
                else if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text != string.Empty)
                {
                    MessageBox.Show(" Win");
                    this.Hide();
                    game_form f1 = new game_form();
                    f1.ShowDialog();
                }
                else if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text != string.Empty)
                {
                    MessageBox.Show(" Win");
                    this.Hide();
                    game_form f1 = new game_form();
                    f1.ShowDialog();
                }
                else if (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text != string.Empty)
                {
                    MessageBox.Show(" Win");
                    this.Hide();
                    game_form f1 = new game_form();
                    f1.ShowDialog();
                }
                else if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text != string.Empty)
                {
                    MessageBox.Show(" Win");
                    this.Hide();
                    game_form f1 = new game_form();
                    f1.ShowDialog();
                }
                else if (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text != string.Empty)
                {
                    MessageBox.Show(" Win");
                    this.Hide();
                    game_form f1 = new game_form();
                    f1.ShowDialog();
                }
                else if (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text != string.Empty)
                {
                    MessageBox.Show(" Win");
                    this.Hide();
                    game_form f1 = new game_form();
                    f1.ShowDialog();
                }
                else if (button3.Text == button5.Text && button5.Text == button7.Text && button7.Text != string.Empty)
                {
                    MessageBox.Show(" Win");
                    this.Hide();
                    game_form f1 = new game_form();
                    f1.ShowDialog();
                }

            }
        }
    }
}
