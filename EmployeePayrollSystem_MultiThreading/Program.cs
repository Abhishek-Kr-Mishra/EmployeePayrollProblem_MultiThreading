using System;
using System.Net;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace EmployeePayrollSystem_MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Payroll using threads");

            string[] words = CreateWordArray(@"http://www.gutenberg.org/files/54700/54700-0.txt");

            #region ParallelTasks

            Parallel.Invoke(() =>
            {
                Console.WriteLine("Begin First Task..");
                GetLongestWord(words);
            },
            () =>
                    {
                        Console.WriteLine("Begin Second Task..");
                        GetMostCommonWords(words);
                    }, //Close Second Action

                    () =>
                    {
                        Console.WriteLine("Begin third task..");
                    }//Close Third Action
            );//Close Parellel Invoke
            #endregion
        }

        private static void GetMostCommonWords(string[] words)
        {
            var frequencyOrder = from word in words
                                 where word.Length > 6
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;
            var commonWords = frequencyOrder.Take(10);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The most common words are: ");
            foreach(var v in commonWords)
            {
                sb.AppendLine("  " + v);
            }
            Console.WriteLine(sb.ToString());
        }

        private static string GetLongestWord(string[] words)
        {
            var longestWord = (from w in words
                               orderby w.Length descending
                               select w).First();
            Console.WriteLine($"Task -- The Longest word is {longestWord},");
            return longestWord;
        }

        private static string[] CreateWordArray(string uri)
        {
            Console.WriteLine($"Retrieving Form {uri}");

            string blog = new WebClient().DownloadString(uri);

            return blog.Split(
                new char[] { ' ', '\u000A', ',', '.', ';', ':', '-', '_', '/' },
                StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
