susing System;

namespace AssignmentOneQueue
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("1.Finite Size(10) of String Type\n2.Custom Length of String type\n3.Infinite Length of String Type\n4.Finite Size(10) of Generic Type\n5.Custom Length of String type\n6.Infinite Length of String Type");

                int.TryParse(Console.ReadLine(), out int choice);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Size of Queue = 10;");
                        QueueGeneric<String> qString = new QueueGeneric<string>();
                        ContFunction(qString);
                        break;
                    case 2:
                        Console.WriteLine("Custom length:");
                        Console.WriteLine("What size of Array??");
                        int.TryParse(Console.ReadLine(), out int cSize);
                        QueueGeneric<String> cString = new QueueGeneric<string>(cSize);
                        ContFunction(cString);
                        break;
                    case 3:
                        Console.WriteLine("Infinite Length:");
                        QueueGeneric<String> infString = new QueueGeneric<string>();
                        infString.InfOption = true;
                        ContFunction(infString);
                        break;
                    case 4:
                        Console.WriteLine("Size of Queue = 10;");
                        Console.WriteLine("Type: ");
                        bool a = true;
                        Type myType = Type.GetType("bool");
                        QueueGeneric<String> fGeneric = new QueueGeneric<string>();
                        ContFunction(fGeneric);
                        break;
                    case 5:
                        Console.WriteLine("Custom length:");
                        Console.WriteLine("What size of Array??");
                        int.TryParse(Console.ReadLine(), out cSize);
                        QueueGeneric<String> cGeneric = new QueueGeneric<string>(cSize);
                        ContFunction(cGeneric);
                        break;
                    case 6:
                        Console.WriteLine("Infinite Length:");
                        QueueGeneric<String> infGeneric = new QueueGeneric<string>();
                        infGeneric.InfOption = true;
                        ContFunction(infGeneric);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void ContFunction(QueueGeneric<String> qString)
        {
            bool continuee = true;
            while (continuee)
            {
                Console.WriteLine("1.Queue\n2.Remove From Queue\n3.Display\n4.GoBack");
                String schoice = Console.ReadLine();
                if (schoice == "1")
                {
                    bool con = true;
                    do
                    {
                        Console.WriteLine("Enter string to Queue");
                        if (qString.InfOption)
                        {
                            qString.AddItem(Console.ReadLine());
                        }
                        else
                        {
                            qString.AddItemF(Console.ReadLine());
                        }
                        
                        Console.WriteLine("Continue? (y/n)");
                        String key = Console.ReadLine();
                        if (key.ToLower() == "n")
                        {
                            con = false;
                        }
                    } while (con);
                }
                else if (schoice == "2")
                {
                    bool con = true;
                    do
                    {
                        qString.RemoveItem();
                        Console.WriteLine("Remove More? (y/n)");
                        String key = Console.ReadLine();
                        if (key.ToLower() == "n")
                        {
                            con = false;
                        }
                    } while (con);
                }
                else if (schoice == "3")
                {
                    qString.Iterate();
                }
                else if (schoice == "4")
                {
                    break;
                }
            }
        }
    }
}
