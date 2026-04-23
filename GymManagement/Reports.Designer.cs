namespace GymManagement
{
    partial class Reports
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(323, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox1.Location = new System.Drawing.Point(217, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 45);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(187, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type Member ID:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(776, 79);
            this.label2.TabIndex = 6;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(217, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 57);
            this.button2.TabIndex = 7;
            this.button2.Text = "Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(385, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 57);
            this.button3.TabIndex = 8;
            this.button3.Text = "Activity/Usage";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}