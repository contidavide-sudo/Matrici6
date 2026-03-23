namespace Matrici6
{
    internal class Program
    {
        static int[,] CreaMatrice()
        {
            int[,] mat = new int[10, 10];
            int cont = 10;
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    if(i==0 && j == 0)
                    {
                        mat[i, j] = mat.GetLength(0) * mat.GetLength(1);
                    }
                    else
                    {
                        mat[i, j] = mat.GetLength(0) * mat.GetLength(1) - cont;
                    }
                        
                }
                cont = cont - 1;
            }
            return mat;
        }

        static void Stampa(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"[{mat[i, j]}]");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] matrice= CreaMatrice();

            Stampa(matrice);
        }
    }
}
