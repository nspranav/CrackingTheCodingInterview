/*
Problem : Given an array of N distinct integer values find the number of pairs of integers that have 
difference of K. For ex: given an array of {1,7,5,9,2,12,3} and K=2 the number of pairs are 4
{(1,3),(3,5),(5,7),(7,9)} 

Solution: Add the elemtnts to Hashset. For each element i in array search the elements with value (i+K) (i-k) 
*/

using System;
using System.Collections.Generic;

 namespace PairsWithDifferenceEqualsN
 {
     class PairsWithDifferenceEqualsN
     {
         public static void Main(string[] args){
             Console.WriteLine("Enter the size of array");
             int n = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter each element of array");
             int[] array = new int[n];
             for(int i=0;i<n;i++){
                 array[i] = Convert.ToInt32(Console.ReadLine());
             }
             Console.WriteLine("Enter the difference");
             int difference = Convert.ToInt32(Console.ReadLine());
             int numberOfPairs = findPairsWithDifference(array,difference);
             Console.WriteLine($"number of pairs with {difference} are {numberOfPairs}");
         }

         private static int findPairsWithDifference(int[] arr, int difference){
             HashSet<int> hashSet = new HashSet<int>();
             int numberOfPairs = 0;
             foreach(var i in arr){
                 if(!hashSet.Contains(i)){
                     hashSet.Add(i);
                 }
             }
             foreach(var i in arr){
                 if(hashSet.Contains(i+difference)){
                     numberOfPairs++;
                     //Console.WriteLine("sum: "+ i );
                 }if(hashSet.Contains(i-difference)){
                     numberOfPairs++;
                     //Console.WriteLine("difference: "+ i);
                 }
                 hashSet.Remove(i);
             }
             return numberOfPairs;
         }
     }
 }