namespace quizGame
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            lblQuestion = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(8, 514);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(414, 58);
            button1.TabIndex = 1;
            button1.Tag = "1";
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ClickAnswerEvent;
            // 
            // button2
            // 
            button2.Location = new Point(505, 514);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(414, 58);
            button2.TabIndex = 1;
            button2.Tag = "2";
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ClickAnswerEvent;
            // 
            // button3
            // 
            button3.Location = new Point(8, 590);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(414, 58);
            button3.TabIndex = 1;
            button3.Tag = "3";
            button3.Text = "button1";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ClickAnswerEvent;
            // 
            // button4
            // 
            button4.Location = new Point(505, 590);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(414, 58);
            button4.TabIndex = 1;
            button4.Tag = "4";
            button4.Text = "button1";
            button4.UseVisualStyleBackColor = true;
            button4.Click += ClickAnswerEvent;
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(8, 462);
            lblQuestion.Margin = new Padding(4, 0, 4, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(925, 49);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "Question";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            lblQuestion.Click += lblQuestion_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Yellow;
            pictureBox2.Image = Properties.Resources.questions;
            pictureBox2.Location = new Point(25, 98);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(894, 351);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 42);
            label1.Name = "label1";
            label1.Size = new Size(94, 35);
            label1.TabIndex = 3;
            label1.Text = "Total de Pontos: ";
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 665);
            Controls.Add(label1);
            Controls.Add(lblQuestion);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Simple Quiz Game MOO ICT";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblQuestion;
        private PictureBox pictureBox2;
        private Label label1;
    }
}
