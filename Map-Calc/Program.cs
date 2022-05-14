

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
            Console.WriteLine("");
            Answer = Console.ReadLine();
            switch(Answer) {
                case "1":
                   option1();   
                break;
                
                case "2":

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
        }
    }

   
}