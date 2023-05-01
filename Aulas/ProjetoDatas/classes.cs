

using System.Security.Cryptography;

public class Modulo11
    {
    public void AulaDaTa()
    {
        var date = new DateTime(2012, 12, 01, 19, 22, 23);
        var date2 = DateTime.Parse("2022/10/02 19:30:20");
        var date3 = DateTime.Now;
        var date4 = DateTime.Today;

        Console.WriteLine(date);
        Console.WriteLine(date2);
        Console.WriteLine(date3);
        Console.WriteLine(date4);

        Console.WriteLine(date.ToString("dd-MM-yyyy HH:mm:ss"));
    }
    

    public void AulaSubtrairData()
    {
        var date1 =  DateTime.Now;
        var date2 = DateTime.Parse("2022-01-01");

        var dif = date1.Subtract(date2);
        Console.WriteLine((int)dif.TotalHours);
        Console.WriteLine((int)dif.TotalDays);


    }
}
