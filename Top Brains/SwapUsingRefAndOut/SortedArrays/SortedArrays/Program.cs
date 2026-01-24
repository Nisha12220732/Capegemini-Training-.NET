class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of 1st Array");
        int n = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of 2nd Array");
        int m = int.Parse(Console.ReadLine());

        int[] arr1 = new int[n];
        int[] arr2 = new int[m];
        int[] ansarr = new int[n + m];

        Console.WriteLine("Enter elements for 1st Array");
        for(int i = 0; i < n; i++)
        {
            arr1[i] = Int32.Parse(Console.ReadLine()) ;
        }

        Console.WriteLine("Enter elements for 2nd Array");
        for (int i = 0; i < m; i++)
        {
            arr2[i] = Int32.Parse(Console.ReadLine());
        }

        Array.Sort(arr1);
        Array.Sort(arr2);

        Console.WriteLine("Elements of 1st Array");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr1[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Elements of 2nd Array");
        for (int i = 0; i < m; i++)
        {
            Console.Write(arr2[i] + " ");
        }

        Console.WriteLine();

        int a = 0;
        int b = 0;

        while(a< arr1.Length || b < arr2.Length)
        {
            if (a < arr1.Length && b< arr2.Length && arr1[a] < arr2[b])
            {
                ansarr[a + b] = arr1[a];
                a++;
            }
            else if (a >= arr1.Length)
            {
                ansarr[a + b] = arr2[b];
                b++;
            }
            else if (b >= arr2.Length)
            {
                ansarr[a + b] = arr1[a];
                a++;
            }
          
            else
            {
                ansarr[a + b] = arr2[b];
                b++;
            }
        }

        Console.WriteLine("Sorted Array is");

        for(int i = 0; i < ansarr.Length; i++)
        {
            Console.Write(ansarr[i] + " ");
        }
    }
}