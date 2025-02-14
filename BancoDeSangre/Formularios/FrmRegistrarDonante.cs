﻿using AppCore.Interfaces;
using AppCore.Services;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeSangre.Formularios
{
    public partial class FrmRegistrarDonante : Form
    {
        public IDonanteService donanteModel { get; set; }
        public FrmRegistrarDonante()
        {
            InitializeComponent();
        }

        private void FrmRegistrarDonante_Load(object sender, EventArgs e)
        {
            cmbGrupoSanguineo.Items.AddRange(Enum.GetValues(typeof(GrupoSanguineo)).Cast<object>().ToArray());
            cmbGenero.Items.AddRange(Enum.GetValues(typeof(Genero)).Cast<object>().ToArray());
            cmbEstadoCivil.Items.AddRange(Enum.GetValues(typeof(EstadoCivil)).Cast<object>().ToArray());
            cmbFactorRH.Items.AddRange(Enum.GetValues(typeof(FactorRH)).Cast<object>().ToArray());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Donante donante = new Donante()
            //    {
            //        Id = donanteModel.GetLastId() + 1,
            //        Nombre = txtNombre.Text,
            //        Apellido = txtApellidos.Text,
            //        Cedula = txtCedula.Text,
            //        Correo = txtCorreo.Text,
            //        FactorRH = (FactorRH)cmbFactorRH.SelectedIndex,
            //        EstadoCivil = (EstadoCivil)cmbEstadoCivil.SelectedIndex,
            //        FechaNacimiento = dtpFechaNacimiento.Value,
            //        GrupoSanguineo = (GrupoSanguineo)cmbGrupoSanguineo.SelectedIndex,
            //        Genero = (Genero)cmbGenero.SelectedIndex,
            //        Telefono = txtTelefono.Text,
            //        Ocupacion = txtOcupacion.Text,
            //    };

            //    donanteModel.Create(donante);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error: {ex}");
            //}

            if (cmbEstadoCivil.SelectedIndex == -1)
            {
                MessageBox.Show("Error, todos los campos son necesarios","Mensaje de Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (cmbFactorRH.SelectedIndex==-1)
            {
                MessageBox.Show("Error, todos los campos son necesarios", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbGenero.SelectedIndex==-1)
            {
                MessageBox.Show("Error, todos los campos son necesarios", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbGrupoSanguineo.SelectedIndex == -1)
            {
                MessageBox.Show("Error, todos los campos son necesarios", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string patronCedula = @"\A[0-9]{3}(\-)[0-9]{6}(\-)[0-9]{4}[A-Z]\Z";
            if (!Regex.IsMatch(txtCedula.Text, patronCedula))
            {
                MessageBox.Show("Error, cédula ingresada invalida", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string patronTelefono = @"\A[0-9]{7,10}\z";
            if(!Regex.IsMatch(txtTelefono.Text, patronTelefono))
            {
                MessageBox.Show("Error, telefono ingresado invalido","Mensaje de Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrEmpty(txtCedula.Text)
                || string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtOcupacion.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Error, se requieren de todos los campos", "Mensaje de Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Donante donante = new Donante()
            {
                Id = donanteModel.GetLastId() + 1,
                Nombre = txtNombre.Text,
                Apellido = txtApellidos.Text,
                Cedula = txtCedula.Text,
                Correo = txtCorreo.Text,
                FactorRH = (FactorRH)cmbFactorRH.SelectedIndex,
                EstadoCivil = (EstadoCivil)cmbEstadoCivil.SelectedIndex,
                FechaNacimiento = dtpFechaNacimiento.Value,
                GrupoSanguineo = (GrupoSanguineo)cmbGrupoSanguineo.SelectedIndex,
                Genero = (Genero)cmbGenero.SelectedIndex,
                Telefono = txtTelefono.Text,
                Ocupacion = txtOcupacion.Text
            };
            donanteModel.Create(donante);
            LimpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCedula.Clear();
            txtCorreo.Clear();
            txtOcupacion.Clear();
            txtTelefono.Clear();
            cmbEstadoCivil.SelectedIndex = -1;
            cmbFactorRH.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
            cmbGrupoSanguineo.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbGrupoSanguineo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

