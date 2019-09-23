﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTaxonomico
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            pnlAdmin.Visible = false;
            pnlConsulta.Visible = false;
        }
        private void hideSubMenu()
        {
            if (pnlAdmin.Visible == true)
                pnlAdmin.Visible = false;
            if (pnlConsulta.Visible == true)
                pnlConsulta.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void BtnAdminitracion_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlAdmin);
        }

        private void BtnCadenaCompleta_Click(object sender, EventArgs e)
        {
            //...
            hideSubMenu();
        }

        private void BtnCadenaCatgoria_Click(object sender, EventArgs e)
        {
            //...
            hideSubMenu();
        }

        private void BtnEliminarEspecie_Click(object sender, EventArgs e)
        {
            //...
            hideSubMenu();
        }

        private void BtnConsuta_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlConsulta);
        }

        private void BtnVerEspecie_Click(object sender, EventArgs e)
        {
            //...
            hideSubMenu();
        }

        private void BtnEspecieClase_Click(object sender, EventArgs e)
        {
            //...
            hideSubMenu();
        }

        private void BtnCateProfundidad_Click(object sender, EventArgs e)
        {
            //...
            hideSubMenu();
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            //..
            hideSubMenu();
        }
    }
}
