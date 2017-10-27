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
			int y;            
			string a1 = "Coding is fun!", a2;           
			Console.WriteLine("Question1:该字符串长度为:{0}",a1.Length); 
			y = a1.IndexOf("d");   
			if (y == -1)      
			Console.WriteLine("Question2:该字符串中没有d");      
			else         
			Console.WriteLine("Question2:d的下标为{0}，位置为{1}", y, y + 1);    
			a2 = a1.Substring(10, 3);      
			Console.WriteLine("Question3:"+a2);     
			Console.WriteLine("Question4:即以下式子\na) x==y/2\nc) x-y<0||!(x>=y)\nd) x+6!=y||x/y<=0");    
			Console.WriteLine("Question5:从原字符串中得到新字符串Hy并输出");    
		}    
	}
}
