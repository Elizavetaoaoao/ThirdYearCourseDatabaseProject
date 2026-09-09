using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Base
{
    public partial class Start : Form
    {
        Classs myBase = new Classs();
        string status = "";
        public Start()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void enter_Click(object sender, EventArgs e)//обработка нажатия кнопки Войти
        {
            var passw = pass.Text;
            var login = log.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string  q = $"select * from Сотрудники where id='{login}' and password = '{passw}'";//запрос
            SqlCommand command = new SqlCommand(q, myBase.getConnection());//запрос в бд с подключением через метод Classs    
            adapter.SelectCommand = command;
            try
            {
                adapter.Fill(table);
                if (table.Rows.Count == 1)
                {
                    string Name = Convert.ToString(table.Rows[0][1]);//присвоение пер значения из первого столбца таблицы
                    string s = Convert.ToString(table.Rows[0][2]);//передача должности пользователя
                    //string status;
                    int level = GetLevel(s);
                    
                    mainAdmin formwork = new mainAdmin(level, this);//создание формы для работы с бд
                    this.Hide();//убрать текущую форму
                    formwork.Show();//вызов формы
                    formwork.Naming(Name, status, level) ;//обращение к методу Naming формы mainAdmin с передачей имени, должности
                }
                else
                { MessageBox.Show("Вход не удался."); }
            }
            catch (System.Data.SqlClient.SqlException) { MessageBox.Show("Введите корректные данные"); }//заполнение таблицы с данными о вошедшем пользователе
        }
        private int GetLevel(string status)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string q = $"select Должность, Уровень_Доступа from Должности where id='{status}'";
            SqlCommand command = new SqlCommand(q, myBase.getConnection());//запрос в бд с подключением через метод Classs    
            adapter.SelectCommand = command;
            adapter.Fill(table);
            int level = (int)table.Rows[0][1];
            SetStatus(Convert.ToString(table.Rows[0][0]));
            return level;
        }
        private void SetStatus(string s)
        {
            this.status = s;
        }
        private void hide_check_CheckedChanged(object sender, EventArgs e)//сокрытие пароля
        {
            if (hide_check.Checked == true) { pass.PasswordChar = '*'; }
            else { pass.PasswordChar = '\0'; }
        }
    }
}
