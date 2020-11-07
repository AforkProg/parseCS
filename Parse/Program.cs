using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            Console.WriteLine("Type user`s name: ");
            string name = Console.ReadLine();
            string path = "data.txt";
            StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                int counter = 0;
                for (int a = 0; a < line.Length; a++)
                {
                    if (line[a] == '|')
                        counter++;
                }
                if (counter != 7)
                    continue;
                else
                {
                    Regex regex = new Regex(@"\b" + name + @"\b");
                    MatchCollection match = regex.Matches(line);
                    if (match.Count > 0)
                    {
                        check = true;
                        Console.WriteLine(line);
                    }
                    else
                        continue;
                }
            }
            Console.WriteLine("Parsing complited!\n");
            if (check == false)
            {
                Console.WriteLine("There is no result!\n");
            }
        }
    }
}