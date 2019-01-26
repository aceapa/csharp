using System;
namespace GenLibrary
{
    public class ValContainer
    {
        public ValContainer() => Val = 0;
        public ValContainer(int val) => this.Val=val;
        private int Val;
        public int MyVall{
            get { 
                return Val;
            }
            set {
                if (value > 0) 
                Val = value;
            }
        }
        public void SetStringtoVal(string val)
        {
            try
            {
                MyVall = Convert.ToInt32(val);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }   
        }
        
    }
    
}
