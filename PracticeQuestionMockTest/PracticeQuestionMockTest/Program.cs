class Program
{
    public static bool IsVowel(char ch)
    {
        if(ch=='a'|| ch == 'e' || ch == 'i' || ch == 'o'|| ch == 'u')
        {
            return true;
        }
        return false;
    }
    public static char NextVowel(char ch)
    {
        if (ch == 'a')
        {
            return 'e';
        }
        if (ch == 'e')
        {
            return 'i';
        }
        if (ch == 'i')
        {
            return 'o';
        }
        if (ch == 'o')
        {
            return 'u';
        }
        if (ch == 'u')
        {
            return 'a';
        }
        return ch;

    }


    public static void Main(string[] args)
    {
        string str = "hello";
        int rotate = 2;
        String str8 = new string(str.Reverse().ToArray());
        String newstr = new String(str8.Distinct().ToArray());
        Console.WriteLine(newstr);
        string str2 = "";
        for(int i = 0; i < newstr.Length; i++)
        {
            if (IsVowel(newstr[i]))
            {
                str2 += NextVowel(newstr[i]);
            }
            else
            {
                str2 += newstr[i];
            }

        }


        string str3 = str2.Substring(0, rotate);
        Console.WriteLine(str3);
        string str4 = str2.Substring(rotate);
        Console.WriteLine(str4);
        string str5 = str4+ str3;
        Console.WriteLine(str5);

        Console.WriteLine("abc" == "abc");
    }
}