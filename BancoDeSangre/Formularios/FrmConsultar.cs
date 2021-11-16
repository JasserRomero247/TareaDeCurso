﻿using AppCore.Services;
using Domain.Entities;
using Domain.Enums;
using Infraestructure.Donantes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeSangre.Formularios
{
    public partial class FrmConsultar : Form
    {
        public DonanteRepository donanteService { get; set; }
        public FrmConsultar()
        {
            InitializeComponent();
        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            dtgListaDonantes.DataSource = null;
            dtgListaDonantes.DataSource = donanteService.GetAll();

            cmbBusquedas.Items.AddRange(Enum.GetValues(typeof(BusquedaDonante)).Cast<object>().ToArray());
            cmbGrupoSanguineo.Items.AddRange(Enum.GetValues(typeof(GrupoSanguineo)).Cast<object>().ToArray());
        }



        private DataTable ConvertToDataTable()
        {
            DataTable dt = new DataTable();
            foreach(DataGridViewColumn col in dtgListaDonantes.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach(DataGridViewRow row in dtgListaDonantes.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach(DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            return dt;
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            List<Donante> donantes = new List<Donante>();
            GrupoSanguineo grupoSanguineo;
            if(e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
                {
                    dtgListaDonantes.DataSource = donanteService.GetAll();
                    return;
                }

                //DataTable dt = ConvertToDataTable();
                //dt.DefaultView.RowFilter = string.Format("Nombre LIKE '*{0}*' OR Cedula LIKE '*{0}*' OR Id = '{0}'", txtBusqueda.Text);
                //BindingSource bs = new BindingSource();
                //bs.DataSource = dt;
                //dtgListaDonantes.DataSource = bs;

                try
                {
                    switch (cmbBusquedas.SelectedIndex)
                    {
                        case 0:
                            donantes = donanteService.GetAll();
                            var filtrado = (from x in donantes
                                            where (x.Id >= 0) && x.Id == Convert.ToInt32(txtBusqueda.Text)
                                            select x).ToList();
                            dtgListaDonantes.DataSource = filtrado;
                            break;
                        case 1:
                            donantes = donanteService.GetAll();
                            filtrado = (from x in donantes
                                            where (x.Cedula != null) && x.Cedula.StartsWith(txtBusqueda.Text)
                                            select x).ToList();
                            dtgListaDonantes.DataSource = filtrado;
                            break;
                        case 2:
                            donantes = donanteService.GetAll();
                            filtrado = (from x in donantes
                                            where (x.Nombre != null) && x.Nombre.StartsWith(txtBusqueda.Text)
                                            select x).ToList();
                            dtgListaDonantes.DataSource = filtrado;
                            break;
                        case 3:
                            donantes = donanteService.GetAll();
                            filtrado = (from x in donantes
                                            where (x.GrupoSanguineo >= 0) && x.GrupoSanguineo.Equals((GrupoSanguineo)cmbGrupoSanguineo.SelectedIndex)
                                            select x).ToList();
                            dtgListaDonantes.DataSource = filtrado;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cmbBusquedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBusquedas.SelectedIndex)
            {
                case 0:
                    pnlCombobox.Visible = false;
                    pnlTextbox.Visible = true;
                    break;
                case 1:
                    pnlCombobox.Visible = false;
                    pnlTextbox.Visible = true;
                    break;
                case 2:
                    pnlCombobox.Visible = false;
                    pnlTextbox.Visible = true;
                    break;
                case 3:
                    pnlCombobox.Visible = true;
                    pnlTextbox.Visible = false;
                    break;
            }
        }

        private void cmbGrupoSanguineo_KeyDown(object sender, KeyEventArgs e)
        {
            List<Donante> donantes = new List<Donante>();
            if(e.KeyCode == Keys.Enter)
            {
                if(cmbGrupoSanguineo.SelectedIndex == -1)
                {
                    dtgListaDonantes.DataSource = donantes;
                    MessageBox.Show("Error, no ha selecciona una opción", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                donantes = donanteService.GetAll();
                var filtrado = (from x in donantes
                            where (x.GrupoSanguineo >= 0) && x.GrupoSanguineo.Equals((GrupoSanguineo)cmbGrupoSanguineo.SelectedIndex)
                            select x).ToList();
                dtgListaDonantes.DataSource = filtrado;
            }
        }
    }
}
