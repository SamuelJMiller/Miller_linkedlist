using System;

namespace Miller_linkedlist
{
    class Program
    {
        // Helper functions
        static void write()
        {
            Console.WriteLine();
        }

        static void write(string s)
        {
            Console.WriteLine(s);
        }

        static string read()
        {
            string s = Console.ReadLine();
            return s;
        }

        static void print_menu()
        {
            write("To select an option to perform, press its number followed by enter:");
            write("1. Add an item to the end of the list");
            write("2. Remove an item from the list");
            write("3. Search for an item");
            write("4. Print all nodes from front to back");
            write("5. Exit the program");
        }

        static void Main(string[] args)
        {
            // Holds list to be operated on
            LinkedList list = new LinkedList();

            // Holds user input
            string option = string.Empty;
            string usertext = string.Empty;

            do
            {
                print_menu();

                option = read();

                switch (option)
                {
                    case "1":
                        write("Enter item to add to the list:");
                        write();

                        usertext = read();
                        list.add(usertext);

                        write("Item " + usertext + " added");

                        write();
                        break;
                    case "2":
                        write("Enter item to remove:");
                        write();

                        usertext = read();

                        bool isremoved = list.remove(usertext);

                        if (isremoved == true)
                        {
                            write("Item removed!");
                        } else
                        {
                            write("No item removed, item not found.");
                        }

                        write();
                        break;
                    case "3":
                        write("Enter item to find:");
                        write();

                        usertext = read();
                        Node n = list.contains(usertext);
                        
                        if (n != null)
                        {
                            write("Found item " + n.Data + " in a node");
                        } else
                        {
                            write("Item not found!");
                        }

                        write();
                        break;
                    case "4":
                        write("List of nodes in order of addition:");
                        write();

                        list.print_all_nodes();

                        write();
                        break;
                }
            } while (option != "5");
        }
    }
}
