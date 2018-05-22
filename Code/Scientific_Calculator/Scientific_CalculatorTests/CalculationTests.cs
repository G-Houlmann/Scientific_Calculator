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
        /// <summary>
        /// Returns a random integer between 1 and 100
        /// </summary>
        public int RndMediumInt
        {
            get { return rnd.Next(99) + 1; ; }
        }

        /// <summary>
        /// Returns a random double between 0 and 100 rounded to 7 decimals
        /// </summary>
        public double RndMediumDouble
        {
            get { return Math.Round(rnd.NextDouble() * 100, 7); }
        }

        /// <summary>
        /// Returns a random integer between 10000000 and 999999999
        /// </summary>
        public int RndBigInt
        {
            get { return rnd.Next(10000000, 999999999); }
        }

        /// <summary>
        /// Returns a random double between 0 and 10000000, rounded to 7 decimals
        /// </summary>
        public double RndBigDouble
        {
            get { return Math.Round(rnd.NextDouble() * 10000000, 7); }
        }

        /// <summary>
        /// Returns a random double between 0 and 0.001, rounded to 7 decimals
        /// </summary>
        public double RndSmallDouble
        {
            get { return Math.Round(rnd.NextDouble() * 0.001, 7); }
        }


        private List<double[]> CreateRandomArrays()
        {
            //Creating the arrays
            List<double[]> lstArrays = new List<double[]>();
            double[] firstMembers = new double[103];
            double[] secondMembers = new double[103];
            double[] resultExpected = new double[103];

            /*Filling the arrays "firstMembers" and "SecondMembers" with the randomized values.
            Half of them are turned into negative values. 100 out of 103 values are filled here, 
            because the last one or the 3 last ones will be used in the test methods to test 
            what happens when zeros are used.*/
            int i = 0;
            //medium ints
            for (i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    firstMembers[i] = RndMediumInt;
                    secondMembers[i] = RndMediumInt;
                }
                else
                {
                    firstMembers[i] = RndMediumInt * -1;
                    secondMembers[i] = RndMediumInt * -1;
                }
            }

            //medium doubles
            for (i = 20; i < 40; i++)
            {
                if (i % 2 == 0)
                {
                    firstMembers[i] = RndMediumDouble;
                    secondMembers[i] = RndMediumDouble;
                }
                else
                {
                    firstMembers[i] = RndMediumDouble * -1;
                    secondMembers[i] = RndMediumDouble * -1;
                }
            }

            //small double
            for (i = 40; i < 60; i++)
            {
                if (i % 2 == 0)
                {
                    firstMembers[i] = RndSmallDouble;
                    secondMembers[i] = RndSmallDouble;
                }
                else
                {
                    firstMembers[i] = RndSmallDouble * -1;
                    secondMembers[i] = RndSmallDouble * -1;
                }
            }

            //big int
            for (i = 60; i < 80; i++)
            {
                if (i % 2 == 0)
                {
                    firstMembers[i] = RndBigInt;
                    secondMembers[i] = RndBigInt;
                }
                else
                {
                    firstMembers[i] = RndBigInt * -1;
                    secondMembers[i] = RndBigInt * -1;
                }
            }

            //big double
            for (i = 80; i < 102; i++)
            {
                if (i % 2 == 0)
                {
                    firstMembers[i] = RndBigDouble;
                    secondMembers[i] = RndBigDouble;
                }
                else
                {
                    firstMembers[i] = RndBigDouble * -1;
                    secondMembers[i] = RndBigDouble * -1;
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

            for (int i = 0; i < 102; i++)
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

            for (int i = 0; i < 60; i++)
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
                resultExpected[i] = Math.Round((Math.Sin(firstMembers[i] * Math.PI / 180)), 5);
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
                resultExpected[i] = Math.Round(Math.Cos(firstMembers[i] * Math.PI / 180), 5);
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
                resultExpected[i] = Math.Round(Math.Tan(firstMembers[i] * Math.PI / 180), 4);
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
                resultCalculated[i] = Math.Round(Calculation.Solve(opList), 4);
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
                resultExpected[i] = Math.Round(Math.Asin(firstMembers[i]) * 180 / Math.PI, 5);
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
                resultExpected[i] = Math.Round(Math.Acos(firstMembers[i]) * 180 / Math.PI, 5);
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
                resultExpected[i] = Math.Round(Math.Atan(firstMembers[i]) * 180 / Math.PI, 5);
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


        [TestMethod()]
        public void SolveTestSquareRoot()
        {
            //Data preparation-----------------------------------------------------------------
            List<double[]> lstArrays = CreateRandomArrays();
            double[] firstMembers = lstArrays.ElementAt(0);
            double[] resultExpected = lstArrays.ElementAt(2);

            for (int i = 0; i < 102; i++)
            {
                /*The result is rounded because after about 10 digits the Solve() method and c# start  
                rounding the decimals in a different way, giving 2 very close but different values.*/
                resultExpected[i] = Math.Round(Math.Sqrt(firstMembers[i]), 5);
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
                opList.Add(" sqrt(");
                opList.Add(firstMembers[i].ToString() + ")");
                resultCalculated[i] = Math.Round(Calculation.Solve(opList), 5);
            }
            //Check----------------------------------------------------------------------------
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }

        /// <summary>
        /// only the medium int, medium double and small double are taken in this test, because bigger values would create numbers that are too high for the system
        /// </summary>
        [TestMethod()]
        public void SolveTestExponentiation()
        {
            //Data preparation---------------------------------------------------------------
            List<double[]> lstArrays = CreateRandomArrays();

            double[] firstMembers = new double[64];
            double[] secondMembers = new double[64];
            double[] resultExpected = new double[64];

            for (int i = 0; i < 60; i++)
            {
                firstMembers[i] = lstArrays.ElementAt(0)[i];
                secondMembers[i] = lstArrays.ElementAt(1)[i];

                if (firstMembers[i] != (int)firstMembers[i])
                {
                    firstMembers[i] /= 15;
                }
                else
                {
                    firstMembers[i] /= 15;
                    firstMembers[i] = Math.Round(firstMembers[i] + 0.5 * Math.Sign(firstMembers[i]));
                }
                if (secondMembers[i] != (int)secondMembers[i])
                {
                    secondMembers[i] /= 15;
                }
                else
                {
                    secondMembers[i] /= 15;
                    secondMembers[i] = Math.Round(secondMembers[i] + 0.5 * Math.Sign(secondMembers[i]));
                }

                resultExpected[i] = lstArrays.ElementAt(2)[i];
            }

            for (int i = 0; i < 60; i++)
            {
                resultExpected[i] = Math.Round(Math.Pow(firstMembers[i], secondMembers[i]), 4);
            }

            //Testing with zeros
            firstMembers[60] = 0;
            firstMembers[61] = 0;
            firstMembers[62] = 0;
            firstMembers[63] = 12.3;

            secondMembers[60] = 0;
            secondMembers[61] = -5.74;
            secondMembers[62] = 5.74;
            secondMembers[63] = 0;

            resultExpected[60] = 1;
            resultExpected[61] = double.PositiveInfinity;
            resultExpected[62] = 0;
            resultExpected[63] = 1;

            //Execution----------------------------------------------------------------------
            double[] resultCalculated = new double[64];
            List<string> opList = new List<string>();
            for (int i = 0; i < 64; i++)
            {
                opList.Clear();
                opList.Add("(" + firstMembers[i] + ")^" + "(" + secondMembers[i] + ")");
                resultCalculated[i] = Math.Round(Calculation.Solve(opList), 4);
            }
            //Check----------------------------------------------------------------------------
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }

        [TestMethod()]
        public void SolveTestRoot()
        {
            //Data preparation---------------------------------------------------------------
            List<double[]> lstArrays = CreateRandomArrays();

            double[] firstMembers = new double[104];
            double[] secondMembers = new double[104];
            double[] resultExpected = new double[104];

            for (int i = 0; i < 100; i++)
            {
                firstMembers[i] = lstArrays.ElementAt(0)[i];
                secondMembers[i] = Math.Round(lstArrays.ElementAt(1)[i]/10, 3);
                resultExpected[i] = lstArrays.ElementAt(2)[i];
            }

            for (int i = 0; i < 100; i++)
            {
                resultExpected[i] = Math.Round(Math.Pow(firstMembers[i], 1/secondMembers[i]), 3);
            }

            //Testing with zeros
            firstMembers[100] = 0;
            firstMembers[101] = 0;
            firstMembers[102] = 0;
            firstMembers[103] = 12.3;

            secondMembers[100] = 0;
            secondMembers[101] = -5.74;
            secondMembers[102] = 5.74;
            secondMembers[103] = 0;

            resultExpected[100] = 0;
            resultExpected[101] = double.NaN;
            resultExpected[102] = 0;
            resultExpected[103] = double.NaN;

            //Execution----------------------------------------------------------------------
            double[] resultCalculated = new double[104];
            List<string> opList = new List<string>();
            for (int i = 0; i < 104; i++)
            {
                opList.Clear();
                opList.Add("root(" + secondMembers[i] + ", " + firstMembers[i] + ")");
                resultCalculated[i] = Math.Round(Calculation.Solve(opList), 3);
            }
            //Check----------------------------------------------------------------------------
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }

        [TestMethod()]
        public void SolveTestExponential()
        {
            //Data preparation-----------------------------------------------------------------
            List<double[]> lstArrays = CreateRandomArrays();
            double[] firstMembers = lstArrays.ElementAt(0);
            double[] resultExpected = lstArrays.ElementAt(2);

            for (int i = 0; i < 102; i++)
            {
                /*The result is rounded because after about 10 digits the Solve() method and c# start  
                rounding the decimals in a different way, giving 2 very close but different values.*/
                resultExpected[i] = Math.Round(Math.Exp(firstMembers[i]), 5);
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
                opList.Add(" exp(");
                opList.Add(firstMembers[i].ToString() + ")");
                resultCalculated[i] = Math.Round(Calculation.Solve(opList), 5);
            }
            //Check----------------------------------------------------------------------------
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }

        [TestMethod()]
        public void SolveTest10BaseLog()
        {
            //Data preparation-----------------------------------------------------------------
            List<double[]> lstArrays = CreateRandomArrays();
            double[] firstMembers = lstArrays.ElementAt(0);
            double[] resultExpected = lstArrays.ElementAt(2);

            for (int i = 0; i < 102; i++)
            {
                /*The result is rounded because after about 10 digits the Solve() method and c# start  
                rounding the decimals in a different way, giving 2 very close but different values.*/
                resultExpected[i] = Math.Round(Math.Log10(firstMembers[i]), 5);
            }

            //Testing with zeros
            firstMembers[102] = 0;

            resultExpected[102] = double.NegativeInfinity;

            //Execution----------------------------------------------------------------------
            double[] resultCalculated = new double[103];
            List<string> opList = new List<string>();
            for (int i = 0; i < 103; i++)
            {
                opList.Clear();
                opList.Add(" log10(");
                opList.Add(firstMembers[i].ToString() + ")");
                resultCalculated[i] = Math.Round(Calculation.Solve(opList), 5);
            }
            //Check----------------------------------------------------------------------------
            CollectionAssert.AreEquivalent(resultExpected, resultCalculated);
        }



        #endregion
    }
}