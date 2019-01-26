using System;
using GenLibrary;
using CSTest;
namespace Prog
{
	class myApp{

		static void Main(string[] arg)
		{
			TestCase TestScenario = new TestCase();
			int ValueLeft = 0;
			int ValueRight = 0;
			if (arg.Length > 0)  
			{
				if (arg.Length > 1)
				{
					Console.WriteLine("Len = {0}", arg.Length);
					ValueRight = (int)Convert.ToInt32(arg[1]);
					ValueLeft =(int)Convert.ToInt32(arg[0]);
				}
			}
			TestScenario.SwapVariables(ref ValueLeft, ref ValueRight);
			Console.WriteLine("Right = {0} \nLeft = {1}", ValueRight, ValueLeft);
		}
	}
}