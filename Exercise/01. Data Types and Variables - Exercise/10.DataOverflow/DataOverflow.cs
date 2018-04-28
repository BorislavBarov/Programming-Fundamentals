namespace DataOverflow
{
    using System;

    public class DataOverflow
    {
        public static void Main()
        {
            var numOne = ulong.Parse(Console.ReadLine());
            var numTwo = ulong.Parse(Console.ReadLine());

            ulong dataTypeOne = 0;
            ulong dataTypeTwo = 0;

            string dataTypeStringOne = null;
            string dataTypeStringTwo = null;

            ulong maxValueOne = 0;
            ulong maxValueTwo = 0;

            if (byte.MinValue <= numOne && numOne <= byte.MaxValue)
            {
                dataTypeOne = numOne;
                dataTypeStringOne = "byte";
                maxValueOne = byte.MaxValue;
            }
            else if (ushort.MinValue <= numOne && numOne <= ushort.MaxValue)
            {
                dataTypeOne = numOne;
                dataTypeStringOne = "ushort";
                maxValueOne = ushort.MaxValue;
            }
            else if (uint.MinValue <= numOne && numOne <= uint.MaxValue)
            {
                dataTypeOne = numOne;
                dataTypeStringOne = "uint";
                maxValueOne = uint.MaxValue;
            }
            else if (ulong.MinValue <= numOne && numOne <= ulong.MaxValue)
            {
                dataTypeOne = numOne;
                dataTypeStringOne = "ulong";
                maxValueOne = ulong.MaxValue;
            }
            
            if (byte.MinValue <= numTwo && numTwo <= byte.MaxValue)
            {
                dataTypeTwo = numTwo;
                dataTypeStringTwo = "byte";
                maxValueTwo = byte.MaxValue;
            }
            else if (ushort.MinValue <= numTwo && numTwo <= ushort.MaxValue)
            {
                dataTypeTwo = numTwo;
                dataTypeStringTwo = "ushort";
                maxValueTwo = ushort.MaxValue;
            }
            else if (uint.MinValue <= numTwo && numTwo <= uint.MaxValue)
            {
                dataTypeTwo = numTwo;
                dataTypeStringTwo = "uint";
                maxValueTwo = uint.MaxValue;
            }
            else if (ulong.MinValue <= numTwo && numTwo <= ulong.MaxValue)
            {
                dataTypeTwo = numTwo;
                dataTypeStringTwo = "ulong";
                maxValueTwo = ulong.MaxValue;
            }

            if (numOne > numTwo)
            {
                Console.WriteLine("bigger type: " + dataTypeStringOne);
                Console.WriteLine("smaller type: " + dataTypeStringTwo);
                Console.WriteLine($"{dataTypeOne} can overflow {dataTypeStringTwo} {Math.Round(dataTypeOne / (decimal)maxValueTwo)} times");
            }
            else
            {
                Console.WriteLine("bigger type: " + dataTypeStringTwo);
                Console.WriteLine("smaller type: " + dataTypeStringOne);
                Console.WriteLine($"{dataTypeTwo} can overflow {dataTypeStringOne} {Math.Round(dataTypeTwo / (decimal)maxValueOne)} times");
            }
        }
    }
}