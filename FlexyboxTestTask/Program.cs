using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FlexyboxTestTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            var instances = InstanceService<Vehicle>.GetInstances();

            instances = instances.OrderBy(x => x.GetType().ToString()).ToList();

            foreach (var instance in instances)
            {
                Console.WriteLine(instance.GetType().ToString());
            }

            var search = Search("car", instances).ToList();

            WriteToDiskService writeService = new WriteToDiskService();
            writeService.Write(instances);

            var str = ReverseString("Lorem ipsum dolor sit amet");

            var isPalindrome = IsPalindrome("A man, a plan, a canal, Panama!");

            var missingElements = MissingElements(new int[] {2, 3, 4}).ToList();

            Console.ReadLine();
        }

        public static IEnumerable<Vehicle> Search(string query, IEnumerable<Vehicle> instances)
        {
            return instances.Where(x => x.GetType().ToString().ToUpper().Contains(query.ToUpper()));
        }

        public static string ReverseString(string s)
        {
            var charArray = 
                s.Select((value, index) => new {value, index})
                    .OrderByDescending(x => x.index)
                    .Select(v => v.value)
                    .ToArray();
            return new string(charArray);
        }

        public static bool IsPalindrome(string s)
        {
            var reverse = ReverseString(s);

            reverse = Regex.Replace(reverse, "[^0-9a-zA-Z]+", "").ToUpper();
            s = Regex.Replace(s, "[^0-9a-zA-Z]+", "").ToUpper();

            return reverse.Equals(s);
        }

        public static IEnumerable<int> MissingElements(int[] arr)
        {
            return Enumerable.Range(arr.Min(), arr.Max() - arr.Min())
                             .Except(arr);
        }
    }
}
