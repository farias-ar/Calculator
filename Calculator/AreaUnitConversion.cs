using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class AreaUnitConversion
    {
        private IRecord _record;
        private readonly IConsoleIO _consoleIO;
        private const double PI = 3.14159265358979;

        public AreaUnitConversion(IRecord record, IConsoleIO consoleIO)
        {
            _consoleIO = consoleIO;
            _record = record;
        }

        #region Area

        public double TriangleArea()
        {
            double parameterA, parameterB, outcome;

            _consoleIO.WriteLine("Digite primeiro a base do triângulo: ");
            parameterA = UserInput();
            _consoleIO.WriteLine("Digite agora a altura do triângulo: ");
            parameterB = UserInput();

            outcome = (parameterA + parameterB) / 2;
            _consoleIO.WriteLine($"O resultado da área do triâgulo é {outcome}\n\n");
            _record.RecordOperations("triangle", parameterA, parameterB, outcome);
            return outcome;
        }

        public double SquareArea()
        {
            double parameterA, outcome;

            _consoleIO.WriteLine("Digite o lado do quadrado: ");
            parameterA = UserInput();

            outcome = parameterA * parameterA;
            _consoleIO.WriteLine($"O resultado da área do quadrado é {outcome}\n\n");
            _record.RecordOperations("square", parameterA, outcome);
            return outcome;
        }

        public double CircleArea()
        {
            double parameterA, outcome;

            _consoleIO.WriteLine("Digite o o ráio do círculo: ");
            parameterA = UserInput();

            outcome = PI * (parameterA * parameterA);
            _consoleIO.WriteLine($"O resultado da área do círculo é {outcome}\n\n");
            _record.RecordOperations("circle", parameterA, outcome);
            return outcome;
        }

        #endregion

        #region Units

        public double FromMillimetre()
        {
            double parameterA, outcome, userKey;

            do
            {
                _consoleIO.WriteLine("Digite para qual medida você gostaria de converter?");
                _consoleIO.WriteLine("1) Para centímetro?");
                _consoleIO.WriteLine("2) Para metro?");
                _consoleIO.WriteLine("3) Para kilómetro?");
                userKey = UserInput();
            } while (userKey < 0 || userKey > 3);
            

            _consoleIO.WriteLine("Digite o valor em milímetros a ser convertido: ");
            parameterA = UserInput();

            switch (userKey)
            {
                case 1:
                    outcome = parameterA / 10;
                    _consoleIO.WriteLine($"A conversão de {parameterA}mm é {outcome}cm\n\n");
                    _record.RecordOperations("mmTocm", parameterA, outcome);
                    return outcome;
                case 2:
                    outcome = parameterA / 1000;
                    _consoleIO.WriteLine($"A conversão de {parameterA}mm é {outcome}m\n\n");
                    _record.RecordOperations("mmTom", parameterA, outcome);
                    return outcome;
                case 3:
                    outcome = parameterA / 1e+6;
                    _consoleIO.WriteLine($"A conversão de {parameterA}mm é {outcome}km\n\n");
                    _record.RecordOperations("mmTokm", parameterA, outcome);
                    return outcome;
                case 0:
                    return 0;
                default:
                    _consoleIO.WriteLine("Valor inválido");
                    return 0;
            }
        }

        public double FromCentimeter()
        {
            double parameterA, outcome, userKey;

            do
            {
                _consoleIO.WriteLine("Digite para qual medida você gostaria de converter?");
                _consoleIO.WriteLine("1) Para milímetro?");
                _consoleIO.WriteLine("2) Para metro?");
                _consoleIO.WriteLine("3) Para kilómetro?");
                userKey = UserInput();
            } while (userKey < 0 || userKey > 3);
            

            _consoleIO.WriteLine("Digite o valor em milímetros a ser convertido: ");
            parameterA = UserInput();

            switch (userKey)
            {
                case 1:
                    outcome = parameterA * 10;
                    _consoleIO.WriteLine($"A conversão de {parameterA}cm é {outcome}mm\n\n");
                    _record.RecordOperations("cmTomm", parameterA, outcome);
                    return outcome;
                case 2:
                    outcome = parameterA / 100;
                    _consoleIO.WriteLine($"A conversão de {parameterA}cm é {outcome}m\n\n");
                    _record.RecordOperations("cmTom", parameterA, outcome);
                    return outcome;
                case 3:
                    outcome = parameterA / 100000;
                    _consoleIO.WriteLine($"A conversão de {parameterA}cm é {outcome}km\n\n");
                    _record.RecordOperations("cmTokm", parameterA, outcome);
                    return outcome;
                default:
                    _consoleIO.WriteLine("Valor inválido");
                    return 0;
            }
        }

        public double FromMeter()
        {
            double parameterA, outcome, userKey;
            do 
            { 
                _consoleIO.WriteLine("Digite para qual medida você gostaria de converter?");
                _consoleIO.WriteLine("1) Para milímetro?");
                _consoleIO.WriteLine("2) Para centímetro?");
                _consoleIO.WriteLine("3) Para kilómetro?");
                userKey = UserInput();
            } while (userKey< 0 || userKey> 3);

            _consoleIO.WriteLine("Digite o valor em milímetros a ser convertido: ");
            parameterA = UserInput();

            switch (userKey)
            {
                case 1:
                    outcome = parameterA * 1000;
                    _consoleIO.WriteLine($"A conversão de {parameterA}m é {outcome}mm\n\n");
                    _record.RecordOperations("mTomm", parameterA, outcome);
                    return outcome;
                case 2:
                    outcome = parameterA * 100;
                    _consoleIO.WriteLine($"A conversão de {parameterA}m é {outcome}cm\n\n");
                    _record.RecordOperations("mTocm", parameterA, outcome);
                    return outcome;
                case 3:
                    outcome = parameterA / 1000;
                    _consoleIO.WriteLine($"A conversão de {parameterA}m é {outcome}km\n\n");
                    _record.RecordOperations("mTokm", parameterA, outcome);
                    return outcome;
                default:
                    _consoleIO.WriteLine("Valor inválido");
                    return 0;
            }
        }

        public double FromKilometer()
        {
            double parameterA, outcome, userKey;

            do
            {
                _consoleIO.WriteLine("Digite para qual medida você gostaria de converter?");
                _consoleIO.WriteLine("1) Para milímetro?");
                _consoleIO.WriteLine("2) Para centímetro?");
                _consoleIO.WriteLine("3) Para metro?");
                userKey = UserInput();
            } while (userKey < 0 || userKey > 3);
            

            _consoleIO.WriteLine("Digite o valor em milímetros a ser convertido: ");
            parameterA = UserInput();

            switch (userKey)
            {
                case 1:
                    outcome = parameterA * 1e+6;
                    _consoleIO.WriteLine($"A conversão de {parameterA}km é {outcome}mm\n\n");
                    _record.RecordOperations("kmTomm", parameterA, outcome);
                    return outcome;
                case 2:
                    outcome = parameterA * 100000;
                    _consoleIO.WriteLine($"A conversão de {parameterA}km é {outcome}cm\n\n");
                    _record.RecordOperations("kmTocm", parameterA, outcome);
                    return outcome;
                case 3:
                    outcome = parameterA * 1000;
                    _consoleIO.WriteLine($"A conversão de {parameterA}km é {outcome}m\n\n");
                    _record.RecordOperations("kmTom", parameterA, outcome);
                    return outcome;
                default:
                    _consoleIO.WriteLine("Valor inválido");
                    return 0;
            }
        }

        public double FromGram()
        {
            double parameterA, outcome, userKey;

            do
            {
                _consoleIO.WriteLine("Digite para qual medida você gostaria de converter?");
                _consoleIO.WriteLine("1) Para quilogramas?");
                _consoleIO.WriteLine("2) Para toneladas?");
                userKey = UserInput();
            } while (userKey < 0 || userKey > 2);
            

            _consoleIO.WriteLine("Digite o valor em gramas a ser convertido: ");
            parameterA = UserInput();

            switch (userKey)
            {
                case 1:
                    outcome = parameterA / 1000;
                    _consoleIO.WriteLine($"A conversão de {parameterA}g é {outcome}kg\n\n");
                    _record.RecordOperations("gTokg", parameterA, outcome);
                    return outcome;
                case 2:
                    outcome = parameterA / 1e+6;
                    _consoleIO.WriteLine($"A conversão de {parameterA}g é {outcome}t\n\n");
                    _record.RecordOperations("gTot", parameterA, outcome);
                    return outcome;
                default:
                    _consoleIO.WriteLine("Valor inválido");
                    return 0;
            }
        }

        public double FromKilogram()
        {
            double parameterA, outcome, userKey;

            do
            {
                _consoleIO.WriteLine("Digite para qual medida você gostaria de converter?");
                _consoleIO.WriteLine("1) Para grama?");
                _consoleIO.WriteLine("2) Para toneladas?");
                userKey = UserInput();
            } while (userKey < 0 || userKey > 2);
            

            _consoleIO.WriteLine("Digite o valor em kilogramas a ser convertido: ");
            parameterA = UserInput();

            switch (userKey)
            {
                case 1:
                    outcome = parameterA * 1000;
                    _consoleIO.WriteLine($"A conversão de {parameterA}kg é {outcome}g\n\n");
                    _record.RecordOperations("kgTog", parameterA, outcome);
                    return outcome;
                case 2:
                    outcome = parameterA / 1000;
                    _consoleIO.WriteLine($"A conversão de {parameterA}kg é {outcome}t\n\n");
                    _record.RecordOperations("kgTot", parameterA, outcome);
                    return outcome;
                default:
                    _consoleIO.WriteLine("Valor inválido");
                    return 0;
            }
        }

        public double FromTonne()
        {
            double parameterA, outcome, userKey;

            do
            {
                _consoleIO.WriteLine("Digite para qual medida você gostaria de converter?");
                _consoleIO.WriteLine("1) Para grama?");
                _consoleIO.WriteLine("2) Para kilograma?");
                userKey = UserInput();
            } while (userKey < 0 || userKey > 2);
            
            _consoleIO.WriteLine("Digite o valor em tonelada a ser convertido: ");
            parameterA = UserInput();

            switch (userKey)
            {
                case 1:
                    outcome = parameterA * 1e+6;
                    _consoleIO.WriteLine($"A conversão de {parameterA}t é {outcome}g\n\n");
                    _record.RecordOperations("tTog", parameterA, outcome);
                    return outcome;
                case 2:
                    outcome = parameterA * 1000;
                    _consoleIO.WriteLine($"A conversão de {parameterA}t é {outcome}kg\n\n");
                    _record.RecordOperations("tTokg", parameterA, outcome);
                    return outcome;
                default:
                    _consoleIO.WriteLine("Valor inválido");
                    return 0;
            }
        }

        public double FromMilliliters()
        {
            double parameterA, outcome, userKey;

            do
            {
                _consoleIO.WriteLine("Digite para qual medida você gostaria de converter?");
                _consoleIO.WriteLine("1) Para litro?");
                userKey = UserInput();
            } while (userKey != 1);
            

            _consoleIO.WriteLine("Digite o valor em mililitros a ser convertido: ");
            parameterA = UserInput();

            switch (userKey)
            {
                case 1:
                    outcome = parameterA / 1000;
                    _consoleIO.WriteLine($"A conversão de {parameterA}mL é {outcome}L\n\n");
                    _record.RecordOperations("mlTol", parameterA, outcome);
                    return outcome;
                default:
                    return 0;
            }
        }

        public double FromLiter()
        {
            double parameterA, outcome, userKey;

            do
            {
                _consoleIO.WriteLine("Digite para qual medida você gostaria de converter?");
                _consoleIO.WriteLine("1) Para litro?");
                userKey = UserInput();
            } while (userKey != 1);
            

            _consoleIO.WriteLine("Digite o valor em litros a ser convertido: ");
            parameterA = UserInput();

            switch (userKey)
            {
                case 1:
                    outcome = parameterA * 1000;
                    _consoleIO.WriteLine($"A conversão de {parameterA}L é {outcome}mL\n\n");
                    _record.RecordOperations("lToml", parameterA, outcome);
                    return outcome;
                default:
                    return 0;
            }
        }

        #endregion

        #region SubMenu
        public void AreaSubMenu()
        {
            double userKey;

            _consoleIO.WriteLine("Escolha qual figura deseja descobrir a área: ");
            _consoleIO.WriteLine("1) Triângulo");
            _consoleIO.WriteLine("2) Quadrado");
            _consoleIO.WriteLine("3) Círculo");
            _consoleIO.WriteLine("0) Para voltar ao menu principal");

            userKey = UserInput();

            switch (userKey)
            {
                case 1:
                    _consoleIO.Clear();
                    TriangleArea();
                    AreaSubMenu();
                    break;
                case 2:
                    _consoleIO.Clear();
                    SquareArea();
                    AreaSubMenu();
                    break;
                case 3:
                    _consoleIO.Clear();
                    CircleArea();
                    AreaSubMenu();
                    break;
                case 0:
                    _consoleIO.Clear();
                    return;
                default:
                    _consoleIO.WriteLine("Valor inválido!");
                    AreaSubMenu();
                    break;
            }

        }

        public void LengthConverterSubMenu()
        {
            double userKey;

            _consoleIO.WriteLine("Escolha qual unidade de conversão deseja: ");
            _consoleIO.WriteLine("1) Milímetro");
            _consoleIO.WriteLine("2) Centímetro");
            _consoleIO.WriteLine("3) Metro");
            _consoleIO.WriteLine("4) Kilómetro");
            _consoleIO.WriteLine("0) Para voltar ao menu principal");

            userKey = UserInput();

            switch (userKey)
            {
                case 1:
                    _consoleIO.Clear();
                    FromMillimetre();
                    LengthConverterSubMenu();
                    break;
                case 2:
                    _consoleIO.Clear();
                    FromCentimeter();
                    LengthConverterSubMenu();
                    break;
                case 3:
                    _consoleIO.Clear();
                    FromMeter();
                    LengthConverterSubMenu();
                    break;
                case 4:
                    _consoleIO.Clear();
                    FromKilometer();
                    LengthConverterSubMenu();
                    break;
                case 0:
                    _consoleIO.Clear();
                    return;
                default:
                    _consoleIO.WriteLine("Valor inválido!");
                    LengthConverterSubMenu();
                    break;
            }

        }

        public void VolumeConverterSubMenu()
        {
            double userKey;

            _consoleIO.WriteLine("Escolha qual unidade de conversão deseja: ");
            _consoleIO.WriteLine("1) Mililitros");
            _consoleIO.WriteLine("2) Lítros");
            _consoleIO.WriteLine("0) Para voltar ao menu principal");

            userKey = UserInput();

            switch (userKey)
            {
                case 1:
                    _consoleIO.Clear();
                    FromMilliliters();
                    VolumeConverterSubMenu();
                    break;
                case 2:
                    _consoleIO.Clear();
                    FromLiter();
                    VolumeConverterSubMenu();
                    break;
                case 0:
                    _consoleIO.Clear();
                    return;
                default:
                    _consoleIO.WriteLine("Valor inválido!");
                    VolumeConverterSubMenu();
                    break;
            }

        }

        #endregion

        private double UserInput()
        {
            double userKey;

            while (!double.TryParse(_consoleIO.ReadLine(), out userKey))
            {
                _consoleIO.WriteLine("Valor inválido, Digite um número.");
            }
            return userKey;
        }
    }
}