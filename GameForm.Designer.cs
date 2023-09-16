
namespace TicTacToe
{
    partial class GameForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.difficultyBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button1.Location = new System.Drawing.Point(13, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 122);
            this.button1.TabIndex = 0;
            this.button1.Tag = "0,0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button3.Location = new System.Drawing.Point(248, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 122);
            this.button3.TabIndex = 2;
            this.button3.Tag = "0,2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button4.Location = new System.Drawing.Point(13, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 116);
            this.button4.TabIndex = 3;
            this.button4.Tag = "1,0";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button5.Location = new System.Drawing.Point(131, 130);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 116);
            this.button5.TabIndex = 4;
            this.button5.Tag = "1,1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button6.Location = new System.Drawing.Point(248, 130);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 116);
            this.button6.TabIndex = 5;
            this.button6.Tag = "1,2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button7.Location = new System.Drawing.Point(13, 242);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 114);
            this.button7.TabIndex = 6;
            this.button7.Tag = "2,0";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button8.Location = new System.Drawing.Point(131, 242);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 114);
            this.button8.TabIndex = 7;
            this.button8.Tag = "2,1";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button9.Location = new System.Drawing.Point(248, 242);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(122, 114);
            this.button9.TabIndex = 8;
            this.button9.Tag = "2,2";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Btn_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.resultLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.resultLabel.Location = new System.Drawing.Point(376, 32);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(205, 121);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.Text = "TIC-TAC-TOE";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newGameBtn
            // 
            this.newGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.newGameBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newGameBtn.Location = new System.Drawing.Point(384, 183);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(186, 53);
            this.newGameBtn.TabIndex = 10;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.quitBtn.ForeColor = System.Drawing.Color.Maroon;
            this.quitBtn.Location = new System.Drawing.Point(384, 303);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(186, 53);
            this.quitBtn.TabIndex = 11;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // difficultyBtn
            // 
            this.difficultyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.difficultyBtn.Location = new System.Drawing.Point(384, 242);
            this.difficultyBtn.Name = "difficultyBtn";
            this.difficultyBtn.Size = new System.Drawing.Size(186, 55);
            this.difficultyBtn.TabIndex = 12;
            this.difficultyBtn.Text = "Difficulty";
            this.difficultyBtn.UseVisualStyleBackColor = true;
            this.difficultyBtn.Click += new System.EventHandler(this.difficultyBtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button2.Location = new System.Drawing.Point(131, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 120);
            this.button2.TabIndex = 1;
            this.button2.Tag = "0,1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 379);
            this.Controls.Add(this.difficultyBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "GameForm";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button difficultyBtn;
        private System.Windows.Forms.Button button2;
    }
}

