using System.Data.SqlClient;

public interface ICanctovari
{
    void ShowAllTovars(SqlConnection connection); //Відображення всієї інформації про канцтовари
    void ShowAllTovarsType(SqlConnection connection); //Відображення всіх типів канцтоварів
    void ShowAllManagers(SqlConnection connection); //Відображення всіх менеджерів з продажу
    void ShowMaxTovars(SqlConnection connection); //Показати канцтовари з максимальною кількістю одиниць
    void ShowMinTovars(SqlConnection connection); //Показати канцтовари з мінімальною кількістю одиниць
    void ShowMinSobivartistTovars(SqlConnection connection); //Показати канцтовари з мінімальною собівартістю одиниці
    void ShowMaxSobivartistTovars(SqlConnection connection); //Показати канцтовари з максимальною собівартістю одиниці
}