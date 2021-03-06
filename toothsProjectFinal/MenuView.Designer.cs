﻿using System.Drawing;

namespace toothsProjectFinal
{
    partial class MenuView
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
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarConsultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDentistaApp = new System.Windows.Forms.Label();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odontogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radiogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.pacienteToolStripMenuItem,
            this.odontogramaToolStripMenuItem,
            this.radiogramaToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(126, 450);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStripPrincipal";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.agendaToolStripMenuItem.Text = "Agenda";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.buttonAgenda_Click);
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.alterarConsultarToolStripMenuItem});
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.pacienteToolStripMenuItem.Text = "Usuario";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // alterarConsultarToolStripMenuItem
            // 
            this.alterarConsultarToolStripMenuItem.Name = "alterarConsultarToolStripMenuItem";
            this.alterarConsultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterarConsultarToolStripMenuItem.Text = "Alterar/Consultar";
            this.alterarConsultarToolStripMenuItem.Click += new System.EventHandler(this.buttonAlterarCadastro_Click);
            // 
            // labelDentistaApp
            // 
            this.labelDentistaApp.AutoSize = true;
            this.labelDentistaApp.BackColor = System.Drawing.Color.Transparent;
            this.labelDentistaApp.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDentistaApp.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelDentistaApp.Location = new System.Drawing.Point(346, 188);
            this.labelDentistaApp.Name = "labelDentistaApp";
            this.labelDentistaApp.Size = new System.Drawing.Size(216, 42);
            this.labelDentistaApp.TabIndex = 1;
            this.labelDentistaApp.Text = "Dentista App";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.buttonConsultas_Click);
            // 
            // odontogramaToolStripMenuItem
            // 
            this.odontogramaToolStripMenuItem.Name = "odontogramaToolStripMenuItem";
            this.odontogramaToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.odontogramaToolStripMenuItem.Text = "Odontograma";
            // 
            // radiogramaToolStripMenuItem
            // 
            this.radiogramaToolStripMenuItem.Name = "radiogramaToolStripMenuItem";
            this.radiogramaToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.radiogramaToolStripMenuItem.Text = "Radiograma";
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::toothsProjectFinal.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDentistaApp);
            this.Controls.Add(this.menuStripPrincipal);
            this.Name = "MenuView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.Label labelDentistaApp;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarConsultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odontogramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radiogramaToolStripMenuItem;
    }
}