using System;
using System.Collections;

namespace Keywords
{

    //Enum keyword

    enum month
    {
        January,
        February,
        March,
        April,
        May,
        June,
    }




    public class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enum keyword: ");
            month meetingday = month.January;
            Console.WriteLine(meetingday + "\n");

            Console.WriteLine("For, Continue, while, do, foreach");
            for (int i = 1; i <= 5; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            //while loop
            Console.WriteLine("while loop: ");
            int start = 1;
            while (start < 6)
            {
                Console.Write(start);
                start++;
            }
            Console.WriteLine();
            int l = 1, n = 5, multiple;

            //do while loop
            Console.WriteLine("do while loop: ");
            do
            {
                multiple = l * n;
                Console.WriteLine("{1} x {0} = {2}", n, l, multiple);
                l++;
            } while (l <= 5);


            //foreach
            Console.WriteLine("foreach");
            string[] array = { "Arun", "Kumar", "UT", " ", "MCA", " ", "in", " ", "srmv" };
            foreach (var arrays in array)
            {
                Console.Write(arrays);
            }

            //if condition
            Console.WriteLine("If and Else: ");
            Console.Write("Enter the number: ");
            int converted = int.Parse(Console.ReadLine());
            Console.WriteLine(converted % 2);
            if (converted % 2 == 0)
            {
                Console.WriteLine(converted + " is even number");
            }
            else
            {
                Console.WriteLine(converted + " is odd number");

            }

            //Switch case
            Console.WriteLine("switch, case, break");
            char ch;
            Console.Write("Enter the letter: ");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(ch);
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("It is a vowel: ");
                    break;
                case 'e':
                    Console.WriteLine("It is a vowel: ");
                    break;
                case 'i':
                    Console.WriteLine("It is a vowel: ");
                    break;
                case 'o':
                    Console.WriteLine("It is a vowel: ");
                    break;
                case 'u':
                    Console.WriteLine("It is a vowel: ");
                    break;
                default:
                    Console.WriteLine("It is not a vowel: ");
                    break;
            }

            //goto keyword
            Console.WriteLine("goto");
            int number = 20;
            switch (number)
            {
                case 5:
                    Console.WriteLine("case 5");
                    break;
                case 10:
                    Console.WriteLine("case 10");
                    break;
                case 20:
                    Console.WriteLine("case 20");
                    goto case 5;
                default:
                    Console.WriteLine("No match found");
                    break;
            }

            //Const type
            Console.WriteLine("Const type: ");
            const int myNum = 15;
            //myNum = 20;
            Console.WriteLine(myNum);

            /*//All datatypes
            char letter = 'a';
            int values = 20;
            string words = "any sentence";
            long longno = 66578864;*/



            //Is keyword
            Console.WriteLine("Is keyword: ");
            object objt = 123;
            if(objt is string)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            //As keyword
            Console.WriteLine("As keyword: ");
            ArrayList list = new ArrayList();
            list.Add("kumaresan");
            list.Add(123);
            list.Add(true);
            foreach (var lists in list)
            {
                string st = lists as string;
                if (st != null)
                {
                    Console.WriteLine(lists);
                }
                else
                {
                    Console.WriteLine("Null");
                }
            }

            //checked keyword
            Console.WriteLine("checked keyword: ");
            Console.WriteLine("try and catch: ");
            try
            {

                checked
                {
                    int val = int.MaxValue;
                    Console.WriteLine(val + 2);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //unchecked keyword
            Console.WriteLine("unchecked keyword: ");
            unchecked
            {
                int val = int.MinValue;
                Console.WriteLine(val + 2);
            }


        }

    }
}
