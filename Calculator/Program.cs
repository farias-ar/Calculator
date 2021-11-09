using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Start();
        }

        public static void Menu()
        {
            Console.WriteLine("\t\t~Calculadora com histórico~\n");
            Console.WriteLine("-- Seja bem vindo, por favor escolha uma operação: --");
            Console.WriteLine("1)  Soma");
            Console.WriteLine("2)  Subtração");
            Console.WriteLine("3)  Multiplicação");
            Console.WriteLine("4)  Divisão");
            Console.WriteLine("5)  Potenciação");
            Console.WriteLine("6)  Raiz Quadrada"); 
            Console.WriteLine("7)  Raiz Cúbica");
            Console.WriteLine("8)  Cálculo de áreas");
            Console.WriteLine("9)  Conversão de unidade de pesos");
            Console.WriteLine("10) Conversão de unidade de medidas");
            Console.WriteLine("\r\n0) Para SAIR da calculadora. ");
        }

        public static void Start()
        {
            Record _record = new Record();
            ConsoleIO _consoleIO = new ConsoleIO();
            Arithmetic _arithmetic = new Arithmetic(_record, _consoleIO);
            AreaUnitConversion _areaUnit = new AreaUnitConversion(_record, _consoleIO);

            double key;
            do
            {
                key = UserInput();
                if (key == 0)
                {
                    _consoleIO.Clear();
                    _consoleIO.WriteLine("Fechando a aplicação!");
                    break;
                }
                if (key < 0 || key > 10)
                {
                    _consoleIO.WriteLine("Escolha uma opção válida.");
                }
                switch (key)
                {
                    case 1:
                        _consoleIO.Clear();
                        _arithmetic.Addition();
                        Menu();
                        break;
                    case 2:
                        _consoleIO.Clear();
                        _arithmetic.Subtraction();
                        Menu();
                        break;
                    case 3:
                        _consoleIO.Clear();
                        _arithmetic.Multiplication();
                        Menu();
                        break;
                    case 4:
                        _consoleIO.Clear();
                        _arithmetic.Division();
                        Menu();
                        break;
                    case 5:
                        _consoleIO.Clear();
                        _arithmetic.Exponentiation();
                        Menu();
                        break;
                    case 6:
                        _consoleIO.Clear();
                        _arithmetic.SquareRoot();
                        Menu();
                        break;
                    case 7:
                        _consoleIO.Clear();
                        _arithmetic.CubeRoot();
                        Menu();
                        break;
                    case 8:
                        _consoleIO.Clear();
                        _areaUnit.AreaSubMenu();
                        Menu();
                        break;
                    case 9:
                        _consoleIO.Clear();
                        _areaUnit.LengthConverterSubMenu();
                        Menu();
                        break;
                    case 10:
                        _consoleIO.Clear();
                        _areaUnit.VolumeConverterSubMenu();
                        Menu();
                        break;
                    default:
                        break;
                }
            } while (key >= 0 || key <= 10);
        }

        private static double UserInput()
        {
            double userKey;

            while (!double.TryParse(Console.ReadLine(), out userKey))
            {
                Console.WriteLine("Valor inválido, Digite um número.");
            }
            return userKey;
        }

    }
}
