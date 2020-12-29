using System;

namespace Tests
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            //solution for test one to pass
            if (string.IsNullOrEmpty(input))
                return 0;
            return int.Parse(input);
            
        }
    }
}