using System;

class Program
{
    static void Main()
    {
        Console.Write("請輸入體重（公斤）：");
        string weightInput = Console.ReadLine();
        double weight = Convert.ToDouble(weightInput);

        Console.Write("請輸入身高（公尺）：");
        string heightInput = Console.ReadLine();
        double height = Convert.ToDouble(heightInput);

        double bmi = weight / (height * height);

        Console.WriteLine($"您的 BMI 是：{bmi:F2}");
        Console.Read();
    }
}
