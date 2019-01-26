using System;
namespace CSTest{
    public class TestCase{
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
    }
}