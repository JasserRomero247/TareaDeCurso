﻿
namespace BancoDeSangre.Formularios
{
    partial class FrmAlmacen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbGrupoSanguineo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cpbProgresoAlmacen = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGrupoSanguineo
            // 
            this.cmbGrupoSanguineo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupoSanguineo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cmbGrupoSanguineo.FormattingEnabled = true;
            this.cmbGrupoSanguineo.Location = new System.Drawing.Point(214, 86);
            this.cmbGrupoSanguineo.Name = "cmbGrupoSanguineo";
            this.cmbGrupoSanguineo.Size = new System.Drawing.Size(155, 25);
            this.cmbGrupoSanguineo.TabIndex = 2;
            this.cmbGrupoSanguineo.SelectedIndexChanged += new System.EventHandler(this.cmbGrupoSanguineo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione grupo sanguíneo:";
            // 
            // cpbProgresoAlmacen
            // 
            this.cpbProgresoAlmacen.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbProgresoAlmacen.AnimationSpeed = 500;
            this.cpbProgresoAlmacen.BackColor = System.Drawing.Color.Transparent;
            this.cpbProgresoAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbProgresoAlmacen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbProgresoAlmacen.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbProgresoAlmacen.InnerMargin = 2;
            this.cpbProgresoAlmacen.InnerWidth = -1;
            this.cpbProgresoAlmacen.Location = new System.Drawing.Point(383, 116);
            this.cpbProgresoAlmacen.MarqueeAnimationSpeed = 2000;
            this.cpbProgresoAlmacen.Name = "cpbProgresoAlmacen";
            this.cpbProgresoAlmacen.OuterColor = System.Drawing.Color.Silver;
            this.cpbProgresoAlmacen.OuterMargin = -25;
            this.cpbProgresoAlmacen.OuterWidth = 26;
            this.cpbProgresoAlmacen.ProgressColor = System.Drawing.Color.Red;
            this.cpbProgresoAlmacen.ProgressWidth = 25;
            this.cpbProgresoAlmacen.SecondaryFont = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbProgresoAlmacen.Size = new System.Drawing.Size(366, 295);
            this.cpbProgresoAlmacen.StartAngle = 270;
            this.cpbProgresoAlmacen.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbProgresoAlmacen.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbProgresoAlmacen.SubscriptText = "";
            this.cpbProgresoAlmacen.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbProgresoAlmacen.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbProgresoAlmacen.SuperscriptText = "";
            this.cpbProgresoAlmacen.TabIndex = 4;
            this.cpbProgresoAlmacen.Text = "A+";
            this.cpbProgresoAlmacen.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbProgresoAlmacen.Value = 68;
            this.cpbProgresoAlmacen.Click += new System.EventHandler(this.cpbProgresoAlmacen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total almacenado:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(117, 275);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(29, 45);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mililitros";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(335, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 23);
            this.label14.TabIndex = 15;
            this.label14.Text = "ALMACEN DE SANGRE";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BancoDeSangre.Properties.Resources.mano;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cpbProgresoAlmacen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGrupoSanguineo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlmacen";
            this.Text = "FrmAlmacen";
            this.Load += new System.EventHandler(this.FrmAlmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbGrupoSanguineo;
        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar cpbProgresoAlmacen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}