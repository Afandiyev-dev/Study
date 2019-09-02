namespace Study
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.label_bal = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_c = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_BSQ = new System.Windows.Forms.CheckBox();
            this.label_bsq = new System.Windows.Forms.Label();
            this.textBox_bsq = new System.Windows.Forms.TextBox();
            this.label_qiymet = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hesabla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_click);
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(239, 196);
            this.textBox_b.Multiline = true;
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(54, 21);
            this.textBox_b.TabIndex = 1;
            this.textBox_b.TextChanged += new System.EventHandler(this.TextBox_b_TextChanged);
            this.textBox_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_b_KeyPress);
            // 
            // label_bal
            // 
            this.label_bal.AutoSize = true;
            this.label_bal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_bal.Location = new System.Drawing.Point(76, 223);
            this.label_bal.Name = "label_bal";
            this.label_bal.Size = new System.Drawing.Size(0, 33);
            this.label_bal.TabIndex = 5;
            this.label_bal.TextChanged += new System.EventHandler(this.button_click);
            // 
            // textBox_a
            // 
            this.textBox_a.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_a.Location = new System.Drawing.Point(239, 169);
            this.textBox_a.Multiline = true;
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(54, 21);
            this.textBox_a.TabIndex = 6;
            this.textBox_a.TextChanged += new System.EventHandler(this.TextBox_a_TextChanged);
            this.textBox_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_a_KeyPress);
            // 
            // textBox_c
            // 
            this.textBox_c.Location = new System.Drawing.Point(239, 223);
            this.textBox_c.Multiline = true;
            this.textBox_c.Name = "textBox_c";
            this.textBox_c.Size = new System.Drawing.Size(54, 21);
            this.textBox_c.TabIndex = 7;
            this.textBox_c.TextChanged += new System.EventHandler(this.TextBox_c_TextChanged);
            this.textBox_c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_c_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "KSQ1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "KSQ2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "KSQ3";
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(153, 60);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(31, 17);
            this.radio2.TabIndex = 11;
            this.radio2.Text = "2";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.Radio2_CheckedChanged);
            this.radio2.Click += new System.EventHandler(this.Radio2_Click);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(202, 60);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(31, 17);
            this.radio3.TabIndex = 12;
            this.radio3.Text = "3";
            this.radio3.UseVisualStyleBackColor = true;
            this.radio3.CheckedChanged += new System.EventHandler(this.Radio3_CheckedChanged);
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Checked = true;
            this.radio4.Location = new System.Drawing.Point(251, 60);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(31, 17);
            this.radio4.TabIndex = 13;
            this.radio4.TabStop = true;
            this.radio4.Text = "4";
            this.radio4.UseVisualStyleBackColor = true;
            this.radio4.CheckedChanged += new System.EventHandler(this.Radio4_CheckedChanged);
            // 
            // textBox_d
            // 
            this.textBox_d.Location = new System.Drawing.Point(239, 250);
            this.textBox_d.Multiline = true;
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(54, 21);
            this.textBox_d.TabIndex = 14;
            this.textBox_d.TextChanged += new System.EventHandler(this.TextBox_d_TextChanged);
            this.textBox_d.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_d_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "KSQ4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Summativ №";
            // 
            // checkBox_BSQ
            // 
            this.checkBox_BSQ.AutoSize = true;
            this.checkBox_BSQ.Location = new System.Drawing.Point(234, 122);
            this.checkBox_BSQ.Name = "checkBox_BSQ";
            this.checkBox_BSQ.Size = new System.Drawing.Size(48, 17);
            this.checkBox_BSQ.TabIndex = 17;
            this.checkBox_BSQ.Text = "BSQ";
            this.checkBox_BSQ.UseVisualStyleBackColor = true;
            this.checkBox_BSQ.Click += new System.EventHandler(this.CheckBox_BSQ_Click);
            // 
            // label_bsq
            // 
            this.label_bsq.AutoSize = true;
            this.label_bsq.Location = new System.Drawing.Point(198, 280);
            this.label_bsq.Name = "label_bsq";
            this.label_bsq.Size = new System.Drawing.Size(29, 13);
            this.label_bsq.TabIndex = 19;
            this.label_bsq.Text = "BSQ";
            this.label_bsq.Visible = false;
            // 
            // textBox_bsq
            // 
            this.textBox_bsq.Location = new System.Drawing.Point(239, 277);
            this.textBox_bsq.Multiline = true;
            this.textBox_bsq.Name = "textBox_bsq";
            this.textBox_bsq.Size = new System.Drawing.Size(54, 21);
            this.textBox_bsq.TabIndex = 18;
            this.textBox_bsq.Visible = false;
            this.textBox_bsq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_bsq_KeyPress);
            // 
            // label_qiymet
            // 
            this.label_qiymet.AutoSize = true;
            this.label_qiymet.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_qiymet.Location = new System.Drawing.Point(124, 266);
            this.label_qiymet.Name = "label_qiymet";
            this.label_qiymet.Size = new System.Drawing.Size(0, 33);
            this.label_qiymet.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(-4, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 33);
            this.label8.TabIndex = 21;
            this.label8.Text = "Bal :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(-4, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 33);
            this.label9.TabIndex = 22;
            this.label9.Text = "Qiymət :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Sıfırla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Study.Properties.Resources.analytics;
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 127);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(300, 371);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_qiymet);
            this.Controls.Add(this.label_bsq);
            this.Controls.Add(this.textBox_bsq);
            this.Controls.Add(this.checkBox_BSQ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.radio4);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_c);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.label_bal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summativ ";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_bal;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_c;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_BSQ;
        private System.Windows.Forms.Label label_bsq;
        private System.Windows.Forms.TextBox textBox_bsq;
        private System.Windows.Forms.Label label_qiymet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
    }
}

