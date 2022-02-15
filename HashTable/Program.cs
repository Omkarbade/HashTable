using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HashTable Program");
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            CountFrequencyofWords(paragraph);
            Console.ReadLine();
        }
        //Count the frequency of the words
        public static void CountFrequencyofWords(string paragraph)
        {
            MyMapNode<string, int> myMapNode = new MyMapNode<string, int>(6);
            string[] words = paragraph.Split(' ');
            foreach (string word in words)
            {
                if (myMapNode.Exists(word))
                    myMapNode.Add(word.ToLower(), myMapNode.Get(word) + 1);
                else
                    myMapNode.Add(word.ToLower(), 1);
            }
            Console.WriteLine("Display after add operation\n");
            myMapNode.Display();
            Console.WriteLine("\nRemove word avoidable from hash table");
            string a = "avoidable";
            myMapNode.Remove(a);
            Console.WriteLine("Element in hash table after removal of words\n");
            myMapNode.Display();
        }
    }
}
