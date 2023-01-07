﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dblabs
{
    public partial class GroupsForm : Form
    {
        public GroupsForm()
        {
            InitializeComponent();
        }

        private void группыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.группыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.facultyDataSet);

        }

        private void Groups_Load(object sender, EventArgs e)
        {
            this.студентыTableAdapter.Fill(this.facultyDataSet.Студенты);
            this.студентыTableAdapter.Fill(this.facultyDataSet.Студенты);
            this.группыTableAdapter.Fill(this.facultyDataSet.Группы);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Validate();
            студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.facultyDataSet);
        }
    }
}
