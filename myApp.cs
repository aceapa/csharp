using System;
using GenLibrary;
using CSTest;
namespace Prog
{
	class myApp{

		static void Main(string[] arg)
		{
			TestCase TestScenario = new TestCase();
			double ValueLeft = 0;
			double ValueRight = 0;
			double[] values;
			if (arg.Length > 0)  
			{
				if (arg.Length > 1)
				{
					ValueRight = (double)Convert.ToDouble(arg[1]);
					ValueLeft =(double)Convert.ToDouble(arg[0]);	
				}
			}
			//TestScenario.SwapVariables(ref ValueLeft, ref ValueRight);
			values = TestScenario.Payment(ValueLeft, ValueRight);
			for (int Item = 0; Item < values.Length; Item++)
			{
				Console.WriteLine("{0}$ = {1}", TestScenario.MoneySize[Item], values[Item]);	

			}
		}
	}
}