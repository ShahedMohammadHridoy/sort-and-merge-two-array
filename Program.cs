using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application {
	class Program {
		static void Main(string[] args) {
			int[] amount = {20,10,50,70,30,5,100};            
            string[] name = {"A","B","C","D","E","F","a"};
            
            //sorting
            int temp;
            string tempName;
            for (int j = 0; j <= amount.Length - 2; j++) {
                for (int i = 0; i <= amount.Length - 2; i++) {
                    if (amount[i] < amount[i + 1]) {
                        
                        temp = amount[i + 1];
                        tempName = name[i+1];

                        amount[i + 1] = amount[i];
                        name[i+1]=name[i];
                        
                        amount[i] = temp;
                        name[i] = tempName;
                    }
                }
            }

            //print
            for(int i=0; i<amount.Length; i++){
                Console.WriteLine(amount[i]+" - "+name[i]);
            }
		}
	}
}
