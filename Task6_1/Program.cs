using System.Text.RegularExpressions;

namespace Task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine();
            var splitText = Regex.Split(inputText.Trim(),@"\s+");

            Array.Sort(splitText);
            Console.WriteLine(splitText[splitText.Length - 1]);
            Console.ReadKey();
            //for (int i = 0; i < splitText.Length; i++)
            //{
            //    if ( splitText[i].Length > maxLenght)
            //    {
            //        string value = "";
            //        value += splitText[i];
            //        maxLenght= splitText[i].Length;
            //    }

            //}
           
        }
    }
}
