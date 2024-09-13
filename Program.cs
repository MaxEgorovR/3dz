

using System.Security.Cryptography;

while (true)
{
    Console.WriteLine("1 - Task 1\n2 - Task 2\nElse - Exit");
    string choise = Console.ReadLine();
    if(choise == "1")
    {
        Console.WriteLine("Enter the K1:");
        int K1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the K2:");
        int K2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of A:");
        int[] A = new int[int.Parse(Console.ReadLine())];
        Console.WriteLine("Enter all elements in A:");
        for(int i = 0; i < A.Length; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter the length of B:");
        int[] B = new int[int.Parse(Console.ReadLine())];
        Console.WriteLine("Enter all elements in B:");
        for (int i = 0; i < B.Length; i++)
        {
            B[i] = int.Parse(Console.ReadLine());
        }
        IEnumerable<int> A1 = from el in A where el>K1 orderby el select el;
        IEnumerable<int> B1 = from el in A where el < K2 orderby el select el;
        Console.WriteLine("A:");
        foreach (int i in A1)
        {
            Console.WriteLine(i + " ");
        }
        Console.WriteLine("B:");
        foreach (int i in B1)
        {
            Console.WriteLine(i+" ");
        }
    }
    else if(choise == "2")
    {
        int[] arr = new int[int.Parse(Console.ReadLine())];
        Console.WriteLine("Enter all elements in arr:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        var tmp = (from el in arr where el > 0 select el%10).Distinct();
        foreach (int i in tmp)
        {
            Console.WriteLine(i+" ");
        }
    }
    else
    {
        break;
    }
}