using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp3
{
	class Assignment1    
	{        
		public double weight,bmi;        
		public int height,height2;    
	}    
	class Program    
	{        
		public const int BMIVALUE = 703;        
		static void Main(string[] args)        
		{           
			Assignment1 body = new Assignment1();            
			Console.Write("What is your weight?");            
			body.weight = double.Parse(Console.ReadLine());            
			Console.Write("What is your height?\nFeet: ");            
			body.height = int.Parse(Console.ReadLine());            
			Console.Write("Inches:");            
			body.height2 = int.Parse(Console.ReadLine());            
			body.height *= 12;            
			body.height+=body.height2;           
			body.bmi = body.weight*BMIVALUE /( body.height *body.height);           
			Console.WriteLine("Your current BMI is:{0:F2}", body.bmi);        
		}    
	}
}
