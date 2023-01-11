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
    public partial class FormSQL : Form
    {
        public FormSQL()
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

        private void radioButtonGroups_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(
                "SELECT [Название факультета], COUNT(DISTINCT Студенты.[Номер зачётной книжки]) " +
                "AS [Количество студентов во всех группах на данном факультете] " +
                "FROM Группы, Студенты " +
                "GROUP BY [Название факультета]");
        }

        private void radioButtonStudents_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(
                "SELECT ФИО, [Номер группы], " +
                "[Изучение предметов студентами].[Название предмета], " +
                "[Изучение предметов студентами].[Оценка] " +
                "FROM Студенты " +
                "INNER JOIN [Изучение предметов студентами] " +
                "ON [Студенты].[Номер зачётной книжки] = [Изучение предметов студентами].[Номер зачётной книжки]");
        }

        private void radioButtonDisciplines_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(
                "SELECT [ФИО преподавателя], [Название предмета] " +
                "FROM Предметы " +
                "WHERE [ФИО преподавателя] = 'Горяинов Александр Евгеньевич'");
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            textBoxGroupNumber.Text = "580-2";
            if (textBoxGroupNumber.Text.Length == 0)
            {
                throw new Exception("Ошибка! Введите номер группы.");
            }
            string groupNumber = textBoxGroupNumber.Text;
            string sqlSelect =
                "SELECT Студенты.[Номер зачётной книжки], Студенты.ФИО, Студенты.[Номер группы] " +
                "FROM Студенты, [Изучение предметов студентами] " +
                "WHERE Студенты.[Номер группы] = '" + groupNumber + "' " +
                "GROUP BY Студенты.[Номер зачётной книжки], Студенты.ФИО, Студенты.[Номер группы] ";
            if (checkBoxGoodAverageMark.Checked)
            {
                sqlSelect += " HAVING AVG([Изучение предметов студентами].Оценка) < 3";
            }
            if (checkBoxDescendingNameSort.Checked)
            {
                sqlSelect += " ORDER BY Студенты.ФИО";
            }
            dataGridViewFullSelect.DataSource = FillDataGridView(sqlSelect);
        }

        private void buttonDoSubquery_Click(object sender, EventArgs e)
        {
            if (radioButtonCorrealed.Checked)
            {
                dataGridViewSubquery.DataSource = FillDataGridView(
                    "SELECT Студенты.[Номер зачётной книжки], ФИО " +
                    "FROM Студенты, [Изучение предметов студентами] " +
                    "WHERE Студенты.[Год поступления] = (SELECT AVG( Студенты.[Год поступления]) FROM Студенты)");
            }
            else if (radioButtonNoCorrealed.Checked)
            {
                dataGridViewSubquery.DataSource = FillDataGridView(
                    "SELECT Студенты.[Номер зачётной книжки], ФИО " +
                    "FROM Студенты, [Изучение предметов студентами] " +
                    "WHERE ФИО IN(SELECT ФИО FROM Студенты WHERE[Фактический адрес проживания] = [Адрес прописки])");
            }
        }

        private void buttonDoQuery_Click(object sender, EventArgs e)
        {
            string sourceDisciplineName = textBoxSourceDisciplineName.Text;
            string newDisciplineName = textBoxNewDisciplineName.Text;
            string sourceTeacherName = textBoxSourceTeacherName.Text;
            string newTeacherName = textBoxNewTeacherName.Text;
            if (radioButtonAdd.Checked)
            {
                dataGridViewAED.DataSource = FillDataGridView(
                    "INSERT INTO Предметы " +
                    "VALUES ('" + sourceDisciplineName + "' , '" + sourceTeacherName + "')");

                dataGridViewAED.DataSource = FillDataGridView(
                    "SELECT Предметы.[Название предмета], Предметы.[ФИО преподавателя]" +
                    "FROM Предметы");
            }
            else if (radioButtonEdit.Checked)
            {
                dataGridViewAED.DataSource = FillDataGridView(
                    "UPDATE Предметы " +
                    "SET [Название предмета] = '" + newDisciplineName + "', [ФИО преподавателя] = '" + newTeacherName + "' " +
                    "WHERE [Название предмета] = '" + sourceDisciplineName + "' " +
                    "AND [ФИО преподавателя] = '" + sourceTeacherName + "'");

                dataGridViewAED.DataSource = FillDataGridView(
                    "SELECT Предметы.[Название предмета], Предметы.[ФИО преподавателя]" +
                    "FROM Предметы");
            }
            else if (radioButtonRemove.Checked)
            {
                dataGridViewAED.DataSource = FillDataGridView(
                    "DELETE FROM Предметы " +
                    "WHERE [Название предмета] = '" + sourceDisciplineName + "' " +
                    "AND [ФИО преподавателя] = '" + sourceTeacherName + "'");

                dataGridViewAED.DataSource = FillDataGridView(
                    "SELECT Предметы.[Название предмета], Предметы.[ФИО преподавателя]" +
                    "FROM Предметы");
            }
        }

    }
}
