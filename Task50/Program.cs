// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void ShowDesiredNumb(int thisNumb, int[,] thisArray) 
{  
    string coord = "";

    for(int i = 0; i < thisArray.GetLength(0) ; i++)
    {
        for(int j = 0; j < thisArray.GetLength(1) ; j++) 
        {
            if (thisArray[i, j] == thisNumb)
            {
                coord = "Coordinates of desired number is "  + (i+1) + " ," + (j+1); 
                Console.WriteLine($"{thisNumb} " + coord);
            }


        }        
            
    }
    if (coord.Length == 0)
        Console.Write($"{thisNumb} -> такого числа нет");

}

int r = 4;
int c = 3;
int[,] MyArray = EnterArrayElements(r, c);
Console.WriteLine("Array was created :-) ");

Console.WriteLine("Enter the desired number: ");
int Numb = Convert.ToInt32(Console.ReadLine());

ShowArrayElements(MyArray);

ShowDesiredNumb(Numb, MyArray);