using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel=Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace Base
{
    public partial class mainAdmin : Form
    {
        static Classs myBase = new Classs();//подключение
        //инф из таблиц
        private DataSet dataSetItems = null;//Товары
        private DataSet dataSetEmp = null;//Сотрудники
        private DataSet dataSetProv = null;//Поставщики
        private DataSet dataSetStorage = null;//склад
        private DataSet dataSetPosition = null;//Должность
        private DataSet dataSetClass = null;//Категория
        private DataSet dataSetType = null;//Тип
        //адаптеры
        private SqlDataAdapter dataAdapter;//общий
        private SqlDataAdapter adapterItems = new SqlDataAdapter();//Товары
        private SqlDataAdapter adapterEmp = new SqlDataAdapter();//Сотрудники
        private SqlDataAdapter adapterProv = new SqlDataAdapter();//Поставщики
        private SqlDataAdapter adapterStor = new SqlDataAdapter();//Склад
        private SqlDataAdapter adapterPosition = new SqlDataAdapter();//Должность
        private SqlDataAdapter adapterType = new SqlDataAdapter();//Тип
        private SqlDataAdapter adapterClass = new SqlDataAdapter();//Категория
        //
        private Form form;
        public mainAdmin(int l, Form f)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            UploadInfo();
            form = f;
            labelStatus.Text = "";
        }
        //метод обновления данных таблиц системы
        private void UploadInfo()
        {
            dataSetItems = load("Товары");
            gridItems.DataSource = dataSetItems.Tables["Товары"];
            dataSetEmp = load("Сотрудники");
            gridEmployee.DataSource = dataSetEmp.Tables["Сотрудники"];
            dataSetProv = load("Поставщики");
            gridProviders.DataSource = dataSetProv.Tables["Поставщики"];
            dataSetStorage = load("Склад");
            gridStorage.DataSource = dataSetStorage.Tables["Склад"];
            dataSetPosition = load("Должности");
            gridPosition.DataSource = dataSetPosition.Tables["Должности"];
            dataSetType = load("Тип");
            gridType.DataSource = dataSetType.Tables["Тип"];
            dataSetClass = load("Категория");
            gridClass.DataSource = dataSetClass.Tables["Категория"];
            GetInfoForStorage();
        }
        //метод получение данных из бд
        private DataSet load(string tableName)
        {
            string query = $"SELECT * FROM {tableName}";//запрос
            dataAdapter = new SqlDataAdapter(query, myBase.getConnection());
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, tableName);
            Adapters(tableName, dataAdapter);//вызов метода 
            return dataSet;
        }
        //присвоение подключения адаптеру по имени
        private void Adapters(string tN, SqlDataAdapter da)
        {
            switch (tN)
            {
                case "Товары": adapterItems = da; break;
                case "Сотрудники": adapterEmp = da; break;
                case "Поставщики": adapterProv = da; break;
                case "Должности": adapterPosition= da; break;
                case "Тип": adapterType = da; break;
                case "Категория": adapterClass = da; break;
                case "Склад": adapterStor = da; break;
            }
        }
        //метод получения информации из таблицы в combobox'ы
        private void GetInfoForStorage()
        {
            comboBoxItemName.Items.Clear();
            for (int i = 0; i < gridItems.Rows.Count; i++)
            {
                
                if (gridItems.Rows[i].Cells[1].Value != null)
                { comboBoxItemName.Items.Add(Convert.ToString(gridItems.Rows[i].Cells[1].Value)); }
            }
        } 
        public void mainAdmin_Load(object sender, EventArgs e)
        {
        }
        //присвоение имени и сокрытие элементов
        public void Naming(string n, string s, int l)
        {
            this.Text = $"{n}.          Должность: {s}";//изменение заголовка формы

            if (l == 2)
            {
                gridEmployee.ReadOnly = true;//таблица Сотрудники только для чтения
                delEmp.Visible = false;//сокрытие кнопки удаления сотрудника
                gridEmployee.Columns[3].Visible = false;
                gridPosition.ReadOnly = true;
                delPositionButton.Visible = false;
            }
            else if ((l >= 4))//скрыть таблицы кроме Товары и запретить изменения
            {
                tabDop.Parent = null;
                tabEmployee.Parent = null;
                tabProvide.Parent = null;
                tabPosition.Parent = null;
                gridItems.ReadOnly = true;
                delItem.Visible= false;
                DelStorage.Visible = false;
                gridStorage.ReadOnly = true;
                if (l == 4)
                    tabStorage.Parent = null;
            }
            
        }
        //Товары страница
        private void delItem_Click(object sender, EventArgs e)//удалить
        {   DeleteRow(gridItems, dataSetItems, "Товары");   }

        private void reportEx_Click(object sender, EventArgs e)//создание отчета
        {   SaveToXlsx(gridItems);  }//обращение к методу по сохранению в Excel
        private void reportW_Click(object sender, EventArgs e)
        {   SaveToDocx(gridItems); }//обращение к методу по сохранению в Word

        //поиск по параметрам
        private void searchItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchItemName.Text != string.Empty)
                {
                    UploadInfo();
                    (gridItems.DataSource as DataTable).DefaultView.RowFilter = $"наименование LIKE '%{searchItemName.Text}%' and цена_за_шт>{Convert.ToDecimal(costMin.Text)} and цена_за_шт<{Convert.ToDecimal(costMax.Text)}";
                }
                else
                {
                    string minPrice = Convert.ToString(costMin.Text);
                    string maxPrice = Convert.ToString(costMax.Text);
                    string q = $"select * from Товары where цена_за_шт > {minPrice} and цена_за_шт<{maxPrice}";
                    SqlCommand command = new SqlCommand(q, myBase.getConnection());//запрос в бд с подключением через метод Classs    
                    adapterItems.SelectCommand = command;
                    DataTable table = new DataTable();
                    adapterItems.Fill(table);
                    gridItems.DataSource = table;
                }
            }
            catch (System.FormatException) { MessageBox.Show("Укажите ценовой диапазон."); }
        }
        //Сотрудники страница
        private void searchStatus_TextChanged(object sender, EventArgs e)//фильтр
        {
            string s = searchStatus.Text;
            SqlCommand command = new SqlCommand($"SELECT Сотрудники.id, Сотрудники.ФИО, Сотрудники.password, Должности.Должность FROM Сотрудники INNER JOIN Должности ON Сотрудники.должность = Должности.id WHERE Должности.Должность='{s}'", myBase.getConnection());
            adapterEmp.SelectCommand = command;
            DataTable table = new DataTable();
            adapterEmp.Fill(table);
            gridEmployee.DataSource = table;
            //(gridEmployee.DataSource as DataTable).DefaultView.RowFilter = $"должность LIKE '%{searchStatus.Text}%'";
            if (gridEmployee.Rows.Count ==1)
            {
                employeeMessage.Text = "Сотрудников с указанной должностью не найдено.";
            }
            else { employeeMessage.Text = $"Сотрудников найдено: {gridEmployee.Rows.Count-1}"; }
        }
        private void delEmp_Click(object sender, EventArgs e)//удалить
        {   DeleteRow(gridEmployee, dataSetEmp, "Сотрудники");  }
        //Поставщики страница
        private void delProv_Click(object sender, EventArgs e)
        {   DeleteRow(gridProviders, dataSetProv, "Поставщики");    }
        //Доп страница
        private void delType_Click(object sender, EventArgs e)//удалить тип
        {   DeleteRow(gridType, dataSetType, "Тип");    }
        private void delClass_Click(object sender, EventArgs e)//удалить категорию
        {   DeleteRow(gridClass, dataSetClass, "Категория");    }
        private void DelStorage_Click(object sender, EventArgs e)
        { DeleteRow(gridStorage, dataSetStorage, "Склады"); }

        private void delPositionButton_Click(object sender, EventArgs e)
        { DeleteRow(gridPosition, dataSetPosition, "Должности"); }
        //обработка переключения вкладок
        private void tabControl1_Deselected(object sender, TabControlEventArgs e)
        { labelStatus.Text = ""; Save(); GetInfoForStorage(); searchStatus.Text = null;  }

        //обработка закрытия
        private void mainAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения перед выходом?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Save();
                form.Dispose();
            }
            else { form.Dispose(); }
        }
        //МЕТОДЫ ВСТР
        private void Save()//сохранение изменений таблиц
        {
            SaveChange(adapterItems, dataSetItems, "Товары",gridItems);
            SaveChange(adapterEmp, dataSetEmp, "Сотрудники",gridEmployee);
            SaveChange(adapterProv, dataSetProv, "Поставщики",gridProviders);
            SaveChange(adapterPosition,dataSetPosition,"Должности",gridPosition);
            SaveChange(adapterStor, dataSetStorage, "Склад", gridStorage);
            SaveChange(adapterType, dataSetType, "Тип",gridType);
            SaveChange(adapterClass, dataSetClass, "Категория",gridClass);
        }
        //сохранение изменений в таблице
        private void SaveChange(SqlDataAdapter da, DataSet ds, string tN, DataGridView dgv)
        {
            try
            {
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
                da.Update(ds, tN);
            }
            catch (System.Data.SqlClient.SqlException) { MessageBox.Show("Указанного значения нет в родительской таблице. Измените значение на имеющееся в таблице."); }
           
        }
        //удаление строки таблицы 
        private void DeleteRow(DataGridView dgv, DataSet ds, string tN)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedIndex = dgv.SelectedRows[0].Index;
                    ds.Tables[tN].Rows[selectedIndex].Delete();
                }
                catch (System.IndexOutOfRangeException) { }
            }
            else { MessageBox.Show("Выберите всю строку."); }
        }
        //отчет Excel
        public void SaveToXlsx(DataGridView dataGridView)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            for (int i = 1; i <= dataGridView.Columns.Count; i++)
            {   wsh.Cells[1, i].Value = dataGridView.Columns[i - 1].HeaderText; }
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {   wsh.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value;    }
            }
            exApp.Visible = true;
        }
        //отчет Word
        public void SaveToDocx(DataGridView dataGridView)
        {
            Word.Application wApp = new Word.Application();
            var wDoc = wApp.Documents.Add();
            var table = wDoc.Tables.Add(wDoc.Range(), dataGridView.Rows.Count, dataGridView.ColumnCount);
            for (int i = 1; i < dataGridView.Columns.Count; i++)
            {   table.Rows[1].Cells[i+1].Range.Text = dataGridView.Columns[i-1].HeaderText; }
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    if (dataGridView[j, i].Value == null) { dataGridView[j, i].Value = 0; }
                    else { table.Rows[i + 2].Cells[j + 1].Range.Text = dataGridView[j,i].Value.ToString(); }
                }
            }
            table.Borders.Enable = 1;
            wApp.Visible = true;
        }
        //обработка некорректных данных в ячейке
        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 0)
                MessageBox.Show($"Введите корректное число: в поле ID может быть только уникальное число");
            else if (gridItems.CurrentCell.ColumnIndex==5)
                MessageBox.Show($"Введите корректное число: в поле 'цена' могут быть только цифры");
        }
        //метод обновления информации по бд, обработчик для кнопки
        private void UploadInfo(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения?\nЕсли вы не вносили изменения, нажмите любую кнопку", "Обновление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Save();
            }
            UploadInfo();
            labelStatus.Text = "Информация обновлена";
        }
        //метод сохранения информации со склада в "Товары"
        private void SaveInStorageButton_Click(object sender, EventArgs e)
        {
            int RowsCount = gridItems.Rows.Count;
            string ItemName = comboBoxItemName.Text;
            if (comboBoxItemName.SelectedItem != null)
            {
                for (int i = 0; i < RowsCount; i++)
                {
                    if (Convert.ToString(gridItems.Rows[i].Cells[1].Value) == ItemName)
                    {
                        gridItems.Rows[i].Cells[6].Value = numericUpDown.Value;
                        labelStatus.Text = "Информация изменена";
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните поля 'Наименование товара' и 'Склад'");
            }
        }
        //метод очистки label
        private void ClearLabelStatus(object sender, EventArgs e)
        {
            labelStatus.Text = "";
        }

    }
}