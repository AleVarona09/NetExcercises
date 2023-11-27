// See https://aka.ms/new-console-template for more information



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


int[] numbers = {1, -10, -2, 1, -1, 2 , -9};

int value = Solution(numbers);
Console.WriteLine("The smallest number in the array is: " + value + "\n");

Console.WriteLine("---------------------------------");
Console.WriteLine("---------------------------------");








Console.ReadLine();

