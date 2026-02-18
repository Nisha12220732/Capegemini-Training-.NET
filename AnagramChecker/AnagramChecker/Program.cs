class Program
{
    public static void Main(string[] args)
    {
        //string str1 = "study";
        //string str2 = "dusty";
        //string str3 = new string(str1.Reverse().ToArray());
        //Console.WriteLine(str3);
        //char[] chararray = str3.ToCharArray();
        //foreach(char c in chararray)
        //{
        //    Console.Write(c);
        //}
        //Console.WriteLine();
        //chararray.Sort();
        //foreach (char c in chararray)
        //{
        //    Console.Write(c);
        //}

        ////chararray.ToString();
        //Console.WriteLine(chararray.ToString());
        Console.WriteLine("Enter your 1st String: ");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter your 2nd String: ");
        string str2 = Console.ReadLine();

        char[] chararr1 = str1.ToCharArray();
        char[] chararr2 = str2.ToCharArray();



        //chararr1.Sort();
        //chararr2.Sort();
        //string str4 = chararr1.ToString();
        //string str5 = chararr2.ToString();

        //Console.WriteLine(str4);
        //Console.WriteLine(str5);
        Array.Reverse(chararr1);
        string str = new String(chararr1);

        Console.WriteLine(str);
        //foreach (char c in chararr1)
        //{
        //    Console.Write(c);
        //}


    }
}
