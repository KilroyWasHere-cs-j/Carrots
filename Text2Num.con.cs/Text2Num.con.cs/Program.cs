using System;
using System.IO;
using System.Linq;

namespace Text2Num.con.cs
{
    class Program
    {
        static long count = 0;
        static string queryTxt = "";
        static void Main(string[] args)
        {
            Console.WriteLine("<----Set query---->");
            queryTxt = Console.ReadLine();
            queryTxt = queryTxt.ToLower();
            Console.WriteLine("<----Press enter to start---->");
            Console.ReadKey();
            Console.WriteLine("<----Starting---->");
            string txtFilePath = "Words1.txt";
            string[] lines = File.ReadAllLines(txtFilePath);
            foreach(string line in lines)
            {
                if(line.Contains(",") == true)
                {
                    int index = line.IndexOf(",");
                    string modLine = line.Substring(0, index);
                    modLine = modLine.ToLower();
                    modLine = modLine.Replace(",", "");
                    count++;
                    Console.WriteLine(count + "-" + modLine);
                    query(modLine, count);
                }
                else
                {
                    if(line.Contains(";") == true)
                    {
                        int index = line.IndexOf(";");
                        string modLine = line.Substring(0, index);
                        modLine = modLine.ToLower();
                        modLine = modLine.Replace(";", "");
                        count++;
                        Console.WriteLine(count + "-" + modLine);
                        query(modLine, count);
                    }
                    else
                    {
                        count++;
                        Console.WriteLine(count + "-" + line.ToLower());
                        query(line, count);
                    }
                }
            }
            //string fdfdf = File.ReadLines("Words1.txt").Skip(1).Take(1).First();
            Console.WriteLine($"<----There are {count} items in {txtFilePath}---->");
            Console.WriteLine("<----Done---->");
            Console.ReadKey();
        }

        static void query(string line, long lineNumber)
        {
            if(line == queryTxt)
            {
                Console.WriteLine($"<----Data line {lineNumber}---->");
                Console.WriteLine("<----Query found---->");
                Console.ReadKey();
            }
            else
            {

            }
        }
    }
}
