﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_ABSENCE.uc_stagiaire
{
    public partial class uc_ajouter : UserControl
    {
        public uc_ajouter()
        {
            InitializeComponent();
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btxtcin_Click(object sender, EventArgs e)
        {
            txtcin.Text =null;
        }

        private void txtnom_Click(object sender, EventArgs e)
        {
            txtnom.Text = null;
        }

        private void txtprenom_Click(object sender, EventArgs e)
        {
            txtprenom.Text = null;
        }

        private void txttelephone_Click(object sender, EventArgs e)
        {
            txttelephone.Text = null;
        }
    }
}
