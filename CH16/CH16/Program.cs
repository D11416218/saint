using System;

namespace CH16
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight, heightCm, heightM, bmi;

            Console.Write("請輸入體重（公斤）：");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("請輸入身高（公分）：");
            heightCm = Convert.ToDouble(Console.ReadLine());

            if (heightCm <= 0 || weight <= 0)
            {
                Console.WriteLine("錯誤：身高和體重必須為正數。");
            }
            else
            {
                // 將公分轉換為公尺
                heightM = heightCm / 100;

                // 計算BMI
                bmi = weight / (heightM * heightM);

                Console.WriteLine("您的BMI值為：" + Math.Round(bmi, 2));
            }
    }
}
}
