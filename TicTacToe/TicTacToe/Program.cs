using System;
using System.Threading;


namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {

            string field1 = "1", field2 = "2", field3 = "3", field4= "4", field5= "5", field6 = "6", field7 = "7", field8 = "8", field9= "9";
            char choice;
            string str;





            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("TicTacToe");
                Console.WriteLine("");
                Console.WriteLine(" {0} | {1} | {2} ", field1, field2, field3);
                Console.WriteLine("---+---+---");
                Console.WriteLine(" {0} | {1} | {2} ", field4, field5, field6);
                Console.WriteLine("---+---+---");
                Console.WriteLine(" {0} | {1} | {2} ", field7, field8, field9);
                Console.WriteLine("");

                Console.Write("Ruch gracza[X]: ");

                str = Console.ReadLine();
                choice = str[0];

                switch (choice) //Przebrzydki switch :<
                {
                    case '1':
                        {
                            if (field1 == "1")
                            {
                                field1 = "X"; break;
                            }
                            else
                            {
                                Console.WriteLine("Pole zajęte!"); break;
                            }
                        }
                    case '2':
                        {
                            if (field2 == "2")
                            {
                                field2 = "X"; break;
                            }
                            else
                            {
                                Console.WriteLine("Pole zajęte!"); break;
                            }
                        }
                    case '3':
                        {
                            if (field3 == "3")
                            {
                                field3 = "X"; break;
                            }
                            else
                            {
                                Console.WriteLine("Pole zajęte!"); break;
                            }
                        }
                    case '4':
                        {
                            if (field4 == "4")
                            {
                                field4 = "X"; break;
                            }
                            else
                            {
                                Console.WriteLine("Pole zajęte!"); break;
                            }
                        }
                    case '5':
                        {
                            if (field5 == "5")
                            {
                                field5 = "X"; break;
                            }
                            else
                            {
                                Console.WriteLine("Pole zajęte!"); break;
                            }
                        }
                    case '6':
                        {
                            if (field6 == "6")
                            {
                                field6 = "X"; break;
                            }
                            else
                            {
                                Console.WriteLine("Pole zajęte!"); break;
                            }
                        }
                    case '7':
                        {
                            if (field7 == "7")
                            {
                                field7 = "X"; break;
                            }
                            else
                            {
                                Console.WriteLine("Pole zajęte!"); break;
                            }
                        }
                    case '8':
                        {
                            if (field8 == "8")
                            {
                                field8 = "X"; break;
                            }
                            else
                            {
                                Console.WriteLine("Pole zajęte!"); break;
                            }
                        }
                    case '9':
                        {
                            if (field9 == "9")
                            {
                                field9 = "X"; break;
                            }
                            else
                            {
                                Console.WriteLine("Pole zajęte!"); break;
                            }
                        }
                    default:
                        Console.WriteLine("Nierozpoznany znak, za karę tracisz ruch!\n");
                        Thread.Sleep(5000);break;
                }
                Console.Clear();
                
           
                Console.WriteLine("TicTacToe");
                Console.WriteLine("");
                Console.WriteLine(" {0} | {1} | {2} ", field1, field2, field3);
                Console.WriteLine("---+---+---");
                Console.WriteLine(" {0} | {1} | {2} ", field4, field5, field6);
                Console.WriteLine("---+---+---");
                Console.WriteLine(" {0} | {1} | {2} ", field7, field8, field9);
                Console.WriteLine("");

                Console.Write("Ruch gracza[O]: ");

                str = Console.ReadLine();
                choice = str[0];

                switch (choice) //Przebrzydki switch :<
                {
                    case '1':
                        {
                            if (field1 == "1")
                            {
                                field1 = "O"; break;
                            }
                            else
                            {
                                Console.WriteLine("Pole zajęte!"); break;
                            }
                        }
                    case '2':
                        {
                            if (field2 == "2")
                            {
                                field2 = "O"; break;
                            }
                            else
                            {
                                Console.WriteLine("Pole zajęte!"); break;
                            }
                        }
                    case '3':
                        {
                            if (field3 == "3")
                            {
                                field3 = "O"; break;
                            }
                            else
                            {
                                Console.WriteLine("Pole zajęte!"); break;
                            }
                        }
                    case '4':
                        {
                            if (field4 == "4")
                            {
                                field4 = "O"; break;
                            }
                            else
                            {
                                Console.WriteLine("Pole zajęte!"); break;
                            }
                        }
                    case '5':
                        {
                            if (field5 == "5")
                            {
                                field5 = "O"; break;
                            }
                            else
                            {
                                Console.WriteLine("Pole zajęte!"); break;
                            }
                        }
                    case '6':
                        {
                            if (field6 == "6")
                            {
                                field6 = "O"; break;
                            }
                            else
                            {
                                Console.WriteLine("Pole zajęte!"); break;
                            }
                        }
                    case '7':
                        {
                            if (field7 == "7")
                            {
                                field7 = "O"; break;
                            }
                            else
                            {
                                Console.WriteLine("Pole zajęte!"); break;
                            }
                        }
                    case '8':
                        {
                            if (field8 == "8")
                            {
                                field8 = "O"; break;
                            }
                            else
                            {
                                Console.WriteLine("Pole zajęte!"); break;
                            }
                        }
                    case '9':
                        {
                            if (field9 == "9")
                            {
                                field9 = "O"; break;
                            }
                            else
                            {
                                Console.WriteLine("Pole zajęte!"); break;
                            }
                        }
                    default:
                        Console.WriteLine("Nierozpoznany znak, za karę tracisz ruch!\n");
                        Thread.Sleep(5000);
                        break;
                }


                Console.Clear();


            }







        }
    }
}
