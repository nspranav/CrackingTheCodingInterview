using System;
namespace AllStringPermutations{
    class AllStringPermutations
    {
        public static void Main(string[] args){
            Console.WriteLine("ENter the string");
            string s = Console.ReadLine();
            generatePermutation(s);
        }
        static void generatePermutation(string s){
            generatePermutation(s,"");
        }
        static void generatePermutation(string s, string prefix){
            if(s.Length == 0){
                Console.WriteLine(prefix);
            }else{
                for(int i=0;i<s.Length;i++){
                    string rem = s.Substring(0,i)+s.Substring(i+1);
                    generatePermutation(rem,prefix+s[i]);
                }
            }
        }
    }
}