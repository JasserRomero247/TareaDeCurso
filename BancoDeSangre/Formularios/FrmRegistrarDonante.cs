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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeSangre.Formularios
{
    public partial class FrmRegistrarDonante : Form
    {
        public DonanteRepository donanteModel { get; set; }
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

            if (string.IsNullOrEmpty(txtNombre.Text)||string.IsNullOrEmpty(txtApellidos.Text)||string.IsNullOrEmpty(txtCedula.Text)
                || string.IsNullOrEmpty(txtCorreo.Text)||string.IsNullOrEmpty(txtOcupacion.Text)||string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Error, se requieren de todos los campos","Mensaje de Error", MessageBoxButtons.OK,
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
            Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
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
    }
}

