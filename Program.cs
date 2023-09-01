using System.ComponentModel.Design;

namespace Class02File
{
    public class Program
    {
        public static void Main()
        {
            //*********************************** How To Create A File Using c# **************************************

            FileManager fileManager = new FileManager();
            string menu;
            string fileName = "grades.txt";
            

            do
            {
                // Menu Structure for assignment
                Console.WriteLine("1. Write data to file");
                Console.WriteLine("2. Read data from file");
                Console.WriteLine("3. Exit");
                menu = Console.ReadLine();

                if (menu == "1")
                {
                    fileManager.fileWrite(fileName);
                }
                else if (menu == "2")
                {
                    if (File.Exists(fileName))
                    {
                        fileManager.fileRead(fileName);
                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }

                }
                 
            } while (menu != "3");
        }
    }
}