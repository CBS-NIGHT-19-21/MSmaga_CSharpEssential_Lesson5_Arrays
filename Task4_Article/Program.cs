#region Задание 4
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Требуется: 
//Создать класс Article, содержащий следующие закрытые поля: 
//• название товара; 
//• название магазина, в котором продается товар; 
//• стоимость товара в гривнах. 
//Создать класс Store, содержащий закрытый массив элементов типа Article. 
//Обеспечить следующие возможности: 
//• вывод информации о товаре по номеру с помощью индекса; 
//• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров 
//нет, выдать соответствующее сообщение;
//Написать программу, вывода на экран информацию о товаре.
#endregion

// !!!Realize the Object-oriented programming principle - Encapsulation(hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// !!!Implement a way to organize interaction between classes - Aggregation : Association.
// Aggregation : Association - an object of a class is passed as a parameter
// to the constructor of another class.

// Indexers allow instances of a class or struct to be indexed just like arrays.

// Create an array of 5 instances of the Article class.
Article[] articleArray = new Article[5];

// Initialize the array elements.
articleArray[0] = new Article("Good1", "Store1", 13.0m);
articleArray[1] = new Article("Good2", "Store2", 23.0m);
articleArray[2] = new Article("Good3", "Store3", 33.0m);
articleArray[3] = new Article("Good4", "Store4", 43.0m);
articleArray[4] = new Article("Good5", "Store5", 53.0m);


// Create an instance of the Store class accepting an array of 5 instances of the Article class.
Store store = new Store(articleArray);

// Using the indexer of the Store class, initialize the properties of the array instances.
Console.WriteLine("Please, insert store index: ");

int index = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please, insert good info: ");

store[index].Good = Console.ReadLine();

Console.WriteLine("Please, insert price info: ");

store[index].Price = Convert.ToDecimal(Console.ReadLine());


// Using the indexer of the Store class, display the properties of the array instances.
Console.WriteLine("Good: {0}, Store: {1}, Price: {2}",
        store[index].Good, store[index].Store, store[index].Price);

// Delay.
Console.ReadLine();