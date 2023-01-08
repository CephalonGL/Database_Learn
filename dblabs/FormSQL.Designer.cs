namespace dblabs
{
    partial class FormSQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPageExample = new System.Windows.Forms.TabPage();
            this.groupBoxDataRequests = new System.Windows.Forms.GroupBox();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.radioButtonGroups = new System.Windows.Forms.RadioButton();
            this.radioButtonDisciplines = new System.Windows.Forms.RadioButton();
            this.radioButtonStudents = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.labelGoodAverageMark = new System.Windows.Forms.Label();
            this.checkBoxGoodAverageMark = new System.Windows.Forms.CheckBox();
            this.labelSort = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.checkBoxDescendingNameSort = new System.Windows.Forms.CheckBox();
            this.textBoxGroupNumber = new System.Windows.Forms.TextBox();
            this.labelGroupNumber = new System.Windows.Forms.Label();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.dataGridViewFullSelect = new System.Windows.Forms.DataGridView();
            this.tabPageSubquery = new System.Windows.Forms.TabPage();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.groupBoxSubquery = new System.Windows.Forms.GroupBox();
            this.buttonDoSubquery = new System.Windows.Forms.Button();
            this.radioButtonNoCorrealed = new System.Windows.Forms.RadioButton();
            this.radioButtonCorrealed = new System.Windows.Forms.RadioButton();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.buttonDoQuery = new System.Windows.Forms.Button();
            this.labelTeacherName = new System.Windows.Forms.Label();
            this.textBoxSourceTeacherName = new System.Windows.Forms.TextBox();
            this.labelDisciplineName = new System.Windows.Forms.Label();
            this.textBoxSourceDisciplineName = new System.Windows.Forms.TextBox();
            this.dataGridViewAED = new System.Windows.Forms.DataGridView();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.radioButtonEdit = new System.Windows.Forms.RadioButton();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.radioButtonRemove = new System.Windows.Forms.RadioButton();
            this.groupBoxSourceData = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNewDisciplineName = new System.Windows.Forms.TextBox();
            this.textBoxNewTeacherName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlSQL.SuspendLayout();
            this.tabPageExample.SuspendLayout();
            this.groupBoxDataRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.tabPageSelect.SuspendLayout();
            this.groupBoxFSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFullSelect)).BeginInit();
            this.tabPageSubquery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.groupBoxSubquery.SuspendLayout();
            this.tabPageDML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAED)).BeginInit();
            this.groupBoxDML.SuspendLayout();
            this.groupBoxSourceData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlSQL.Controls.Add(this.tabPageExample);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Controls.Add(this.tabPageSubquery);
            this.tabControlSQL.Controls.Add(this.tabPageDML);
            this.tabControlSQL.Location = new System.Drawing.Point(12, 12);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(1507, 707);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPageExample
            // 
            this.tabPageExample.Controls.Add(this.groupBoxDataRequests);
            this.tabPageExample.Location = new System.Drawing.Point(4, 29);
            this.tabPageExample.Name = "tabPageExample";
            this.tabPageExample.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExample.Size = new System.Drawing.Size(1499, 674);
            this.tabPageExample.TabIndex = 0;
            this.tabPageExample.Text = "Примеры запросов";
            this.tabPageExample.UseVisualStyleBackColor = true;
            // 
            // groupBoxDataRequests
            // 
            this.groupBoxDataRequests.Controls.Add(this.dataGridViewSelect);
            this.groupBoxDataRequests.Controls.Add(this.radioButtonGroups);
            this.groupBoxDataRequests.Controls.Add(this.radioButtonDisciplines);
            this.groupBoxDataRequests.Controls.Add(this.radioButtonStudents);
            this.groupBoxDataRequests.Location = new System.Drawing.Point(6, 6);
            this.groupBoxDataRequests.Name = "groupBoxDataRequests";
            this.groupBoxDataRequests.Size = new System.Drawing.Size(756, 381);
            this.groupBoxDataRequests.TabIndex = 0;
            this.groupBoxDataRequests.TabStop = false;
            this.groupBoxDataRequests.Text = "Запросы по данным";
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Location = new System.Drawing.Point(6, 55);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.RowHeadersWidth = 62;
            this.dataGridViewSelect.RowTemplate.Height = 28;
            this.dataGridViewSelect.Size = new System.Drawing.Size(1481, 607);
            this.dataGridViewSelect.TabIndex = 3;
            // 
            // radioButtonGroups
            // 
            this.radioButtonGroups.AutoSize = true;
            this.radioButtonGroups.Location = new System.Drawing.Point(6, 25);
            this.radioButtonGroups.Name = "radioButtonGroups";
            this.radioButtonGroups.Size = new System.Drawing.Size(88, 24);
            this.radioButtonGroups.TabIndex = 2;
            this.radioButtonGroups.TabStop = true;
            this.radioButtonGroups.Text = "Группы";
            this.radioButtonGroups.UseVisualStyleBackColor = true;
            this.radioButtonGroups.CheckedChanged += new System.EventHandler(this.radioButtonGroups_CheckedChanged);
            // 
            // radioButtonDisciplines
            // 
            this.radioButtonDisciplines.AutoSize = true;
            this.radioButtonDisciplines.Location = new System.Drawing.Point(216, 25);
            this.radioButtonDisciplines.Name = "radioButtonDisciplines";
            this.radioButtonDisciplines.Size = new System.Drawing.Size(115, 24);
            this.radioButtonDisciplines.TabIndex = 1;
            this.radioButtonDisciplines.TabStop = true;
            this.radioButtonDisciplines.Text = "Предметы";
            this.radioButtonDisciplines.UseVisualStyleBackColor = true;
            this.radioButtonDisciplines.CheckedChanged += new System.EventHandler(this.radioButtonDisciplines_CheckedChanged);
            // 
            // radioButtonStudents
            // 
            this.radioButtonStudents.AutoSize = true;
            this.radioButtonStudents.Location = new System.Drawing.Point(100, 25);
            this.radioButtonStudents.Name = "radioButtonStudents";
            this.radioButtonStudents.Size = new System.Drawing.Size(110, 24);
            this.radioButtonStudents.TabIndex = 0;
            this.radioButtonStudents.TabStop = true;
            this.radioButtonStudents.Text = "Студенты";
            this.radioButtonStudents.UseVisualStyleBackColor = true;
            this.radioButtonStudents.CheckedChanged += new System.EventHandler(this.radioButtonStudents_CheckedChanged);
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.labelGoodAverageMark);
            this.tabPageSelect.Controls.Add(this.checkBoxGoodAverageMark);
            this.tabPageSelect.Controls.Add(this.labelSort);
            this.tabPageSelect.Controls.Add(this.buttonFind);
            this.tabPageSelect.Controls.Add(this.checkBoxDescendingNameSort);
            this.tabPageSelect.Controls.Add(this.textBoxGroupNumber);
            this.tabPageSelect.Controls.Add(this.labelGroupNumber);
            this.tabPageSelect.Controls.Add(this.groupBoxFSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 29);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(1499, 674);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // labelGoodAverageMark
            // 
            this.labelGoodAverageMark.AutoSize = true;
            this.labelGoodAverageMark.Location = new System.Drawing.Point(6, 68);
            this.labelGoodAverageMark.Name = "labelGoodAverageMark";
            this.labelGoodAverageMark.Size = new System.Drawing.Size(173, 20);
            this.labelGoodAverageMark.TabIndex = 7;
            this.labelGoodAverageMark.Text = "Средний балл ниже 3";
            // 
            // checkBoxGoodAverageMark
            // 
            this.checkBoxGoodAverageMark.AutoSize = true;
            this.checkBoxGoodAverageMark.Location = new System.Drawing.Point(303, 67);
            this.checkBoxGoodAverageMark.Name = "checkBoxGoodAverageMark";
            this.checkBoxGoodAverageMark.Size = new System.Drawing.Size(22, 21);
            this.checkBoxGoodAverageMark.TabIndex = 6;
            this.checkBoxGoodAverageMark.UseVisualStyleBackColor = true;
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Location = new System.Drawing.Point(6, 38);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(278, 20);
            this.labelSort.TabIndex = 5;
            this.labelSort.Text = "Сортировать по возрастанию ФИО";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(12, 110);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 31);
            this.buttonFind.TabIndex = 4;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // checkBoxDescendingNameSort
            // 
            this.checkBoxDescendingNameSort.AutoSize = true;
            this.checkBoxDescendingNameSort.Location = new System.Drawing.Point(303, 37);
            this.checkBoxDescendingNameSort.Name = "checkBoxDescendingNameSort";
            this.checkBoxDescendingNameSort.Size = new System.Drawing.Size(22, 21);
            this.checkBoxDescendingNameSort.TabIndex = 3;
            this.checkBoxDescendingNameSort.UseVisualStyleBackColor = true;
            this.checkBoxDescendingNameSort.CheckedChanged += new System.EventHandler(this.checkBoxDescendingNameSort_CheckedChanged);
            // 
            // textBoxGroupNumber
            // 
            this.textBoxGroupNumber.Location = new System.Drawing.Point(264, 6);
            this.textBoxGroupNumber.Name = "textBoxGroupNumber";
            this.textBoxGroupNumber.Size = new System.Drawing.Size(100, 26);
            this.textBoxGroupNumber.TabIndex = 2;
            this.textBoxGroupNumber.Leave += new System.EventHandler(this.textBoxGroupNumber_Leave);
            // 
            // labelGroupNumber
            // 
            this.labelGroupNumber.AutoSize = true;
            this.labelGroupNumber.Location = new System.Drawing.Point(6, 9);
            this.labelGroupNumber.Name = "labelGroupNumber";
            this.labelGroupNumber.Size = new System.Drawing.Size(115, 20);
            this.labelGroupNumber.TabIndex = 1;
            this.labelGroupNumber.Text = "Номер группы";
            // 
            // groupBoxFSelect
            // 
            this.groupBoxFSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFSelect.Controls.Add(this.dataGridViewFullSelect);
            this.groupBoxFSelect.Location = new System.Drawing.Point(6, 147);
            this.groupBoxFSelect.Name = "groupBoxFSelect";
            this.groupBoxFSelect.Size = new System.Drawing.Size(1487, 521);
            this.groupBoxFSelect.TabIndex = 0;
            this.groupBoxFSelect.TabStop = false;
            this.groupBoxFSelect.Text = "Информация об успеваемости студентов";
            // 
            // dataGridViewFullSelect
            // 
            this.dataGridViewFullSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFullSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFullSelect.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewFullSelect.Name = "dataGridViewFullSelect";
            this.dataGridViewFullSelect.RowHeadersWidth = 62;
            this.dataGridViewFullSelect.RowTemplate.Height = 28;
            this.dataGridViewFullSelect.Size = new System.Drawing.Size(1475, 490);
            this.dataGridViewFullSelect.TabIndex = 4;
            // 
            // tabPageSubquery
            // 
            this.tabPageSubquery.Controls.Add(this.dataGridViewSubquery);
            this.tabPageSubquery.Controls.Add(this.groupBoxSubquery);
            this.tabPageSubquery.Location = new System.Drawing.Point(4, 29);
            this.tabPageSubquery.Name = "tabPageSubquery";
            this.tabPageSubquery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubquery.Size = new System.Drawing.Size(1499, 674);
            this.tabPageSubquery.TabIndex = 2;
            this.tabPageSubquery.Text = "Примеры подзапросов";
            this.tabPageSubquery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(9, 148);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.RowHeadersWidth = 62;
            this.dataGridViewSubquery.RowTemplate.Height = 28;
            this.dataGridViewSubquery.Size = new System.Drawing.Size(1484, 520);
            this.dataGridViewSubquery.TabIndex = 1;
            // 
            // groupBoxSubquery
            // 
            this.groupBoxSubquery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSubquery.Controls.Add(this.buttonDoSubquery);
            this.groupBoxSubquery.Controls.Add(this.radioButtonNoCorrealed);
            this.groupBoxSubquery.Controls.Add(this.radioButtonCorrealed);
            this.groupBoxSubquery.Location = new System.Drawing.Point(9, 6);
            this.groupBoxSubquery.Name = "groupBoxSubquery";
            this.groupBoxSubquery.Size = new System.Drawing.Size(1484, 136);
            this.groupBoxSubquery.TabIndex = 0;
            this.groupBoxSubquery.TabStop = false;
            this.groupBoxSubquery.Text = "Подзапросы по данным";
            // 
            // buttonDoSubquery
            // 
            this.buttonDoSubquery.Location = new System.Drawing.Point(6, 100);
            this.buttonDoSubquery.Name = "buttonDoSubquery";
            this.buttonDoSubquery.Size = new System.Drawing.Size(215, 30);
            this.buttonDoSubquery.TabIndex = 3;
            this.buttonDoSubquery.Text = "Выполнить подзапрос";
            this.buttonDoSubquery.UseVisualStyleBackColor = true;
            this.buttonDoSubquery.Click += new System.EventHandler(this.buttonDoSubquery_Click);
            // 
            // radioButtonNoCorrealed
            // 
            this.radioButtonNoCorrealed.AutoSize = true;
            this.radioButtonNoCorrealed.Location = new System.Drawing.Point(6, 55);
            this.radioButtonNoCorrealed.Name = "radioButtonNoCorrealed";
            this.radioButtonNoCorrealed.Size = new System.Drawing.Size(277, 24);
            this.radioButtonNoCorrealed.TabIndex = 2;
            this.radioButtonNoCorrealed.TabStop = true;
            this.radioButtonNoCorrealed.Text = "Некоррелированный подзапрос";
            this.radioButtonNoCorrealed.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorrealed
            // 
            this.radioButtonCorrealed.AutoSize = true;
            this.radioButtonCorrealed.Location = new System.Drawing.Point(6, 25);
            this.radioButtonCorrealed.Name = "radioButtonCorrealed";
            this.radioButtonCorrealed.Size = new System.Drawing.Size(258, 24);
            this.radioButtonCorrealed.TabIndex = 1;
            this.radioButtonCorrealed.TabStop = true;
            this.radioButtonCorrealed.Text = "Коррелированный подзапрос";
            this.radioButtonCorrealed.UseVisualStyleBackColor = true;
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.groupBox1);
            this.tabPageDML.Controls.Add(this.groupBoxSourceData);
            this.tabPageDML.Controls.Add(this.buttonDoQuery);
            this.tabPageDML.Controls.Add(this.dataGridViewAED);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 29);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDML.Size = new System.Drawing.Size(1499, 674);
            this.tabPageDML.TabIndex = 3;
            this.tabPageDML.Text = "Запросы изменения данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            this.tabPageDML.Click += new System.EventHandler(this.tabPageDML_Click);
            // 
            // buttonDoQuery
            // 
            this.buttonDoQuery.Location = new System.Drawing.Point(0, 131);
            this.buttonDoQuery.Name = "buttonDoQuery";
            this.buttonDoQuery.Size = new System.Drawing.Size(171, 34);
            this.buttonDoQuery.TabIndex = 6;
            this.buttonDoQuery.Text = "Выполнить запрос";
            this.buttonDoQuery.UseVisualStyleBackColor = true;
            this.buttonDoQuery.Click += new System.EventHandler(this.buttonDoQuery_Click);
            // 
            // labelTeacherName
            // 
            this.labelTeacherName.AutoSize = true;
            this.labelTeacherName.Location = new System.Drawing.Point(6, 54);
            this.labelTeacherName.Name = "labelTeacherName";
            this.labelTeacherName.Size = new System.Drawing.Size(171, 20);
            this.labelTeacherName.TabIndex = 5;
            this.labelTeacherName.Text = "ФИО преподавателя";
            // 
            // textBoxSourceTeacherName
            // 
            this.textBoxSourceTeacherName.Location = new System.Drawing.Point(183, 51);
            this.textBoxSourceTeacherName.Name = "textBoxSourceTeacherName";
            this.textBoxSourceTeacherName.Size = new System.Drawing.Size(318, 26);
            this.textBoxSourceTeacherName.TabIndex = 4;
            // 
            // labelDisciplineName
            // 
            this.labelDisciplineName.AutoSize = true;
            this.labelDisciplineName.Location = new System.Drawing.Point(6, 22);
            this.labelDisciplineName.Name = "labelDisciplineName";
            this.labelDisciplineName.Size = new System.Drawing.Size(163, 20);
            this.labelDisciplineName.TabIndex = 3;
            this.labelDisciplineName.Text = "Название предмета";
            // 
            // textBoxSourceDisciplineName
            // 
            this.textBoxSourceDisciplineName.Location = new System.Drawing.Point(183, 18);
            this.textBoxSourceDisciplineName.Name = "textBoxSourceDisciplineName";
            this.textBoxSourceDisciplineName.Size = new System.Drawing.Size(318, 26);
            this.textBoxSourceDisciplineName.TabIndex = 2;
            this.textBoxSourceDisciplineName.TextChanged += new System.EventHandler(this.textBoxDisciplineName_TextChanged);
            // 
            // dataGridViewAED
            // 
            this.dataGridViewAED.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAED.Location = new System.Drawing.Point(6, 225);
            this.dataGridViewAED.Name = "dataGridViewAED";
            this.dataGridViewAED.RowHeadersWidth = 62;
            this.dataGridViewAED.RowTemplate.Height = 28;
            this.dataGridViewAED.Size = new System.Drawing.Size(1487, 443);
            this.dataGridViewAED.TabIndex = 1;
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.radioButtonEdit);
            this.groupBoxDML.Controls.Add(this.radioButtonAdd);
            this.groupBoxDML.Controls.Add(this.radioButtonRemove);
            this.groupBoxDML.Location = new System.Drawing.Point(6, 6);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(389, 119);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы";
            // 
            // radioButtonEdit
            // 
            this.radioButtonEdit.AutoSize = true;
            this.radioButtonEdit.Location = new System.Drawing.Point(6, 55);
            this.radioButtonEdit.Name = "radioButtonEdit";
            this.radioButtonEdit.Size = new System.Drawing.Size(375, 24);
            this.radioButtonEdit.TabIndex = 2;
            this.radioButtonEdit.TabStop = true;
            this.radioButtonEdit.Text = "Изменение предмета по введённым данным";
            this.radioButtonEdit.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(6, 25);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(264, 24);
            this.radioButtonAdd.TabIndex = 1;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "Добавление нового предмета";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            // 
            // radioButtonRemove
            // 
            this.radioButtonRemove.AutoSize = true;
            this.radioButtonRemove.Location = new System.Drawing.Point(6, 85);
            this.radioButtonRemove.Name = "radioButtonRemove";
            this.radioButtonRemove.Size = new System.Drawing.Size(367, 24);
            this.radioButtonRemove.TabIndex = 0;
            this.radioButtonRemove.TabStop = true;
            this.radioButtonRemove.Text = "Удаление предмета по введённым данным";
            this.radioButtonRemove.UseVisualStyleBackColor = true;
            // 
            // groupBoxSourceData
            // 
            this.groupBoxSourceData.Controls.Add(this.labelDisciplineName);
            this.groupBoxSourceData.Controls.Add(this.textBoxSourceDisciplineName);
            this.groupBoxSourceData.Controls.Add(this.textBoxSourceTeacherName);
            this.groupBoxSourceData.Controls.Add(this.labelTeacherName);
            this.groupBoxSourceData.Location = new System.Drawing.Point(401, 6);
            this.groupBoxSourceData.Name = "groupBoxSourceData";
            this.groupBoxSourceData.Size = new System.Drawing.Size(507, 119);
            this.groupBoxSourceData.TabIndex = 8;
            this.groupBoxSourceData.TabStop = false;
            this.groupBoxSourceData.Text = "Исходные данные";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxNewDisciplineName);
            this.groupBox1.Controls.Add(this.textBoxNewTeacherName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(914, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 119);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заменить на";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название предмета";
            // 
            // textBoxNewDisciplineName
            // 
            this.textBoxNewDisciplineName.Location = new System.Drawing.Point(183, 18);
            this.textBoxNewDisciplineName.Name = "textBoxNewDisciplineName";
            this.textBoxNewDisciplineName.Size = new System.Drawing.Size(318, 26);
            this.textBoxNewDisciplineName.TabIndex = 2;
            // 
            // textBoxNewTeacherName
            // 
            this.textBoxNewTeacherName.Location = new System.Drawing.Point(183, 51);
            this.textBoxNewTeacherName.Name = "textBoxNewTeacherName";
            this.textBoxNewTeacherName.Size = new System.Drawing.Size(318, 26);
            this.textBoxNewTeacherName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ФИО преподавателя";
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 731);
            this.Controls.Add(this.tabControlSQL);
            this.Name = "FormSQL";
            this.Text = "Запросы";
            this.tabControlSQL.ResumeLayout(false);
            this.tabPageExample.ResumeLayout(false);
            this.groupBoxDataRequests.ResumeLayout(false);
            this.groupBoxDataRequests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.tabPageSelect.ResumeLayout(false);
            this.tabPageSelect.PerformLayout();
            this.groupBoxFSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFullSelect)).EndInit();
            this.tabPageSubquery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.groupBoxSubquery.ResumeLayout(false);
            this.groupBoxSubquery.PerformLayout();
            this.tabPageDML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAED)).EndInit();
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
            this.groupBoxSourceData.ResumeLayout(false);
            this.groupBoxSourceData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPageExample;
        private System.Windows.Forms.GroupBox groupBoxDataRequests;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.RadioButton radioButtonGroups;
        private System.Windows.Forms.RadioButton radioButtonDisciplines;
        private System.Windows.Forms.RadioButton radioButtonStudents;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.TextBox textBoxGroupNumber;
        private System.Windows.Forms.Label labelGroupNumber;
        private System.Windows.Forms.GroupBox groupBoxFSelect;
        private System.Windows.Forms.CheckBox checkBoxDescendingNameSort;
        private System.Windows.Forms.DataGridView dataGridViewFullSelect;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label labelGoodAverageMark;
        private System.Windows.Forms.CheckBox checkBoxGoodAverageMark;
        private System.Windows.Forms.TabPage tabPageSubquery;
        private System.Windows.Forms.GroupBox groupBoxSubquery;
        private System.Windows.Forms.Button buttonDoSubquery;
        private System.Windows.Forms.RadioButton radioButtonNoCorrealed;
        private System.Windows.Forms.RadioButton radioButtonCorrealed;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.RadioButton radioButtonEdit;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.RadioButton radioButtonRemove;
        private System.Windows.Forms.Button buttonDoQuery;
        private System.Windows.Forms.Label labelTeacherName;
        private System.Windows.Forms.TextBox textBoxSourceTeacherName;
        private System.Windows.Forms.Label labelDisciplineName;
        private System.Windows.Forms.TextBox textBoxSourceDisciplineName;
        private System.Windows.Forms.DataGridView dataGridViewAED;
        private System.Windows.Forms.GroupBox groupBoxSourceData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewDisciplineName;
        private System.Windows.Forms.TextBox textBoxNewTeacherName;
        private System.Windows.Forms.Label label2;
    }
}