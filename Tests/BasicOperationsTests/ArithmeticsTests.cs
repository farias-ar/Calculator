using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace BasicOperationsTests
{
    [TestClass]
    public class ArithmeticsTests
    {
        // delegate c#
        private static List<string> userInputs =  new List<string>();
        private static int currentInput = 0;

        [TestMethod]
        public void Successful_sum_of_two_positive_numbers()
        {
            double a = 10, b = 15, result = 0;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(a.ToString(), b.ToString());

            var arithmetics = new Arithmetic(record.Object, mockConsole.Object);

            result = arithmetics.Addition();

            record.Verify(x => x.RecordOperations("+", a, b, 25), Times.Once);
            Assert.AreEqual(25, result);

        }

        [TestMethod]
        public void Successful_subtraction_of_two_positive_numbers()
        {
            double a = 12, b = 8, result = 0;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(a.ToString(), b.ToString());

            var arithmetics = new Arithmetic(record.Object, mockConsole.Object);

            result = arithmetics.Subtraction();

            record.Verify(x => x.RecordOperations("-", a, b, 4), Times.Once);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Successful_divide_of_two_positive_numbers()
        {
            double a = 15, b = 7, result = 0;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(a.ToString(), b.ToString());

            var arithmetics = new Arithmetic(record.Object, mockConsole.Object);

            result = arithmetics.Division();

            record.Verify(x => x.RecordOperations("/", a, b, 2.1428571428571428571428571428571), Times.Once);
            Assert.AreEqual(2.1428571428571428571428571428571, result);
        }

        [TestMethod]
        public void Successful_multiply_of_two_positive_numbers()
        {   
            double a = 15, b = 7, result = 0;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(a.ToString(), b.ToString());

            var arithmetics = new Arithmetic(record.Object, mockConsole.Object);

            result = arithmetics.Multiplication();

            
            record.Verify(x => x.RecordOperations("*", a, b, 105), Times.Once);
            Assert.AreEqual(105, result);
        }

        [TestMethod]
        public void Successful_exponetinal_of_two_positive_numbers()
        {
            double a = 2, b = 10, result = 0;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(a.ToString(), b.ToString());

            var arithmetics = new Arithmetic(record.Object, mockConsole.Object);

            result = arithmetics.Exponentiation();

            record.Verify(x => x.RecordOperations("^", a, b, 1024), Times.Once);
            Assert.AreEqual(1024, result);
        }

        [TestMethod]
        public void Successful_obtain_square_roots_from_a_positive_number()
        { 
            double a = 4, result = 0;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(a.ToString());

            var arithmetics = new Arithmetic(record.Object, mockConsole.Object);

            result = arithmetics.SquareRoot();
            record.Verify(x => x.RecordOperations("sqrt", a, 2), Times.Once);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Successful_obtain_cubic_roots_from_a_positive_number()
        {
            double a = 8, result = 0;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(a.ToString());

            var arithmetics = new Arithmetic(record.Object, mockConsole.Object);

            result = arithmetics.CubeRoot();
            record.Verify(x => x.RecordOperations("cube", a, 2), Times.Once);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Successful_obtain_triangle_area()
        {
            double a = 2, b = 12, result = 0;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(a.ToString(), b.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.TriangleArea();
            record.Verify(x => x.RecordOperations("triangle", a, b, 7), Times.Once);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Successful_obtain_square_area()
        {
            double a = 2, result = 0;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.SquareArea();
            record.Verify(x => x.RecordOperations("square", a, 4), Times.Once);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Successful_obtain_circle_area()
        {
            double a = 12, result = 0;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.CircleArea();
            record.Verify(x => x.RecordOperations("circle", a, 452.38934211692976), Times.Once);
            Assert.AreEqual(452.38934211692976, result);
        }

        

        [TestMethod]
        public void Successful_convert_millimeter_to_centimeter()
        {
            double a = 12, result = 0, userKey = 1;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(userKey.ToString(), a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.FromMillimetre();
            record.Verify(x => x.RecordOperations("mmTocm", a, 1.2), Times.Once);
            Assert.AreEqual(1.2, result);
        }

        [TestMethod]
        public void Successful_convert_millimeter_to_meter()
        {
            double a = 17, userKey = 2, result = 0;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(userKey.ToString(), a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.FromMillimetre();

            record.Verify(x => x.RecordOperations("mmTom", a, 0.017), Times.Once);
            Assert.AreEqual(0.017, result);
        }

        [TestMethod]
        public void Successful_convert_millimeter_to_kilometer()
        {
            double a = 17, result = 0, userKey = 3;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(userKey.ToString(), a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.FromMillimetre();

            record.Verify(x => x.RecordOperations("mmTokm", a, 1.7E-05), Times.Once);
            Assert.AreEqual(1.7E-05, result);
        }

        [TestMethod]
        public void Successful_convert_centimeter_to_millimeter()
        {
            double a = 1500, result = 0, userKey = 1;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(userKey.ToString(), a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.FromCentimeter();

            record.Verify(x => x.RecordOperations("cmTomm", a, 15000), Times.Once);
            Assert.AreEqual(15000, result);
        }

        [TestMethod]
        public void Successful_convert_centimeter_to_meter()
        {
            double a = 55, result = 0, userKey = 2;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(userKey.ToString(), a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.FromCentimeter();

            record.Verify(x => x.RecordOperations("cmTom", a, 0.55), Times.Once);
            Assert.AreEqual(0.55, result);
        }

        [TestMethod]
        public void Successful_convert_centimeter_to_kilometer()
        {
            double a = 175, result = 0, userKey = 3;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(userKey.ToString(), a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.FromCentimeter();

            record.Verify(x => x.RecordOperations("cmTokm", a, 0.00175), Times.Once);
            Assert.AreEqual(0.00175, result);
        }

        [TestMethod]
        public void Successful_convert_meter_to_millimeter()
        {
            double a = 62, result = 0, userKey = 1;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(userKey.ToString(), a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.FromMeter();

            record.Verify(x => x.RecordOperations("mTomm", a, 62000), Times.Once);
            Assert.AreEqual(62000, result);
        }

        [TestMethod]
        public void Successful_convert_meter_to_centimeter()
        {
            double a = 155, result = 0, userKey = 2;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(userKey.ToString(), a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.FromMeter();

            record.Verify(x => x.RecordOperations("mTocm", a, 15500), Times.Once);
            Assert.AreEqual(15500, result);
        }

        [TestMethod]
        public void Successful_convert_meter_to_kilometer()
        {
            double a = 17, result = 0, userKey = 3;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(userKey.ToString(), a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.FromMeter();

            record.Verify(x => x.RecordOperations("mTokm", a, 0.017), Times.Once);
            Assert.AreEqual(0.017, result);
        }

        [TestMethod]
        public void Successful_convert_kilometer_to_millimeter()
        {
            double a = 6, result = 0, userKey = 1;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(userKey.ToString(), a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.FromKilometer();

            record.Verify(x => x.RecordOperations("kmTomm", a, 6000000), Times.Once);
            Assert.AreEqual(6000000, result);
        }

        [TestMethod]
        public void Successful_convert_kilometer_to_centimeter()
        {
            double a = 25, result = 0, userKey = 2;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(userKey.ToString(), a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.FromKilometer();

            record.Verify(x => x.RecordOperations("kmTocm", a, 2500000), Times.Once);
            Assert.AreEqual(2500000, result);
        }

        [TestMethod]
        public void Successful_convert_kilometer_to_meter()
        {
            double a = 11, result = 0, userKey = 3;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(userKey.ToString(), a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.FromKilometer();

            record.Verify(x => x.RecordOperations("kmTom", a, 11000), Times.Once);
            Assert.AreEqual(11000, result);
        }

        [TestMethod]
        public void Successful_convert_gram_to_kilogram()
        {
            double a = 12.68, result = 0, userKey = 1;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(userKey.ToString(), a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.FromGram();

            record.Verify(x => x.RecordOperations("gTokg", a, 0.01268), Times.Once);
            Assert.AreEqual(0.01268, result);
        }

        [TestMethod]
        public void Successful_convert_gram_to_tonne()
        {
            double a = 112.61, result = 0, userKey = 2;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(userKey.ToString(), a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.FromGram();

            record.Verify(x => x.RecordOperations("gTot", a, 0.00011261), Times.Once);
            Assert.AreEqual(0.00011261, result);
        }

        [TestMethod]
        public void Successful_convert_kilogram_to_gram()
        {
            double a = 11.21, result = 0, userKey = 1;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(userKey.ToString(), a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.FromKilogram();

            record.Verify(x => x.RecordOperations("kgTog", a, 11210), Times.Once);
            Assert.AreEqual(11210, result);
        }

        [TestMethod]
        public void Successful_convert_kilogram_to_tonne()
        {
            double a = 9.11, result = 0, userKey = 2;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(userKey.ToString(), a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.FromKilogram();

            record.Verify(x => x.RecordOperations("kgTot", a, 0.00911), Times.Once);
            Assert.AreEqual(0.00911, result);
        }

        [TestMethod]
        public void Successful_convert_tonne_to_gram()
        {
            double a = 5, result = 0, userKey = 1;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(userKey.ToString(), a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.FromTonne();

            record.Verify(x => x.RecordOperations("tTog", a, 5000000), Times.Once);
            Assert.AreEqual(5000000, result);   
        }

        [TestMethod]
        public void Successful_convert_tonne_to_kilogram()
        {
            double a = 6.1, result = 0, userKey = 2;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(userKey.ToString(), a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.FromTonne();

            record.Verify(x => x.RecordOperations("tTokg", a, 6100), Times.Once);
            Assert.AreEqual(6100, result);
        }

        [TestMethod]
        public void Successful_convert_milliliters_to_liter()
        {
            double a = 88.11, result = 0, userKey = 1;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(userKey.ToString(), a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.FromMilliliters();

            record.Verify(x => x.RecordOperations("mlTol", a, 0.08811), Times.Once);
            Assert.AreEqual(0.08811, result);
        }

        [TestMethod]
        public void Successful_convert_liter_to_milliliter()
        {
            double a = 44.11, result = 0, userKey = 1;
            var mockConsole = new Mock<IConsoleIO>();

            Mock<IRecord> record = new Mock<IRecord>();

            mockConsole.Setup(x => x.ReadLine()).Returns(ReadUserInput);
            SetUserInput(userKey.ToString(), a.ToString());

            var area_unit = new AreaUnitConversion(record.Object, mockConsole.Object);

            result = area_unit.FromLiter();

            record.Verify(x => x.RecordOperations("lToml", a, 44110), Times.Once);
            Assert.AreEqual(44110, result);
        }



        private static void SetUserInput(params string[] inputs)
        {
            userInputs.Clear();
            userInputs.AddRange(inputs);
            currentInput = 0;
        }
        
        private static string ReadUserInput()
        { 
            return userInputs[currentInput++];
        }
    }
}
