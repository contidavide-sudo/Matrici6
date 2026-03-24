using static System.Net.Mime.MediaTypeNames;

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
            float [] medie = new float[matrice.GetLength(0)];
            int cont = 0;

            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                cont = 0;

                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    cont = cont + matrice[i, j];
                }

                medie[i] = cont / matrice.GetLength(0);
            }

            return medie;

        }

        static int[] Somma(int[,] matrice)
        {
            int[] somma = new int[matrice.GetLength(1)];
            int cont = 0;

            for (int i = 0; i < matrice.GetLength(1); i++)
            {
                cont = 0;

                for (int j = 0; j < matrice.GetLength(0); j++)
                {
                    cont = cont + matrice[j, i];
                }

                somma[i] = cont;
            }

            return somma;
        }

        static int[,] SommaCelle(int[,] matrice)
        {
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    if(i==0 && j==0)
                    {
                        matrice[i, j] = matrice[i + 1, j] + matrice[i, j + 1];
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            //Es 1

            int[,] matrice = CreaMatrice();

            Stampa(matrice);

            Console.WriteLine();

            //Es 2

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

            //Es 3

            float[] med = Media(matrice2);

            for (int i = 0;i < med.Length;i++)
            {
                Console.Write($"[{med[i]}]");
            }

            Console.WriteLine();

            //Es 4

            int[] somm = Somma(matrice2);

            for (int i = 0; i < somm.Length; i++)
            {
                Console.Write($"[{somm[i]}]");
            }
        }
    }
}
