﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treeDiM.StackBuilder.ExcelListEvaluator
{
    public partial class FormOptionsSettings : GLib.Options.OptionsForm
    {
        public FormOptionsSettings()
        {
            InitializeComponent();

            Panels.Add(new OptionsPanelFiltering());
        }
    }
}
