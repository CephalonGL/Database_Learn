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
        //объявляем метод, на вход подаем строку запроса, а возвращаем объект DataTable
        DataTable FillDataGridView(string sqlSelect)
        {
            //Создаем объект connection класса SqlConnection для соединения с БД
            //CafeConnectionString – строка описания соединения с источником данных

            SqlConnection connection = new
           SqlConnection(Properties.Settings.Default.facultyConnectionString);
            //Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результата запроса
            DataTable table = new DataTable();
            //заполним набор данных результатом запроса
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

        private void textBoxGroupNumber_Leave(object sender, EventArgs e)
        {
        }

        private void checkBoxDescendingNameSort_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            //try
            //{
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
            //sqlSelect += " GROUP BY [Номер зачётной книжки]";
            dataGridViewFullSelect.DataSource = FillDataGridView(sqlSelect);
            //}
            //catch (Exception exception)
            //{

            //    MessageBox.Show(exception.Message,
            //        "Ошибка",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
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

        private void tabPageDML_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDisciplineName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
