// !!!Realize the Object-oriented programming principle - Encapsulation(hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// !!!Implement a way to organize interaction between classes - Aggregation : Association.
// Aggregation : Association - an object of a class is passed as a parameter
// to the constructor of another class.

// Indexers allow instances of a class or struct to be indexed just like arrays.
class Store
{
    // Declare the array as properties of the Store instance.
    private Article[] _article = new Article[3];

    // Declaring a constructor for an instance of the Store class.
    public Store(Article[] array)
    {
        _article = array;
    }

    // Declare property - Indexer of the Store instance.
    public Article this[int index]
    {
        get
        {
            if (index < _article.Length && index >= 0)
            {
                return _article[index];
            }

            else
            {
                return default!;
            }
        }
        set
        {
            if (index < _article.Length && index >= 0)
            {
                _article[index] = value;
            }

            else
            {
                _article[index] = default!;
            }
        }
    }
}
