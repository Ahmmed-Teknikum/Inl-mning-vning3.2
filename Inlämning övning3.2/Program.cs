using System;
using System.Globalization;


namespace inlämning_._övning_._3_._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått i gymnasiet? (Skriv j för ja och n för nej)");
            string skola= Console.ReadLine();

            Console.WriteLine("Hur gammal är du?");
            int år=int.Parse(Console.ReadLine());

            if (skola == "j" && år < 22)
                Console.WriteLine("Vi vill gärna anställa dig");
            else
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
            
        }
    }
}
