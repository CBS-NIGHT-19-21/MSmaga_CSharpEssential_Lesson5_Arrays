// !!!Realize the Object-oriented programming principle - Encapsulation(hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// Indexers allow instances of a class or struct to be indexed just like arrays.

class MyMatrix
{   //Declaration of private fields of a class instance  
    private static int _numRow = 1;
    private static int _numColumn = 1;
    private int[,] _array = new int[_numRow, _numColumn];


    /// <summary>
    /// Constructs an object of class MyMatrix with auto fill by random values
    /// </summary>
    /// <param name="numRow"></param>
    /// <param name="numColumn"></param>
    public MyMatrix(int numRow, int numColumn)
    {
        _array = new int[numRow, numColumn];

        Random random = new Random();

        for (int i = 0; i < _array.GetLength(0); i++)
        {
            for (int j = 0; j < _array.GetLength(1); j++)
            {
                _array[i, j] = random.Next(0, 13);
            }
        }
        Console.WriteLine("The Matrix has been created and filled randomly!");

        Show();
    }

    /// <summary>
    /// Cuts the matrix by numRow and numColumn
    /// </summary>
    /// <param name="numRow"></param>
    /// <param name="numColumn"></param>
    public void Cut(int numRow, int numColumn)
    {
        int[,] bufferArray = new int[numRow, numColumn];

        for (int i = 0; i < bufferArray.GetLength(0); i++)
        {
            for (int j = 0; j < bufferArray.GetLength(1); j++)
            {
                bufferArray[i, j] = _array[i, j];
            }
        }

        _array = bufferArray;

        Console.WriteLine("Cut:");

        Show();
    }

    /// <summary>
    /// Expands the matrix by numRow and num Column and auto fills with fillNumber
    /// </summary>
    /// <param name="numRow"></param>
    /// <param name="numColumn"></param>
    /// <param name="fillNumber"></param>
    public void Expand(int numRow, int numColumn, int fillNumber)
    {
        int[,] bufferArray = new int[numRow, numColumn];

        for (int i = 0; i < bufferArray.GetLength(0); i++)
        {
            for (int j = 0; j < bufferArray.GetLength(1); j++)
            {
                bool isOutArray = (i < _array.GetLength(0)) && (j < _array.GetLength(1));

                if (isOutArray)
                {
                    bufferArray[i, j] = _array[i, j];
                }

                else
                {
                    bufferArray[i, j] = fillNumber;
                }
            }
        }

        _array = bufferArray;

        Console.WriteLine("Expanded:");

        Show();
    }

    /// <summary>
    /// Resizes the matrix with Cut()/Expand() - auto fills with Zero
    /// </summary>
    /// <param name="numRow"></param>
    /// <param name="numColumn"></param>
    public void Resize(int numRow, int numColumn)
    {
        Console.Write("Resize - ");

        bool isNeedExpand = (_array.GetLength(0) < numRow) || (_array.GetLength(1) < numColumn);

        if (isNeedExpand)
        {
            this.Expand(numRow, numColumn, 0);
        }

        else
        {
            this.Cut(numRow, numColumn);
        }
    }
    /// <summary>
    /// Shows elements of the matrix
    /// </summary>
    public void Show()
    {

        for (int i = 0; i < _array.GetLength(0); i++)
        {
            for (int j = 0; j < _array.GetLength(1); j++)
            {
                Console.Write("{0} \t", _array[i, j]);
            }

            Console.WriteLine();
        }

        Console.WriteLine("\n");
    }
}
