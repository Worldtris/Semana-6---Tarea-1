﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _06Publicaciones.Controllers;
namespace _06Publicaciones.Views.Ciudades
{
    public partial class frm_Ciudades : Form
    {
        private string id;
        public frm_Ciudades(string id )
        {
            InitializeComponent();
            this.id = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Ciudades_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(this.id);
            PaisesController _paises = new PaisesController();
            comboBox1.DataSource = _paises.todos();
            comboBox1.DisplayMember = "Detalle";
            comboBox1.ValueMember = "IdPais";
            

        }
    }
}

