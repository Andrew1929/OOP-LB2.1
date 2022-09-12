using System;

namespace OOP_LB2._1
{
    class Converter
    {
        public double UsdToGrn { get; set; }
        public double GrnToUsd { get; set; }
        public double EurToGrn { get; set; }
        public double GrnToEur { get; set; }
        public double RubToGrn { get; set; }
        public double GrnToRub { get; set; }
        public Converter(double usd_to_grn,double grn_to_usd, double eur_to_grn,double grn_to_eur, double rub_to_grn,double grn_to_rub)
        {
            this.UsdToGrn = usd_to_grn;
            this.GrnToUsd = grn_to_usd;
            this.EurToGrn = eur_to_grn;
            this.GrnToEur = grn_to_eur;
            this.RubToGrn = rub_to_grn;
            this.GrnToRub = grn_to_rub;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            double UsdToGrn = 36.97;
            double GrnToUsd = 0.027;
            double EurToGrn = 37.11;
            double GrnToEur = 0.027;
            double RubToGrn = 0.61;
            double GrnToRub = 1.63;
            Converter converter = new Converter(UsdToGrn,GrnToUsd,EurToGrn,GrnToEur,RubToGrn,GrnToRub);
            Console.WriteLine("Select currency : 1 - Grn, 2 - Usd, 3 - Eur, 4 - Rub");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("amount of currency:");
            int sum = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            if (i == 1) 
            {
                Console.WriteLine("What currency will you convert to?(1 - Usd , 2 - Eur, 3 - Rub)");
                k = Convert.ToInt32(Console.ReadLine());
            }
            switch (i)
            {
                case (1): 
                    if (k == 1) 
                    {
                        Console.WriteLine($"{sum} grn ---> {sum / converter.UsdToGrn} usd");
                    }
                    else if (k == 2)
                    {
                        Console.WriteLine($"{sum} grn ---> {sum / converter.EurToGrn} eur");
                    }
                    else
                    {
                        Console.WriteLine($"{sum} grn --->  {sum / converter.RubToGrn}  rub");
                    }
                    break;
                case (2):
                    Console.WriteLine($"{sum} usd --->  {sum / converter.GrnToUsd} grn");
                    break;
                case (3):
                    Console.WriteLine($"{sum} eur ---> {sum / converter.GrnToEur} grn");
                    break;
                case (4):
                    Console.WriteLine($"{sum} rub ---> {sum / converter.GrnToRub} grn");
                    break;
                default: Console.WriteLine("incorrect input");
                    break;
            }
            Console.ReadKey();
        }
    }
}
