using System;
using System.Collections.Immutable;
class Space
{
    static void Main()
    {
        List<string> b = new List<string>() { " qw ", " er ", " ty " };
        for (int k = 0; k < b.Count; k++)
        {

            Console.Write(b[k] + " ");



        }
        Console.WriteLine();
        for (int k = 0; k <= 0; k++)
        {
            b[1] += b[0];
            b[2] += b[1];


            Console.Write(b[0] + "," + b[1] + "," + b[2] + " ");

        }


    }
}

class don
{
    static void Main()
    {
        var name = new Dictionary<int, string>()
{
        { 1,"Сергiй" },
        { 2,"Антон" },
        { 3, "Олександра"},
        { 4, "Арсен"},
        { 5,"Юрiй"},
        { 6, "Анна"},
        { 7,"Володимир"},
        { 8,"Марiйка"},
        { 9,"Богдан"},
        { 10,"Владислав"}
};
        for (int k = 1; k <= name.Count; k++)
        {
            Console.WriteLine(name[k]);
        }
        Console.WriteLine();
        List<string> b = new List<string>() { "Сергiй", "Антон", "Олександра", "Арсен", "Юрiй", "Анна", "Володимир", "Марiйка", "Богдан", "Владислав" };

        b.Sort();
        foreach (string str in b)
            Console.WriteLine(str);

    }
}


//List<int> List = new List<int> { 4, 96, -7, 24, -1, 1, -78, 56, 79, -12, 7, -145 };
//int m = 0;
Console.WriteLine("Список:");
foreach (var item in List)
{
    Console.Write(item + " : ");
}
Console.WriteLine();
Console.WriteLine();
var newList = from i in List
              where i < m
              orderby i
              select i;
Console.Write("Вiдємнi числа : ");
foreach (var item in newList)
{
    Console.Write(item + " : ");


}
Console.WriteLine();
Console.WriteLine();
int count = newList.Count();
Console.WriteLine("Кiлькiсть вiємних чисел : " + count);
int Sum = newList.Sum();
Console.WriteLine("Cyма Вiдємних чисел : " + Sum);






