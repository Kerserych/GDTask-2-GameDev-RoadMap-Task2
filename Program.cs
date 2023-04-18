object[] bob = new object[] { "15", 3, 2, 5, "22", 4, "33", 15, "15" };
Console.WriteLine(GetSmth(bob));

int GetSmth(object[] mas1)
{

    List<int> newmas1 = new List<int>();

    int intsum = 0;

    for (int i = 0; i < mas1.Length; i++)
    {
        if ((mas1[i] is int == true) & (mas1[i] is string == false))
        {
            newmas1.Add((int)mas1[i]);
        }
    }
    //Console.WriteLine(String.Join(" ",newmas1));

    for (int i = 0; i < newmas1.Count; i++)
    {
        intsum += newmas1[i];
    }
    //Console.WriteLine(intsum);
    //Console.WriteLine(mas1.Length - newmas1.Count);

    return intsum - (mas1.Length - newmas1.Count);
}