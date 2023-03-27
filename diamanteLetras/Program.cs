namespace diamanteLetras
{
    internal class Program
    {
        static char[] letras = new char[26];

        //Parte ALTA
        static string pegarLetra(string texto)
        {
            Console.WriteLine(texto);
            string letraDigitada = Console.ReadLine();
            letraDigitada = letraDigitada.ToUpper();

            return letraDigitada;
        }

        static char[] fazerArrayAlfabeto()
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            alfabeto = alfabeto.ToUpper();
            letras = alfabeto.ToCharArray();

            return letras;
        }
 
        static int daValorAltura(int altura, string letraDigitada)
        {
            char letra = char.Parse(letraDigitada);
            altura = Array.BinarySearch(letras, letra) + 1;
            //for (int i = 0; i < letras.Length; i++)
            //{
            //    if (letras[i] == letraDigitada.ToCharArray()[0])
            //    {
            //        altura = i + 1;
            //        break;
            //    }
            //}

            return altura;
        }

        static void colocarEspacoForaCima(int espacoForaCima)
        {
            for (int j = 0; j < espacoForaCima; j++)
            {
                Console.Write(" ");
            }

            
        }

        static void modificaValoresEspacosEscreveLetrasAlto(int altura, ref int espacoDentro, int limiteDentro, ref int espacoForaCima, int i)
        {
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

        //PARTE BAIXA

        static void colocaEspacoForaBaixo(int espacoForaBaixo)

       
        {
            for (int j = espacoForaBaixo; j >= 0; j--)
            {
                Console.Write(" ");
            }
        }

        static void modificaValoresEspacosEscreveLetrasBaixo(ref int espacoForaBaixo, ref int espacoDentro2, int limiteDentro2, int i, int altura)
        {
            if (i == 0)
            {
                Console.WriteLine(letras[i]);
                espacoForaBaixo++;
            }

            if (espacoDentro2 == 1)
            {
                
            }

            else
            {
                Console.Write(letras[i]);

                for (int k = espacoDentro2 - 2; k > 0; k--)
                {
                    Console.Write(" ");

                }

                if (limiteDentro2 < espacoDentro2) //*
                {
                    espacoDentro2 -= 2;
                }

                if (i < altura)
                {
                    espacoForaBaixo++;

                }
                Console.Write(letras[i]);

                Console.WriteLine();

            }
        }
        
        static void Main(string[] args)
        {
            int altura = 0;

            string letraDigitada = pegarLetra("Qual a letra digitada: ");

            fazerArrayAlfabeto();

            altura = daValorAltura(altura, letraDigitada);

            int espacoDentro = 0;
            int limiteDentro = (altura * 2) - 1;
            int espacoForaCima = 25;

            // FAZ DIAMANTE CIMA
            for (int i = 0; i < altura; i++)
            {
                colocarEspacoForaCima(espacoForaCima);
                modificaValoresEspacosEscreveLetrasAlto(altura, ref espacoDentro, limiteDentro, ref espacoForaCima, i);
            }

            int espacoDentroBaixo = espacoDentro - 2;
            int limiteDentroBaixo = 0;
            int espacoForaBaixo = espacoForaCima + 1;

            // FAZ DIAMANTE BAIXO
            for (int i = altura - 2; i >= 0; i--)
            {
                colocaEspacoForaBaixo(espacoForaBaixo);
                modificaValoresEspacosEscreveLetrasBaixo(ref espacoForaBaixo, ref espacoDentroBaixo, limiteDentroBaixo, i, altura);
            }
        }
    }
}