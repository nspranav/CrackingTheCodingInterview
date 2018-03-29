using System;
using System.Collections;
using System.Text;

namespace CompressString
{
    public class CompressString{
    
        public static void Main(string[] args){
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();
            Console.WriteLine($"Compressed string is: {CompressedString(str)}");
        }
    //problem: given a string compress it to show the number of counts the character repeats consecutively
    //If the compressed string length is greater than the given string then return the original string else return the 
    //compressed string
    //example: aabbcc is a2b2c2 and aabbc is aabbc because compressed string aabbc is a2b2c1 which has more length, 6,
    //Algorithm: I'm using the C# stringbuilder's feature which is A StringBulder will have a Capacity and MaxCapacity
    //properties. Capacity of StringBuilder can grow upto MaxCapacity if explicity specified using StringBuilder(int,int) 
    //Process
    //Check if the string is empty ot length is 1 then return string because compressed string of a is a1 of length 2
    //initialize the counter to 1 because if string is not empty then it must have character and count of 1
    //Appending after it reaches MaxCapacity will result in either ArgumentOutOfRangeException or OutOfMemoryException
    //Inside the try block, for each character until the one before end of string, check if it is equal to the next character, if equal 
    //increment the counter, else append the character and the count of that character
    //Note that the last character may or may not be equal to the last second character
    //We are looping until the last second character because the comparision str[i] !=str[i+1]
    //If i = str.Length -1 then the code breaks
    //After the loop check if the last character int he string is equal to the last second character
    //if it is then append the character and then append the count, else append the character and count 1
    //this covers the case aabbcccccc and aabbccccccd 

        private static string CompressedString(string str){
            if(string.IsNullOrEmpty(str)||str.Length==1) return str;
            StringBuilder compressed = new StringBuilder(0,str.Length);
            int count = 1;
            try{
                for(int i=0;i<str.Length-1;i++){
                    if(str[i]!=str[i+1]){
                        compressed.Append(str[i]).Append(count);
                        count = 1; 
                    }
                    else{
                        count++;
                    }
                }
                if(str[str.Length-1]!=str[str.Length-2]){
                    compressed.Append(str[str.Length - 1]).Append(1);
                }else{
                    compressed.Append(str[str.Length - 1]).Append(count);
                }
            }
            catch(Exception ex) when(ex is OutOfMemoryException || ex is ArgumentOutOfRangeException){
                return str;
            }
            return compressed.ToString();
        }
    }
}