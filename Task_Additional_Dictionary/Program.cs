namespace Task_Additional_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание Дополнительное
            //Расширьте пример 5 (русско-английский словарь) еще и украинским словарем. Реализуйте возможность 
            //поиска не только по ключевым русским словам и словам на остальных языках. 
            #endregion

            // !!!Realize the Object-oriented programming principle - Encapsulation(hiding the implementation).
            // Encapsulate data set and methods for working on it as an object.
            // Declarate class of this kind of objects.
            // Declarate the method to constructor an object of this class.

            // Indexers allow instances of a class or struct to be indexed just like arrays.

            // Instantiate the Dictionary class.
            Dictionary dictionary = new Dictionary();

            // Accessing the string elements of the internal array of the instance using the string property of the indexer.
            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблоко"]);
            Console.WriteLine(dictionary["солнце"]);
            Console.WriteLine(new string('-', 20));

            // Referring to string elements of internal field - arrays of the instance using the string property of the indexer

            Console.WriteLine(dictionary["солнце"]);
            Console.WriteLine(dictionary["яблуко"]);
            Console.WriteLine(dictionary["table"]);

            Console.WriteLine(new string('-', 20));

            // Referring to string elements of internal field - arrays of the instance using the int property of the indexer

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(dictionary[i]);
            }
            //Delay.
            Console.ReadKey();
        }
    }
}

