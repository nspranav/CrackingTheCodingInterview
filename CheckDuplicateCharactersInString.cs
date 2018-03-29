using System;
using System.Collections;
using System.Collections.Generic;

namespace CheckDuplicateCharactersInString
{
    public class CheckDuplicateCharactersInString
    {
        public static void Main(string[] args){
            Console.WriteLine("Enter a string ");
            string str = Console.ReadLine();
            Console.WriteLine(HasUniqueChars(str));
        }
        public static bool CheckDuplicateCharacters(string str){
            HashSet<char> hs  = new HashSet<char>(); 
            foreach(char c in str){
                if(hs.Contains(c)){
                    return true;
                }
                else 
                    hs.Add(c);
            }
            return false;
        }

        public static bool HasUniqueChars(string str){
            int checker =0 ;
            for(int i=0;i<str.Length;i++){
                int val = str[i] - 'a';
                if((checker & (1 << val ))> 0){
                    return false;
                }
                checker |= (1 << val);
            }
            return true;
        }
    }
}