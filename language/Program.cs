namespace language
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // inputs for target language and translation
            // read functionality
            // fake DB
            Dictionary<string, string> database = new Dictionary<string, string>();

            // fails
            int fail = 1;

            Console.WriteLine("Welcome to the Language App");
            Console.WriteLine("Choose from the menu: ");

            while (fail <= 3) 
            {
                Console.WriteLine("");
                // choice
                Console.WriteLine("- Press 1 for adding words");
                Console.WriteLine("- Press 2 for showing words");
                Console.WriteLine("- Press 3 for exit");
                Console.WriteLine("- Press 4 for clearing database");
                // input
                Console.Write("input:  ");
                string choice = Console.ReadLine();
                Console.WriteLine("");

                // Adding words
                if (choice == "1")
                {
                    //adding data to database
                    Console.Write("word: ");
                    string word = Console.ReadLine();
                    Console.Write("translation: ");
                    string translation = Console.ReadLine();

                    database.Add(word, translation);
                    Console.WriteLine("SUCCESS: Words successfully added.");
                   
                }
                // showing words
                else if (choice == "2")
                {
                    // checking if database is empty
                    bool isEmpty = (database.Count == 0);

                    if (isEmpty)
                    {
                        Console.WriteLine("Database is empty");
                    }

                    Console.WriteLine("WORDS: ");
                    Console.WriteLine($"word - translation");
                    //looping database
                    foreach (var item in database)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                } 
                // exiting 
                else if (choice == "3") {
                    Console.WriteLine("thank you for using our app");
                    return;

                } 
                // deleting data from DB
                else if (choice == "4") {
                    Console.WriteLine("Are you sure you want delete all your data?");
                    Console.Write("input:  ");
                    string delete = Console.ReadLine();

                    if (delete == "yes") {
                        database.Clear();
                        Console.WriteLine("SUCCESS: Database was cleared");
                    } 
                
                } 
                // wrong input
                else
                {
                    Console.WriteLine("ERROR: Wrong input. Please use menu.");
                    // increment
                    fail++;
                }
                
            }
            // checking if we failed 3x
            if (fail > 3) {
                Console.WriteLine("Many wrong inputs. Quit.");
            } 

        }
    }
}