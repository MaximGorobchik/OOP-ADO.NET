using System.Data.SqlClient;
using System;
using System.Data.Common;

public class StudentMarks : IStudentMarks
{
    public void ShowAllInformation(SqlConnection connection) //Відображення всієї інформації
    {
        string SqlExpression = "SELECT * FROM MarksOfStudents";
            SqlCommand command = new SqlCommand(SqlExpression, connection); //для виповнення запросу
            SqlDataReader reader = command.ExecuteReader(); //для зчитування данних
            if (reader.HasRows) //якщо є данні
            {
            //виводимо назву стовпців
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t{4}\t   {5}\t{6}",
                    reader.GetName(0),reader.GetName(1),reader.GetName(2),reader.GetName(3),reader.GetName(4),reader.GetName(5),reader.GetName(6));
                while (reader.Read()) //рядково зчитуємо данні
                {
                    //зберігаємо данні з таблиці
                    string lastname = reader.GetString(0);
                    string firstname = reader.GetString(1);
                    string surname = reader.GetString(2);
                    string groupname = reader.GetString(3);
                    double avgmark = reader.GetDouble(4);
                    double minavgsubjectmark = reader.GetDouble(5);
                    double maxavgsubjectmark = reader.GetDouble(6);
                Console.WriteLine("{0} \t{1} \t\t{2} \t{3} \t\t{4} \t   {5} \t\t\t{6}", lastname,firstname,surname,groupname,avgmark,minavgsubjectmark,maxavgsubjectmark);//вивід даних
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
            reader.Close();
    }
    public void ShowLNS(SqlConnection connection) //Відображення ПІБ
    {
        string SqlExpression = "SELECT Lastname,Firstname,Surname FROM MarksOfStudents";
        SqlCommand command = new SqlCommand(SqlExpression,connection); //для виповнення запросу
        SqlDataReader reader = command.ExecuteReader(); //для зчитування данних
        if (reader.HasRows) //якщо є данні
        {
            //виводимо назву стовпців
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0}  {1}  {2}\n",
                    reader.GetName(0), reader.GetName(1), reader.GetName(2));
            while(reader.Read()) //рядково зчитуємо данні
            {
                //зберігаємо данні з таблиці
                string lastname = reader.GetString(0);
                string firstname = reader.GetString(1);
                string surname = reader.GetString(2);
                Console.WriteLine("{0}     {1}    {2}", lastname,firstname,surname);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        reader.Close();
    }
    public void ShowAvgMarks(SqlConnection connection) //Відображення середніх оцінок
    {
        string SqlExpression = "SELECT AvgMark FROM MarksOfStudents";
        SqlCommand command = new SqlCommand(SqlExpression,connection);
        SqlDataReader reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(reader.GetName(0));
            while (reader.Read())
            {
                double avgmark = reader.GetDouble(0);
                Console.WriteLine(avgmark);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        reader.Close();
    }
    public void ShowMinMarks(SqlConnection connection) //Відображення мінімальних оцінок
    {
        string SqlExpression = "SELECT Lastname,Firstname,Surname FROM MarksOfStudents WHERE AvgMark = (SELECT MIN(AvgMark) FROM MarksOfStudents)";
        SqlCommand command = new SqlCommand(SqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{reader.GetName(0)} {reader.GetName(1)} {reader.GetName(2)}");
            while(reader.Read())
            {
                string lastname = reader.GetString(0);
                string firstname = reader.GetString(1);
                string surname = reader.GetString(2);
                Console.WriteLine($"{lastname}    {firstname}     {surname}");
            }
        }
        Console.ForegroundColor = ConsoleColor.White;
        reader.Close();
    }
    public void ShowMinSubjectsMarks(SqlConnection connection) //Відображення всіх предметів з мінімальною оцінкою
    {
        string SqlExpression = "SELECT distinct MinAvgSubjectMark FROM MarksOfStudents";
        SqlCommand command = new SqlCommand(SqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{reader.GetName(0)}");
            while(reader.Read())
            {
                string subjmark = reader.GetString(0);
                Console.WriteLine(subjmark);
            }
            Console.ForegroundColor = ConsoleColor.White;
            reader.Close();
        }
    }
    public void ShowMinAvgMark(SqlConnection connection) //Відображення мінімальної середньої оцінки
    {
        string SqlExpression = "SELECT MIN(AvgMark) FROM MarksOfStudents";
        SqlCommand command = new SqlCommand(SqlExpression, connection);
        object reader = command.ExecuteScalar();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Мiнiмальна середня оцiнка - {reader}");
        Console.ForegroundColor = ConsoleColor.White;
    }
    public void ShowMaxAvgMark(SqlConnection connection) //Відображення максимальної середньої оцінки
    {
        string SqlExpression = "SELECT MAX(AvgMark) FROM MarksOfStudents";
        SqlCommand command = new SqlCommand(SqlExpression, connection);
        object reader = command.ExecuteScalar();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Максимальна середня оцiнка - {reader}");
        Console.ForegroundColor = ConsoleColor.White;
    }
    public void ShowMinMath(SqlConnection connection) //Відображення мінімальної середньої оцінки з математики
    {
        string SqlExpression = "SELECT COUNT(*) FROM MarksOfStudents WHERE MinAvgSubjectMark = 'Math'";
        SqlCommand command = new SqlCommand(SqlExpression, connection);
        object reader = command.ExecuteScalar();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Кiлькiсть студентiв з мiн. сер. оцiнкою з математики - {reader}");
        Console.ForegroundColor = ConsoleColor.White;
    }
    public void ShowMaxMath(SqlConnection connection) //Відображення максимальної середньої оцінки з математики
    {
        string SqlExpression = "SELECT COUNT(*) FROM MarksOfStudents WHERE MaxAvgSubjectMark = 'Math'";
        SqlCommand command = new SqlCommand(SqlExpression, connection);
        object reader = command.ExecuteScalar();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Кiлькiсть студентiв з макс. сер. оцiнкою з математики - {reader}");
        Console.ForegroundColor = ConsoleColor.White;
    }
    public void ShowStudentsInGroup(SqlConnection connection) //Відображення кількості студентів у кожній групі
    {
        string SqlExpression1 = "SELECT GroupName, COUNT(*) AS [Кiлькiсть студентiв] FROM MarksOfStudents GROUP BY GroupName";
        SqlCommand command = new SqlCommand(SqlExpression1, connection);
        SqlDataReader reader = command.ExecuteReader();
        if(reader.HasRows)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{reader.GetName(0)}\t{reader.GetName(1)}");
            while(reader.Read())
            {
                string groupname = reader.GetString(0);
                int count = reader.GetInt32(1);
                Console.WriteLine($"{groupname}\t  ->\t{count}");
            }
        }
        Console.ForegroundColor = ConsoleColor.White;
        reader.Close();
    }
}