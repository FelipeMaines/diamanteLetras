namespace diamanteLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura = 0;

            Console.Write("Qual a letra digitada: ");
            string letraDigitada = Console.ReadLine();
            letraDigitada = letraDigitada.ToUpper();

            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            alfabeto = alfabeto.ToUpper();

            char[] letras = new char[26];
            letras = alfabeto.ToCharArray();


            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i] == letraDigitada.ToCharArray()[0])
                {
                    altura = i + 1;
                    break;
                }
            }

            int espacoDentro = 0;
            int limiteDentro = (altura * 2) - 1;
            int espacoForaCima = 25;

            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < espacoForaCima; j++)
                {
                    Console.Write(" ");
                }

                if (i == 0)
                {
                    Console.WriteLine(letras[i]);
                    espacoForaCima--;
                }

                if (espacoDentro == 0)
                {
                    espacoDentro++;
                }

                else
                {
                    Console.Write(letras[i]);

                    for (int k = 1; k <= espacoDentro; k++)
                    {
                        Console.Write(" ");

                    }

                    if (limiteDentro > espacoDentro) //*
                    {   
                        espacoDentro += 2;      
                    }

                    if (i < altura)
                    {
                        espacoForaCima--;

                    }
                    Console.Write(letras[i]);

                    Console.WriteLine();

                }
                

            }


            int espacoDentro2 = espacoDentro -2;
            int limiteDentro2 = 0;
            int espacoForaCima2 = espacoForaCima + 1;

            for (int i = altura -2; i >= 0; i--)
            {
                for (int j = espacoForaCima2; j >= 0; j--)
                {
                    Console.Write(" ");
                }

                if (i == 0)
                {
                    Console.WriteLine(letras[i]);
                    espacoForaCima2++;
                }

                if (espacoDentro2 == 1)
                {
                    break;
                }

                else
                {
                    Console.Write(letras[i]);

                    for (int k = espacoDentro2 -2; k > 0; k--)
                    {
                        Console.Write(" ");

                    }

                    if (limiteDentro2 < espacoDentro2) //*
                    {
                        espacoDentro2 -= 2;
                    }

                    if (i < altura)
                    {
                        espacoForaCima2++;

                    }
                    Console.Write(letras[i]);

                    Console.WriteLine();

                }


            }

        }
    }
}