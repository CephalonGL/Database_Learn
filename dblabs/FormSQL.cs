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
    }
}
