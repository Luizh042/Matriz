namespace MTZ;
public class Matriz
{
    public static void Main(string[] args)
    {
       //Matriz.ex1();
       Matriz.ex2();
    }

    public int[,] ex1()
    {
         int[,] matrix = new int[3, 3];//
         int posicao = 1;

        for (int i = 0; i < 3; i++)//coluna
        {
            for (int j = 0; j < 3; j++)//linha
            {
               matrix[i,j] = posicao;
               posicao = posicao + 1;             
               Console.Write(matrix[i, j] + " ");

            }
            Console.WriteLine("");
        }
        return matrix;
    }

    public static void ex2()
    {
         int[,] matrix = new int[3, 3];

         int[,] transposedMatrix = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                transposedMatrix[i, j] = matrix[j, i];
                Console.Write(transposedMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }   
}
