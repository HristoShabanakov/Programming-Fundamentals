using System;
using System.Collections.Generic;
using System.Linq;

class Spyfer
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (i == 0)
            {
                if(numbers[i] == numbers[i + 1])
                {
                    numbers.RemoveAt(i + 1);
                 //When we remove and element we have to process again from the start,
                 //to do that we set up i = 0 this will bring us back in the beginning of the list
                    i = 0;
                }
            }
            else if (i == numbers.Count - 1)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    numbers.RemoveAt(i - 1);
                    i = 0;
                }
            }
            //For all other cases or when i is in the middle.
            else
            {
                if(numbers[i]==numbers[i-1] + numbers[i + 1])
                {
                    numbers.RemoveAt(i + 1);
                    numbers.RemoveAt(i - 1);
                    i = 0;
                }
            }
        }
        Console.WriteLine(string.Join(" ",numbers));
    }
}
