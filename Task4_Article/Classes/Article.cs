// !!!Realize the Object-oriented programming principle - Encapsulation(hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// !!!Implement a way to organize interaction between classes - Aggregation : Association.
// Aggregation : Association - an object of a class is passed as a parameter
// to the constructor of another class.

// Indexers allow instances of a class or struct to be indexed just like arrays.

class Article
{   // Declaring a property of an instance of a class.
    //? - Nullable References - we solve the problem with Null.
    private string _good;
    private string _store;
    private decimal _price;

    // Declaring a constructor for an instance of a class.
    public Article(string good, string store, decimal price)
    {
        _good = good;
        _store = store;
        _price = price;
    }

    public string Good { get { return _good; } set { _good = value; } }
    public string Store { get { return _store; } set { _store = value; } }
    public decimal Price { get { return _price; } set { _price = value; } }
}
