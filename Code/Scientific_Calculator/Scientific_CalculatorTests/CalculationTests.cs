using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scientific_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scientific_Calculator.Tests
{

    [TestClass()]
    public class CalculationTests
    {
        Random rnd = new Random();
        double rndMediumInt;
        double rndMediumDouble;
        double rndBigInt;
        double rndBigDouble;
        double rndSmallDouble;

        public void CreateRandoms()
        {
            rndMediumInt = rnd.Next(100);
            rndMediumDouble = rnd.NextDouble() * 100;
            rndBigInt = rnd.Next(10000000, 999999999);
            rndBigDouble = rnd.NextDouble() * 10000000000;
            rndSmallDouble = rnd.NextDouble() * 0.001;
        }

        [TestMethod()]
        public void SolveTestSum()
        {
            //Data preparation
            double[] firstMembers = new double[20];
            double[] secondMembers = new double[20];
            double[] resultExpected = new double[20];
            for (int i = 0; i < 20; i++)
            {
                CreateRandoms();
                if(i%2 == 0)
                {
                    firstMembers[i] = rndMediumInt;
                    CreateRandoms();
                    secondMembers[i] = rndMediumInt;
                }
                else
                {
                    firstMembers[i] = rndMediumInt * -1;
                    CreateRandoms();
                    secondMembers[i] = rndMediumInt * -1;
                }
                
                resultExpected[i] = firstMembers[i] + secondMembers[i];
            }

            //Execution
            double[] resultCalculated = new double[20];
            List<string> opList = new List<string>();
            for (int i = 0; i < 20; i++)
            {
                opList.Clear();
                opList.Add("(" + firstMembers[i].ToString() + ")");
                opList.Add("+");
                opList.Add("(" + secondMembers[i].ToString() + ")");
                resultCalculated[i] = Calculation.Solve(opList);
            }
            //Check
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }
    }
}