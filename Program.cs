using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
{
    class Data{
        int amount;
        string name;
        public Data(int a, string n){
            this.amount = a;
            this.name = n;
        }

        public int getAmount(){
            return this.amount;
        }
        public string getName(){
            return this.name;
        }
    }
	class Program
	{
		static void Main(string[] args)
		{
			int[] amount = {20,10,50,70,30,5};
            
            string[] name = {"A","B","C","D","E","F"};

            
            int[] tempInt = new int[amount.Length];

            List<Data> dataList = new List<Data>();
            for(int i=0; i<amount.Length; i++){
                Data d = new Data(amount[i],name[i]);
                dataList.Add(d);
            }

            for(int i=0; i<amount.Length; i++){
                tempInt[i] = amount[i];
            }
            
            //sorting
            int temp;
            for (int j = 0; j <= amount.Length - 2; j++) {
                for (int i = 0; i <= amount.Length - 2; i++) {
                    if (amount[i] < amount[i + 1]) {
                        temp = amount[i + 1];
                        amount[i + 1] = amount[i];
                        amount[i] = temp;
                    }
                }
            }

            //print amount with name
            for(int i=0; i<amount.Length; i++){
                Console.Write(amount[i] + " - ");
                for(int j=0; j<amount.Length; j++){
                    if(amount[i]==dataList[j].getAmount()){
                        Console.WriteLine(dataList[j].getName());
                    }
                }
            }
		}
	}
}
