using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Vraj
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp, height_ft, height_in, weight, new_height, bmi;
            string f_name, l_name;
            string _input = "";
            bool false_temp = true;
            bool false_height_ft = true; 
            bool false_height_in = true;
            bool false_weight = true;
            Console.WriteLine("IT 330 Quick Health Assessment.");

            do
            {
                Console.Write("Please enter your first name: ");
                f_name = Console.ReadLine();
                if(string.IsNullOrEmpty(f_name))
                {
                    Console.WriteLine("Error. You must enter a first name. Please try again.");
                }
            }

            while(string.IsNullOrEmpty(f_name));
            //if the string f_name is empty re-run the loop unitl it's not empty

            do
            {
                Console.Write("Please enter your last name: ");
                l_name = Console.ReadLine();
                if (string.IsNullOrEmpty(l_name))
                {
                    Console.WriteLine("Error. You must enter a last name. Please try again.");
                }
            }

            while(string.IsNullOrEmpty(l_name));

            do
            {
                Console.Write("Please enter your temperature: ");
                _input = Console.ReadLine();
                if (!double.TryParse(_input, out temp))
                {
                    Console.WriteLine("Error. You must enter a number. Please try again.");
                }

                else if (temp <= 0)
                {
                    Console.WriteLine("Error. Number must be greater than 0. Please try again.");
                }

                else
                {
                    false_temp = false;
                }

            }
            while (false_temp == true || temp <= 0);

            do
            {
                Console.Write("Please enter the first part of your height in feet: ");
                _input = Console.ReadLine();
                if (!double.TryParse(_input, out height_ft))
                {
                    Console.WriteLine("Error. You must enter a number. Please try again.");
                }

                else if (height_ft < 0)
                {
                    Console.WriteLine("Error. Number must be greater than 0. Please try again.");
                }

                else
                {
                    false_height_ft = false;
                }
            }
            while (false_height_ft == true || height_ft < 0);

            do
            {
                Console.Write("Please enter the second part of your height in inches: ");
                _input = Console.ReadLine();
                if (!double.TryParse(_input, out height_in))
                {
                    Console.WriteLine("Error. You must enter a number. Please try again.");
                }

                else if (height_in < 0)
                {
                    Console.WriteLine("Error. Number must be greater than 0. Please try again.");
                }

                else
                {
                    false_height_in = false;
                }
            }
            while (false_height_in == true || height_in < 0);

            do
            {
                Console.Write("Please enter your weight in pounds: ");
                _input = Console.ReadLine();
                if (!double.TryParse(_input, out weight))
                {
                    Console.WriteLine("Error. You must enter a number. Please try again.");
                }

                else if (weight < 0)
                {
                    Console.WriteLine("Error. Number must be greater than 0. Please try again.");
                }

                else
                {
                    false_weight = false;
                }
            }
            while (false_weight == true || weight < 0);
           
            //temp checking
            if (temp < 97)
            {
                Console.WriteLine("Temp is below normal. Seek medical attention");
            }

            else if((temp >= 97) && (temp < 99))
            {
                Console.WriteLine("Temp is normal");
            }

            else if ((temp >= 99) && (temp < 101))
            {
                Console.WriteLine("Temp is a bit above normal. Monitor it closely");
            }

            else if (temp >= 101)
            {
                Console.WriteLine("Temp is above normal. Seek medical attention");
            }
            new_height = (height_ft * 12) + height_in;
            //Console.WriteLine("new height "+ new_height);
            //Console.WriteLine("weight " + weight);

            //doing bmi calculation
            bmi = ((weight / (new_height * new_height)) * 703);
            if (bmi < 18.5)
            {
                Console.WriteLine($"Your BMI is {bmi} and is considered underweight");
            }

            else if ((bmi > 18.5) && (bmi <= 24.9))
            {
                Console.WriteLine($"Your BMI is {bmi} and is considered normal weight");
            }

            else if ((bmi >= 25) && (bmi <= 29.9))
            {
                Console.WriteLine($"Your BMI is {bmi} and is considered  overweight");
            }

            else if (bmi >= 30)
            {
                Console.WriteLine($"Your BMI is {bmi} and is considered obese");
            }

            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }

    }
}
