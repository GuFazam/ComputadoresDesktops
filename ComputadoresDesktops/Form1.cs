using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputadoresDesktops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButtonComputador_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBoxComputador1.Visible = true;
            this.pictureBoxComputador2.Visible = true;
            this.pictureBoxComputador3.Visible = true;

            this.pictureBoxNotebook1.Visible = false;
            this.pictureBoxNotebook2.Visible = false;
            this.pictureBoxNotebook3.Visible = false;

            this.radioButton3.Visible = true;
            this.radioButton4.Visible = true;
            this.radioButton5.Visible = true;

            this.radioButton6.Visible = false;
            this.radioButton7.Visible = false;
            this.radioButton8.Visible = false;

            this.label1.Visible = false;
            this.label2.Visible = false;
        }

        private void radioButtonNotebook_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBoxNotebook1.Visible = true;
            this.pictureBoxNotebook2.Visible = true;
            this.pictureBoxNotebook3.Visible = true;

            this.pictureBoxComputador1.Visible = false;
            this.pictureBoxComputador2.Visible = false;
            this.pictureBoxComputador3.Visible = false;

            this.radioButton3.Visible = false;
            this.radioButton4.Visible = false;
            this.radioButton5.Visible = false;

            this.radioButton6.Visible = true;
            this.radioButton7.Visible = true;
            this.radioButton8.Visible = true;

            this.label1.Visible = false;
            this.label2.Visible = false;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            this.pictureBoxComputador1.Visible = false;
            this.pictureBoxComputador2.Visible = false;
            this.pictureBoxComputador3.Visible = false;

            this.pictureBoxNotebook1.Visible = false;
            this.pictureBoxNotebook2.Visible = false;
            this.pictureBoxNotebook3.Visible = false;

            this.radioButton3.Checked = false;
            this.radioButton4.Checked = false;
            this.radioButton5.Checked = false;

            this.radioButton6.Checked = false;
            this.radioButton7.Checked = false;
            this.radioButton8.Checked = false;

            this.radioButton3.Visible = false;
            this.radioButton4.Visible = false;
            this.radioButton5.Visible = false;

            this.radioButton6.Visible = false;
            this.radioButton7.Visible = false;
            this.radioButton8.Visible = false;

            this.label1.Visible = false;
            this.label2.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBoxComputador1.Visible = true;
            this.radioButton3.Visible = true;

            this.pictureBoxComputador2.Visible = false;
            this.pictureBoxComputador3.Visible = false;
            this.radioButton4.Visible = false;
            this.radioButton5.Visible = false;

            this.label1.Visible = true;
            this.label1.Text = "O computador escolhido: Computador 1 Custa R$: 2.000,00";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBoxComputador2.Visible = true;
            this.radioButton4.Visible = true;

            this.pictureBoxComputador1.Visible = false;
            this.pictureBoxComputador3.Visible = false;
            this.radioButton3.Visible = false;
            this.radioButton5.Visible = false;

            this.label1.Visible = true;
            this.label1.Text = "O computador escolhido: Computador 2 Custa R$: 1.500,00";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBoxComputador3.Visible = true;
            this.radioButton5.Visible = true;

            this.pictureBoxComputador1.Visible = false;
            this.pictureBoxComputador2.Visible = false;
            this.radioButton3.Visible = false;
            this.radioButton4.Visible = false;

            this.label1.Visible = true;
            this.label1.Text = "O computador escolhido: Computador 3 Custa R$: 2.500,00";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBoxNotebook1.Visible = true;
            this.radioButton6.Visible = true;

            this.pictureBoxNotebook2.Visible = false;
            this.pictureBoxNotebook3.Visible = false;
            this.radioButton7.Visible = false;
            this.radioButton8.Visible = false;

            this.label2.Visible = true;
            this.label2.Text = "O Notebook escolhido: Notebook 1 Custa R$: 1.750,00";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBoxNotebook2.Visible = true;
            this.radioButton7.Visible = true;

            this.pictureBoxNotebook1.Visible = false;
            this.pictureBoxNotebook3.Visible = false;
            this.radioButton6.Visible = false;
            this.radioButton8.Visible = false;

            this.label2.Visible = true;
            this.label2.Text = "O Notebook escolhido: Notebook 2 Custa R$: 2.900,00";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBoxNotebook3.Visible = true;
            this.radioButton8.Visible = true;

            this.pictureBoxNotebook1.Visible = false;
            this.pictureBoxNotebook2.Visible = false;
            this.radioButton6.Visible = false;
            this.radioButton7.Visible = false;

            this.label2.Visible = true;
            this.label2.Text = "O Notebook escolhido: Notebook 3 Custa R$: 1.550,00";
        }
    }
    }
