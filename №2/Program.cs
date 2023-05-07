using System;
using System.Collections;

namespace _2
{
    class Program
    {
        //Используя Visual Studio, создайте про.ект по шаблону Console Application.
        //Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
        //Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем
        //задании 2 для данного урока.Выведите на экран значения элементов массива, который вернул
        //расширяющий метод GetArray()
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            Random random = new Random();
            for (int g = 0; g < 20; g++)
            {
                int a = random.Next(20);
                for (int i = 0; i < 1; i++)
                {
                    myList.Add(a);
                }
            }
            myList.List();
        }
    }
    interface IMyList<T>
    {
        void Add(T a);
        T this[int index] { get; }
        int Cout { get; }
        void Clear();
        bool Contains(T item);
    }
    public class MyList<T> : IMyList<T>
    {
        private T[] array = new T[20];
        ArrayList list = new ArrayList();

        //public static void GetArray<T>(this MyList<T> list)
        //{
            
        //}
        public void List()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("\t" + list[i]);
            }
        } // -

        public T this[int index] => throw new NotImplementedException(); // -

        public int Cout => throw new NotImplementedException(); // -

        public void Add(T a)
        {
            list.Add(a);
        } // +

        public void Clear()
        {
            Console.WriteLine("Удалили елемент в листе !");
            list.Clear();
        } // + 

        public bool Contains(T item)
        {
            Console.WriteLine(list.Contains(item));
            return Contains(item);
        } // +
    }
}
