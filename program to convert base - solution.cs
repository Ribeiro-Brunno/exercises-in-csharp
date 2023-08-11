using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1_Principal
{
    internal class Program
    {
        static int menuConversao()
        {
            //Trabalho Prático 1 - Programação de Computadores & Matemática

            //O objetivo deste trabalho é o desenvolvimento de uma calculadora didática de conversão de bases.

            int conversaoEscolha = 100;

            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("| ------------------ Menu de conversão de base: -------------------|");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("| --------- Digite o numero referente a conversão desejada --------|");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("|                                 --> BINÁRIO                      |");
            Console.WriteLine("| Digite 1 para converter DECIMAL --> OCTAL                        |");
            Console.WriteLine("|                                 --> HEXADECIMAL                  |");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("| Digite 2 para converter BINÁRIO --> OCTAL                        |");
            Console.WriteLine("|                                 --> HEXADECIMAL                  |");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("| Digite 3 para converter BINÁRIO --> DECIMAL                      |");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("| Digite 4 para converter OCTAL --> BINÁRIO                        |");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("| Digite 5 para converter OCTAL --> DECIMAL                        |");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("| Digite 6 para converter OCTAL --> HEXADECIMAL                    |");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("| Digite 7 para converter HEXADECIMAL --> BINÁRIO                  |");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("| Digite 8 para converter HEXADECIMAL --> OCTAL                    |");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("| Digite 9 para converter HEXADECIMAL --> DECIMAL                  |");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("| Digite 0 para SAIR                                               |");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("| Digite sua OPÇÃO:                                                |");
            Console.WriteLine("|------------------------------------------------------------------|");

            conversaoEscolha = int.Parse(Console.ReadLine());

            return conversaoEscolha;
        }

        static void executarConversao(int opcaoConversao)
        {
            switch (opcaoConversao)
            {
                case 0:
                    Console.WriteLine("Finalizando programa ... ");
                    break;

                case 1:
                    conversao1();
                    break;

                case 2:
                    conversao2();
                    break;

                case 3:
                    conversao3();
                    break;

                case 4:
                    conversao4();
                    break;

                case 5:
                    conversao5();
                    break;

                case 6:
                    conversao6();
                    break;

                case 7:
                    conversao7();
                    break;

                case 8:
                    conversao8();
                    break;

                case 9:
                    conversao9();
                    break;

                default:
                    Console.WriteLine("Numeros validos entre 1 a 9.");
                    Console.WriteLine("Digite qualquer tecla para continuar");
                    break;

            }
        }

        static void conversao1()
        {
            int numeroBaseConversao = 0;
            long div = 0;
            long resto = 0;
            int contador = 0;
            string cont = "";
            string restos = "";

            Console.WriteLine("|--------------------------------------------------------|");
            Console.WriteLine("|-Conversão de numero decimal para Binário (BASE 2)------|");
            Console.WriteLine("|-Conversão de numero decimal para Octal (BASE 8)--------|");
            Console.WriteLine("|-Conversão de numero decimal para Hexadecimal (BASE 16)-|");
            Console.WriteLine("|--------------------------------------------------------|");

            Console.Write("Digite um numero para ser convertido: ");
            string entraNumero = Console.ReadLine();

            if (!ValidaNumeroDecimal(entraNumero))
            {
                Console.WriteLine("Erro: Número decimal inválido - Digite um número decimal válido.");
                Console.WriteLine("Pressione qualquer tecla para encerrar...");
                Console.ReadKey();
                return;
            }

            long numeroDecimal = long.Parse(entraNumero);

            Console.Write("Digite a Base: ");
            numeroBaseConversao = int.Parse(Console.ReadLine());

            Console.WriteLine("|--------------------------------------------------------|");

            div = numeroDecimal;

            if (numeroBaseConversao == 2 || numeroBaseConversao == 8 || numeroBaseConversao == 16)//FIZ UMA CONDICIONAL DAS CONVERSÕES DE DECIMAIS PARA AS DEMAIS BASES PARA ENTRAR NO WHILE
            {
                while (div > 0)
                {
                    contador++;

                    cont += contador + " ";

                    Console.WriteLine("Passo " + contador);

                    Console.WriteLine(numeroDecimal + " / " + numeroBaseConversao);

                    div = numeroDecimal / numeroBaseConversao;
                    resto = numeroDecimal % numeroBaseConversao;

                    Console.WriteLine("Quociente " + numeroDecimal);
                    Console.WriteLine("Resto " + resto);

                    Console.WriteLine("|--------------------------------------------------------|");

                    if (numeroBaseConversao == 16)
                    {
                        if (resto < 10)
                        {
                            restos += resto + " ";
                        }
                        else
                        {
                            char letra = (char)(resto + 55); // Converte para letra hexadecimal de acordo com a tabela ASCII
                            restos += letra + " ";
                        }
                    }
                    else
                    {
                        restos += resto + " ";
                    }

                    numeroDecimal = div * 1;
                }

                string restosInvertida = string.Join("", restos.Reverse()); //JOGUEI ESSA ESTRUTURA ENTRE AS LINHAS 79 E 87 PARA DENTRO DA CONDICIONAL

                Console.WriteLine("Passo " + (contador + 1));

                Console.WriteLine("Junte os valores dos restos dos passos " + cont);

                Console.WriteLine("|--------------------------------------------------------|");

                Console.WriteLine("Resultado = " + restosInvertida);
            }
            else
            {
                Console.WriteLine("Número de base inválido! ");
            }

            Console.ReadKey();
        }

        static bool ValidaNumeroDecimal(string inputNumero)
        {
            return long.TryParse(inputNumero, out _);
        }

        static void conversao2()
        {
            string numeroBinario = "";
            string numeroBaseConversao = "";
            string grupo = "";
            string valorOctal = "";
            string valorHexadecimal = "";
            string resultado = "";
            string resultadototal = "";
            int contador = 0;

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Conversão de número BINÁRIO para Octal (BASE 8)");
            Console.WriteLine("Conversão de número BINÁRIO para Hexadecimal (BASE 16)");
            Console.WriteLine("-----------------------------------------------------------------");

            Console.Write("Digite um numero para ser convertido (Somente números Binários): ");
            numeroBinario = Console.ReadLine();

            bool numeroBinarioValido = true;

            foreach (char digito in numeroBinario)
            {
                if (digito != '0' && digito != '1')
                {
                    numeroBinarioValido = false;
                    break;
                }
            }

            if (!numeroBinarioValido)
            {
                Console.WriteLine("O número digitado não é um número binário válido.");
                Console.ReadKey();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("-----------------------------------------------------------------");

                Console.Write("Digite a base de conversão (8 para Octal, 16 para Hexadecimal): ");
                numeroBaseConversao = Console.ReadLine();

                if (numeroBaseConversao == "8")
                {
                    Console.WriteLine("|--------------- Conversão de números Binários para Octal -----------------|");
                    Console.WriteLine("| Separa-se o número binário em grupos de 3 caracteres (a partir da direta )");
                    Console.WriteLine("|e converte cada grupo (de 3 caracteres) no número octal correspondente.   |");
                    Console.WriteLine("|--- Segue o passo a passo da conversão Binario para Octal.---");
                    Console.WriteLine("|--------------------------------------------------------------------------|");

                    int posicao = ((numeroBinario.Length) - 3);

                    while (posicao >= 0)
                    {
                        grupo = numeroBinario.Substring(posicao, Math.Min(3, numeroBinario.Length - posicao));

                        posicao = posicao - 3;
                        resultado += grupo + " ";

                        valorOctal = grupo.Replace("000", "0")
                                     .Replace("001", "1")
                                     .Replace("010", "2")
                                     .Replace("011", "3")
                                     .Replace("100", "4")
                                     .Replace("101", "5")
                                     .Replace("110", "6")
                                     .Replace("111", "7");

                        resultadototal = valorOctal + resultadototal;

                        Console.WriteLine("Passo " + (contador + 1));
                        Console.WriteLine(resultado);

                        contador++;

                        Console.WriteLine("--------------------------------------");

                    }

                    if (posicao < 0)
                    {
                        grupo = numeroBinario.Substring(0, posicao + 3);
                        grupo = grupo.PadLeft(3, '0');
                        resultado += grupo + " ";

                        valorOctal = grupo.Replace("000", "0")
                                     .Replace("001", "1")
                                     .Replace("010", "2")
                                     .Replace("011", "3")
                                     .Replace("100", "4")
                                     .Replace("101", "5")
                                     .Replace("110", "6")
                                     .Replace("111", "7");

                        resultadototal = valorOctal + resultadototal;

                        Console.WriteLine("Passo " + (contador + 1));
                        Console.WriteLine(resultado);

                        contador++;

                        Console.WriteLine("--------------------------------------");

                    }
                    Console.WriteLine("Resultado = " + resultadototal);

                }

                if (numeroBaseConversao == "16")
                {
                    Console.WriteLine("|--------------- Conversão de números Binários para Hexadecimal ---------------|");
                    Console.WriteLine("| Separa-se o número binário em grupos de 4 caracteres (a partir da direta)    |");
                    Console.WriteLine("| e converte cada grupo (de 4 caracteres) no número hexadecimal correspondente.|");
                    Console.WriteLine("|--- Segue o passo a passo da conversão Binario para Hexadecimal.---|");
                    Console.WriteLine("|------------------------------------------------------------------------------|");

                    int posicao = ((numeroBinario.Length) - 4);

                    while (posicao >= 0)
                    {
                        grupo = numeroBinario.Substring(posicao, Math.Min(4, numeroBinario.Length - posicao));

                        posicao = posicao - 4;
                        resultado += grupo + " ";

                        valorHexadecimal = grupo.Replace("0000", "0")
                                              .Replace("0001", "1")
                                              .Replace("0010", "2")
                                              .Replace("0011", "3")
                                              .Replace("0100", "4")
                                              .Replace("0101", "5")
                                              .Replace("0110", "6")
                                              .Replace("0111", "7")
                                              .Replace("1000", "8")
                                              .Replace("1001", "9")
                                              .Replace("1010", "A")
                                              .Replace("1011", "B")
                                              .Replace("1100", "C")
                                              .Replace("1101", "D")
                                              .Replace("1110", "E")
                                              .Replace("1111", "F");

                        resultadototal = valorHexadecimal + resultadototal;

                        Console.WriteLine("Passo " + (contador + 1));
                        Console.WriteLine(resultado);

                        contador++;

                        Console.WriteLine("--------------------------------------");

                    }

                    if (posicao < 0)
                    {
                        grupo = numeroBinario.Substring(0, posicao + 4);
                        grupo = grupo.PadLeft(4, '0');
                        resultado += grupo + " ";

                        valorHexadecimal = grupo.Replace("0000", "0")
                                              .Replace("0001", "1")
                                              .Replace("0010", "2")
                                              .Replace("0011", "3")
                                              .Replace("0100", "4")
                                              .Replace("0101", "5")
                                              .Replace("0110", "6")
                                              .Replace("0111", "7")
                                              .Replace("1000", "8")
                                              .Replace("1001", "9")
                                              .Replace("1010", "A")
                                              .Replace("1011", "B")
                                              .Replace("1100", "C")
                                              .Replace("1101", "D")
                                              .Replace("1110", "E")
                                              .Replace("1111", "F");

                        resultadototal = valorHexadecimal + resultadototal;

                        Console.WriteLine("Passo " + (contador + 1));
                        Console.WriteLine(resultado);

                        contador++;

                        Console.WriteLine("--------------------------------------");

                    }
                    Console.WriteLine(resultadototal);
                }

                Console.ReadKey();
            }
        }

        static void conversao3()
        {
            Console.Write("Digite um número binário: ");
            string binarioStr = Console.ReadLine();

            long binario;
            if (!long.TryParse(binarioStr, out binario))
            {
                Console.WriteLine("O número digitado não é um número binário válido.");
                Console.ReadKey();
                return;
            }
            else
            {
                int decimalNum = 0;
                int potencia = 1;
                int bit;
                long temp = binario;
                bool erro = false;

                while (temp >= 1)
                {
                    bit = (int)(temp % 10);
                    temp /= 10;

                    if (bit != 0 && bit != 1)
                    {
                        Console.WriteLine("O número digitado não é um número binário válido.");
                        erro = true;
                        break;
                    }

                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("Passo a Passo - Binário para Decimal");
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("Bit atual: " + bit);

                    if (bit == 0)
                    {
                        Console.WriteLine();
                    }

                    if (bit == 1)
                    {
                        Console.WriteLine("Potência atual: " + potencia);
                        Console.WriteLine("Valor adicionado: " + (bit * potencia) + " (2^" + potencia + ")");
                        decimalNum += bit * potencia;

                        Console.WriteLine();
                    }

                    potencia *= 2;
                }

                if (!erro)
                {
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("O número decimal equivalente é: " + decimalNum);
                }
            }

            Console.ReadKey();
        }

        static void conversao4()
        {
            Console.Write("Digite um número octal: ");
            string octalStr = Console.ReadLine();

            Console.WriteLine();

            if (!ValidaOctal(octalStr))
            {
                Console.WriteLine("Erro: Número octal inválido - Digite um número octal válido entre 0 e 7.");
                Console.WriteLine("Pressione qualquer tecla para encerrar...");
                Console.ReadKey();
                return;
            }

            int octal = int.Parse(octalStr);

            string binario = ConverterOctalParaBinario(octal);
            Console.WriteLine("O número binário equivalente é: " + binario);

            Console.ReadKey();
        }

        static bool ValidaOctal(string octalStr)
        {
            int pare = octalStr.Length;
            for (int i = 0; i < pare; i++)
            {
                char c = octalStr.ElementAt(i);
                if (c < '0' || c > '7')
                    return false;
            }
            return true;
        }

        static string ConverterOctalParaBinario(int octal)
        {
            string binario = "";

            Console.WriteLine("Conversão de Octal para Binário:");

            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------");

            while (octal != 0)
            {
                int digito = octal % 10;
                octal /= 10;

                string binarioDigito = ConverterDigitoOctalParaBinario(digito);
                binario = binarioDigito.PadLeft(3, '0') + binario;

                Console.WriteLine("RESULTADOS PARCIAIS");

                Console.WriteLine("Dígito Octal: " + digito);
                Console.WriteLine("Dígito Binário: " + binarioDigito);
                Console.WriteLine("Resultado Parcial: " + binario);

                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------");

            }

            return binario;
        }

        static string ConverterDigitoOctalParaBinario(int digitoOctal)
        {
            string binarioDigito = "";

            Console.WriteLine("Conversão do dígito Octal " + digitoOctal + " para Binário:");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine();

            while (digitoOctal != 0)
            {
                int resto = digitoOctal % 2;
                digitoOctal /= 2;

                binarioDigito = resto.ToString() + binarioDigito;

                Console.WriteLine("Divisão por 2: " + digitoOctal + ", Resto: " + resto);
            }

            Console.WriteLine("Dígito Binário resultante: " + binarioDigito);

            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine();

            return binarioDigito;
        }

        static void conversao5()
        {
            Console.Write("Digite um número octal: ");
            string entradaOctal = Console.ReadLine();

            if (!ValidaOctal3(entradaOctal)) //ACRESCENTEI ESSA PARTE PARA VALIDAR A ENTRADA EM NUMERO OCTAL
            {
                Console.WriteLine("Erro: Número octal inválido - Digite um número octal válido entre 0 e 7.");
                Console.WriteLine("Pressione qualquer tecla para encerrar...");
                Console.ReadKey();
                return;
            }

            int numeroOctal;
            if (!int.TryParse(entradaOctal, out numeroOctal)) // NAO ENTENDI
            {
                Console.WriteLine("Entrada inválida. Certifique-se de inserir um número octal válido.");
                return;
            }

            Console.WriteLine();

            Console.WriteLine("Passo a passo da conversão de octal para decimal: ");

            Console.WriteLine();

            int numeroDecimal = ConverterOctalParaDecimal(numeroOctal);

            Console.WriteLine();
            Console.WriteLine("O número decimal equivalente é: " + numeroDecimal);

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para encerrar o programa...");

            Console.ReadKey();
        }

        static bool ValidaOctal3(string entradaOctal)
        {
            int pare = entradaOctal.Length;
            for (int i = 0; i < pare; i++)
            {
                char c = entradaOctal.ElementAt(i);
                if (c < '0' || c > '7')
                    return false;
            }
            return true;
        }

        static int ConverterOctalParaDecimal(int numeroOctal)
        {
            int numeroDecimal = 0;
            int posicao = 0;

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Número octal: " + numeroOctal);
            Console.WriteLine("----------------------------------------------------");

            while (numeroOctal != 0)
            {
                int digito = numeroOctal % 10;
                int valorDecimal = digito * (int)Math.Pow(8, posicao);

                Console.WriteLine();
                Console.WriteLine($"- Dígito: {digito}");
                Console.WriteLine($"- Valor decimal parcial: {digito} * 8^{posicao} = {valorDecimal}");
                Console.WriteLine($"- Decimal acumulado: {numeroDecimal} + {valorDecimal} = {numeroDecimal + valorDecimal}");
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------");

                numeroDecimal += valorDecimal;
                numeroOctal /= 10;
                posicao++;
            }

            return numeroDecimal;
        }

        static void conversao6()
        {
            string grupo = "";
            string valorHexadecimal = "";
            string resultado = "";
            string resultadototal = "";
            int contador = 0;

            Console.Write("Digite um número octal: ");
            string octalStr = Console.ReadLine();

            Console.WriteLine();

            if (!ValidaOctalparaBinario(octalStr))
            {
                Console.WriteLine("Erro: Número octal inválido - Digite um número octal válido entre 0 e 7.");
                Console.WriteLine("Pressione qualquer tecla para encerrar...");
                Console.ReadKey();
                return;
            }

            int octal = int.Parse(octalStr);

            string binario = ConverterOctalParaBinarioParaHexa(octal);
            Console.WriteLine("O número binário equivalente é: " + binario);
            Console.WriteLine();


            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("--> SEGUNDA PARTE <--");
            Console.WriteLine("Conversão de Binário para Hexadecimal:");
            Console.WriteLine("Será dividido o número binário em grupos de quatros dígitos");
            Console.WriteLine("Se o número binário não for divisível por quatro, ");
            Console.WriteLine("será adicionado zeros à esquerda para completar o grupo final.");
            Console.WriteLine("Aqui está um passo a passo para converter um número binário em Hexadecimal:");
            Console.WriteLine("---------------------------------------------------------------------------");



            int posicao = ((binario.Length) - 4);

            Console.WriteLine("Conversão do valor Binário " + binario + " para Hexadecimal:");
            Console.WriteLine();

            while (posicao >= 0)
            {
                grupo = binario.Substring(posicao, Math.Min(4, binario.Length - posicao));

                posicao = posicao - 4;
                resultado += grupo + " ";

                valorHexadecimal = grupo.Replace("0000", "0")
                                      .Replace("0001", "1")
                                      .Replace("0010", "2")
                                      .Replace("0011", "3")
                                      .Replace("0100", "4")
                                      .Replace("0101", "5")
                                      .Replace("0110", "6")
                                      .Replace("0111", "7")
                                      .Replace("1000", "8")
                                      .Replace("1001", "9")
                                      .Replace("1010", "A")
                                      .Replace("1011", "B")
                                      .Replace("1100", "C")
                                      .Replace("1101", "D")
                                      .Replace("1110", "E")
                                      .Replace("1111", "F");

                resultadototal = valorHexadecimal + resultadototal;

                Console.WriteLine("Passo " + (contador + 1));
                Console.WriteLine(resultado);

                contador++;

                Console.WriteLine("-----------------------------------------------------------");

            }

            if (posicao < 0)
            {
                grupo = binario.Substring(0, posicao + 4);
                grupo = grupo.PadLeft(4, '0');
                resultado += grupo + " ";

                valorHexadecimal = grupo.Replace("0000", "0")
                                      .Replace("0001", "1")
                                      .Replace("0010", "2")
                                      .Replace("0011", "3")
                                      .Replace("0100", "4")
                                      .Replace("0101", "5")
                                      .Replace("0110", "6")
                                      .Replace("0111", "7")
                                      .Replace("1000", "8")
                                      .Replace("1001", "9")
                                      .Replace("1010", "A")
                                      .Replace("1011", "B")
                                      .Replace("1100", "C")
                                      .Replace("1101", "D")
                                      .Replace("1110", "E")
                                      .Replace("1111", "F");

                resultadototal = valorHexadecimal + resultadototal;

                Console.WriteLine("Passo " + (contador + 1));
                Console.WriteLine(resultado);

                contador++;

                Console.WriteLine("-----------------------------------------------------------");

            }
            Console.WriteLine("O número HEXADECIMAL equivalente é: " + resultadototal);


            Console.ReadKey();
        }

        static bool ValidaOctalparaBinario(string octalStr)
        {
            int pare = octalStr.Length;
            for (int i = 0; i < pare; i++)
            {
                char c = octalStr.ElementAt(i);
                if (c < '0' || c > '7')
                    return false;
            }
            return true;
        }

        static string ConverterOctalParaBinarioParaHexa(int octal)
        {
            string binario = "";

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("--> PRIMEIRA PARTE <--");
            Console.WriteLine("Conversão de Octal para Binário:");
            Console.WriteLine("A conversão de números octais para binários é feita convertendo");
            Console.WriteLine("cada dígito octal em seu equivalente binário de 3 bits.");
            Console.WriteLine("Aqui está um passo a passo para converter um número octal em binário:");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine();

            while (octal != 0)
            {
                int digito = octal % 10;
                octal /= 10;

                string binarioDigito = ConverterDigitoOctalParaBinarioParaHexa(digito);
                binario = binarioDigito.PadLeft(3, '0') + binario;

                /*Console.WriteLine("RESULTADOS PARCIAIS");

                Console.WriteLine("Dígito Octal: " + digito);
                Console.WriteLine("Dígito Binário: " + binarioDigito);
                Console.WriteLine("Resultado Parcial: " + binario);

                Console.WriteLine();
                Console.WriteLine("=========================================================");*/

            }

            return binario;
        }

        static string ConverterDigitoOctalParaBinarioParaHexa(int digitoOctal)
        {
            string binarioDigito = "";

            Console.WriteLine("Conversão do dígito Octal " + digitoOctal + " para Binário:");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine();

            while (digitoOctal != 0)
            {
                int resto = digitoOctal % 2;
                digitoOctal /= 2;

                binarioDigito = resto.ToString() + binarioDigito;

                Console.WriteLine("Divisão por 2: " + digitoOctal + ", Resto: " + resto);
            }

            Console.WriteLine("Dígito Binário resultante: " + binarioDigito);

            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine();

            return binarioDigito;
        }

        static void conversao7()
        {
            Console.Write("Digite um número hexadecimal: ");
            string hexadecimal = Console.ReadLine();

            if (!ValidaHexadecimal(hexadecimal))
            {
                Console.WriteLine("Erro: Número Hexadecimal inválido - Digite um número hexadecima válido.");
                Console.WriteLine("Pressione qualquer tecla para encerrar...");
                Console.ReadKey();
                return;
            }

            string binario = ConverterHexadecimalParaBinario(hexadecimal);
            Console.WriteLine("O número binário equivalente é: " + binario);

            Console.ReadKey();
        }

        static bool ValidaHexadecimal(string hexadecimal)
        {
            int length = hexadecimal.Length;
            for (int i = 0; i < length; i++)
            {
                char c = hexadecimal[i];

                if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f')))

                    return false;
            }
            return true;
        }

        static string ConverterHexadecimalParaBinario(string hexadecimal)
        {
            string binario = "";

            Console.WriteLine("\nConversão de Hexadecimal para Binário:");

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");

            for (int i = 0; i < hexadecimal.Length; i++)
            {
                string digitoHexa = hexadecimal.Substring(i, 1);
                string binarioDigito = ConverterDigitoHexadecimalParaBinario(digitoHexa);
                binario += binarioDigito;

                Console.WriteLine("Dígito Hexadecimal: " + digitoHexa);
                Console.WriteLine("Dígito Binário: " + binarioDigito);
                Console.WriteLine("Resultado Parcial: " + binario);
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------------");
            }
            return binario;
        }

        static string ConverterDigitoHexadecimalParaBinario(string digitoHexa)
        {
            string binarioDigito = "";

            Console.WriteLine("Conversão do dígito Hexadecimal " + digitoHexa + " para Binário:");

            Console.WriteLine("---------------------------------------------------------");

            string binario = "";

            switch (digitoHexa.ToUpper())
            {
                case "0":
                    binario = "0000";
                    break;
                case "1":
                    binario = "0001";
                    break;
                case "2":
                    binario = "0010";
                    break;
                case "3":
                    binario = "0011";
                    break;
                case "4":
                    binario = "0100";
                    break;
                case "5":
                    binario = "0101";
                    break;
                case "6":
                    binario = "0110";
                    break;
                case "7":
                    binario = "0111";
                    break;
                case "8":
                    binario = "1000";
                    break;
                case "9":
                    binario = "1001";
                    break;
                case "A":
                    binario = "1010";
                    break;
                case "B":
                    binario = "1011";
                    break;
                case "C":
                    binario = "1100";
                    break;
                case "D":
                    binario = "1101";
                    break;
                case "E":
                    binario = "1110";
                    break;
                case "F":
                    binario = "1111";
                    break;
                default:
                    Console.WriteLine("Dígito Hexadecimal inválido!");
                    break;
            }

            binarioDigito = binario.PadLeft(4, '0');

            Console.WriteLine();
            Console.WriteLine("Dígito Binário resultante: " + binarioDigito);

            return binarioDigito;
        }

        static void conversao8()
        {
            string grupo = "";
            string valorOctal = "";
            string resultado = "";
            string resultadototal = "";
            int contador = 0;

            Console.Write("Digite um número hexadecimal: ");
            string hexadecimal = Console.ReadLine();

            if (!ValidaHexadecimal2(hexadecimal))
            {
                Console.WriteLine("Erro: Número Hexadecimal inválido - Digite um número hexadecima válido.");
                Console.WriteLine("Pressione qualquer tecla para encerrar...");
                Console.ReadKey();
                return;
            }

            string binario = ConverterHexadecimalParaBinario2parte(hexadecimal);
            Console.WriteLine("O número binário equivalente é: " + binario);
            Console.WriteLine();

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("--> SEGUNDA PARTE <--");
            Console.WriteLine("Conversão de Binário para Octal:");
            Console.WriteLine("Será dividido o número binário em grupos de três dígitos");
            Console.WriteLine("Se o número binário não for divisível por três, ");
            Console.WriteLine("será adicionado zeros à esquerda para completar o grupo final.");
            Console.WriteLine("Aqui está um passo a passo para converter um número binário em Octal:");
            Console.WriteLine("---------------------------------------------------------------------");

            int posicao = ((binario.Length) - 3);

            while (posicao >= 0)
            {
                grupo = binario.Substring(posicao, Math.Min(3, binario.Length - posicao));

                posicao = posicao - 3;
                resultado += grupo + " ";

                valorOctal = grupo.Replace("000", "0")
                             .Replace("001", "1")
                             .Replace("010", "2")
                             .Replace("011", "3")
                             .Replace("100", "4")
                             .Replace("101", "5")
                             .Replace("110", "6")
                             .Replace("111", "7");

                resultadototal = valorOctal + resultadototal;

                Console.WriteLine("Passo " + (contador + 1));
                Console.WriteLine(resultado);

                contador++;

                Console.WriteLine("--------------------------------------");

            }

            if (posicao < 0)
            {
                grupo = binario.Substring(0, posicao + 3);
                grupo = grupo.PadLeft(3, '0');
                resultado += grupo + " ";

                valorOctal = grupo.Replace("000", "0")
                             .Replace("001", "1")
                             .Replace("010", "2")
                             .Replace("011", "3")
                             .Replace("100", "4")
                             .Replace("101", "5")
                             .Replace("110", "6")
                             .Replace("111", "7");

                resultadototal = valorOctal + resultadototal;

                Console.WriteLine("Passo " + (contador + 1));
                Console.WriteLine(resultado);

                contador++;

                Console.WriteLine("--------------------------------------");

            }
            Console.WriteLine(" O número Octal equivalente é = " + resultadototal);

            Console.ReadKey();
        }

        static bool ValidaHexadecimal2(string hexadecimal)
        {
            int length = hexadecimal.Length;
            for (int i = 0; i < length; i++)
            {
                char c = hexadecimal[i];

                if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f')))


                    return false;
            }
            return true;

        }

        static string ConverterHexadecimalParaBinario2parte(string hexadecimal)
        {
            string binario = "";

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("--> PRIMEIRA PARTE <--");
            Console.WriteLine("Conversão de Hexadecimal para Binário:");
            Console.WriteLine("A conversão de números hexadecimais para binários é feita convertendo");
            Console.WriteLine("cada dígito hexadecimal em seu equivalente binário de 4 bits.");
            Console.WriteLine("Aqui está um passo a passo para converter um número hexadecimal em binário:");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");

            for (int i = 0; i < hexadecimal.Length; i++)
            {
                string digitoHexa = hexadecimal.Substring(i, 1);
                string binarioDigito = ConverterDigitoHexadecimalParaBinario2parte(digitoHexa);
                binario += binarioDigito;

                Console.WriteLine("Dígito Hexadecimal: " + digitoHexa);
                Console.WriteLine("Dígito Binário: " + binarioDigito);
                Console.WriteLine("Resultado Parcial: " + binario);
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------------");
            }

            return binario;
        }

        static string ConverterDigitoHexadecimalParaBinario2parte(string digitoHexa)
        {
            string binarioDigito = "";

            Console.WriteLine("Conversão do dígito Hexadecimal " + digitoHexa + " para Binário:");

            Console.WriteLine("---------------------------------------------------------");

            string binario = "";

            switch (digitoHexa.ToUpper())
            {
                case "0":
                    binario = "0000";
                    break;
                case "1":
                    binario = "0001";
                    break;
                case "2":
                    binario = "0010";
                    break;
                case "3":
                    binario = "0011";
                    break;
                case "4":
                    binario = "0100";
                    break;
                case "5":
                    binario = "0101";
                    break;
                case "6":
                    binario = "0110";
                    break;
                case "7":
                    binario = "0111";
                    break;
                case "8":
                    binario = "1000";
                    break;
                case "9":
                    binario = "1001";
                    break;
                case "A":
                    binario = "1010";
                    break;
                case "B":
                    binario = "1011";
                    break;
                case "C":
                    binario = "1100";
                    break;
                case "D":
                    binario = "1101";
                    break;
                case "E":
                    binario = "1110";
                    break;
                case "F":
                    binario = "1111";
                    break;
                default:
                    Console.WriteLine("Dígito Hexadecimal inválido!");
                    break;
            }

            binarioDigito = binario.PadLeft(4, '0');

            Console.WriteLine();
            Console.WriteLine("Dígito Binário resultante: " + binarioDigito);

            return binarioDigito;
        }

        static void conversao9()
        {
            Console.Write("Digite um número hexadecimal: ");
            string hexadecimalStr = Console.ReadLine();

            if (ValidarHexadecimal(hexadecimalStr))
            {
                int numeroDecimal = ConverterHexadecimalParaDecimal(hexadecimalStr);
                Console.WriteLine("O número decimal equivalente é: " + numeroDecimal);
            }
            else
            {
                Console.WriteLine("Valor hexadecimal inválido.");
            }

            Console.ReadKey();
        }

        static bool ValidarHexadecimal(string hexadecimal)
        {
            foreach (char c in hexadecimal) // tive que pesquisar esse metodo "foreach"
            {
                if (!ECaractereHexadecimal(c))
                    return false;
            }

            return true;
        }

        static bool ECaractereHexadecimal(char c)
        {
            return (c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f');
        }

        static int ConverterHexadecimalParaDecimal(string hexadecimal)
        {
            Console.WriteLine();
            Console.WriteLine("Conversão de Hexadecimal para Decimal:");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Hexadecimal: " + hexadecimal);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Passo a Passo:");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();

            int numeroDecimal = 0;
            int posicao = hexadecimal.Length - 1;

            foreach (char c in hexadecimal) // tive que pesquisar esse metodo "foreach"
            {
                int valorDigito = ObterValorDigitoHexadecimal(c);

                int potencia = (int)Math.Pow(16, posicao);
                int valorDecimal = valorDigito * potencia;

                Console.WriteLine("Dígito Hexadecimal: " + c);
                Console.WriteLine("Potência: 16^" + posicao);
                Console.WriteLine("Valor Digito * Potência: " + valorDigito + " * " + potencia + " = " + valorDecimal);
                Console.WriteLine("Resultado Parcial: " + numeroDecimal + " + " + valorDecimal + " = " + (numeroDecimal + valorDecimal));
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine();

                numeroDecimal += valorDecimal;
                posicao--;
            }

            Console.WriteLine("Conversão concluída.");
            Console.WriteLine();

            return numeroDecimal;
        }

        static int ObterValorDigitoHexadecimal(char digitoHexadecimal) // tive que pesquisar
        {
            if (digitoHexadecimal >= '0' && digitoHexadecimal <= '9')
                return (int)(digitoHexadecimal - '0');
            else if (digitoHexadecimal >= 'A' && digitoHexadecimal <= 'F')
                return (int)(digitoHexadecimal - 'A' + 10);
            else if (digitoHexadecimal >= 'a' && digitoHexadecimal <= 'f')
                return (int)(digitoHexadecimal - 'a' + 10);

            return 0;
        }

        static void Main(string[] args)
        {
            int opcaoConversao = 1;

            while (opcaoConversao != 0)
            {
                Console.Clear();

                opcaoConversao = menuConversao();

                executarConversao(opcaoConversao);
            }

            Console.ReadKey();
        }
    }
}
