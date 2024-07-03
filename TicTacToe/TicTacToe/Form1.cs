namespace TicTacToe
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            game_form form = new game_form(txt_player1.Text.ToString(), txt_player2.Text.ToString());
            form.ShowDialog();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_player1x.Checked)
            {
                rb_player1o.Checked = false;
                rb_player2o.Checked = true;

            }
        }

        private void rb_player1o_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_player1o.Checked)
            {
                rb_player1x.Checked = false;
                rb_player2x.Checked = true;
            }
        }

        private void rb_player2x_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_player2x.Checked)
            {
                rb_player2o.Checked = false;
                rb_player1o.Checked = true;
            }
        }

        private void rb_player2o_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_player2o.Checked)
            {
                rb_player2x.Checked=false;
                rb_player1x.Checked=true;
            }
        }
    }
}
