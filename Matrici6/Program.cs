namespace Matrici6
{
    internal class Program
    {
        static int[,] CreaMatrice()
        {
            int[,] mat = new int[10, 10];
            int cont1 = 10, cont2 = 10;
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                cont2 = 10;

                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = (cont1 * cont2);
                    cont2 = cont2 - 1;
                }

                cont1 = cont1 - 1;
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

        static int[,] CreaMatEs2()
        {
            Random rnd = new Random();
            int[,] matrice = new int[5, 5];

            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    matrice[i, j] = rnd.Next(1, 101);
                }
            }

            return matrice;
        }

        static int Contatore(int[,] matrice, int x, int y)
        {
            int cont = 0;

            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    if (matrice[i,j] >= x && matrice[i, j] <= y)
                    {
                        cont = cont + 1;
                    }
                }
            }

            return cont;    
        }

        static float[] Media(int[,] matrice)
        {

        }

        static void Main(string[] args)
        {
            int[,] matrice = CreaMatrice();

            Stampa(matrice);

            Console.WriteLine();

            int[,] matrice2 = CreaMatEs2();

            Stampa(matrice2);

            int x, y;

            Console.Write("Inserisci x: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Inserisci y: ");
            y = Convert.ToInt32(Console.ReadLine());

            int cont = Contatore(matrice2, x, y);

            Console.WriteLine(cont);
        }
    }
}
