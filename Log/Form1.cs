using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log
{
    public partial class Form1 : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                // Пример подключения к несуществующей базе данных
                string connectionString = "Server=localhost;Database=NonExistingDb;User Id=username;Password=password;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Это вызовет исключение
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка при подключении к базе данных. Пожалуйста, проверьте настройки соединения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Error(ex, "Ошибка при подключении к базе данных.");
            }
        }

        private void btnOverflow_Click(object sender, EventArgs e)
        {
            try
            {
                checked
                {
                    int x = int.MaxValue;
                    x *= x; // Это вызовет переполнение
                }
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Произошло переполнение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Error(ex, "Переполнение в расчете.");
            }
        }

        private void btnTypeConversion_Click(object sender, EventArgs e)
        {
            try
            {
                string input = "not a number";
                int number = Convert.ToInt32(input); // Это вызовет исключение
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ошибка преобразования строки в число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Error(ex, "Ошибка преобразования строки в число.");
            }
        }

        private void btnFileWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "non_existent_directory/file.txt";
                File.WriteAllText(filePath, "Тестовое содержимое");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Ошибка при записи в файл. Убедитесь, что путь существует и доступен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Error(ex, "Ошибка при записи в файл.");
            }
        }
    }
}
