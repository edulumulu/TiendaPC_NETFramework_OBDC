﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2_tema_4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.catalogo_ordenado' Puede moverla o quitarla según sea necesario.
            this.catalogo_ordenadoTableAdapter.Fill(this.dataSet2.catalogo_ordenado);

            this.reportViewer1.RefreshReport();
        }
    }
}
