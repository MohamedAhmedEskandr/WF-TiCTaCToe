namespace TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_player1 = new Label();
            lbl_player2 = new Label();
            txt_player1 = new TextBox();
            txt_player2 = new TextBox();
            lbl_tictactoe = new Label();
            btn_startgame = new Button();
            rb_player1x = new RadioButton();
            rb_player1o = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            rb_player2x = new RadioButton();
            rb_player2o = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_player1
            // 
            lbl_player1.AutoSize = true;
            lbl_player1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_player1.Location = new Point(246, 191);
            lbl_player1.Name = "lbl_player1";
            lbl_player1.Size = new Size(157, 40);
            lbl_player1.TabIndex = 0;
            lbl_player1.Text = "Player1";
            lbl_player1.Click += label1_Click;
            // 
            // lbl_player2
            // 
            lbl_player2.AutoSize = true;
            lbl_player2.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_player2.Location = new Point(423, 191);
            lbl_player2.Name = "lbl_player2";
            lbl_player2.Size = new Size(159, 40);
            lbl_player2.TabIndex = 1;
            lbl_player2.Text = "Player2";
            lbl_player2.Click += label2_Click;
            // 
            // txt_player1
            // 
            txt_player1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_player1.Location = new Point(246, 332);
            txt_player1.Name = "txt_player1";
            txt_player1.Size = new Size(157, 37);
            txt_player1.TabIndex = 2;
            // 
            // txt_player2
            // 
            txt_player2.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_player2.Location = new Point(423, 332);
            txt_player2.Name = "txt_player2";
            txt_player2.Size = new Size(157, 37);
            txt_player2.TabIndex = 3;
            // 
            // lbl_tictactoe
            // 
            lbl_tictactoe.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_tictactoe.Location = new Point(169, 81);
            lbl_tictactoe.Name = "lbl_tictactoe";
            lbl_tictactoe.Size = new Size(493, 73);
            lbl_tictactoe.TabIndex = 4;
            lbl_tictactoe.Text = "Tic-Tac-Toe";
            lbl_tictactoe.TextAlign = ContentAlignment.MiddleCenter;
            lbl_tictactoe.Click += label1_Click_1;
            // 
            // btn_startgame
            // 
            btn_startgame.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_startgame.ForeColor = Color.FromArgb(0, 192, 0);
            btn_startgame.Location = new Point(137, 399);
            btn_startgame.Name = "btn_startgame";
            btn_startgame.Size = new Size(566, 97);
            btn_startgame.TabIndex = 5;
            btn_startgame.Text = "Start Game";
            btn_startgame.UseVisualStyleBackColor = true;
            btn_startgame.Click += button1_Click;
            // 
            // rb_player1x
            // 
            rb_player1x.Location = new Point(6, 12);
            rb_player1x.Name = "rb_player1x";
            rb_player1x.Size = new Size(56, 38);
            rb_player1x.TabIndex = 8;
            rb_player1x.TabStop = true;
            rb_player1x.Text = "X";
            rb_player1x.UseVisualStyleBackColor = true;
            rb_player1x.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // rb_player1o
            // 
            rb_player1o.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rb_player1o.Location = new Point(68, 12);
            rb_player1o.Name = "rb_player1o";
            rb_player1o.Size = new Size(52, 38);
            rb_player1o.TabIndex = 9;
            rb_player1o.TabStop = true;
            rb_player1o.Text = "O";
            rb_player1o.UseVisualStyleBackColor = true;
            rb_player1o.CheckedChanged += rb_player1o_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_player1x);
            groupBox1.Controls.Add(rb_player1o);
            groupBox1.Location = new Point(246, 254);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(157, 56);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rb_player2x);
            groupBox2.Controls.Add(rb_player2o);
            groupBox2.Location = new Point(423, 254);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(159, 56);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // rb_player2x
            // 
            rb_player2x.Location = new Point(6, 12);
            rb_player2x.Name = "rb_player2x";
            rb_player2x.Size = new Size(56, 38);
            rb_player2x.TabIndex = 8;
            rb_player2x.TabStop = true;
            rb_player2x.Text = "X";
            rb_player2x.UseVisualStyleBackColor = true;
            rb_player2x.CheckedChanged += rb_player2x_CheckedChanged;
            // 
            // rb_player2o
            // 
            rb_player2o.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rb_player2o.Location = new Point(68, 12);
            rb_player2o.Name = "rb_player2o";
            rb_player2o.Size = new Size(52, 38);
            rb_player2o.TabIndex = 9;
            rb_player2o.TabStop = true;
            rb_player2o.Text = "O";
            rb_player2o.UseVisualStyleBackColor = true;
            rb_player2o.CheckedChanged += rb_player2o_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(816, 508);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_startgame);
            Controls.Add(lbl_tictactoe);
            Controls.Add(txt_player2);
            Controls.Add(txt_player1);
            Controls.Add(lbl_player2);
            Controls.Add(lbl_player1);
            Font = new Font("Showcard Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_player1;
        private Label lbl_player2;
        private TextBox txt_player1;
        private TextBox txt_player2;
        private Label lbl_tictactoe;
        private Button btn_startgame;
        private RadioButton rb_player1x;
        private RadioButton rb_player1o;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rb_player2x;
        private RadioButton rb_player2o;
    }
}
