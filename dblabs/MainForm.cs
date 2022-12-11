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
            MessageBox.Show("(C)ТУСУР, КСУП , Лубов Григорий Павлович , 580-2 ,2022",
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
    }
}
