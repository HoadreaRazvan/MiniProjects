﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Album
{
    public partial class Show : Form
    {
        public Show()
        {
            InitializeComponent();
        }

        private void Show_Load(object sender, EventArgs e)
        {
            ControlMasini control = new ControlMasini();

            control.show(lstStatus);

        }

        private void lstStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
