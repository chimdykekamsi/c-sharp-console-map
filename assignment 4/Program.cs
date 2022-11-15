using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your console GPS \n" +
                "/=============================================/");

            Console.WriteLine("Today's destination is Aptech from Shoprite\n");


            // Name and confirmation
            Console.WriteLine("\n==========================================\n");
            Console.WriteLine("Whats your name\n");
            Console.Write("Reply: ");
            string name = Console.ReadLine();
            Console.WriteLine("\n==========================================\n");
            string verify = "false";
            try
            {
                Convert.ToInt32(name);
            }
            catch (Exception)
            {
                verify = "true";               

            }
            while (verify != "true" || name == "")
            {
                Console.WriteLine("\n==========================================\n");
                Console.WriteLine("\ninvalid input Whats your name \n");
                Console.Write("Reply: ");
                name = Console.ReadLine();
                Console.WriteLine("\n==========================================\n");

                try
                {
                    Convert.ToInt32(name);
                }
                catch (Exception )
                {
                    verify = "true";

                }

            }


            // budget and confirmation
            Console.WriteLine("\n==========================================\n");
            Console.WriteLine("\nWhats your budget\n");
            Console.Write("Reply: ");
            string budget = Console.ReadLine();
            Console.WriteLine("\n==========================================\n");
            string verify2 = "true";

            try
            {
                Convert.ToInt32(budget);
                verify2 = "true";

            }
            catch (Exception)
            {
                verify2 = "false";

            }
            while (verify2 != "true" || budget == "")
            {
                Console.WriteLine("\n==========================================\n");
                Console.WriteLine("\ninvalid input Whats your budget \n");
                Console.Write("Reply: ");
                budget = Console.ReadLine();
                Console.WriteLine("\n==========================================\n");
                try
                {
                    Convert.ToInt32(budget);
                    verify2 = "true";
                }
                catch (Exception)
                {
                    verify2 = "false";

                }

            }


            //Route

            string[] routes = {"New market", "Holy ghost","New layout" };
            Console.WriteLine("\n==========================================\n");
            Console.WriteLine("\nSelect Route");
            for (int i = 0; i < routes.Length; i++)
            {                
                Console.WriteLine($"{i + 1} {routes[i]}");
            }

            Console.Write("Reply: ");
            string routeMode = Console.ReadLine();
            Console.WriteLine("\n==========================================\n");
            string selectedR = "";
            string verify3 = "true";
            try
            {
                Convert.ToInt32(routeMode);
            }
            catch (Exception)
            {
                verify3 = "false";

            }
            while (verify3 != "true" || routeMode == "" || Convert.ToInt32(routeMode) > routes.Length || Convert.ToInt32(routeMode) == 0)
            {
                Console.WriteLine("\n==========================================\n");
                Console.WriteLine("\ninvalid input Select Route !select using their respective numbers\n");
                Console.Write("Reply: ");
                routeMode = Console.ReadLine();
                Console.WriteLine("\n==========================================\n");

                try
                {
                    Convert.ToInt32(routeMode);
                    verify3 = "true";
                }
                catch (Exception)
                {
                    verify3 = "false";

                }

            }
                Console.WriteLine("\n==========================================\n");
            for(int i = Convert.ToInt32(routeMode) - 1; i < routes.Length; i++)
            {
                if (i == Convert.ToInt32(routeMode) - 1)
                {
                    selectedR = routes[i];
                    Console.WriteLine($"\n{selectedR}");
                }

            }
                Console.WriteLine("\n==========================================\n");




            //transportation 

            string[] transports = {"On foot (trekkers association)", "Commercial Bus", "KEKE (Drop)" };
            Console.WriteLine("\n==========================================\n");
            Console.WriteLine($"\nAvailable transport means you can afford {name} \n");
            int tLenth = 0;
            string selectedT = "";
            if (Convert.ToInt32(budget) <= 499 && Convert.ToInt32(budget) >= 300)
            {
                    
                for (int b_t = 0; b_t < transports.Length - 1; b_t++)
                {
                    Console.WriteLine($"{b_t + 1} {transports[b_t]}");
                }
                 tLenth = transports.Length - 1;
            }else if (Convert.ToInt32(budget) < 300) {

                for (int b_t = 0; b_t < transports.Length - 2; b_t++)
                {
                    Console.WriteLine($"{b_t + 1} {transports[b_t]}");
                }
                tLenth = transports.Length - 2;
            }
            else
                {

                    for (int b_t = 0; b_t < transports.Length; b_t++)
                    {
                        Console.WriteLine($"{b_t + 1} {transports[b_t]}");
                    }
                 tLenth = transports.Length; 


                }
            Console.Write("Reply: ");
            string transportMode = Console.ReadLine();
            Console.WriteLine("\n==========================================\n");

            string verify4 = "true";
            try
            {
                Convert.ToInt32(transportMode);
            }
            catch (Exception)
            {
                verify4 = "false";

            }
            while (verify4 != "true" || transportMode == "" || Convert.ToInt32(transportMode) == 0 || Convert.ToInt32(transportMode) > tLenth)
            {
                Console.WriteLine("\n==========================================\n");
                Console.WriteLine($"\nInvalid input select mode of transport !select using their respective numbers\n");
                Console.Write("Reply: ");
                transportMode = Console.ReadLine();
                Console.WriteLine("\n==========================================\n");

                try
                {
                    Convert.ToInt32(transportMode);
                    verify4 = "true";
                }
                catch (Exception)
                {
                    verify4 = "false";

                }

            }
            for (int i = Convert.ToInt32(transportMode) - 1; i < transports.Length; i++)
            {
                if (i == Convert.ToInt32(transportMode) - 1)
                {
                    selectedT = transports[i];
                   
                }

            }
            Console.WriteLine("\n==========================================\n");
            Console.WriteLine("\n\npress any key to continue\n\n");
            Console.ReadKey();
            Console.WriteLine("\n==========================================\n");
            //Map navigation
            //"New market", "Holy ghost","New layout"
            // "On foot (trekkers association)", "Commercial Bus", "KEKE (Drop)" 


            // New market

            if (selectedR.ToLower() == "new market")
            {
                //on foot
                if(selectedT.ToLower() == "on foot (trekkers association)")
                {
                    Console.WriteLine("\n==========================================\n");
                    Console.WriteLine($"On route new market on foot");
                    int Remainfund = Convert.ToInt32(budget) - 0;

                    Console.WriteLine("Estimated time of Journey = 1hour 20mins  \n" +
                    $"Estimated budget to remain {Remainfund} \n  ...press any key to continue\n" +
                    $"====================================================\n");

                    Console.WriteLine("Head southwest toward Polo Park Rd\r\n Pass by 9Mobile Experience Centre, Enugu Polo Mall (on the right)\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                    
                    Console.WriteLine("After 130m Turn right onto Polo Park Rd\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                    
                    Console.WriteLine("After 35m Turn right to stay on Polo Park Rd\r\n Pass by KOBB Civic Center (on the left in 40m)\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                      
                    Console.WriteLine("After 120m At the roundabout, take the 1st exit onto Abakaliki Rd\r\n Go through 1 roundabout\r\n Pass by the church (on the left in 98m)\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                       
                    Console.WriteLine("After 1.9 km At the roundabout, take the 3rd exit onto Works Rd\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                          
                    Console.WriteLine("After 66 m Turn right\r\n Pass by Bet9Ja Shop (on the right in 53m)\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                             
                    Console.WriteLine("After 220 m Turn right at CY COSMETICS AND WEAVON\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                                
                    Console.WriteLine("After 80 m Turn left\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                                     
                    Console.WriteLine("After 36 m Turn right\n new market will be on the right\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                                       
                    Console.WriteLine("After 0 m from New market Head southeast\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                                        
                    Console.WriteLine("After 90 m Turn left\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                                         
                    Console.WriteLine("After 36 m Turn right toward Works Rd\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                                             
                    Console.WriteLine("After 170 m Turn right at Don Chika Communication onto Works Rd\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                                           
                    Console.WriteLine("After 100 m Sharp left at dnuku enterprise onto Iva Valley Rd/Old Enugu-Onitsh Express\r\n Go through 1 roundabout\r\n Pass by the park (on the left in 130m)\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                                           
                    Console.WriteLine("After 1.1 km Turn right onto The Ridgeway/Udogy St\r\n Pass by National Teachers Institute (on the right in 68m)\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                                       
                    Console.WriteLine("After 130 m Turn left at Bevina Resources Limited onto Bank Ave\r\n Pass by MDCN Office Enugu Branch (on the left)\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                                       
                    Console.WriteLine("After 270 m Turn right at Idinas Technical Services onto Okpara Ave\r\n Pass by UBA ATM Gallery (on the left in 28m)\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                                 
                    Console.WriteLine("After 290 m At the roundabout, take the 1st exit onto Market Rd/Ogui Rd\r\n Go through 1 roundabout\r\n Pass by Rosac Communications (on the right in 63m)\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                    
                    Console.WriteLine("After 950 m Slight right at Successbase Automobiles onto Zik Ave\r\n Pass by Philip Company (on the left in 170m)\r\n Destination will be on the right\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                    
                    Console.WriteLine("walk 800 m Welcome to Aptech Computer Education, Enugu Center\r\n50 Zik Ave, Achara 400105, Enugu\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                    
                }
                
                // on bus

                else if(selectedT.ToLower() == "commercial bus")
                {
                    Console.WriteLine("\n==========================================\n");
                    Console.WriteLine($"On route new market on commercial bus");
                    int Remainfund = Convert.ToInt32(budget) - 300;

                    Console.WriteLine("Estimated time of Journey = 1hour 20mins  \n" +
                    $"Estimated budget to remain {Remainfund} \n  ...press any key to continue\n" +
                    $"====================================================\n");

                    Console.WriteLine("Head southwest toward Polo Park Rd\r\n Pass by 9Mobile Experience Centre, Enugu Polo Mall (on the right)\n" +
                        "...press any key to continue\n");
                    Console.ReadKey();
                }

                //Keke

                else if (selectedT.ToLower() == "keke (drop)")
                {
                    Console.WriteLine("\n==========================================\n");
                    Console.WriteLine($"On route new market in a keke (drop)");
                    int Remainfund = Convert.ToInt32(budget) - 500;

                    Console.WriteLine("Estimated time of Journey = 30mins  \n" +
                    $"Estimated budget to remain {Remainfund} \n  ...press any key to continue\n");
                }

                
            }
            

            

            Console.ReadKey();
        }
    }
}
