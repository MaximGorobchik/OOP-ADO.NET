using System.Data.SqlClient;

public interface IStudentMarks
{
   void ShowAllInformation(SqlConnection connect); //Відображення всієї інформації
    void ShowLNS(SqlConnection connect); //Відображення ПІБ
    void ShowAvgMarks(SqlConnection connect); //Відображення середніх оцінок
    void ShowMinMarks(SqlConnection connect); //Відображення мінімальних оцінок
    void ShowMinSubjectsMarks(SqlConnection connect); //Відображення всіх предметів з мінімальною оцінкою
    void ShowMinAvgMark(SqlConnection connect); //Відображення мінімальної середньої оцінки
    void ShowMaxAvgMark(SqlConnection connect); //Відображення максимальної середньої оцінки
    void ShowMinMath(SqlConnection connect); //Відображення мінімальної середньої оцінки з математики
    void ShowMaxMath(SqlConnection connect); //Відображення максимальної середньої оцінки з математики
    void ShowStudentsInGroup(SqlConnection connec); //Відображення кількості студентів у кожній групі
}