using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace dblabs
{
    public partial class GroupsForm : Form
    {
        public GroupsForm()
        {
            InitializeComponent();
        }

        DataTable FillDataGridView(string sqlSelect)
        {
            SqlConnection connection = new
                SqlConnection(Properties.Settings.Default.facultyConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        string GetSelectedFieldName()
        {
            return студентыDataGridView.Columns[
                студентыDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void группыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.группыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.facultyDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка сохранения. Проверьте правильность ввода.", 
                    "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void Groups_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'facultyDataSet.Факультет' table. You can move, or remove it, as needed.
            this.факультетTableAdapter.Fill(this.facultyDataSet.Факультет);
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

        private void findToolStripButton_Click(object sender, EventArgs e)
        {
            if (findToolStripTextBox.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                студентыDataGridView.DataSource = FillDataGridView(
                    "SELECT * " +
                    "FROM Студенты " +
                    "WHERE Студенты.[" + GetSelectedFieldName() + "] LIKE '" + findToolStripTextBox.Text + "'");
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
        }

        private void findCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (findCheckBox.Checked)
            {
                if (findToolStripTextBox.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        студентыBindingSource.Filter =
                       "[" + GetSelectedFieldName() + "] " + "='" + findToolStripTextBox.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                студентыBindingSource.Filter = "";
            if (студентыBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                студентыBindingSource.Filter = "";
                findCheckBox.Checked = false;
            }
        }
    }
}
