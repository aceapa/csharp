using System;
namespace CSTest{
    public class TestCase{
		public double[] MoneySize = new double[] {0.25, 0.10, 0.05, 0.01};
		//public double[] MoneySize {get; set;}
        public void TestValues()
		{
			uint ValueInt = 123;
			ushort ValueUShort = 0xFF;
			Console.WriteLine("ushort  = 0x{0:X} ", ValueUShort);
			ulong valueULong = 10123987129387123Ul;
			Console.WriteLine("long  = {0} ", valueULong);
			float ValueFloat = 1.00100000001f;
			double ValueDouble = 0.120310981203d;
			decimal ValueDecimal = 1.000022111119m;
			Console.WriteLine("float  = {0:N20}", ValueFloat); 
			Console.WriteLine("float  = {0} double = {1} decimal = {2}", ValueFloat.ToString(), ValueDouble.ToString(), ValueDecimal.ToString());
			Console.WriteLine("decimal = " + ValueDecimal.ToString());
			char ValueChar = '\u0031';
			int? ValueRef = (int)ValueInt;
			string ValueString = @"this is a text";
			Nullable<int> ValueNull = null;
			Console.WriteLine("Char = {0} \nInt = {1}", ValueChar, ValueRef);	
			Console.WriteLine("String = {0} ", ValueString);
			Console.WriteLine("nullable value = {0} ", ValueNull.HasValue);
			object ValueObject = ValueUShort; 
			Console.WriteLine("Object = {0} ", ValueObject);
		}
        public void SwapVariables(ref int FirstValue, ref int SecondValue)
        {
            FirstValue += SecondValue;
			SecondValue = FirstValue - SecondValue;
			FirstValue  -= SecondValue;
        }

		public double[] Payment(double owed, double paid)
		{
			double[] ReturnMoneyList;
			double ReturnMoney =  paid - owed;
			if (ReturnMoney < 0 )
				ReturnMoneyList = new double[] {ReturnMoney};
			else
			{
				ReturnMoneyList = new double[] {0.0, 0.0, 0.0, 0.0};
				for(int iCount = 0; iCount < MoneySize.Length && ReturnMoney > 0; iCount++)
				{
					ReturnMoneyList[iCount] = Math.Truncate(ReturnMoney / MoneySize[iCount]);
					ReturnMoney -= Math.Truncate(ReturnMoney/MoneySize[iCount]) * MoneySize[iCount];
				}
			}
			return ReturnMoneyList;
		}
    }
	class Words {
        public Words(string SomeTextWord) => (TextWord, NumberOfWords) = (SomeTextWord, 1);
        public string TextWord {get; set;}
        public int NumberOfWords{get; set;}

    }
    class Character{
        public Character(char SomeChar) => (ValueChar, NumberOfChar) = (SomeChar, 1);

        public char ValueChar{get; set;}
        public int NumberOfChar{get; set;}
    }
	class WordCount{
    private static string[] tests = new string[]
        {
            @"The test of the 
            best way to handle

multiple lines,   extra spaces and more.",
            @"Using the starter app, create code that will 
loop through the strings and identify the total 
character count, the number of characters
excluding whitespace (including line returns), and the
number of words in the string. Finally, list each word, ensuring it
is a valid word."
        };

        /* 
            First string (tests[0]) Values:
            Total Words: 14
            Total Characters: 89
            Character count (minus line returns and spaces): 60
            Most used word: the (2 times)
            Most used character: e (10 times)

            Second string (tests[1]) Values:
            Total Words: 45
            Total Characters: 276
            Character count (minus line returns and spaces): 230
            Most used word: the (6 times)
            Most used character: t (24 times)
        */
        private static void WordCount(string Stringtext)
        { 
            List<Words> WordList = new List<Words>();
            List<Character> WordList = new List<character>();
            int CountInteger;
            int CountChar;
            String SomeWord;
            CountChar = 0;

            for(int CharacterIndex = 0; CharacterIndex < Stringtext.Length; CharacterIndex++)
            {
                if (!((Stringtext[CharacterIndex] == '\r') && (Stringtext[CharacterIndex+1] == '\n')))
                {
                   CountChar++; 
                }
                
            }
            Console.WriteLine("Total Characters: {0}", CountChar);
        }
	}
}