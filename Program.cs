/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)
*/

int[,,]matrix = new int[2,2,2]
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            Console.Write($"{matrix[i,j,k} ");
        }
    }
Console.WriteLine();
}

for (int i = 0; i < matrix.GetLength(0) ; i++)
{
newMatrix.Add(new List<double>());
   for (int j = 0; j < matrix.GetLength(1) ; j++)
   {
        for (int k = 0; k < matrix.GetLength(2); k++)
        if (matrix[i][j][k] % 2 == 0) 
        newMatrix[i].Add(j).Add[k];
   }

Console.WriteLine("Массив: ");
Console.WriteLine();
for (int i = 0; i < newMatrix.Count; i++)
   Console.Write("  {0,2}", newMatrix[i]);
Console.WriteLine();

