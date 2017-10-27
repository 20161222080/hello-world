using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp4
{   
	class Program   
	{               
		static void Main(string[] args)  
		{           
			string []a=new string[3];        
			int j;         
			Console.Write("Please input the first name:");   
			a[0] = Console.ReadLine();        
			string a1 = a[0].Substring(0, 1);         
			a[0] = a1.ToUpper() + a[0].Substring(1);        
			Console.WriteLine("{0} is the first name.", a[0]);        
			Console.Write("Please input the second name:");       
			a[1] = Console.ReadLine();        
			a1 = a[1].Substring(0, 1);      
			a[1] = a1.ToUpper() + a[1].Substring(1);     
			Console.WriteLine("{0} is the second name.", a[1]);   
			Console.Write("Please input the third name:");      
			a[2] = Console.ReadLine();    
			a1 = a[2].Substring(0, 1);    
			a[2] = a1.ToUpper() + a[2].Substring(1);      
			Console.WriteLine("{0} is the third name.", a[2]);  
			for(int i=0;i<2;i++)        
				for(j=i+1;j<3;j++)       
				{                  
					if(string.Compare(a[i],a[j])==1)  
					{                
						a1 = a[i];        
						a[i] = a[j];     
						a[j] = a1;      
					}
				}
				Console.WriteLine("The names in alphabetical order are:");    
				for (int i=0;i<3;i++)       
				{             
					Console.WriteLine("\"{0}\"",a[i]);       
				}    
			}   
		}
}
