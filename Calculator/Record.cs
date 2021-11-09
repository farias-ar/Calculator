using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Record : IRecord
    {
        // Save file in the user Documents with the name 'operations.txt'
        private readonly string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private readonly string txtPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\\operations.txt";
        private static int registry = 0;
        private static int counter = 0;
        private static List<string> operations = new List<string> { };

        private void CreateFile()
        {
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    DirectoryInfo directoryInfo = Directory.CreateDirectory(folderPath);
                }
                File.AppendAllText(txtPath, Consolidate());
            }
                
            catch (Exception Ex)
            {
                throw Ex;
            }

        }


        public void RecordOperations(string operation, double parameters_A, double result)
        {
            registry++;
            string operationName = string.Empty;
            string formatedResult = string.Empty;
            switch (operation)
            {
                case "circle":
                    operationName = "Área do círculo";
                    formatedResult = result.ToString();
                    break;
                case "square":
                    operationName = "Área do quadrado";
                    formatedResult = result.ToString();
                    break;
                case "sqrt":
                    operationName = "Raiz Quadrada";
                    formatedResult = result.ToString();
                    break;
                case "cube":
                    operationName = "Raiz Cúbica";
                    formatedResult = result.ToString();
                    break;
                case "mmTocm":
                    operationName = "Coversão MM -> CM";
                    formatedResult = result.ToString() + "CM";
                    break;
                case "mmTom":
                    operationName = "Coversão MM -> M";
                    formatedResult = result.ToString() + "M";
                    break;
                case "mmTokm":
                    operationName = "Coversão MM -> KM";
                    formatedResult = result.ToString() + "KM";
                    break;
                case "cmTomm":
                    operationName = "Coversão CM -> MM";
                    formatedResult = result.ToString() + "MM";
                    break;
                case "cmTom":
                    operationName = "Coversão CM -> M";
                    formatedResult = result.ToString() + "M";
                    break;
                case "cmTokm":
                    operationName = "Coversão CM -> KM";
                    formatedResult = result.ToString() + "KM";
                    break;
                case "mTomm":
                    operationName = "Coversão M -> MM";
                    formatedResult = result.ToString() + "MM";
                    break;
                case "mTocm":
                    operationName = "Coversão M -> CM";
                    formatedResult = result.ToString() + "CM";
                    break;
                case "mTokm":
                    operationName = "Coversão M -> KM";
                    formatedResult = result.ToString() + "KM";
                    break;
                case "kmTomm":
                    operationName = "Coversão KM -> MM";
                    formatedResult = result.ToString() + "MM";
                    break;
                case "kmTocm":
                    operationName = "Coversão KM -> CM";
                    formatedResult = result.ToString() + "CM";
                    break;
                case "kmTom":
                    operationName = "Coversão KM -> M";
                    formatedResult = result.ToString() + "M";
                    break;
                case "gTokg":
                    operationName = "Coversão G -> KG";
                    formatedResult = result.ToString() + "KG";
                    break;
                case "gTot":
                    operationName = "Coversão G -> T";
                    formatedResult = result.ToString() + "T";
                    break;
                case "kgTog":
                    operationName = "Coversão KG -> G";
                    formatedResult = result.ToString() + "G";
                    break;
                case "kgTot":
                    operationName = "Coversão KG -> T";
                    formatedResult = result.ToString() + "T";
                    break;
                case "tTog":
                    operationName = "Coversão T -> G";
                    formatedResult = result.ToString() + "G";
                    break;
                case "tTokg":
                    operationName = "Coversão T -> KG";
                    formatedResult = result.ToString() + "KG";
                    break;
                case "mlTol":
                    operationName = "Coversão ML -> L";
                    formatedResult = result.ToString() + "L";
                    break;
                case "lToml":
                    operationName = "Coversão L -> ML";
                    formatedResult = result.ToString() + "ML";
                    break;
                default:
                    break;
            }
            operations.Add($"{operationName}\t\tParâmetros(A={parameters_A})\t\t{formatedResult}");

            if (registry % 10 == 0)
            {
                CreateFile();
            }
        }
        public void RecordOperations(string operation, double parameters_A, double parameters_B, double result)
        {
            registry++;
            string operationName = string.Empty;
            string formatedResult = string.Empty;
            switch (operation)
            {
                case "+":
                    operationName = "Soma\t";
                    formatedResult = result.ToString();
                    break;
                case "-":
                    operationName = "Subtração\t";
                    formatedResult = result.ToString();
                    break;
                case "/":
                    operationName = "Divisão\t";
                    formatedResult = result.ToString();
                    break;
                case "*":
                    operationName = "Multiplicação";
                    formatedResult = result.ToString();
                    break;
                case "^":
                    operationName = "Potenciação";
                    formatedResult = result.ToString();
                    break;
                case "triangle":
                    operationName = "Área do triângulo";
                    formatedResult = result.ToString();
                    break;
                default:
                    break;
            }
            operations.Add($"{operationName}\t\tParâmetros(A={parameters_A}, B={parameters_B})\t{formatedResult}");

            if (registry % 10 == 0)
            {
                CreateFile();
            }
        }

        private string Consolidate()
        {
            StringBuilder operationsHistory = new StringBuilder();

            if (File.Exists(txtPath))
            {
                var lineCount = File.ReadLines(txtPath).Count();
                if (lineCount > 0) counter = lineCount - 1;
            }

            if (!File.Exists(txtPath))
            {
                operationsHistory.Append("Nº\t\t");
                operationsHistory.Append("Operação\t\t\t");
                operationsHistory.Append("Parâmetros\t\t");
                operationsHistory.Append("Resultado\t\t");
                operationsHistory.AppendLine();
            }

            for (int index = 0; index < operations.Count; index++)
            {
                counter++;
                operationsHistory.Append(counter.ToString("D3"));
                operationsHistory.Append("\t\t");
                operationsHistory.Append(operations[index]);
                operationsHistory.AppendLine();
            }
            operations.Clear();
            return operationsHistory.ToString();
        }
    }
}
