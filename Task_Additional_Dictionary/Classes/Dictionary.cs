// !!!Realize the Object-oriented programming principle - Encapsulation(hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// Indexers allow instances of a class or struct to be indexed just like arrays.

class Dictionary
{  // Declaring the internal fields of the class instance
   // as arrays of string elements.
    private string[] _rus = new string[5];
    private string[] _eng = new string[5];
    private string[] _ua = new string[5];

    // Constructor of the class object, initialization of array fields.
    public Dictionary()
    {
        _rus[0] = "книга"; _eng[0] = "book"; _ua[0] = "книга";

        _rus[1] = "ручка"; _eng[1] = "pen"; _ua[1] = "книга";

        _rus[2] = "солнце"; _eng[2] = "sun"; _ua[2] = "сонце";

        _rus[3] = "яблоко"; _eng[3] = "apple"; _ua[3] = "яблуко";

        _rus[4] = "стол"; _eng[4] = "table"; _ua[4] = "стiл";
    }

    // Create method-field access / Properties using sting indexer
    // returns string.
    public string this[string index]
    {
        get
        {
            for (int i = 0; i < _rus.Length; i++)
            {
                if (_rus[i] == index)
                { return _rus[i] + " - " + _eng[i] + " - " + _ua[i]; }

                if (_ua[i] == index)
                { return _ua[i] + " - " + _eng[i] + " - " + _rus[i]; }

                if (_eng[i] == index)
                { return _eng[i] + " - " + _rus[i] + " - " + _ua[i]; }
            }
            return string.Format("{0} - нет перевода для этого слова.", index);
        }
    }

    // Create method-field access / Properties using int indexer
    // returns string.
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < _rus.Length)
            {
                return _rus[index] + " - " + _eng[index] + " - " + _ua[index];
            }

            else
            {
                return "Error";
            }

        }
    }
}


