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
    public partial class Discipline : Form
    {
        //int idCurrent = -1;
        //public int ShowSelectForm(int idDiscipline, out decimal price)
        //{
        //    idCurrent = idDiscipline;
        //    ShowDialog();
        //    price =
        //   (decimal)((DataRowView)предметыBindingSource.Current)["цена_меню"];
        //    return
        //   (int)((DataRowView)предметыBindingSource.Current)["код_блюда"];
        //}

        public Discipline()
        {
            InitializeComponent();
        }

        private void предметыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.предметыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.facultyDataSet);

        }

        private void Discipline_Load(object sender, EventArgs e)
        {
            this.предметыTableAdapter.Fill(this.facultyDataSet.Предметы);

        }

    }
}
