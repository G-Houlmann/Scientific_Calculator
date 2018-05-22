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
        #region private attributes and methods

        Random rnd = new Random();
        double rndMediumInt;
        double rndMediumDouble;
        double rndBigInt;
        double rndBigDouble;
        double rndSmallDouble;

        /// <summary>
        /// Creates a variety of not-null random numbers in different ranges and of different types
        /// </summary>
        private void CreateRandoms()
        {
            rndMediumInt = rnd.Next(99) + 1;
            rndMediumDouble = Math.Round(rnd.NextDouble() * 100, 7);
            rndBigInt = rnd.Next(10000000, 999999999);
            rndBigDouble = Math.Round(rnd.NextDouble() * 10000000, 7);
            rndSmallDouble = Math.Round(rnd.NextDouble() * 0.001, 7);
        }


        private List<double[]> CreateRandomArrays()
        {
            //Creating the arrays
            List<double[]> lstArrays = new List<double[]>();
            double[] firstMembers = new double[103];
            double[] secondMembers = new double[103];
            double[] resultExpected = new double[103];

            /*Filling the arrays "firstMembers" and "SecondMembers" with the randomized values.
            Half of them are turned into negative values. 22 out of 23 values are filled here, 
            because the last one or the 3 last ones will be used in the test methods to test 
            what happens when zeros are used.*/
            int i = 0;
            //medium ints
            for (i = 0; i < 20; i++)
            {
                CreateRandoms();
                if (i % 2 == 0)
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
            }

            //medium doubles
            for (i = 20; i < 40; i++)
            {
                CreateRandoms();
                if (i % 2 == 0)
                {
                    firstMembers[i] = rndMediumDouble;
                    CreateRandoms();
                    secondMembers[i] = rndMediumDouble;
                }
                else
                {
                    firstMembers[i] = rndMediumDouble * -1;
                    CreateRandoms();
                    secondMembers[i] = rndMediumDouble * -1;
                }
            }

            //small double
            for (i = 40; i < 60; i++)
            {
                CreateRandoms();
                if (i % 2 == 0)
                {
                    firstMembers[i] = rndSmallDouble;
                    CreateRandoms();
                    secondMembers[i] = rndSmallDouble;
                }
                else
                {
                    firstMembers[i] = rndSmallDouble * -1;
                    CreateRandoms();
                    secondMembers[i] = rndSmallDouble * -1;
                }
            }

            //big int
            for (i = 60; i < 80; i++)
            {
                CreateRandoms();
                if (i % 2 == 0)
                {
                    firstMembers[i] = rndBigInt;
                    CreateRandoms();
                    secondMembers[i] = rndBigInt;
                }
                else
                {
                    firstMembers[i] = rndBigInt * -1;
                    CreateRandoms();
                    secondMembers[i] = rndBigInt * -1;
                }
            }

            //big double
            for (i = 80; i < 102; i++)
            {
                CreateRandoms();
                if (i % 2 == 0)
                {
                    firstMembers[i] = rndBigDouble;
                    CreateRandoms();
                    secondMembers[i] = rndBigDouble;
                }
                else
                {
                    firstMembers[i] = rndBigDouble * -1;
                    CreateRandoms();
                    secondMembers[i] = rndBigDouble * -1;
                }
            }
            lstArrays.Add(firstMembers);
            lstArrays.Add(secondMembers);
            lstArrays.Add(resultExpected);

            return lstArrays;
        }

        #endregion

        #region basic operations tests

        [TestMethod()]
        public void SolveTestSum()
        {
            //Data preparation---------------------------------------------------------------
            List<double[]> lstArrays = CreateRandomArrays();
            double[] firstMembers = lstArrays.ElementAt(0);
            double[] secondMembers = lstArrays.ElementAt(1);
            double[] resultExpected = lstArrays.ElementAt(2);

            for(int i = 0; i<102; i++)
            {
                resultExpected[i] = Math.Round(firstMembers[i] + secondMembers[i], 4);
        }

            //Testing with zeros
            firstMembers[100] = 0;
            firstMembers[101] = 0;
            firstMembers[102] = 12.3;

            secondMembers[100] = 0;
            secondMembers[101] = -5.74;
            secondMembers[102] = 0;

            resultExpected[100] = 0;
            resultExpected[101] = -5.74;
            resultExpected[102] = 12.3;

            //Execution----------------------------------------------------------------------
            double[] resultCalculated = new double[103];
            List<string> opList = new List<string>();
            for (int i = 0; i < 103; i++)
            {
                opList.Clear();
                opList.Add("(" + firstMembers[i].ToString() + ")");
                opList.Add("+");
                opList.Add("(" + secondMembers[i].ToString() + ")");
                resultCalculated[i] = Math.Round(Calculation.Solve(opList), 4);
            }
            //Check----------------------------------------------------------------------------
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }


        [TestMethod()]
        public void SolveTestSubstraction()
        {
            //Data preparation---------------------------------------------------------------
            List<double[]> lstArrays = CreateRandomArrays();
            double[] firstMembers = lstArrays.ElementAt(0);
            double[] secondMembers = lstArrays.ElementAt(1);
            double[] resultExpected = lstArrays.ElementAt(2);

            for (int i = 0; i < 100; i++)
            {
                resultExpected[i] = Math.Round(firstMembers[i] - secondMembers[i], 4);
            }

            //Testing with zeros
            firstMembers[100] = 0;
            firstMembers[101] = 0;
            firstMembers[102] = 12.3;

            secondMembers[100] = 0;
            secondMembers[101] = -5.74;
            secondMembers[102] = 0;

            resultExpected[100] = 0;
            resultExpected[101] = 5.74;
            resultExpected[102] = 12.3;

            //Execution----------------------------------------------------------------------
            double[] resultCalculated = new double[103];
            List<string> opList = new List<string>();
            for (int i = 0; i < 103; i++)
            {
                opList.Clear();
                opList.Add("(" + firstMembers[i].ToString() + ")");
                opList.Add("-");
                opList.Add("(" + secondMembers[i].ToString() + ")");
                resultCalculated[i] = Math.Round(Calculation.Solve(opList), 4);
            }
            //Check----------------------------------------------------------------------------
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }

        /// <summary>
        /// only the medium int, medium double and small double are taken in this test, because bigger values would create numbers that are too high for the system
        /// </summary>
        [TestMethod()]
        public void SolveTestMultiplication()
        {
            //Data preparation---------------------------------------------------------------
            List<double[]> lstArrays = CreateRandomArrays();

            double[] firstMembers = new double[63];
            double[] secondMembers = new double[63];
            double[] resultExpected = new double[63];

            for(int i = 0; i< 60; i++)
            {
                firstMembers[i] = lstArrays.ElementAt(0)[i];
                secondMembers[i] = lstArrays.ElementAt(1)[i];
                resultExpected[i] = lstArrays.ElementAt(2)[i];
            }

            for (int i = 0; i < 60; i++)
            {
                resultExpected[i] = Math.Round(firstMembers[i] * secondMembers[i], 4);
            }

            //Testing with zeros
            firstMembers[60] = 0;
            firstMembers[61] = 0;
            firstMembers[62] = 12.3;

            secondMembers[60] = 0;
            secondMembers[61] = -5.74;
            secondMembers[62] = 0;

            resultExpected[60] = 0;
            resultExpected[61] = 0;
            resultExpected[62] = 0;

            //Execution----------------------------------------------------------------------
            double[] resultCalculated = new double[63];
            List<string> opList = new List<string>();
            for (int i = 0; i < 63; i++)
            {
                opList.Clear();
                opList.Add("(" + firstMembers[i].ToString() + ")");
                opList.Add("*");
                opList.Add("(" + secondMembers[i].ToString() + ")");
                resultCalculated[i] = Math.Round(Calculation.Solve(opList), 4);
            }
            //Check----------------------------------------------------------------------------
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }


        [TestMethod()]
        public void SolveTestDivision()
        {
            //Data preparation---------------------------------------------------------------
            List<double[]> lstArrays = CreateRandomArrays();
            double[] firstMembers = lstArrays.ElementAt(0);
            double[] secondMembers = lstArrays.ElementAt(1);
            double[] resultExpected = lstArrays.ElementAt(2);

            for (int i = 0; i < 100; i++)
            {
                /*The result is rounded because after about 10 digits the Solve() method and c# start  
                rounding the decimals in a different way, giving 2 very close but different values.*/
                resultExpected[i] = Math.Round(firstMembers[i] / secondMembers[i], 5);
            }

            //Testing with zeros
            firstMembers[100] = 0;
            firstMembers[101] = 0;
            firstMembers[102] = 12.3;

            secondMembers[100] = 0;
            secondMembers[101] = -5.74;
            secondMembers[102] = 0;

            resultExpected[100] = double.NaN;
            resultExpected[101] = 0;
            resultExpected[102] = double.NaN;

            //Execution------------------------------------------------------------------------
            double[] resultCalculated = new double[103];
            List<string> opList = new List<string>();
            for (int i = 0; i < 103; i++)
            {
                opList.Clear();
                opList.Add("(" + firstMembers[i].ToString() + ")");
                opList.Add("/");
                opList.Add("(" + secondMembers[i].ToString() + ")");
                resultCalculated[i] = Math.Round(Calculation.Solve(opList), 5);
            }
            //Check----------------------------------------------------------------------------
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }

        [TestMethod()]
        public void SolveTestReciprocal()
        {
            //Data preparation-----------------------------------------------------------------
            List<double[]> lstArrays = CreateRandomArrays();
            double[] firstMembers = lstArrays.ElementAt(0);
            double[] resultExpected = lstArrays.ElementAt(2);

            for (int i = 0; i < 102; i++)
            {
                /*The result is rounded because after about 10 digits the Solve() method and c# start  
                rounding the decimals in a different way, giving 2 very close but different values.*/
                resultExpected[i] = Math.Round(1 / firstMembers[i], 5);
            }

            //Testing with zeros
            firstMembers[102] = 0;

            resultExpected[102] = double.NaN;

            //Execution----------------------------------------------------------------------
            double[] resultCalculated = new double[103];
            List<string> opList = new List<string>();
            for (int i = 0; i < 103; i++)
            {
                opList.Clear();
                opList.Add("1/");
                opList.Add("(" + firstMembers[i].ToString() + ")");
                resultCalculated[i] = Math.Round(Calculation.Solve(opList), 5);
            }
            //Check----------------------------------------------------------------------------
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }


        /// <summary>
        /// Only the medium ints are used here, because all the other types of numbers in the arrays are either too big or decimal.
        /// </summary>
        [TestMethod()]
        public void SolveTestFactorial()
        {
            //Data preparation---------------------------------------------------------------
            List<double[]> lstArrays = CreateRandomArrays();

            double[] firstMembers = new double[21];
            double[] secondMembers = new double[21];
            double[] resultExpected = new double[21];

            for (int i = 0; i < 21; i++)
            {
                firstMembers[i] = lstArrays.ElementAt(0)[i];
                resultExpected[i] = lstArrays.ElementAt(2)[i];
            }


            for (int i = 0; i < 21; i++)
            {
                /*The result is rounded because after about 10 digits the Solve() method and c# start  
                rounding the decimals in a different way, giving 2 very close but different values.*/
                double answer = 0;
                double input = firstMembers[i];
                double count;

                if (input > 0 && Math.Round(input) == input)
                {
                    count = 1;
                    while (count <= input)
                    {
                        if (count == 1)
                        {
                            answer = 1;
                            count++;
                        }
                        else
                        {
                            answer = count * answer;
                            count++;
                        }
                    }
                    resultExpected[i] = answer;
                }
                else
                {
                    resultExpected[i] = double.NaN;
                }
            }

            //Testing with zeros and decimal numbers
            firstMembers[20] = 0;

            resultExpected[20] = 1;

            //Execution----------------------------------------------------------------------
            double[] resultCalculated = new double[21];
            List<string> opList = new List<string>();
            for (int i = 0; i < 21; i++)
            {
                opList.Clear();
                opList.Add("(" + firstMembers[i].ToString() + ")");
                opList.Add("!");
                resultCalculated[i] = Calculation.Solve(opList);
            }
            //Check----------------------------------------------------------------------------
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }


        [TestMethod()]
        public void SolveTestAbsValue()
        {
            //Data preparation---------------------------------------------------------------
            List<double[]> lstArrays = CreateRandomArrays();
            double[] firstMembers = lstArrays.ElementAt(0);
            double[] resultExpected = lstArrays.ElementAt(2);

            for (int i = 0; i < 102; i++)
            {
                /*The result is rounded because after about 10 digits the Solve() method and c# start  
                rounding the decimals in a different way, giving 2 very close but different values.*/
                resultExpected[i] = Math.Round(Math.Abs(firstMembers[i]), 5);
            }

            //Testing with zeros
            firstMembers[102] = 0;

            resultExpected[102] = 0;

            //Execution----------------------------------------------------------------------
            double[] resultCalculated = new double[103];
            List<string> opList = new List<string>();
            for (int i = 0; i < 103; i++)
            {
                opList.Clear();
                opList.Add("abs(");
                opList.Add(firstMembers[i].ToString() + ")");
                resultCalculated[i] = Math.Round(Calculation.Solve(opList), 5);
            }
            //Check----------------------------------------------------------------------------
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }


        [TestMethod()]
        public void SolveTestRound()
        {
            //Data preparation---------------------------------------------------------------
            List<double[]> lstArrays = CreateRandomArrays();
            double[] firstMembers = lstArrays.ElementAt(0);
            double[] resultExpected = lstArrays.ElementAt(2);

            for (int i = 0; i < 102; i++)
            {
                /*The result is rounded because after about 10 digits the Solve() method and c# start  
                rounding the decimals in a different way, giving 2 very close but different values.*/
                resultExpected[i] = Math.Round(firstMembers[i]);
            }

            //Testing with zeros
            firstMembers[102] = 0;

            resultExpected[102] = 0;

            //Execution----------------------------------------------------------------------
            double[] resultCalculated = new double[103];
            List<string> opList = new List<string>();
            for (int i = 0; i < 103; i++)
            {
                opList.Clear();
                opList.Add("round(");
                opList.Add(firstMembers[i].ToString() + ", 0)");
                resultCalculated[i] = Calculation.Solve(opList);
            }
            //Check----------------------------------------------------------------------------
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }

        #endregion

        #region trigonometry


        [TestMethod()]
        public void SolveTestSine()
        {
            //Data preparation-----------------------------------------------------------------
            List<double[]> lstArrays = CreateRandomArrays();
            double[] firstMembers = lstArrays.ElementAt(0);
            double[] resultExpected = lstArrays.ElementAt(2);

            for (int i = 0; i < 102; i++)
            {
                /*The result is rounded because after about 10 digits the Solve() method and c# start  
                rounding the decimals in a different way, giving 2 very close but different values.*/
                resultExpected[i] = Math.Round((Math.Sin(firstMembers[i]*Math.PI/180)), 5);
            }

            //Testing with zeros
            firstMembers[102] = 0;

            resultExpected[102] = 0;

            //Execution----------------------------------------------------------------------
            double[] resultCalculated = new double[103];
            List<string> opList = new List<string>();
            for (int i = 0; i < 103; i++)
            {
                opList.Clear();
                opList.Add(" sin(rad(");
                opList.Add(firstMembers[i].ToString() + "))");
                resultCalculated[i] = Math.Round(Calculation.Solve(opList), 5);
            }
            //Check----------------------------------------------------------------------------
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }

        [TestMethod()]
        public void SolveTestCosine()
        {
            //Data preparation-----------------------------------------------------------------
            List<double[]> lstArrays = CreateRandomArrays();
            double[] firstMembers = lstArrays.ElementAt(0);
            double[] resultExpected = lstArrays.ElementAt(2);

            for (int i = 0; i < 102; i++)
            {
                /*The result is rounded because after about 10 digits the Solve() method and c# start  
                rounding the decimals in a different way, giving 2 very close but different values.*/
                resultExpected[i] = Math.Round(Math.Cos(firstMembers[i]*Math.PI/180), 5);
            }

            //Testing with zeros
            firstMembers[102] = 0;

            resultExpected[102] = 1;

            //Execution----------------------------------------------------------------------
            double[] resultCalculated = new double[103];
            List<string> opList = new List<string>();
            for (int i = 0; i < 103; i++)
            {
                opList.Clear();
                opList.Add(" cos(rad(");
                opList.Add(firstMembers[i].ToString() + "))");
                resultCalculated[i] = Math.Round(Calculation.Solve(opList), 5);
            }
            //Check----------------------------------------------------------------------------
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }

        [TestMethod()]
        public void SolveTestTangent()
        {
            //Data preparation-----------------------------------------------------------------
            List<double[]> lstArrays = CreateRandomArrays();
            double[] firstMembers = lstArrays.ElementAt(0);
            double[] resultExpected = lstArrays.ElementAt(2);

            for (int i = 0; i < 102; i++)
            {
                /*The result is rounded because after about 10 digits the Solve() method and c# start  
                rounding the decimals in a different way, giving 2 very close but different values.*/
                resultExpected[i] = Math.Round(Math.Tan(firstMembers[i]*Math.PI/180), 5);
            }

            //Testing with zeros
            firstMembers[102] = 0;

            resultExpected[102] = 0;

            //Execution----------------------------------------------------------------------
            double[] resultCalculated = new double[103];
            List<string> opList = new List<string>();
            for (int i = 0; i < 103; i++)
            {
                opList.Clear();
                opList.Add(" tan(rad(");
                opList.Add(firstMembers[i].ToString() + "))");
                resultCalculated[i] = Math.Round(Calculation.Solve(opList), 5);
            }
            //Check----------------------------------------------------------------------------
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }

        [TestMethod()]
        public void SolveTestInverseSine()
        {
            //Data preparation-----------------------------------------------------------------
            List<double[]> lstArrays = CreateRandomArrays();
            double[] firstMembers = lstArrays.ElementAt(0);
            double[] resultExpected = lstArrays.ElementAt(2);

            for (int i = 0; i < 102; i++)
            {
                /*The result is rounded because after about 10 digits the Solve() method and c# start  
                rounding the decimals in a different way, giving 2 very close but different values.*/
                resultExpected[i] = Math.Round(Math.Asin(firstMembers[i])*180/Math.PI, 5);
            }

            //Testing with zeros
            firstMembers[102] = 0;

            resultExpected[102] = 0;

            //Execution----------------------------------------------------------------------
            double[] resultCalculated = new double[103];
            List<string> opList = new List<string>();
            for (int i = 0; i < 103; i++)
            {
                opList.Clear();
                opList.Add(" deg(asin(");
                opList.Add(firstMembers[i].ToString() + "))");
                resultCalculated[i] = Math.Round(Calculation.Solve(opList), 5);
            }
            //Check----------------------------------------------------------------------------
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }

        [TestMethod()]
        public void SolveTestInverseCosine()
        {
            //Data preparation-----------------------------------------------------------------
            List<double[]> lstArrays = CreateRandomArrays();
            double[] firstMembers = lstArrays.ElementAt(0);
            double[] resultExpected = lstArrays.ElementAt(2);

            for (int i = 0; i < 102; i++)
            {
                /*The result is rounded because after about 10 digits the Solve() method and c# start  
                rounding the decimals in a different way, giving 2 very close but different values.*/
                resultExpected[i] = Math.Round(Math.Acos(firstMembers[i])*180/Math.PI, 5);
            }

            //Testing with zeros
            firstMembers[102] = 0;

            resultExpected[102] = 90;

            //Execution------------------------------------------------------------------------
            double[] resultCalculated = new double[103];
            List<string> opList = new List<string>();
            for (int i = 0; i < 103; i++)
            {
                opList.Clear();
                opList.Add(" deg(acos(");
                opList.Add(firstMembers[i].ToString() + "))");
                resultCalculated[i] = Math.Round(Calculation.Solve(opList), 5);
            }
            //Check----------------------------------------------------------------------------
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }

        [TestMethod()]
        public void SolveTestInverseTangent()
        {
            //Data preparation-----------------------------------------------------------------
            List<double[]> lstArrays = CreateRandomArrays();
            double[] firstMembers = lstArrays.ElementAt(0);
            double[] resultExpected = lstArrays.ElementAt(2);

            for (int i = 0; i < 102; i++)
            {
                /*The result is rounded because after about 10 digits the Solve() method and c# start  
                rounding the decimals in a different way, giving 2 very close but different values.*/
                resultExpected[i] = Math.Round(Math.Atan(firstMembers[i])*180/Math.PI, 5);
            }

            //Testing with zeros
            firstMembers[102] = 0;

            resultExpected[102] = 0;

            //Execution----------------------------------------------------------------------
            double[] resultCalculated = new double[103];
            List<string> opList = new List<string>();
            for (int i = 0; i < 103; i++)
            {
                opList.Clear();
                opList.Add(" deg(atan(");
                opList.Add(firstMembers[i].ToString() + "))");
                resultCalculated[i] = Math.Round(Calculation.Solve(opList), 5);
            }
            //Check----------------------------------------------------------------------------
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }

        #endregion

        #region complex operations

        /// <summary>
        /// only the medium int, medium double and small double are taken in this test, because bigger values would create numbers that are too high for the system
        /// </summary>
        [TestMethod()]
        public void SolveTestSquare()
        {
            //Data preparation---------------------------------------------------------------
            List<double[]> lstArrays = CreateRandomArrays();

            double[] firstMembers = new double[61];
            double[] resultExpected = new double[61];

            for (int i = 0; i < 60; i++)
            {
                firstMembers[i] = lstArrays.ElementAt(0)[i];
                resultExpected[i] = lstArrays.ElementAt(2)[i];
            }

            for (int i = 0; i < 60; i++)
            {
                resultExpected[i] = Math.Round(Math.Pow(firstMembers[i], 2), 5);
            }

            //Testing with zeros
            firstMembers[60] = 0;

            resultExpected[60] = 0;

            //Execution----------------------------------------------------------------------
            double[] resultCalculated = new double[61];
            List<string> opList = new List<string>();
            for (int i = 0; i < 61; i++)
            {
                opList.Clear();
                opList.Add("(" + firstMembers[i] + ")^2");
                resultCalculated[i] = Math.Round(Calculation.Solve(opList), 5);
            }
            //Check----------------------------------------------------------------------------
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }


        #endregion
    }
}