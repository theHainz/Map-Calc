using System.Globalization;

namespace Map_Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string Answer;
            Console.WriteLine("Hello! Welcome to the Map Calculator!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Calculate how big are the lines on the map? type: 1");
            Console.WriteLine("Calculate the Scale via Real Length and Length on Map? type: 2");
            Console.WriteLine("Calculate the area on a map with a scale and the real life area size? type:3");
            Answer = Console.ReadLine();
            switch(Answer) {
                case "1":
                   option1();   
                break;
                
                case "2":
                    option2();
                    break;
                
                case "3":
                    
                    break;
            }
            
            void option1()
            {
                int Scale;
                string Scalestring;
                Console.WriteLine("Alright!");
                Console.WriteLine("Firstly give me a scale in cm");
                Scalestring = Console.ReadLine();
                Scale = Convert.ToInt32(Scalestring);

                string Answer;
                Console.WriteLine("Alright so the scale is " + Scale + " Correct?");
                Console.WriteLine("t/n");
                
                Answer = Console.ReadLine();

                if (Answer == "t")
                {
                  Console.WriteLine("Great!");
                  Console.WriteLine("Now tell me what's the length on map? Also in CM please.");

                  string MapLengthString;
                  double MapLength;

                  MapLengthString = Console.ReadLine();
                  MapLength = Convert.ToDouble(MapLengthString);

                  double Answert = MapLength * Scale;
                  
                  Console.WriteLine("the Answer is " + Answert + " cm");
                }
                else if (Answer == "n")
                { 
                    option1();
                }
                else
                {
                    Console.WriteLine("Pardon?");
                }
            }

            void option2()
            {
               

                double RealLength;
                string RealLengthString;
                double MapLength;
                string MapLengthString;
                double RealLengthincm;
                double Scalenoteven;
                int Scaleeven;

                Console.WriteLine("Firstly will the real length be in meters or kilometers?");
                string Answer;
                Answer = Console.ReadLine();

                if (Answer == "meters")
                {
                    Console.WriteLine("Alright!");
                    Console.WriteLine("So what's the real length?");

                    var culture = new CultureInfo("de-DE");

                    RealLengthString = Console.ReadLine(); // assuming 30000
                    RealLength = double.Parse(RealLengthString, culture);

                    RealLengthincm = RealLength * 100;
                    Console.WriteLine("now what's the length on the map in cm");

                    MapLengthString = Console.ReadLine(); // assuming 8,5
                    MapLength = double.Parse(MapLengthString, culture);

                    //RealLengthincm and Maplength are taken from the user 
                    Scalenoteven = RealLengthincm / MapLength;
                    Scaleeven = (int)Math.Round(Scalenoteven, 0, MidpointRounding.ToZero);
                    Console.WriteLine("The Scale is 1:" + Scaleeven); // outputs 1:352941
                }
            }
        }
    }

   
}