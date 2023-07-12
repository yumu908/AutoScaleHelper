﻿using AutoScaleHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo._7_常用控件测试
{
    public partial class Form_Label : Form
    {
        AutoScale autoScale = new AutoScale(); 
        public Form_Label()
        {
            InitializeComponent();
            autoScale.AutoFont = true;
            autoScale.SetContainer(this);
        }

        private void Form_Label_SizeChanged(object sender, EventArgs e)
        {
            autoScale.UpdateControlsLayout();
        }
    }
}
