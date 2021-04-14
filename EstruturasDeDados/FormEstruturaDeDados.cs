using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EstruturasDeDados
{
    public partial class frmEstruturaDeDados : Form
    {
        public frmEstruturaDeDados()
        {
            InitializeComponent();
        }

        private void btnVetor_Click(object sender, EventArgs e)
        {
            int[] vetor = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            dgvDados.DataSource = vetor;
        }
    }
}
