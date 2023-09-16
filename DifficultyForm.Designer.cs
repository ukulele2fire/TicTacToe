
namespace TicTacToe
{
    partial class DifficultyForm
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
            this.easyBtn = new System.Windows.Forms.Button();
            this.normalBtn = new System.Windows.Forms.Button();
            this.impossibleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // easyBtn
            // 
            this.easyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.easyBtn.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.easyBtn.Location = new System.Drawing.Point(49, 12);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(178, 53);
            this.easyBtn.TabIndex = 0;
            this.easyBtn.Text = "Easy";
            this.easyBtn.UseVisualStyleBackColor = true;
            this.easyBtn.Click += new System.EventHandler(this.easyBtn_Click);
            // 
            // normalBtn
            // 
            this.normalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.normalBtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.normalBtn.Location = new System.Drawing.Point(49, 71);
            this.normalBtn.Name = "normalBtn";
            this.normalBtn.Size = new System.Drawing.Size(178, 55);
            this.normalBtn.TabIndex = 1;
            this.normalBtn.Text = "Normal";
            this.normalBtn.UseVisualStyleBackColor = true;
            this.normalBtn.Click += new System.EventHandler(this.normalBtn_Click);
            // 
            // impossibleBtn
            // 
            this.impossibleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.impossibleBtn.ForeColor = System.Drawing.Color.MediumOrchid;
            this.impossibleBtn.Location = new System.Drawing.Point(49, 132);
            this.impossibleBtn.Name = "impossibleBtn";
            this.impossibleBtn.Size = new System.Drawing.Size(178, 54);
            this.impossibleBtn.TabIndex = 2;
            this.impossibleBtn.Text = "Impossible";
            this.impossibleBtn.UseVisualStyleBackColor = true;
            this.impossibleBtn.Click += new System.EventHandler(this.impossibleBtn_Click);
            // 
            // DifficultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 196);
            this.Controls.Add(this.impossibleBtn);
            this.Controls.Add(this.normalBtn);
            this.Controls.Add(this.easyBtn);
            this.Name = "DifficultyForm";
            this.Text = "DifficultyForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button easyBtn;
        private System.Windows.Forms.Button normalBtn;
        private System.Windows.Forms.Button impossibleBtn;
    }
}