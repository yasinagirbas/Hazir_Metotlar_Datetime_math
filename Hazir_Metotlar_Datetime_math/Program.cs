namespace Hazir_Metotlar_Datetime_math
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine(DateTime.Now); //Günün Tarihini Getirir
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            //add metotları
            
            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(3));
            Console.WriteLine(DateTime.Now.AddYears(1));
            Console.WriteLine(DateTime.Now.AddMilliseconds(60));
            
            //datetime format
            
            Console.WriteLine(DateTime.Now.ToString("dd"));//24
            Console.WriteLine(DateTime.Now.ToString("dddd"));//sat
            Console.WriteLine(DateTime.Now.ToString("dddd"));//saturday
            
            Console.WriteLine(DateTime.Now.ToString("MM"));//04
            Console.WriteLine(DateTime.Now.ToString("MMM"));//apr
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//april
            
            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));
            
            //MATH kütüphanesi
            
            Console.WriteLine(Math.Abs(-25));// eski değer verirseninz artı değerini getirecektir. 25'dir
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));
            
            
            Console.WriteLine(Math.Ceiling(23.4)); //küsüratlı verilerde yarcdımcı oluryor yukarı yuvarlar 24
            Console.WriteLine(Math.Round(22.3));//22 aşağı tyuvarlar
            Console.WriteLine(Math.Floor(22.7));//22
            
            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));
            
            Console.WriteLine(Math.Pow(3,4));//3^4 verir 81
            Console.WriteLine(Math.Sqrt(9));//karakök alır
            Console.WriteLine(Math.Log(9)); // 9 un e tabanındaki logoritmik karşılığını getirir
            Console.WriteLine(Math.Exp(3));// e üzeri 3 verir
            Console.WriteLine(Math.Log10(10)); //10 sayısının 10 tabanındaki karşılığını verir.
            
            
        }
        
    }
}

