using NFluent;
using NUnit.Framework;

namespace CSharpDiscovery
{
    using System;

    [TestFixture]
    public class ClassesTests
    {
        private const double piConst = 3.14;
        static readonly double piRO = 3.14;

        [Test]
        public void CreateACalculatorClassWithADefaultConstructorAndInstanciate()
        {
            Calculator calculator = new Calculator();
            Check.That(calculator).IsNotNull();
        }

        [Test]
        public void AddAnotherConstructorWithAFriendlyNameAndInstanciate()
        {
            // use a public member for Name for now, i.e public string Name;
            Calculator calculator = new Calculator("Calculator");
            Check.That(calculator.Name).Equals("Calculator");
        }

        [Test]
        public void AddAMethodThatMakeASumOfAnArrayOfDouble()
        {
            var valuesToSum = new[] { 1.3, 1.7 };
            Calculator calculator = new Calculator();
            // add a method Sum to calculator class
            double sumOfTheArray = Calculator.sum(valuesToSum);
            Check.That(sumOfTheArray).Equals(3.0);
        }

        [Test]
        public void AddAMethodOverloadThatMakeASumOfTwoDoubleFromStringRepresentation()
        {
            var sumOfTwoDoubleFromString = "1,0+2";
            // add a method with the same name that uses the previous method
            // tips : use string.Split
            double onePlusTwo = Calculator.sum(sumOfTwoDoubleFromString);
            Check.That(onePlusTwo).Equals(3.0);
        }

        [Test]
        public void AddAGetterForNameInsteadOfPublicNameMember()
        {
            Calculator calculator = new Calculator("Calculator");

            Check.That(calculator.Name).Equals("Calculator");
        }

        [Test]
        public void AddASetterForNameAndChangeNameWithIt()
        {
            Calculator calculator = new Calculator();
            calculator.Name = "Enhanced Calculator";
            Check.That(calculator.Name).Equals("Enhanced Calculator");
        }

        [Test]
        public void UseObjectInitilizerWithDefaultConstructor()
        {
            Calculator calculator = new Calculator();
            Check.That(calculator.Name).Equals("Calculator");
        }

        [Test]
        public void DefineConstantForPi()
        {
            var sumOfADoubleAndPiConstant = "1,2 + pi";
            // define pi constant (as double) and replace pi string with constant value

            sumOfADoubleAndPiConstant = sumOfADoubleAndPiConstant.Replace("pi", piConst.ToString());
            Calculator calculator = new Calculator();
            double sum = Calculator.sum(sumOfADoubleAndPiConstant);
            Check.That(sum).Equals(4.34);
        }

        [Test]
        public void StaticReadonlyMembers()
        {
            
            var sumOfADoubleAndPiConstant = "1,2 + pi";
            // replace pi constant with a static readonly member

            sumOfADoubleAndPiConstant = sumOfADoubleAndPiConstant.Replace("pi", piRO.ToString());
            Calculator calculator = new Calculator();
            double sum = Calculator.sum(sumOfADoubleAndPiConstant);
            Check.That(sum).Equals(4.34);
        }

        [Test]
        public void MakeSumMethodsStaticAsTheyDoNotNeedAnyInstanceSpecific()
        {
            var valuesToSum = new[] { 1.3, 1.7 };
            // make sum methods static and call one these to retrieve a sum of double array values
            double sum = Calculator.sum(valuesToSum);
            Check.That(sum).Equals(3.0);
        }

        [Test]
        public void AddStaticCalculatorClass()
        {
            // define a static class StaticCalculator that uses Calculator static methods & define static getter for Name
            Check.That(staticCalculator.Name).Equals("Static calculator");
        }
    }
}
