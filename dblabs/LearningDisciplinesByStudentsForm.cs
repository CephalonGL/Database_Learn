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
    public partial class LearningDisciplinesByStudentsForm : Form
    {
        public LearningDisciplinesByStudentsForm()
        {
            InitializeComponent();
        }

        private void изучение_предметов_студентамиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.изучение_предметов_студентамиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.facultyDataSet);

        }

        private void LearningDisciplinesByStudents_Load(object sender, EventArgs e)
        {
            this.изучение_предметов_студентамиTableAdapter.Fill(this.facultyDataSet.Изучение_предметов_студентами);
        }
    }
}
