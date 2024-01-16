
using System.ComponentModel.Design;

namespace CPRG_211___Lab_0
{
    class Program
    {
        static void Main(string[] args)
        {

            //TASK 1
            //Get low Number from User
            Console.WriteLine("Enter a Low Number:");
            string userInput1 = Console.ReadLine();

            //convert string to int
            int userInput1Int = int.Parse(userInput1);

            //Get High Number from User
            Console.WriteLine("Enter a High Number:");
            string userInput2 = Console.ReadLine();

            //convert string to int
            int userInput2Int = int.Parse(userInput2);

            //Calculate Differencce
            int calculation = userInput2Int - userInput1Int;

            //Print Difference
            Console.WriteLine("The Difference between " + userInput2Int + " and " + userInput1Int + " is " + calculation);

            //Task 2
            //Get Positive Low Number from User
            Console.WriteLine("Enter a Positive low Number:");
            int lowNumber = GetLowNumber();

            //Get High Number from User
            Console.WriteLine("Enter a High Number Greater than the previous low Number");
            int highNumber = GetHighNumber(lowNumber);

            //Task 3
            //Calculate Size of Array
            int arraySize = highNumber - lowNumber;
            //Create empty array
            int[] highLowArray = new int[arraySize];
            //Input values into array
            for (int i = 1; i < arraySize; i++)
            {
                highLowArray[i] = lowNumber + i;
            }
            //Reverse the Order of the Array (High to Low)
            Array.Reverse(highLowArray);

            //Write Array Values to File
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Criff\\source\\repos\\CPRG 211 - Lab 0\\CPRG 211 - Lab 0\\numbers.txt"))
            {
                foreach (int number in highLowArray)
                {
                    sw.WriteLine(number);
                }
            }

            //Additional Task 2
            //Read File Values
            using (StreamReader sr = new StreamReader("C:\\Users\\Criff\\source\\repos\\CPRG 211 - Lab 0\\CPRG 211 - Lab 0\\numbers.txt"))
            {
                //declare variables
                int sum = 0;
                string line;
                //While loop to read all lines where not null
                while ((line = sr.ReadLine()) != null)
                {
                    //parse each string to int and add to sum
                    sum += int.Parse(line);
                }
                //output sum
                Console.WriteLine($"The Value of the text file is {sum}");
            }

            //Additional Task 5
            Console.WriteLine($"Prime Numbers from {highNumber} - {lowNumber}");
            for (int i = 1; i < arraySize; i++)
            {
                int value = lowNumber + i;
                if (GetPrimeNumber(value))
                {
                    Console.WriteLine(value);
                }

            }


        }


        public static int GetLowNumber()
        {
            //declare Int
            int lowNum;
            //While loop to iterate until condition is met
            while (true)
            {
                //Get User Input 
                string userInput3 = Console.ReadLine();
                //Convert to Int
                bool convert = int.TryParse(userInput3, out lowNum);
                //Check if both statements are true
                if (convert && lowNum > 0)
                {
                    //Inform user and Return Value if True
                    Console.WriteLine("You have entered a positive low number");
                    return lowNum;

                }
                else
                {
                    //Prompt User for Re - Input if False
                    Console.WriteLine("Please enter a valid positive low number");
                }
            }

        }

        public static int GetHighNumber(int lowNum)
        {
            //declare Int
            int highNum;
            //While loop to iterate until condition is met
            while (true)
            {
                //Get User Input
                string userInput4 = Console.ReadLine();
                //convert to Int
                bool convert = int.TryParse(userInput4, out highNum);
                //Check if both statements are true
                if (convert && highNum > lowNum)
                {
                    //Inform user and Return Value if True
                    Console.WriteLine("You have entered a number greater than the previous low number");
                    return highNum;
                }
                else
                {
                    //Prompt User for Re - Input if False
                    Console.WriteLine("Invalid Input, Please Enter a number greater than the previous low number (" + lowNum + ")");
                }
            }
        }

        public static bool GetPrimeNumber(int value)
        {
            if(value <= 1)
            {
                return false;
            }

            if (value >= 4 && value % 3 == 0)
            {
                return false;
            }

            if (value % 2 != 0)
                {
                    return true;
                }
                
            return false;
        }
    }
}

