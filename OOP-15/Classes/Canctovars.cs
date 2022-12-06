using System.Data.SqlClient;
using System;
public class Canctovars : ICanctovari
{
    public void ShowAllTovars(SqlConnection connection) //Відображення всієї інформації про канцтовари
    {
        string SqlExpression = "show_all_tovars"; //назва процедури
        SqlCommand command = new SqlCommand(SqlExpression, connection);
        command.CommandType = System.Data.CommandType.StoredProcedure; //встановлюється, щоб система зрозуміла що це процедура
        SqlDataReader reader = command.ExecuteReader();
        if(reader.HasRows)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine($"{reader.GetName(0)}  {reader.GetName(1)}  {reader.GetName(2)}  {reader.GetName(3)}  {reader.GetName(4)}\n");
            while(reader.Read())
            {
                string nazva_tovaru = reader.GetString(0);
                string typ_tovaru = reader.GetString(1);
                int kilkist_tovaru = reader.GetInt32(2);
                int sovivartist = reader.GetInt32(3);
                int cina = reader.GetInt32(4);
                Console.WriteLine($"{nazva_tovaru}   {typ_tovaru}   {kilkist_tovaru}   {sovivartist}   {cina}");
            }
        }
        Console.ForegroundColor= ConsoleColor.White;
        reader.Close();
    }
    public void ShowAllTovarsType(SqlConnection connection) //Відображення всіх типів канцтоварів
    {
        string SqlExpression = "show_all_tovars_types";
        SqlCommand command = new SqlCommand(SqlExpression,connection);
        command.CommandType = System.Data.CommandType.StoredProcedure;
        SqlDataReader reader = command.ExecuteReader();
        if(reader.HasRows)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine(reader.GetName(0));
            while(reader.Read())
            {
                string type = reader.GetString(0);
                Console.WriteLine(type);
            }
        }
        Console.ForegroundColor= ConsoleColor.White;
        reader.Close();
    }
    public void ShowAllManagers(SqlConnection connection) //Відображення всіх менеджерів з продажу
    {
        string SqlExpression = "show_all_managers";
        SqlCommand command = new SqlCommand(SqlExpression, connection);
        command.CommandType = System.Data.CommandType.StoredProcedure;
        SqlDataReader reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(reader.GetName(0));
            while (reader.Read())
            {
                string manager = reader.GetString(0);
                Console.WriteLine(manager);
            }
        }
        Console.ForegroundColor = ConsoleColor.White;
        reader.Close();
    }
    public void ShowMaxTovars(SqlConnection connection) //Показати канцтовари з максимальною кількістю одиниць
    {
        string SqlExpression = "show_max_tovars";
        SqlCommand command = new SqlCommand(SqlExpression, connection);
        command.CommandType = System.Data.CommandType.StoredProcedure;
        SqlDataReader reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            while (reader.Read())
            {
                int max_tovar = reader.GetInt32(0);
                string max_tovar_name = reader.GetString(1);
                Console.WriteLine($"{reader.GetName(0)} -> {max_tovar_name} -> {max_tovar}");
            }
        }
        Console.ForegroundColor = ConsoleColor.White;
        reader.Close();
    }
    public void ShowMinTovars(SqlConnection connection) //Показати канцтовари з мінімальною кількістю одиниць
    {
        string SqlExpression = "show_min_tovars";
        SqlCommand command = new SqlCommand(SqlExpression, connection);
        command.CommandType = System.Data.CommandType.StoredProcedure;
        SqlDataReader reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            while (reader.Read())
            {
                int min_tovar = reader.GetInt32(0);
                string min_tovar_name = reader.GetString(1);
                Console.WriteLine($"{reader.GetName(0)} -> {min_tovar_name} -> {min_tovar}");
            }
        }
        Console.ForegroundColor = ConsoleColor.White;
        reader.Close();
    }
    public void ShowMinSobivartistTovars(SqlConnection connection) //Показати канцтовари з мінімальною собівартістю одиниці
    {
        string SqlExpression = "show_min_sobivartist";
        SqlCommand command = new SqlCommand(SqlExpression, connection);
        command.CommandType = System.Data.CommandType.StoredProcedure;
        SqlDataReader reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            while (reader.Read())
            {
                int min_sobivartist = reader.GetInt32(0);
                string min_sobivartist_name = reader.GetString(1);
                Console.WriteLine($"{reader.GetName(0)} -> {min_sobivartist_name} -> {min_sobivartist}");
            }
        }
        Console.ForegroundColor = ConsoleColor.White;
        reader.Close();
    }
    public void ShowMaxSobivartistTovars(SqlConnection connection)  //Показати канцтовари з максимальною собівартістю одиниці
    {
        string SqlExpression = "show_max_sobivartist";
        SqlCommand command = new SqlCommand(SqlExpression, connection);
        command.CommandType = System.Data.CommandType.StoredProcedure;
        SqlDataReader reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            while (reader.Read())
            {
                int max_sobivartist = reader.GetInt32(0);
                string max_sobivartist_name = reader.GetString(1);
                Console.WriteLine($"{reader.GetName(0)} -> {max_sobivartist_name} -> {max_sobivartist}");
            }
        }
        Console.ForegroundColor = ConsoleColor.White;
        reader.Close();
    }
}