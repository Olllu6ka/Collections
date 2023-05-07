using System;
using System.Collections;

public class SortedListM
{
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте программу в которой используя класс SortedList, создайте небольшую коллекцию и
    //выведите на экран значения пар «ключ- значение» сначала в алфавитном порядке, а затем в
    //обратном.
    public static void Main()
    {
        SortedList mySL = new SortedList();
        mySL.Add("Third", "I");
        mySL.Add("Second", "Love");
        mySL.Add("First", "C#");
        Console.WriteLine("SortedListM");
        Console.WriteLine(" Keys and Values:");
        PrintKeysAndValues(mySL);
        PrintOutputInReverseOrder(mySL);
    }

    public static void PrintKeysAndValues(SortedList myList)
    {
        Console.WriteLine("\t-KEY-\t-VALUE-");
        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine("\t{0}:\t{1}", myList.GetKey(i), myList.GetByIndex(i));
        }
        Console.WriteLine();
    }
    public static void PrintOutputInReverseOrder(SortedList myList)
    {
        Console.WriteLine("\t-KEY-\t-VALUE-");
        for (int i = myList.Count - 1; i >= 0; i--)
        {
            Console.WriteLine("\t{0}:\t{1}", myList.GetKey(i), myList.GetByIndex(i));
        }
        Console.WriteLine();
    }
}