# region Задание 3
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Требуется: 
//Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера 
//с возможностью изменения числа строк и столбцов. 
//Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных 
//порядков. 
#endregion 

// !!!Realize the Object-oriented programming principle - Encapsulation(hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// Indexers allow instances of a class or struct to be indexed just like arrays.

// Instancing MyMatrix class using constructor
MyMatrix matrix = new MyMatrix(6, 6);

//Expanding the matrix by numRow and num Column and auto fills with fillNumber
matrix.Expand(9, 9, 0);

//Cutting the matrix by numRow and numColumn
matrix.Cut(3, 3);

//Resizes the matrix with Cut()/ Expand() - auto fills with Zero
matrix.Resize(9, 9);

matrix.Resize(3, 3);

// Delay.
Console.ReadKey();
