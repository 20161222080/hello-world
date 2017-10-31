using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace P2_11
{   
	class BankAccount  
	{      
		double checking_balances, Saving_balances; 
		string id;     
		string getID(){            return id;        }       
		public BankAccount() { id = "???"; checking_balances = 0; Saving_balances = 0; }   
		public BankAccount(string initID, double initChecking, double initSaving)       
			{ id = initID; checking_balances = initChecking; Saving_balances = initSaving; }    
		public double getChecking()     
		{       
			return checking_balances;   
		}    
		public double getSaving()     
		{       
			return Saving_balances;   
		}
		public double getbalance()   
		{
			return Saving_balances - checking_balances; 
		}  
		public void setID(string name)       
		{
			id = name;
		}
		public void deposit(double depositAmount) 
		{
			if (depositAmount > 0)
			Saving_balances += depositAmount;
		}
		public Boolean withdraw(double withdrawAmount) 
		{
			if ( getbalance()>= withdrawAmount && withdrawAmount > 0)    
			{
				checking_balances += withdrawAmount; 
				return true; 
			}
			return false;    
		}
		public void addInterest()   
		{
			double balance = getbalance();
			if (getbalance() <= 1000) 
				Saving_balances += balance * 0.025;
			else if (getbalance() < 5000)   
				Saving_balances += balance * 0.035;  
			else
				Saving_balances += balance * 0.045;  
		}
		public Boolean equals(string i_s) 
		{        
			if (id == i_s)    
				return true;
			return false;
		}
		public String toString()   
		{    
		 	string s = "ID:" + id + "\n" + "Checking Balance:$" + checking_balances + "\n" + "Saving Balance:$" + Saving_balances + 			"\n";
		 	return s;
		 }
		}  
		class Program 
		{
			static void Main()   
			{
				string ID;   
				BankAccount b1=new BankAccount("23456",4000000,4180000),b2=new BankAccount();   
				double initcheck, initsaving;  
				Console.WriteLine("以下为带参数构造函数展示");    
				Console.WriteLine(b1.toString());      
				Console.WriteLine("以下为对新账户操作");     
				Console.WriteLine("不带参数的初始化:"+b2.toString());
				Console.WriteLine("请输入id:");    
				ID = Console.ReadLine();     
				b2.setID(ID);  
				while (true)   
				{          
					Console.WriteLine("请验证id:");  
					ID = Console.ReadLine();   
					if (!b2.equals(ID))  
					{
						Console.WriteLine("输入错误");    
						continue;     
					}
					Console.WriteLine("输入成功,请输入存入金额:");      
					initsaving = double.Parse(Console.ReadLine());  
					b2.deposit(initsaving);    
					Console.WriteLine("请输入支出金额:");     
					initcheck = double.Parse(Console.ReadLine());        
					b2.withdraw(initcheck); 
					Console.WriteLine("存入金额:");        
					Console.WriteLine(b2.getSaving());    
					Console.WriteLine("支出存入金额:");         
					Console.WriteLine(b2.getChecking());       
					Console.WriteLine("账户金额:");      
					Console.WriteLine(b2.getbalance());   
					Console.WriteLine(b2.toString());     
					b2.addInterest();           
					Console.WriteLine("利息计算之后:" + b2.toString());  
					break;       
				}
			}
		}
	}
