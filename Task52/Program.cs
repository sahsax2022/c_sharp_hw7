// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] EnterArrayElements(int rows, int cols) 
{   
    int[,] NewArray = new int[rows, cols];
    
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)   
        {
            NewArray[i, j] = new Random().Next(0, 10);
        }
            
    }       
    
    return NewArray;
}

void ShowArrayElements(int[,] thisArray) 
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

void ShowArithmeticMean(int[,] thisArray) 
{      
    for(int j = 0; j < thisArray.GetLength(1) ; j++) 
    {
        double sum = 0.0;
        for(int i = 0; i < thisArray.GetLength(0) ; i++)  
            sum += thisArray[i,j];        
        
        sum = sum / thisArray.GetLength(0);  
        Console.WriteLine($" {sum} ");     
            
    }
}

int r = 4;
int c = 3;
int[,] MyArray = EnterArrayElements(r, c);
Console.WriteLine("Array was created :-) ");

ShowArrayElements(MyArray);

ShowArithmeticMean(MyArray);