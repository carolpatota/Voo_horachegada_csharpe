using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3935_Carolina_T01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_bx1.ResetText();
            txt_bx2.ResetText();
            txt_bx3.ResetText();
            txt_bx4.ResetText();
            lbl_hora_resultado.ResetText();
            lbl_min_resultado.ResetText();
            lbl_text_resultado.ResetText();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int h_part;
            int min_part;
            int h_dur;
            int min_dur;
            

            try
            {
                h_part = int.Parse(txt_bx1.Text);
                min_part = int.Parse(txt_bx2.Text);
                h_dur = int.Parse(txt_bx3.Text);
                min_dur = int.Parse(txt_bx4.Text);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
             return;
            }
           
            int h_chegada = h_part + h_dur;
            int h_adicional;

            if (h_chegada > 23)
            {
                h_adicional = h_chegada - 23;
                lbl_hora_resultado.Text = h_adicional.ToString();
                lbl_text_resultado.Text = "Seu voo ira chegar no dia seguinte";
            }
            else
            {
                lbl_hora_resultado.Text = h_chegada.ToString();
                lbl_text_resultado.Text = "Seu voo ira chegar no mesmo dia";
            }

            int min_chegada = min_part + min_dur;
            int min_adicional;

            if (min_chegada >= 60)
            {
                min_adicional = min_chegada - 60;
                h_chegada++; //incrementa na hora de chegada
                lbl_min_resultado.Text = min_adicional.ToString();
                
            }
            else
            {
                lbl_min_resultado.Text = min_chegada.ToString();
            }
        }

        private void txt_bx1_KeyPress(object sender, KeyPressEventArgs e) //garantir que o objeto inserido ]e um digito
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_bx2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_bx3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_bx4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_bx1_Validating(object sender, CancelEventArgs e)
        {
            int h_part = int.Parse(txt_bx1.Text);

            if (h_part < 0 || h_part > 23)
            {
                MessageBox.Show("Deve inserir um numero entre 0 e 23", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_bx2_Validating(object sender, CancelEventArgs e)
        {
            int min_part = int.Parse(txt_bx2.Text);

            if(min_part < 0 || min_part > 59)
            {
                MessageBox.Show("Deve inserir um numero entre 0 e 59", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_bx3_Validating(object sender, CancelEventArgs e)
        {
            int h_dur = int.Parse(txt_bx3.Text);

            if (h_dur < 0 || h_dur > 23)
            {
                MessageBox.Show("Deve inserir um numero entre 0 e 23", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_bx4_Validating(object sender, CancelEventArgs e)
        {
            int min_dur = int.Parse(txt_bx4.Text); //transformar o texto em numero

            if (min_dur < 0 || min_dur > 59)
            {
                MessageBox.Show("Deve inserir um numero entre 0 e 23", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
