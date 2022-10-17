using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._13_Exec_DeclareString
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q1: c:\temp\a.jpg
			string sentence1 = "c:\\temp\\a.jpg";
			Console.WriteLine("Q-1: " + sentence1 + "的正確寫法?");
			Console.WriteLine("A-1: " + "c:\\temp\\a.jpg");
			Console.WriteLine();

			//Q2: 我是一個"好學生".
			string sentence2 = "我是一個\"好學生\".";
			Console.WriteLine("Q-2:" + sentence2 + "的正確寫法?");
			Console.WriteLine("A-2:" + "我是一個\"好學生\".");
			Console.WriteLine();

			//Q3: 我是第一行
			//    我是第二行
			Console.WriteLine("Q-3: 如何讓兩個句子換行?");
			Console.WriteLine();
			Console.Write("當句子一: " + "我是第一行；");
			Console.WriteLine("句子二: " + "我是第二行。");
			Console.WriteLine();
			Console.WriteLine("A-3: " + "我是第一行\n     我是第二行") ; //有對齊好看!

			Console.ReadKey();

		}
	}
}
