using CSharpBasics;
using System.Runtime.CompilerServices;
using System.Collections; //Using ArrayList

public class CSharpBasicProgram
{
    public static void Main(string[] args)
    {
        float vat = 15f;
        float productA = 3.99f;
        float productB = 2.50f;
        float productC = 11.50f;

        float sum = productA + productB + productC;
        float sumTwo;
        float tax = (sum / 100) * vat;

        float inputValueAsInt;
        bool inputOneValidated = false;
        sum += tax;

        //Arrays
        int[] grades = new int[3];

        grades[0] = 20;
        grades[1] = 15;
        grades[2] = 8;

        //Other way to initialize array
        int[] mathclassAGrades = { 20, 18, 18, 17, 14 };

        //Third way to initialize array
        int[] mathclassBGrades = new int[] { 18, 16, 12, 9, 7 };

        Console.WriteLine("Length of grades: " + mathclassAGrades.Length);

        //Foreach loop
        int counter = 0;
        foreach (int g in grades)
        {
            Console.WriteLine("Element {0}: {1}", counter, g);
        }

        //Declare 2D Array
        string[,] matrix;

        int[,] array2D = new int[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        //Access 5 from array2D
        Console.WriteLine("Central value of 2D array is {0}", array2D[1, 1]);

        //Declare 3D Array
        int[,,] threeDArray = new int[,,]
        {
            {
                {1, 2 },
                {3, 4 }
            },
            {
                {5, 6 },
                {7, 8 }
            },
        };

        //Access 5 from threeDAarray
        Console.WriteLine("Central value of 3D array is {0}", threeDArray[1, 0, 0]);

        //Specify 3 rows with 2 entries each
        string[,] array2DStrings = new string[3, 2]
        {
            {"one", "two"},
            {"three", "four"},
            {"five", "six"},
        };

        //Outer for loop
        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            //Inner for loop
            for (int j = 0; j < array2D.GetLength(0); j++)
            {
                Console.Write(array2D[i, j] + " ");
            }
        }

        //Jagged array; Store an array of arrays; I want 3 arrays
        int[][] jaggedArray = new int[3][];

        jaggedArray[0] = new int[5];
        jaggedArray[1] = new int[4];
        jaggedArray[2] = new int[3];

        jaggedArray[0] = new int[] { 2, 3, 4, 5, 6 };
        jaggedArray[1] = new int[] { 1, 3, 5, 7};
        jaggedArray[2] = new int[] { 2, 4, 6 };

        //Other way to initialize jagged array
        int[][] jaggedArray2 = new int[][]
        {
            new int[] {2, 4, 6, 8},
            new int[] {1, 3, 5, 7, 9}
        };

        //Access 5 from jaggedArray2
        Console.WriteLine("Third value of 2nd array is {0}", jaggedArray2[1][2]);

        //Declare ArrayList with undefined amount of objects
        ArrayList firstArrayList = new ArrayList();
        //Declare ArrayList with defined objects
        ArrayList secondArrayList = new ArrayList(15);

        //Add elements
        firstArrayList.Add(25);
        firstArrayList.Add("2nd element");
        firstArrayList.Add(128);
        firstArrayList.Add("Yeah no");

        //Delete element with specific value
        firstArrayList.Remove(25);
        //Delete element at specific index
        firstArrayList.RemoveAt(0);
        Console.WriteLine(firstArrayList.Count);

        double arrayListSum = 0;
        foreach(object obj in firstArrayList)
        {
            if(obj is int)
            {
                arrayListSum += Convert.ToDouble(obj);
            }
            else if(obj is double)
            {
                arrayListSum += (double)obj;
            }
            else if(obj is string)
            {
                Console.WriteLine(obj);
            }
        }

        //Increment operator
        sum++;
        //Decrement operator
        sum--;
        //Equality operator
        bool isEqual;
        isEqual = sum == tax;

        int Add(int num1, int num2) 
        {
            return num1 + num2;
        }

        while(!inputOneValidated)
        {
            Console.WriteLine("Please enter a value");
            string inputString = Console.ReadLine();
            try
            {
                inputValueAsInt = int.Parse(inputString);   
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception; Please enter a number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception; Number too long or too short for int32");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Argumentnull exception; Value was empty");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }
        }
        Console.WriteLine("sum products: " + sum.ToString());

        //Switch statement
        switch (sum) 
        {
            case 25:
                Console.WriteLine("sum is over 25 how much did you eat");
                break;
            default:
                Console.WriteLine("sum is ok");
                break;
        }

        //Ternary operator
        string sumString = sum > 25 ? "That's a big sum" : "That's a reasonable amount";


        //Basics of OOP & classes
        Human Dennis = new Human("Dennis", "Nedry", "blue", 36);
        Dennis.IntroduceMyself();
        Human Michael = new Human("Michael", "Scott", "green", 45);
        Michael.IntroduceMyself();
        Human basicHuman = new Human();

    }

    public static bool ValidateInput(string input)
    {
        int i;
        return int.TryParse(input, out i);
    }
}

