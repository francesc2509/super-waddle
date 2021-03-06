 using System;
 using System.Collections.Generic;
                     
 public class Program
 {
     public static void Main()
     {
         int[] result = GetPrimeNumbers(new int[] { 1, 3, 9, 10, 11, 97, 12, 13, 301, 307, 3000, 37 });
         
         for (int i = 0; i < r.Length; i++) {
             Console.WriteLine(r[i]);
         }
     }
         
     private static int[] GetPrimeNumbers(int[] nums) {
         List<int> prime = new List<int>();
         int[] divisors = new int[] { 2, 3, 5, 7 };
         
         // for(int i = 0; i < nums.Length; i++)
         //     int num = nums[i];
         foreach (int num in nums) {
             if(num == 1) {
                 prime.Add(num);
                 continue;
             }
 
             bool exit = false;
             for(int divPos = 0; !exit && divPos < divisors.Length; divPos++) {
                 int divisor = divisors[divPos];
 
                 if (divisor == num) {
                     prime.Add(num);
                     exit = true;
                     break;
                 }
 
                 if (num % divisor == 0) {
                      exit = true;
                     break;
                 }
             }
 
             if(!exit) {
                 prime.Add(num);    
             }
         }
         
         return prime.ToArray();
     }
 }
