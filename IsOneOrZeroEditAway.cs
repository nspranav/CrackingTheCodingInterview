using System;
using System.Collections.Generic;

namespace IsOneOrZeroEditsAway
{
    public class IsOneOrZeroEditsAway{
        public static void Main(string[] args){
            Console.WriteLine("Enter the first String: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string: ");
            string str2 = Console.ReadLine();
            Console.WriteLine($"is one or zero edits away: {isOneOrZeroEditsAway(str1,str2)}");
        }

        private static bool isOneOrZeroEditsAway(string str1, string str2){
            if(str1==null||str2==null) return false;
            if(str1.Length==str2.Length){
                return checkForReplacement(str1,str2);
            }else if(str1.Length+1 == str2.Length){
                //The idea is to have larger string as first argument 
                return checkForInsertion(str2,str1);
            }else if(str2.Length+1 == str1.Length){
                return checkForInsertion(str1,str2);
            }
            return false;
        }

        private static bool checkForReplacement(string str1,string str2){
            //I don't need to check for the last character because
            //if there is a mismatch only at he last character of the string 
            //then it is one edit away. If ther is a mismatch in between and in the last character
            // "abcde" and "abfdj" then the substring equality returns false 
            for(int i=0;i<str1.Length-1;i++){
                if((str1[i]!=str2[i])){
                      return str1.Substring(i+1).Equals(str2.Substring(i+1));      
                }
            }
            return true;
        }

        //For this function str1.Length is always > str2.Length 
        private static bool checkForInsertion(string str1,string str2){
            for(int i=0;i<str2.Length;i++){
                if(str2[i]!=str1[i]){
                    return str2.Substring(i).Equals(str1.Substring(i+1));
                }
            }
            return true;            
        }
    }
}