using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Programacao
{
    internal class Program
    {
        static int exibirMenu()
        {
            int opcao = 0;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("--------------MENU---------------");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Escolha uma das questões abaixo: ");
            Console.WriteLine("---------------------------------");

            for (int i = 0; i <= 25; i++)
            {
                Console.WriteLine("----- Questão: " + i + "-----");
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("--- Se desejar sair digite 0 ----");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(" Digite uma opção ");
            opcao = int.Parse(Console.ReadLine());

            return opcao;
        }

        static void nomeMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    Console.WriteLine("janeiro");
                    break;

                case 2:
                    Console.WriteLine("fevereiro");
                    break;

                case 3:
                    Console.WriteLine("março");
                    break;
                case 4:
                    Console.WriteLine("abril");
                    break;

                case 5:
                    Console.WriteLine("maio");
                    break;

                case 6:
                    Console.WriteLine("junho");
                    break;
                case 7:
                    Console.WriteLine("julho");
                    break;

                case 8:
                    Console.WriteLine("agosto");
                    break;

                case 9:
                    Console.WriteLine("setembro");
                    break;
                case 10:
                    Console.WriteLine("outubro");
                    break;

                case 11:
                    Console.WriteLine("novembro");
                    break;

                case 12:
                    Console.WriteLine("dezembro");
                    break;

                default:
                    Console.WriteLine("Valor invalido");
                    break;
            }
        }

        static void menuMes(string referenteMes)
        {
            Console.WriteLine("==================================MENU=========================================");
            Console.WriteLine("==== 1 - Janeiro, 2 - Fevereiro, 3 - Março, 4 - Abril, 5 - Maio, 6 - Junho ====");
            Console.WriteLine("7 - Julho, 8 - Agosto, 9 - Setembro, 10 - Outubro, 11 - Novembro, 12 - Dezembro");
            Console.WriteLine("===============================================================================");
            Console.WriteLine(referenteMes);

        }

        static void cabecalho(string nomeFulano)
        {
            Console.WriteLine("===================================================");
            Console.WriteLine("=== UFMG – Universidade Federal de Minas Gerais ===");
            Console.WriteLine("=== ICEx – Instituto de Ciências Exatas ===========");
            Console.WriteLine("=== Disciplina de Programação de Computadores =====");
            Console.WriteLine("=== Nome: " + nomeFulano);
            Console.WriteLine("===================================================");
        }

        public static int verificadorAlfabeto(int caractereAlfabeto)
        {
            if ((caractereAlfabeto >= 65 && caractereAlfabeto <= 90) || (caractereAlfabeto >= 97 && caractereAlfabeto <= 122))
            {
                Console.WriteLine(" -> 1 <- ");
                Console.WriteLine("O caractere digitado é uma letra do Alfabeto");
                Console.WriteLine("O carectere digitado corresponde a posição " + caractereAlfabeto);
            }
            else
            {
                Console.WriteLine("0");
                Console.WriteLine("O caractere digitado NÃO é uma letra do Alfabeto");
            }

            return caractereAlfabeto;
        }

        public static int valorMenor(int valor1, int valor2)
        {
            int valor;


            if (valor1 > valor2)
            {
                valor = valor2;
                Console.WriteLine(valor + " é o menor entre os dois numeros");
            }
            else if (valor2 > valor1)
            {
                valor = valor1;
                Console.WriteLine(valor + " é o menor entre os dois numeros");
            }
            else
            {
                valor = valor1;
                Console.WriteLine(valor + " é igual a " + valor);
            }
            return valor;
        }

        static void executarQuestao(int opcaoQuestao) //opcaoQuestao é um parametro
        {
            switch (opcaoQuestao)
            {
                case 0:
                    Console.WriteLine("Finalizando programa ... ");
                    break;

                case 1:
                    questao1();
                    break;

                case 2:
                    questao2();
                    break;

                case 3:
                    questao3();
                    break;

                case 4:
                    questao4();
                    break;

                case 5:
                    questao5();
                    break;

                case 6:
                    questao6();
                    break;

                case 7:
                    questao7();
                    break;

                case 8:
                    questao8();
                    break;

                case 9:
                    questao9();
                    break;

                case 10:
                    questao10();
                    break;

                case 11:
                    questao11();
                    break;

                case 12:
                    questao12();
                    break;

                case 13:
                    questao13();
                    break;

                case 14:
                    questao14();
                    break;

                case 15:
                    questao15();
                    break;

                case 16:
                    questao16();
                    break;

                case 17:
                    questao17();
                    break;

                case 18:
                    questao18();
                    break;

                case 19:
                    questao19();
                    break;

                case 20:
                    questao20();
                    break;

                case 21:
                    questao21();
                    break;

                case 22:
                    questao22();
                    break;

                case 23:
                    questao23();
                    break;

                case 24:
                    questao24();
                    break;

                case 25:
                    questao25();
                    break;

                default:
                    Console.WriteLine("Numeros validos entre 0 a 25.");
                    Console.WriteLine("Digite qualquer tecla para continuar");
                    Console.ReadKey();
                    break;

            }
        }

        static void questao1()
        {
            Console.WriteLine("Digite um numero para saber seu sucessor e seu antecessor");
            int numero = int.Parse(Console.ReadLine());

            int sucessor = (numero + 1);
            int antecessor = (numero - 1);

            Console.WriteLine($"O antecessor de {numero} é {antecessor}, e o sucessor de {numero} é {sucessor}");

            //Console.ReadKey();

        }

        static void questao2()
        {
            float mediaAritimetica = 0;

            Console.WriteLine("Este programa faz a media aritmética de 3 numeros");

            Console.WriteLine("Digite o 1° numero: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2° numero: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite p 3° numero: ");
            float num3 = float.Parse(Console.ReadLine());

            mediaAritimetica = ((num1 + num2 + num3) / 3);

            Console.WriteLine($"Media aritmética dos 3 numeros digitados: {mediaAritimetica}");

        }

        static void questao3()
        {
            double tempFahrenheit = 0;
            double tempCelsius = 0;
            string conversao = "";
            string conversaoUpper = "";
            string continuar = "";
            string continuarUpper = "";

            do
            {
                Console.WriteLine("Este programa faz a conversão de temperaturas Celsius - °C e Fahrenheit - °F.");

                Console.WriteLine("Digite (F) se deseja converter Celsius para Fahrenheit ou digite (C) se deseja converter para Celsius.");
                conversao = Console.ReadLine();
                conversaoUpper = conversao.ToUpper();

                Console.WriteLine("Digite o valor da temperatura que deseja converter: ");
                double valorTemperatura = double.Parse(Console.ReadLine());

                if (conversaoUpper == "F")
                {
                    tempFahrenheit = ((valorTemperatura * 1.8) + 32.0);
                    Console.WriteLine($"A temperatura em Fahrenheit é : {tempFahrenheit} °F");
                }
                else if (conversaoUpper == "C")
                {
                    tempCelsius = ((valorTemperatura - 32.0) / 1.8);
                    Console.WriteLine($"A temperatura em Celsius é : {tempCelsius} °C");
                }
                else
                {
                    Console.WriteLine("Codigo digitado invalido");
                }

                Console.WriteLine("Digite (C) para coninuar e (S) para sair");
                continuar = Console.ReadLine();
                continuarUpper = continuar.ToUpper();

            }
            while (continuarUpper == "C");

            Console.WriteLine("Programa Encerrado");

        }

        static void questao4()
        {
            double valorTotal = 0;
            double parcela30 = 0;
            double parcela38 = 0;
            double parcela32 = 0;
            double prova = 0;

            Console.WriteLine("Este programa ler um valor total, em dólares, e calcule a parcela destinada a 3 pessoa.");

            Console.WriteLine("Digite o valor total em dolar $ : ");
            valorTotal = Convert.ToDouble(Console.ReadLine());

            parcela30 = (valorTotal * 0.3);

            parcela38 = (valorTotal * 0.38);

            parcela32 = (valorTotal * 0.32);

            prova = (parcela30 + parcela38 + parcela32);


            Console.WriteLine($"Valor referente a 30%, 38% e 32% : ${parcela30}, ${parcela38}, ${parcela32} ");

            Console.WriteLine(prova);

        }

        static void questao5()
        {
            double totalLatao = 0;
            double cobre = 0;
            double zinco = 0;

            Console.WriteLine("Este programa solicita quantos quilos de latão quer produzir e depois informa ao usuário as quantidades de cobre e zinco necessárias.");

            Console.WriteLine("Digite a quantidade de latão deseja produzir (kg): ");
            totalLatao = double.Parse(Console.ReadLine());

            zinco = (totalLatao * 0.3);
            cobre = (totalLatao * 0.7);

            Console.WriteLine($"Para produzir {totalLatao}kg de latão, você precisa de {cobre}kg de cobre e {zinco}kg de zinco, na proporção de 7 partes de cobre para 3 partes de zinco.");
        }

        static void questao6()
        {
            int numero = 0;

            Console.WriteLine("Este programa imprime uma mensagem textual somente se o numero digitado for maior que 20.");

            Console.WriteLine("Digite um numero");
            numero = int.Parse(Console.ReadLine());

            if (numero > 20)
            {
                Console.WriteLine("numero maior que 20");
            }

        }

        static void questao7()
        {
            int numero1;
            int numero2;
            int somaNumero;

            Console.WriteLine("Este programa ler dois números inteiros e calcula a soma desses dois números.");

            Console.WriteLine("Digite o 1° numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2° numero: ");
            numero2 = int.Parse(Console.ReadLine());

            somaNumero = (numero1 + numero2);

            if (somaNumero > 10)
            {
                Console.WriteLine($"A soma entre os dois numeros é {somaNumero}");
            }
            else
            {
                Console.WriteLine("A soma entre os dois numeros é menor ou igual a 10");
            }

        }

        static void questao8()
        {
            int numero;

            Console.WriteLine("Este programa determina se o número é par ou impar.");

            Console.WriteLine("Digite um numero para saber se é PAR ou IMPAR");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O numero digita é PAR");
            }
            else
            {
                Console.WriteLine("O numero digita é IMPAR");
            }
        }

        static void questao9()
        {
            int numero;

            Console.WriteLine("Este programa exibi uma mensagem de texto identificando se o número é “POSITIVO”,“NEGATIVO” ou “NULO”.");

            Console.WriteLine("Digite um numero; ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("Numero POSITIVO");
            }
            else if (numero < 0)
            {
                Console.WriteLine("Numero NEGATIVO");
            }
            else
            {
                Console.WriteLine("Numero NULO");
            }
        }

        static void questao10()
        {
            int numero;
            double raiz;
            double potencia;


            Console.WriteLine("Este programa exibe se o número é positivo, ou nulo (0), se 'sim' o programa calcula a raiz quadrada do número. se 'não' o programa calcula o quadrado desse número.\n");

            Console.WriteLine("Digite um numero");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                raiz = Math.Sqrt(numero);
                Console.WriteLine($"A Raiz quadrada de {numero} é {raiz}");
            }
            else
            {
                potencia = Math.Pow(numero, 2);
                Console.WriteLine($"A potencia de {numero}² é {potencia}");
            }

        }

        static void questao11()
        {
            //USAR FATORIAL - n! = n x (n-1) x (n-2) x (n-3)...
            //3! = 3 x 2 x 1 = 6

            int numero1;
            int numero2;
            int numero3;
            string loop = "s";

            while (loop == "s")
            {

                Console.WriteLine("Este programa solicita 3 valores e imprimi os valores em ordem crescente.");

                Console.WriteLine("Digite o 1° numero");
                numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o 2° numero");
                numero2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o 3° numero");
                numero3 = int.Parse(Console.ReadLine());

                if ((numero1 <= numero2) && (numero2 <= numero3) && (numero1 <= numero3))
                {
                    Console.WriteLine($" {numero1}, {numero2}, {numero3}");
                }
                else if ((numero2 <= numero1) && (numero2 <= numero3) && (numero1 <= numero3))
                {
                    Console.WriteLine($" {numero2}, {numero1}, {numero3}");
                }
                else if ((numero3 <= numero2) && (numero3 <= numero1) && (numero2 <= numero1))
                {
                    Console.WriteLine($" {numero3}, {numero2}, {numero1}");
                }
                else if ((numero3 <= numero1) && (numero3 <= numero2) && (numero1 <= numero2))
                {
                    Console.WriteLine($" {numero3}, {numero1}, {numero2}");
                }
                else if ((numero1 <= numero2) && (numero3 <= numero2) && (numero1 <= numero3))
                {
                    Console.WriteLine($" {numero1}, {numero3}, {numero2}");
                }
                else if ((numero2 <= numero1) && (numero2 <= numero3) && (numero3 <= numero1))
                {
                    Console.WriteLine($" {numero2}, {numero3}, {numero1}");
                }

                Console.WriteLine("Deseja continuar? 's' para sim e 'n' para não");
                loop = Console.ReadLine();

            }
            Console.WriteLine("FINALIZANDO PROGRAMA...");

        }

        static void questao12()
        {
            //TROQUEI APENAS AS SAIDAS

            int numero1;
            int numero2;
            int numero3;

            Console.WriteLine("Este programa solicita 3 valores e imprimi os valores em ordem decrescente.");

            Console.WriteLine("Digite o 1° numero");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2° numero");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 3° numero");
            numero3 = int.Parse(Console.ReadLine());

            if ((numero1 <= numero2) && (numero2 <= numero3) && (numero1 <= numero3))
            {
                Console.WriteLine($" {numero3}, {numero2}, {numero1}");
            }
            else if ((numero2 <= numero1) && (numero2 <= numero3) && (numero1 <= numero3))
            {
                Console.WriteLine($" {numero3}, {numero1}, {numero2}");
            }
            else if ((numero3 <= numero2) && (numero3 <= numero1) && (numero2 <= numero1))
            {
                Console.WriteLine($" {numero1}, {numero2}, {numero3}");
            }
            else if ((numero3 <= numero1) && (numero3 <= numero2) && (numero1 <= numero2))
            {
                Console.WriteLine($" {numero2}, {numero1}, {numero3}");
            }
            else if ((numero1 <= numero2) && (numero3 <= numero2) && (numero1 <= numero3))
            {
                Console.WriteLine($" {numero2}, {numero3}, {numero1}");
            }
            else if ((numero2 <= numero1) && (numero2 <= numero3) && (numero3 <= numero1))
            {
                Console.WriteLine($" {numero1}, {numero3}, {numero2}");
            }

        }

        static void questao13()
        {
            //Codifique um programa que leia um número inteiro qualquer e determine se esse número é igual a 5, ou se é igual a 200, ou se é igual a 400, 
            //ou se está no intervalo aberto entre 500 e 1000 (aberto nos dois extremos).O programa também verifica se o número não atende a nenhum
            //dos critérios anteriores.

            int numero;

            Console.WriteLine("Digite um numero");
            numero = int.Parse(Console.ReadLine());

            if ((numero == 5) || (numero == 200) || (numero == 400))
            {
                Console.WriteLine("O numero digitado obedece os requisios");
                Console.WriteLine("Requesitos: se o número é igual a 5, ou se é igual a 200, ou se é igual a 400");
                Console.WriteLine("O numero digitado é: " + numero);
            }
            else if ((numero > 500) && (numero < 1000))
            {
                Console.WriteLine("O numero digitado está no intervalo aberto entre 500 e 1000");
                Console.WriteLine("O numero digitado é: " + numero);
            }
            else
            {
                Console.WriteLine("O numero digitado NÃO obedece os requisios");
            }

        }

        static void questao14()
        {
            //Codifique um programa que faça a leitura de dois números reais pelo teclado, (X)e(Y),
            //respectivamente.O programa imprime o quadrado do menor número, e a raiz quadrada do maior número, quando for possível.

            double numero1;
            double numero2;
            double raizDoMaiorNumero;
            double potenciaDoMenorNumero;

            Console.WriteLine("Digite o 1° numero: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2° numero: ");
            numero2 = double.Parse(Console.ReadLine());

            if (numero1 < numero2)
            {
                potenciaDoMenorNumero = Math.Pow(numero1, 2);
                raizDoMaiorNumero = Math.Sqrt(numero2);
                raizDoMaiorNumero = Math.Round(raizDoMaiorNumero, 2);
                Console.WriteLine($"O quadrado do < numero é {potenciaDoMenorNumero} e a raiz quadrada do > numero é {raizDoMaiorNumero}");
            }
            else if (numero2 < numero1)
            {
                potenciaDoMenorNumero = Math.Pow(numero2, 2);
                raizDoMaiorNumero = Math.Sqrt(numero1);
                raizDoMaiorNumero = Math.Round(raizDoMaiorNumero, 2);
                Console.WriteLine($"O quadrado do < numero é {potenciaDoMenorNumero} e a raiz quadrada do > numero é {raizDoMaiorNumero}");
            }

        }

        static void questao15()
        {
            //Escreva um programa que imprima todos os números inteiros de 0 a 50.

            int numero = -1;

            //com FOR

            for (int contador = 0; contador <= 50; contador++)
            {
                Console.Write(" " + contador);
            }

            /*com WHILE
            while (numero < 50)
            {
                numero++;
                Console.Write(" " + numero);
            }*/
        }

        static void questao16()
        {
            //Escreva um programa que imprima todos os números inteiros de 100 a 200.

            int numero = 99;

            while (numero < 200)
            {
                numero++;
                Console.Write(" " + numero);
            }
        }

        static void questao17()
        {
            //Escreva um programa que receba dez números do usuário e imprima o quadrado de cada número.

            int numero;
            int contador = 0;
            double quadradoNumero;

            while (contador < 10)
            {
                Console.WriteLine("Digite o numero");
                numero = int.Parse(Console.ReadLine());

                contador++;
                Console.WriteLine("Ordem de Numeros digitados " + contador);
                quadradoNumero = Math.Pow(numero, 2);

                Console.WriteLine($"O quadrado do {numero}² é {quadradoNumero}");
            }
        }

        static void questao18()
        {
            //Criar um programa que imprima todos os números de 1 até 100, inclusive, e a soma de todos eles.

            int somaGauss = 0;
            int contador = 0;

            for (contador = 1; contador <= 100; contador++)
            {
                Console.Write(" " + contador);
                somaGauss = somaGauss + contador;
            }

            Console.Write("\nA soma de todos eles é " + somaGauss);

            //somaGauss = ((100 * (1 + 100)) / 2); // SOMA DE GAUSS

        }

        static void questao19()
        {
            //Criar um programa que imprima todos os números de 1 até 100, inclusive, e a soma do quadrados de todos eles.

            int somaGauss = 0;
            int contador = 0;

            for (contador = 1; contador <= 100; contador++)
            {
                Console.Write(" " + (contador * contador));
                somaGauss = somaGauss + (contador * contador);
            }

            Console.Write("\nA soma de todos eles é " + somaGauss);

        }

        static void questao20()
        {
            //Seja a seguinte série:1, 4, 9, 16, 25, 36...
            //Escreva um programa que gere esta série até o N-ésimo termo. Este N-ésimo termo é digitado pelo usuário.

            int numero = 0;
            int contador = 0;

            Console.WriteLine("Este programa gera uma série (1, 4, 9, 16, 25, 36,...) até o N-ésimo termo");
            Console.WriteLine("Digite o N-ésimo termo");
            numero = int.Parse(Console.ReadLine());

            while (contador < numero)
            {
                contador++;
                Console.Write(" " + (contador * contador));
            }

        }

        static void questao21()
        {
            //Seja a seguinte série: 1, 4, 4, 2, 5, 5, 3, 6, 6, 4, 7, 7, ...
            //Escreva um programa que seja capaz de gerar os N termos dessa série.Esse número N deve ser lido do teclado.

            int numero = 0;
            int contador = 0;

            Console.WriteLine("Digite o N-ésimo termo");
            numero = int.Parse(Console.ReadLine());

            while (contador < numero)
            {
                contador++;
                Console.Write(" " + (contador) + " " + (contador + 3) + " " + (contador + 3) + " ");
            }

        }

        static void questao22() 
        {
            int numeroMes = 0;
            string referenteMes = "";

            menuMes(referenteMes);

            Console.WriteLine("Digite um o valor entre 1 a 12 referente ao meses do ano: ");
            numeroMes = int.Parse(Console.ReadLine());

            Console.Write("O numero digitado corresponde ao mês: ");
            nomeMes(numeroMes);

        }

        static void questao23()
        {
            Console.WriteLine("Digite o nome para preenchimento do cabeçalho: ");
            string nomeFulano = Console.ReadLine();

            Console.Clear();

            cabecalho(nomeFulano);

        }

        static void questao24()
        {
            Console.WriteLine("Digite um caractere para verificar se é (ou não) uma letra do alfabeto");
            int caractereAlfabeto = char.Parse(Console.ReadLine());

            verificadorAlfabeto(caractereAlfabeto);

        }

        static void questao25()
        {
            Console.WriteLine("Este programa verifica dois valores e me informar qual é o menor");

            Console.WriteLine("Digite o segundo valor ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor ");
            int valor2 = int.Parse(Console.ReadLine());

            valorMenor(valor1, valor2);

        }


        static void Main(string[] args)
        {
            int opcaoEscolhida = 1;

            while (opcaoEscolhida != 0 )
            {

                opcaoEscolhida = exibirMenu();

                executarQuestao(opcaoEscolhida);
                Console.WriteLine("Digite qualquer tecla para continuar ");
                Console.ReadKey();
            }

            Console.ReadKey();

        }
    }
}
