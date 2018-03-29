using System;
using System.Collections.Generic;

namespace IsPermutationOfPalindrome
{
    public class IsPermutationOfPalindrome{
        public static void Main(string[] args){
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            Console.WriteLine($"Is Permutation of Palindrome: {isPermutationofPalindrome(str)}");
        }
        //Problem: Find if a given string is a Permutation of a Palindrome string
        // Assumptions: none
        //Approach: For a string to be palindrome every character must have a pair(aabbcc "abccba" ) except for one character
        //if the length of the string is odd(abaaa "aabaa"). If we generalise the above statement then technically a palinodrome string
        //can have at most one individual character and rest should be pairs. 
        //My algorithm: For each character add it to Dictionary and set it to true for odd occurence (1,3,5...) also increment the counter
        //If the character is repeated then set the value to false if true and decrement the counter and vice versa. By the end of the string the counter must
        //be either 0 or 1. If it is greater than 1 then it is not a palindrome (abca). Even though the "abca" has even number of characters
        //it does not make a palindrome

        private static bool isPermutationofPalindrome(string str){
            Dictionary<char,bool> map = new Dictionary<char,bool>();
            int count = 0;

            foreach (var c in str)
            {
                if(map.ContainsKey(c)){
                    if(map[c]){
                        map[c] = false;
                        count--;
                    }else{
                        map[c] = true;
                        count++;
                    }
                }else{
                    map.Add(c,true);
                    count++;
                }
            }
            return count>1?false:true;
        }
    }
}