// See https://aka.ms/new-console-template for more information

using System.Data.Common;

int Solution(int[] numbers)
{
    int small = numbers[0]; // before int small = 0;
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < small) { 
            small = numbers[i];
        }
    }

    return small;
}

int[] numbers = {-20, 1, -10, -2, 1, -1, 2 , -9};

int value = Solution(numbers);
Console.WriteLine("The smallest number in the array is: " + value + "\n");

Console.WriteLine("---------------------------------");
Console.WriteLine("---------------------------------\n");

int powerSum(int x, int n)
{
    int value = 0;

    //obtain the integer value of the calculation of the square of index n
    int sqr = Convert.ToInt32(Math.Pow(x, 1.0/n));
    bool checkIfSqr = sqr * sqr == x;

    if (checkIfSqr) 
    {
        value++;
    }

    List<int> list = new List<int>();

    for (int i = 1; i < sqr; i++)
    {
        int tem = Convert.ToInt32(Math.Pow(i, n));
        list.Add(Convert.ToInt32(Math.Pow(i, n)));
        for (int j = i + 1; j < sqr+1; j++)
        {
            int tem2 = Convert.ToInt32(Math.Pow(j, n)); 
            if (tem + tem2 == x)
            {
                value++;
            }
        }

    }

    /*
     = (1^2 + 3^2 + 4^2 + 5^2 + 7^2) = 1+9+16+25+49
                                    
    int[] array = { 1,4,9,16,25,36,49,64,81};
    */

    return value;
}

int sumaR = powerSum(100,2);

Console.WriteLine(sumaR+ "\n");
Console.ReadLine();



