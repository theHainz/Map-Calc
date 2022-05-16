using System.Globalization;

namespace Map_Calc
{
    internal class Program
    {
        static void Main(string[] args)
            {

                var culture = new CultureInfo("de-DE");

                string Answer;
                Console.WriteLine("Hello! Welcome to the Map Calculator!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Calculate how big are the lines on the map? type: 1");
                Console.WriteLine("Calculate the Scale via Real Length and Length on Map? type: 2");
                Console.WriteLine("Calculate area size? type: 3");
                Answer = Console.ReadLine();
                switch (Answer)
                {
                    case "1":
                        option1();
                        break;

                    case "2":
                        option2();
                        break;
                    case "3":
                        option3();
                        break;
                }

                void option1()
                {
                    int Scale;
                    string Scalestring;
                    Console.WriteLine("Alright!");
                    Console.WriteLine("Firstly give me a scale in cm");
                    Scalestring = Console.ReadLine();
                    Scale = Int32.Parse(Scalestring, culture);

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
                        MapLength = Double.Parse(MapLengthString, culture);

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
                    else if (Answer == "kilometers")
                    {
                        Console.WriteLine("Alright!");
                        Console.WriteLine("So what's the real length?");

                        RealLengthString = Console.ReadLine(); // assuming 30000
                        RealLength = double.Parse(RealLengthString, culture);

                        RealLengthincm = RealLength * 100000;
                        Console.WriteLine("now what's the length on the map in cm");

                        MapLengthString = Console.ReadLine(); // assuming 8,5
                        MapLength = double.Parse(MapLengthString, culture);

                        //RealLengthincm and Maplength are taken from the user 
                        Scalenoteven = RealLengthincm / MapLength;
                        Scaleeven = (int)Math.Round(Scalenoteven, 0, MidpointRounding.ToZero);
                        Console.WriteLine("The Scale is 1:" + Scaleeven); // outputs 1:352941
                    }
                    else
                    {
                        Console.WriteLine("hmmm.... Somethings not right");
                        Console.WriteLine("Would you like to try again?");
                        Console.WriteLine("y/n");
                        string Answer3;
                        Answer3 = Console.ReadLine();
                        if (Answer3 == "y")
                        {
                            option2();
                        }
                        else if (Answer3 == "n")
                        {
                            Console.WriteLine("Alright...");
                        }
                    }
                }
                void option3()
                {
                    int Skala;
                    int Skala2;
                    double Area;
                    string Skalastring;
                    string Skalastring2;
                    string Areastring;
                    double Area2;
                    double Area3;
                    double Area4;
                    Console.WriteLine("Alright!");
                    Console.WriteLine("Give me a Scale");
                    Skalastring = Console.ReadLine();
                    Skalastring2 = Skalastring.TrimEnd((char)0);
                    Skala = Convert.ToInt32(Skalastring2);
                                       
                    
                    Console.WriteLine("Alright");
                    Console.WriteLine("Now the size of the area in ha");
                    Areastring = Console.ReadLine();
                    Areastring.TrimEnd((char)0);
                    Area = Convert.ToDouble(Areastring);
                    Area2 = Area * 10;
                    Area3 = Area2 / Skala;
                    Area4 = Area3 * 2;
                    
                    Console.WriteLine("the size of the area is " + Area4 + "dm2");
                }
            }
        }
    }

    