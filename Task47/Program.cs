// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] EnterArrayElements(int rows, int cols) 
{   
    double[,] NewArray = new double[rows, cols];
    
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)   
        {
            NewArray[i, j] = new Random().NextDouble() * 100;
        }
            
    }       
    
    return NewArray;
}

void ShowArrayElements(double[,] thisArray) 
{  
    for(int i = 0; i < thisArray.GetLength(0) ; i++)
    {
        Console.Write("[");
        for(int j = 0; j < thisArray.GetLength(1) ; j++) 
        {
            Console.Write(string.Format("{0:f1}", thisArray[i, j]));
            if(j < thisArray.GetLength(1) - 1)
                Console.Write("; ");
            else
                Console.WriteLine("] ");                
        }        
            
    }

}

Console.WriteLine("Input array Rows size: ");
int thisRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input array Colums size: ");
int thisCols = Convert.ToInt32(Console.ReadLine());

double[,] MyArray = EnterArrayElements(thisRows, thisCols);
Console.WriteLine("Array was created :-) ");

ShowArrayElements(MyArray);