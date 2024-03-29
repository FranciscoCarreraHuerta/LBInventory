﻿using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBInventory
{
    public partial class FormOrdenes : Form
    {
        public delegate void EnviarOrden(string cve);
        public event EnviarOrden Enviar;
        private string etiqueta = "";
        public FormOrdenes(string etiqueta)
        {
            InitializeComponent();
            
            this.etiqueta = etiqueta;
        }

        private void FormPartidas_Load(object sender, EventArgs e)
        {
            
            if (etiqueta == "Compras")
            {
                lblPartida.Text = "Ordenes de Compra";
                RNCompra.ObtenerCompras(dataGridOrdenes);
            }               
            else if (etiqueta == "Ventas")
            {
                lblPartida.Text = "Ordenes de Venta";
                RNVenta.ObtenerVentas(dataGridOrdenes);
            }
                

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridPartida_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Enviar(dataGridOrdenes.CurrentCell.Value.ToString());
            this.Close();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
