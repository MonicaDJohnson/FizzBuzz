﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz//Monica Johnson Homework
{
    public class FizzBuzzer
    {
        public string Get(int num)
        {


            if (num % 3 ==0 && num % 5 ==0)
            {
                return "FizzBuzz";
            }

            if (IsMultipleOf3(num))
            {
                return "Fizz";
            }

            if (IsMultipleOf5(num))
            {
                return "Buzz";
            }

            
           

            //if (IsMultipleOf3And5(num))
            //{
            //    return "FizzBuzz";
            //}

            
            return num.ToString();


        }

        private bool IsMultipleOf3(int numberToCheck)
        {
            return numberToCheck % 3 == 0;
        }

        private bool IsMultipleOf5(int numberToCheck)
        {
            return numberToCheck % 5 == 0;
        }

        //private bool IsMultipleOf3And5(int numberToCheck)//I am trying to write an 'and' statement that would include the modulus operator for both 3 and 5.
        //{
        //    return numberToCheck % 3 == 0 && numberToCheck % 5 == 0;
        //}

    }

}
