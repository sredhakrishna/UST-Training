using System;

internal class Program

{

    static void Main(string[] args)

    {
        Console.WriteLine("enter size");
        int n=int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("enter elements");
        for (int i=0; i<arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int sum = 12;
        subArraySum(arr, n, sum);

    }

    public static void subArraySum(int[] arr, int n, int sum)

    {
       
        for (int i = 0; i < n; i++)

        {
           

            int currentSum1 = arr[i];

            if (currentSum1 == sum)

            {

                Console.WriteLine("sum found at indexe" + i);

                

            }

            else

            {

                for (int j = i + 1; j < n; j++)

                {

                    currentSum1 += arr[j];

                    if (currentSum1 == sum)

                    {

                        Console.WriteLine("Sum found between indexes" + (i +1)+ "and" +( j+1));

                        

                    }

                }

            }

        }

        Console.WriteLine("No subarray found");

        

    }

}



