using System;
using System.Configuration;
using System.Data.SqlClient;

namespace OOP_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //підключеня для частини 1
            /*string connectionString_Part1 = @"Data Source=FSB\MYSERVER;Initial Catalog=Students;Integrated Security=True"; //Імя сервера; Ім'я бази даних на сервері; Встановлює автентифікацію
            IStudentMarks functions = new StudentMarks();*/
            //конструкція using для автоматичного закриття підключення
            /*using (SqlConnection connection = new SqlConnection(connectionString_Part1))
            {
                connection.Open();
                Console.WriteLine($"Пiдключення вiдкрито: [{connection.Database}] [{connection.DataSource}]");
                functions.ShowAllInformation(connection); //Відображення всієї інформації
                functions.ShowLNS(connection); //Відображення ПІБ
                functions.ShowAvgMarks(connection); //Відображення середніх оцінок
                functions.ShowMinMarks(connection); //Відображення мінімальних оцінок
                functions.ShowMinSubjectsMarks(connection);//Відображення всіх предметів з мінімальною оцінкою
                functions.ShowMinAvgMark(connection); //Відображення мінімальної середньої оцінки
                functions.ShowMaxAvgMark(connection); //Відображення максимальної середньої оцінки
                functions.ShowMinMath(connection); //Відображення мінімальної середньої оцінки з математики
                functions.ShowMaxMath(connection); //Відображення максимальної середньої оцінки з математики
                functions.ShowStudentsInGroup(connection); //Відображення кількості студентів у кожній групі
            }*/
            /*Console.WriteLine($"{Environment.NewLine}Пiдключення закрито");*/


            //підключення для частини 2
            string connectionString_Part2 = @"Data Source=FSB\MYSERVER;Initial Catalog=Фірма канцтоварів;Integrated Security=True"; //Імя сервера; Ім'я бази даних на сервері; Встановлює автентифікацію
            ICanctovari canctovari = new Canctovars();
            using (SqlConnection connection1 = new SqlConnection(connectionString_Part2))
            {
                connection1.Open();
                Console.WriteLine($"Пiдключення вiдкрито: [{connection1.Database}] [{connection1.DataSource}]");
                /*canctovari.ShowAllTovars(connection1);*/ //Відображення всієї інформації про канцтовари
                /*canctovari.ShowAllTovarsType(connection1);*/ //Відображення всіх типів канцтоварів
                /*canctovari.ShowAllManagers(connection1);*/ //Відображення всіх менеджерів з продажу
                /*canctovari.ShowMaxTovars(connection1);*/ //Показати канцтовари з максимальною кількістю одиниць
                /*canctovari.ShowMinTovars(connection1);*/ //Показати канцтовари з мінімальною кількістю одиниць
                /*canctovari.ShowMinSobivartistTovars(connection1);*/ //Показати канцтовари з мінімальною собівартістю одиниці
                canctovari.ShowMaxSobivartistTovars(connection1); //Показати канцтовари з максимальною собівартістю одиниці
            }
            Console.WriteLine($"{Environment.NewLine}Пiдключення закрито");
        }
    }
}
