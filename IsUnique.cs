using System;
using System.Collections.Generic;

namespace IsUnique
{
    public class IsUnique
    {
        ///<Problem>
        ///Find if a given string has all unique charaters or not.
        ///</Problem>
        ///<Solution>
        ///Insert each character into a Dictionary. If a character is already in the dictionary return false
        ///</solution>
        public static void Main(string[] args){
            Console.WriteLine("Enter the string");
            string input = Console.ReadLine();
            Console.WriteLine($"The string contains unique characters {HasUniqueCharacters(input)}");
            Console.WriteLine($"The string contains unique characters {HasUniqueCharactersNoDS(input)}");
        }
        
        private static bool HasUniqueCharacters(string str){
            var set = new HashSet<char>();
            foreach (var c in str)
            {
                if(set.Contains(c)) 
                    return false;
                set.Add(c);
            }
            return true;
        }
        ///<Problem-2>
        ///Find if a string has duplicate characters without using any additional datastructures
        ///</Problem-2>
        ///<solution>
        ///Compare each character to other characters
        ///</solution>
        private static HasUniqueCharactersNoDS(string str){
            for(int i=0;i<str.Length;i++){
                for(int j=i+1;j<str.Length;j++){
                    if(str[i] == str[j])
                        return false;
                }
            }
            return true;
        }
    }
}