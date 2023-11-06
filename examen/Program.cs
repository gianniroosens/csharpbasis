namespace examen;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        string cursor = ">";


        while (isRunning)
        {
            Console.Write(cursor);
            string inputUser = Console.ReadLine();

            switch (inputUser.ToLower())
            {
                case "set":
                    TestWaarden();
                    break;

                case "info":
                    InfoGegevens();
                    // functie maken die alle inputwaarden weergeeft
                    break;
                case "default":
                    break;
                    // functie maken en de inputwaarden naar default zetten
                case "run":
                    break;
                    //functie maken om programma te runnen

         
            }
        }

    }
    static private void TestWaarden()
    {
        Console.Write("Kamertemperatuur: ");
        string inputKamerTemp = Console.ReadLine() ?? "";
        if (decimal.TryParse(inputKamerTemp, out decimal userInputKamerTemp))
        {
       
            Console.WriteLine($"{userInputKamerTemp.ToString("F2")}°C");
        }
        else
        {
            Console.WriteLine("Foutieve waarden, voer opnieuw in door opnieuw set in te geven");

        }
        Console.Write("Voer de gemeten temperatuur in: ");
        string inputGemetenTemp = Console.ReadLine() ?? "";
        if (decimal.TryParse(inputGemetenTemp, out decimal userInputGemetenTemp))
        {
            Console.WriteLine($"{userInputGemetenTemp.ToString("F2")}°C");
        }
        else
        {
            Console.WriteLine("Foutieve waarden, voer opnieuw in door opnieuw set in te geven");

        }
        Console.Write("Voer de luchtvochtigheid in: ");
        string inputLuchtVochtigheid = Console.ReadLine() ?? "";
        if (int.TryParse(inputLuchtVochtigheid, out int userInputLuchtVochtigheid))
        {
            Console.WriteLine($"{userInputLuchtVochtigheid}%");
        }
        else
        {
            Console.WriteLine("Foutieve waarden, voer opnieuw in door opnieuw set in te geven");

        }
        Console.Write("Voer de keteldruk in: ");
        string inputKetelDruk = Console.ReadLine() ?? "";
        if (double.TryParse(inputKetelDruk, out double userInputKetelDruk))
        {
            Console.WriteLine($"{userInputKetelDruk} bar");
        }
        else
        {
            Console.WriteLine("Foutieve waarden, voer opnieuw in door opnieuw set in te geven");

        }
      

    }
    private static void InfoGegevens()
    {
       
    }    
    private static void Default()
    {
        
    }
    private static void RunProgram()
    {
        // regels
        decimal userInputGewensteTemp;
        decimal userInputGemetenTemp;
        int userInputLuchtVochtigheid;
        double userInputKetelDruk;
     


        while (userInputGewensteTemp < userInputGemetenTemp -2)
        {



            userInputGewensteTemp = userInputGewensteTemp + 0.2M;
            
       

            if (userInputLuchtVochtigheid > 90 && userInputKamerTemp < userInputGemetenTemp)
            {
                userInputKamerTemp = userInputKamerTemp + 0.2M;

            }

            if (userInputKetelDruk < 2 && userInputKetelDruk > 3)
            {
                Console.WriteLine("Veiligheidsboodschap");
                Console.WriteLine("Ketel wordt uitgeschakeld");

            }
        }
        Console.WriteLine($"Gewenste temperatuur behaald {userInputGewensteTemp} C");



        //uitvoeren test



            

        
           


    }
       

}

