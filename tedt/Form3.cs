﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tedt
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        public Form3(string id, string name)
        {
            InitializeComponent();
            label1.Text = id;
            label2.Text = name;
        }
    }
}
