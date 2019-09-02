using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_a.Text) || string.IsNullOrWhiteSpace(textBox_b.Text) )
            {
                MessageBox.Show("Məlumatları daxil edin !");
                return;


            }


            //string var1,var2;
            //var1 =textBox_a.Text ;
            //var2 =textBox_b.Text;
            //int a, b, c,d; 
            float a,b,c,z,bsq,bs_res,t,f,d;
            //double f = 0.0d;//qiymet
            
            a = float.Parse(textBox_a.Text); // Привязываем переменные к текстбоксу и конвертируем текст в интегер
            b = float.Parse(textBox_b.Text); //

            if (a >= 101 || b >= 101 )
            {
                MessageBox.Show("Daxil edilen reqem 100 den coxdur");
                return;
            }
            

            

            {

                if (radio2.Checked)
                {
                    f = (a + b) / 2;
                    f = (float)System.Math.Round(f, 3);
                    if (checkBox_BSQ.Checked == true ) {

                        if (string.IsNullOrWhiteSpace(textBox_bsq.Text ))
                        {
                            MessageBox.Show("Məlumatları daxil edin !");
                            return;
                        }

                        bsq = float.Parse(textBox_bsq.Text);
                        if (bsq >=101)
                        {
                            MessageBox.Show("Daxil edilen reqem 100 den coxdur");
                        }
                        // bsq bali
                        bs_res = bsq * 0.6f; // bsq bali * 0.6 ve bs_res saxlanilir
                        t = f * 0.4f; // ksq ortalma ballari * 0.4 , t de saxlanilir
                       f = bs_res + t; // yekun bal sum da saxlanilir
                        f = (float)System.Math.Round(f, 3);

                    }
                    else 

                        if (f <= 30)
                        {
                            z = 2;
                            label_bal.Text = Convert.ToString(f);
                            label_qiymet.Text = Convert.ToString(z);
                        }
                        if (f >= 30.5 && f <= 60)
                        {
                            z = 3;
                            label_bal.Text = Convert.ToString(f);
                            label_qiymet.Text = Convert.ToString(z);
                        }
                        if (f >= 60.5 && f <= 80)
                        {
                            z = 4;
                            label_bal.Text = Convert.ToString(f);
                            label_qiymet.Text = Convert.ToString(z);
                        }
                        if (f >= 80.5 && f <= 100)
                        {
                            z = 5;
                            label_bal.Text = Convert.ToString(f);
                            label_qiymet.Text = Convert.ToString(z);
                        }

                    }
                
                else if (radio3.Checked)
                {
                    if (string.IsNullOrWhiteSpace(textBox_a.Text) || string.IsNullOrWhiteSpace(textBox_b.Text) || string.IsNullOrWhiteSpace(textBox_c.Text))
                    {
                        MessageBox.Show("Məlumatları daxil edin !");
                        return;


                    }
                    c = float.Parse(textBox_c.Text);


                    if (c >= 101 )
                    {
                        MessageBox.Show("Daxil edilen reqem 100 den coxdur");
                        return;
                    }
                    
                    f = (a + b + c) / 3;
                    f = (float)System.Math.Round(f, 3);

                    if (checkBox_BSQ.Checked == true)
                    {
                        if (string.IsNullOrWhiteSpace(textBox_bsq.Text))
                            {
                            MessageBox.Show("Məlumatları daxil edin !");
                            return;
                        }

                        bsq = float.Parse(textBox_bsq.Text);
                        if (bsq >= 101)
                        {
                            MessageBox.Show("Daxil edilen reqem 100 den coxdur");

                        }
                        // bsq bali
                        bs_res = bsq * 0.6f; // bsq bali * 0.6 ve bs_res saxlanilir
                        t = f * 0.4f; // ksq ortalma ballari * 0.4 , t de saxlanilir
                        f = bs_res + t; // yekun bal sum da saxlanilir
                        f = (float)System.Math.Round(f, 3);

                    }

                   
                    if (f <= 30)
                    {
                        z = 2;
                        label_bal.Text = Convert.ToString(f);
                        label_qiymet.Text = Convert.ToString(z);
                    }
                    if (f >= 30.5 && f <= 60)
                    {
                        z = 3;
                        label_bal.Text = Convert.ToString(f);
                        label_qiymet.Text = Convert.ToString(z);
                    }
                    if (f >= 60.5 && f <= 80)
                    {
                        z = 4;
                        label_bal.Text = Convert.ToString(f);
                        label_qiymet.Text = Convert.ToString(z);
                    }
                    if (f >= 80.5 && f <= 100)
                    {
                        z = 5;
                        label_bal.Text = Convert.ToString(f);
                        label_qiymet.Text = Convert.ToString(z);
                    }

                }
                else if (radio4.Checked)

                {

                    if (string.IsNullOrWhiteSpace(textBox_a.Text) || string.IsNullOrWhiteSpace(textBox_b.Text) || string.IsNullOrWhiteSpace(textBox_c.Text) || string.IsNullOrWhiteSpace(textBox_d.Text))
                    {
                        MessageBox.Show("Məlumatları daxil edin !");
                        return;


                    }
                    c = int.Parse(textBox_c.Text);
                    d = int.Parse(textBox_d.Text);

                    if (c >= 101 || d >= 101 )
                    {
                        MessageBox.Show("Daxil edilen reqem 100 den coxdur");
                    }
                    f = (a + b + c + d) / 4;
                    f = (float)System.Math.Round(f, 3); // after dot. 3 values
                    if (checkBox_BSQ.Checked == true)
                    {
                        if (string.IsNullOrWhiteSpace(textBox_bsq.Text))
                        {
                            MessageBox.Show("Məlumatları daxil edin !");
                            return;
                        }

                        bsq = float.Parse(textBox_bsq.Text);
                        if (bsq >= 101)
                        {
                            MessageBox.Show("Daxil edilen reqem 100 den coxdur");
                            
                            return;
                        }
                        // bsq bali
                        bs_res = bsq * 0.6f; // bsq bali * 0.6 ve bs_res saxlanilir
                        t = f * 0.4f; // ksq ortalma ballari * 0.4 , t de saxlanilir
                        f = bs_res + t;
                        f = (float)System.Math.Round(f, 3);// yekun bal sum da saxlanilir


                    }
                    if (f <= 30)
                    {
                        z = 2;
                        label_bal.Text = Convert.ToString(f);
                        label_qiymet.Text = Convert.ToString(z);
                    }
                    if (f >= 30.5 && f <= 60)
                    {
                        z = 3;
                        label_bal.Text = Convert.ToString(f);
                        label_qiymet.Text = Convert.ToString(z);
                    }
                    if (f >= 60.5 && f <= 80)
                    {
                        z = 4;
                        label_bal.Text = Convert.ToString(f);
                        label_qiymet.Text = Convert.ToString(z);
                    }
                    if (f >= 80.5 && f <= 100)
                    {
                        z = 5;
                        label_bal.Text = Convert.ToString(f);
                        label_qiymet.Text = Convert.ToString(z);
                    }
                }








                    //int.TryParse(d, out c);
                    // f = (a + b + c + d) / 4;
                    // label1.Text = Convert.ToString(f);

                    //label1.ForeColor = Color.Orange;
                }

        }

        private void TextBox_a_TextChanged(object sender, EventArgs e)
        {
            textBox_a.MaxLength = 3;
            textBox_a.BackColor = Color.Orange;
        }

        private void TextBox_b_TextChanged(object sender, EventArgs e)
        {
            textBox_b.BackColor = Color.Gold;
            textBox_b.MaxLength = 3;
        }

        private void TextBox_c_TextChanged(object sender, EventArgs e)
        {
            textBox_c.BackColor = Color.Aqua;
            textBox_c.MaxLength = 3;
        }

        private void TextBox_d_TextChanged(object sender, EventArgs e)
        {
            textBox_d.BackColor = Color.LightSteelBlue;
            textBox_d.MaxLength = 3;
        }


        private void Radio2_CheckedChanged(object sender, EventArgs e)
        {
            textBox_c.Visible = false;
            textBox_d.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }

        private void Radio3_CheckedChanged(object sender, EventArgs e)
        {
            textBox_c.Visible = true;
            label4.Visible = true;
            textBox_d.Visible = false;
            label5.Visible = false;
        }

        private void Radio4_CheckedChanged(object sender, EventArgs e)
        {
            textBox_c.Visible = true;
            label4.Visible = true;
            textBox_d.Visible = true;
            label5.Visible = true;
        }

        private void CheckBox_BSQ_Click(object sender, EventArgs e)
        {
            if (checkBox_BSQ.Checked)
            {
                textBox_bsq.Visible = true;
                label_bsq.Visible = true;
            }

            else
            {
                textBox_bsq.Visible = false;
                label_bsq.Visible = false;
            }
        }

        private void Radio2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox_a.Clear();
            textBox_a.BackColor = Color.White;
            textBox_b.Clear();
            textBox_b.BackColor = Color.White;
            textBox_c.Clear();
            textBox_c.BackColor = Color.White;
            textBox_d.Clear();
            textBox_d.BackColor = Color.White;
            textBox_bsq.Clear();
            textBox_bsq.BackColor = Color.White;
            return;
        }

        private void TextBox_a_KeyPress(object sender, KeyPressEventArgs e)  // insert only numbers
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
        }

        private void TextBox_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                
                e.Handled = true;
            }
        }

        private void TextBox_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TextBox_d_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TextBox_bsq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Hazırladı : Tahir Afandiyev",
                             " afandiyev.t@yahoo.com");
               
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}