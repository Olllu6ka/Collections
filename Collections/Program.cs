using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте програму в которой реализуйте коллекцию MyList<T>.Реализуйте в простейшем
        //приближении возможность использования ее экземпляра аналогично экземпляру класса
        //List<T>.
        //Для данной задачи создайте обобщенный интерфейс IMyList<T>, интерфейс должен
        //содержать следующие методы и свойства:
        // 1) Метод void Add(T a); - для добавления элемента в коллекцию;
        // 2) T this[int index] { get; }
        // свойство – для получения элемента массива из
        // коллекции по индексу;
        // 3) int Count { get; }
        // свойство которое возвращает количество элементов массива;
        // 4) Метод void Clear(); - удаляет из коллекции все элементы;
        // 5) Метод bool Contains(T item); - определяет содержится ли элемент в коллекции.
        // Далее создайте обобщенный класс MyList<T> (экземпляр которой и будет использоватся
        // аналогично экземпляру List<T>.), в котором реализуйте интерфейс IMyList<T> также в теле
        // класса создайте закрытий массив элементов типа Т - private T[] array и конструктор
        // класса public MyList() в котором инициализируйте массив элементов.
        //Далее в методе Main создайте экземпляр коллекции MyList<T> и циклом добавьте в него 20
        //элементов, после чего в цикле переберите все его элементы и выведите их значение на консоль.
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            Random random = new Random();
            for (int g = 0; g < 20; g++){
                int a = random.Next(20);
                for (int i = 0; i < 1; i++){
                    myList.Add(a);
                }
            }
            myList.List();
        }
    }
    interface IMyList<T> {
        void Add(T a);
        T this [int index] { get; }
        int Cout { get; }
        void Clear();
        bool Contains(T item);
    }
    class MyList<T> : IMyList<T>
    {
        private T[] array = new T[20];
        ArrayList  list = new ArrayList();

        public void List(){
            for (int i = 0; i < 20; i++){
                Console.WriteLine("\t" + list[i]);
            }
        } // -

        public T this[int index] => throw new NotImplementedException(); // -

        public int Cout => throw new NotImplementedException(); // -

        public void Add(T a){
            list.Add(a);
        } // +

        public void Clear(){
            Console.WriteLine("Удалили елемент в листе !");
            list.Clear();
        } // + 

        public bool Contains(T item){
            Console.WriteLine(list.Contains(item));
            return Contains(item);
        } // +
    }
}
