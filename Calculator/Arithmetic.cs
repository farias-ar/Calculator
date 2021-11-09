using System;

namespace Calculator
{
    public class Arithmetic
    {
        private IRecord _record;
        private readonly IConsoleIO _consoleIO;

        public Arithmetic(IRecord record, IConsoleIO consoleIO)
        {
            _consoleIO = consoleIO;
            _record = record;
        }

        public double Addition()
        {
            double parameterA, parameterB, outcome;

            _consoleIO.WriteLine("Digite o primeiro número a ser somado: ");
            parameterA = UserInput();
            _consoleIO.WriteLine("Digite o segundo número a ser somado: ");
            parameterB = UserInput();

            outcome = parameterA + parameterB;
            _consoleIO.WriteLine($"O resultado da soma de {parameterA} + {parameterB} = {outcome}\n\n");
            _record.RecordOperations("+", parameterA, parameterB, outcome);
            return outcome;
        }

        public double Subtraction()
        {
            double parameterA, parameterB, outcome;

            _consoleIO.WriteLine("Digite o primeiro número a ser subitraido: ");
            parameterA = UserInput();
            _consoleIO.WriteLine("Digite o segundo número a ser subtraido: ");
            parameterB = UserInput();

            outcome = parameterA - parameterB;
            _consoleIO.WriteLine($"O resultado da soma de {parameterA} - {parameterB} = {outcome}\n\n");
            _record.RecordOperations("-", parameterA, parameterB, outcome);
            return outcome;
        }

        public double Division()
        {
            double parameterA, parameterB, outcome;

            _consoleIO.WriteLine("Digite o dividendo: ");
            parameterA = UserInput();
            _consoleIO.WriteLine("Digite o divisor: ");
            parameterB = UserInput();

            outcome = parameterA / parameterB;
            _consoleIO.WriteLine($"O resultado da soma de {parameterA} / {parameterB} = {outcome}\n\n");
            _record.RecordOperations("/", parameterA, parameterB, outcome);
            return outcome;
        }

        public double Multiplication()
        {
            double parameterA, parameterB, outcome;

            _consoleIO.WriteLine("Digite o primeiro número a ser multiplicado: ");
            parameterA = UserInput();
            _consoleIO.WriteLine("Digite o segundo número a ser multiplicado: ");
            parameterB = UserInput();

            outcome = parameterA * parameterB;
            _consoleIO.WriteLine($"O resultado da soma de {parameterA} * {parameterB} = {outcome}\n\n");
            _record.RecordOperations("*", parameterA, parameterB, outcome);
            return outcome;
        }

        public double Exponentiation()
        {
            double parameterA, parameterB;
            double outcome = 1;
            // in case the exponent is positive
            bool sign = true;

            _consoleIO.WriteLine("Digite a base: ");
            parameterA = UserInput();
            _consoleIO.WriteLine("Agora digite o expoente: ");
            parameterB = UserInput();

            if (parameterB < 0)
            {
                sign = false;
                parameterB *= -1;
            }
            
            for (int i = 1; i <= parameterB; i++)
            {
                if (sign)
                {
                    outcome *= parameterA;
                }
                else
                {
                    outcome /= parameterA;
                }
            }

            if (parameterA < 0 && outcome > 0)
            {
                outcome *= -1;
            }
            
            _consoleIO.WriteLine($"O resultado da potência de {parameterA} ^ {parameterB} = {outcome}\n\n");
            _record.RecordOperations("^", parameterA, parameterB, outcome);

            return outcome;
        }

        // Using Newton-raphson square root method
        public double SquareRoot()
        {
            double parameterA;
            double outcome = 1;

            _consoleIO.WriteLine("Digite um numero para descobrir sua raiz quadrada: ");
            parameterA = UserInput();


            if (parameterA < 0)
            {
                throw new Exception("Radicand Cannot be a negative number");
            }
            for (int i = 0; i < 10; i++)
            {
                outcome = (outcome + parameterA / outcome) / 2;
            }
            _consoleIO.WriteLine($"O resultado da raiz quadrada de {parameterA} é: {outcome}\n\n");
            _record.RecordOperations("sqrt", parameterA, outcome);
            return outcome;
        }

        public double CubeRoot()
        {
            double start = 0, end = 0, parameterA;
            _consoleIO.WriteLine("Digite um numero para descobrir sua raiz cúbica: ");

            parameterA = UserInput();
            end = parameterA;
            double e = 0.0000001;

            while (true)
            {
                double outcome = (start + end) / 2;
                double error = Diff(parameterA, outcome);

                if (error <= e)
                {
                    _consoleIO.WriteLine($"O resultado da raiz cubica de {parameterA} é: {outcome}\n\n");
                    _record.RecordOperations("cube", parameterA, outcome);
                    return outcome;
                }
                if ((outcome * outcome * outcome) > parameterA)
                {
                    end = outcome;
                }
                else
                {
                    start = outcome;
                }
            }
        }

        private double UserInput()
        {
            double userKey;

            while (!double.TryParse(_consoleIO.ReadLine(), out userKey))
            {
                _consoleIO.WriteLine("Valor inválido, Digite um número.");
            }
            return userKey;
        }

        private double Diff(double n, double mid)
        {
            if (n > (mid * mid * mid))
                return (n - (mid * mid * mid));
            else
                return ((mid * mid * mid) - n);
        }
    }
}
