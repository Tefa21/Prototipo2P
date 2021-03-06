﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        public void AbrirFormEnPanel(object Formhijo)
        {
            if (this.Pnl_Contenedor.Controls.Count > 0)
                this.Pnl_Contenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Pnl_Contenedor.Controls.Add(fh);
            this.Pnl_Contenedor.Tag = fh;
            fh.Show();
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmMantenimiento());
        }
    }
}
