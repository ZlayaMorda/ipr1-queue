using System;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Deque<string> Deq = new Deque<string>();
            Deq.Notify += DisplayMessage;

            Console.WriteLine("Add elements to Stack and press Enter to finish" +
                              "\npress 1 to add the first one" +
                              "\npress 2 to add the last one" +
                              "\npress 3 to remove the first one" +
                              "\npress 4 to remove the last one");

            bool temp = true;
            while (temp == true)
            {
                try
                {
                    switch (Console.ReadKey(true).Key)
                    {

                        case ConsoleKey.D1:
                            {
                                Console.Write("member:");
                                Deq.EnqueueFirst(Console.ReadLine());
                                break;
                            }

                        case ConsoleKey.D2:
                            {
                                Console.Write("member:");
                                Deq.EnqueueLast(Console.ReadLine());
                                break;
                            }

                        case ConsoleKey.D3:
                            {
                                string t = Deq.DequeueFirst();
                                break;
                            }

                        case ConsoleKey.D4:
                            {
                                string t = Deq.DequeueLast();
                                break;
                            }

                        case ConsoleKey.Enter:
                            {
                                temp = false;
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("Please, choose what you want to do");
                                break;
                            }
                    }
                }
                catch (InvalidOperationException ex) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{ex.Message}"); 
                    Console.ResetColor();
                    continue;
                }

                catch
                {
                    Console.WriteLine("try again");
                    continue;
                }

            }

            Console.WriteLine($"Size: {Deq.Count()}");
            Deq.Clear();


            Console.ReadKey();



        }

            private static void DisplayMessage(string message)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(message);
                    Console.ResetColor();
                }

        

    }
}
