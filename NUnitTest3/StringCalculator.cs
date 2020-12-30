﻿using System;

namespace Tests
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            //solution for test one to pass
            //if the input is null or a blank string (like line 21 in Unit test)
            //if (string.IsNullOrEmpty(input))
            //    return 0;
            //return int.Parse(input);

            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            var numbers = input.Split(',');
            var total = 0;

            foreach(var number in numbers)
            {
                total += int.Parse(number); 
            }
            return total;
        }
    }
}