﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://www.youtube.com/watch?v=5Anto1N_FSs
namespace sceriffo0
{
    public partial class Tasse1 : Form
    {
        //List<Panel> listPanel = new List<Panel>();
        public Tasse1()
        {
            InitializeComponent();
        }

        private void Tasse1_Load(object sender, EventArgs e)
        {

            //listPanel.Add(panelLogIn);
            panelLogIn.Visible = true;

        }

        private void bottoneAccedi_Click(object sender, EventArgs e)
        {
            panelLogIn.Visible = false;
        }
    }
}