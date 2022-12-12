using System;
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
    public partial class MainForm : Form
    {
        public static FacultyForm _facultyForm;

        public static GroupsForm _groupsForm;

        public static StudentsForm _studentsForm;

        public static DisciplinesForm _disciplinesForm;

        public static LearningDisciplinesByStudentsForm _learningDisciplinesByStudentsForm;

        public static FacultyForm FacultyForm
        {
            get
            {
                if (_facultyForm is null
                    || _facultyForm.IsDisposed)
                {
                    return _facultyForm = new FacultyForm();
                }
                else
                {
                    return _facultyForm;
                }
            }
        }

        public static GroupsForm GroupsForm
        {
            get
            {
                if (_groupsForm is null
                    || _groupsForm.IsDisposed)
                {
                    return _groupsForm = new GroupsForm();
                }
                else
                {
                    return _groupsForm;
                }
            }
        }
        
        public static StudentsForm StudentsForm
        {
            get
            {
                if (_studentsForm is null
                    || _studentsForm.IsDisposed)
                {
                    return _studentsForm = new StudentsForm();
                }
                else
                {
                    return _studentsForm;
                }
            }
        }
        
        public static DisciplinesForm DisciplinesForm
        {
            get
            {
                if (_disciplinesForm is null
                    || _disciplinesForm.IsDisposed)
                {
                    return _disciplinesForm = new DisciplinesForm();
                }
                else
                {
                    return _disciplinesForm;
                }
            }
        }

        public static LearningDisciplinesByStudentsForm LearningDisciplinesByStudentsForm
        {
            get
            {
                if (_learningDisciplinesByStudentsForm is null
                    || _learningDisciplinesByStudentsForm.IsDisposed)
                {
                    return _learningDisciplinesByStudentsForm = new LearningDisciplinesByStudentsForm();
                }
                else
                {
                    return _learningDisciplinesByStudentsForm;
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?", 
                           "Внимание", 
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                       != DialogResult.Yes;
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КСУП, Лубов Григорий Павлович, 580-2 ,2022",
                "О программе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainForm_FormClosing(sender, new FormClosingEventArgs(
                CloseReason.ApplicationExitCall, true));
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dblabs.Properties.Settings.Default.Save();
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupsForm.Show();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsForm.Show();
        }

        private void disciplinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisciplinesForm.Show();
        }

        private void learningDisciplinesByStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LearningDisciplinesByStudentsForm.Show();
        }

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacultyForm.Show();
        }
    }
}
