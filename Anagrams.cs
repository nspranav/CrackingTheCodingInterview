using System;
using System.Collections.Generic;

namespace Anagram
{
    public class Anagram
    {
        public static void Main(string[] args){
            Console.WriteLine("Enter the string 1");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the string 2");
            string str2 = Console.ReadLine();
            Console.WriteLine($"Are they anagrams: {CheckForAnagrams(str1,str2)}");
        }
        //Assumption that the spaces do matter i.e. "dog    " is different from "god"
        //Assumption that the strings are case sensitive i.e. "dog" is different from "God"
        
        //Algorithm: First check for the string lengths if they do not match then they cannot be anagrams
        //For first string puteach character as key  and 1 as value into a hashtable or in our case it is Dictionary
        //Increment the value if the character repeats
        //Next for each character in the second string check if the charater is in the Dictionary
        //If it is not then the strings are not Anagrams
        //if the character exists then we decrement the value for that key. If at anytime the value for a key is less than zero
        //then ther is an extra character in the second string we return false
        
        private static bool CheckForAnagrams(string str1,string str2){
            if(str1.Length!=str2.Length) return false; // this takes care of case aaaa, aaab
            Dictionary<char,int> map = new Dictionary<char,int>();
            foreach (char c in str1)
            {
                if(map.ContainsKey(c)){
                    map[c]++; 
                }else{
                    map.Add(c,1);
                }
            }
            foreach (char c in str2)
            {
                if(!map.ContainsKey(c)){ //this will return false for 'b' in aaab
                    return false;
                }else{
                    map[c]--;
                    if(map[c]<0) return false; //this takes care of aabc,
                    //aaac we have all the characters of second string in first onr
                    //it will escape containsKey(c) check  
                }
            }
            return true;
        }
    }
}