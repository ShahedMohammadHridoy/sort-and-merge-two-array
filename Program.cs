using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] amount = {20,10,50,70,30,5};
            
            string[] name = {"A","B","C","D","E","F"};

            int[] tempInt = new int[amount.Length];

            

             for(int i=0; i<amount.Length; i++){
                 tempInt[i] = amount[i];
             }
            
            Array.Sort(amount);
            Array.Reverse(amount);

            for(int i=0; i<amount.Length; i++){

                Console.Write(amount[i] + " - ");
                Console.WriteLine(name[Array.IndexOf(tempInt,amount[i])]);
            }
		}
	}
}
