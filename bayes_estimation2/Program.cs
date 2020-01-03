using fmincon_r;
using fsolve_r1;
using integrate;
using integrate1;
using MathNet.Numerics.Data.Matlab;
using MathNet.Numerics.LinearAlgebra.Double;
using MathWorks.MATLAB.NET.Arrays;
using pre_process;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace bayes_estimation2
{
    class Program
    {
        //调用API函数
        [DllImport("kernel32.dll")]
        extern static short QueryPerformanceCounter(ref long x);
        [DllImport("kernel32.dll")]
        extern static short QueryPerformanceFrequency(ref long x);

        static DenseVector Std_t1(DenseMatrix mat1)
        {
            int row = mat1.RowCount, col = mat1.ColumnCount;
            DenseVector rows = (DenseVector)mat1.ColumnSums();
            rows /= row;
            double rowtmp = 0;

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                    rowtmp += Math.Pow(mat1[j, i] - rows[i], 2);
                rows[i] = Math.Sqrt(rowtmp / (row - 1));
            }
            return rows;
        }

        static void Main()
        {
            Func<double, double> Result = ((double result) => { return Math.Pow(Math.E, -result); });
            Console.WriteLine("...bayes_estimation2 Start!!!...");

            Class_p pre1 = new Class_p();
            MWArray max_m1 = (MWNumericArray)pre1.pre_process();
            f_method fsolve_r1 = new f_method();
            f_method1 fmincon_r = new f_method1();
            Classi integratef = new Classi();
            Classi1 integratef1 = new Classi1();
            MWCharArray str2 = "theta";
            MWCharArray str2f = "n";
            string str1tt = "(theta^" + 0.ToString() + "/factorial(" + 0.ToString() + ")*exp(1)^(-theta))", str1t;

            Console.WriteLine("please assign the number of points you want deal with:");
            int i, j, data_range = int.Parse(Console.ReadLine());

            for (i = 0; i <= data_range; i++)
                str1tt = str1tt + "*" + "(theta^" + i.ToString() + "/factorial(" + i.ToString() + ")*exp(1)^(-theta))";

            string str1ttf = "(theta^n/factorial(n)*exp(1)^(-theta))" + "*" + str1tt;

            double[,] max_m2 = (double[,])max_m1.ToArray();
            var max_m3 = DenseMatrix.OfArray(max_m2);

            int s1 = max_m2.GetLength(0), s2 = max_m2.GetLength(1);

            var result_p = new DenseMatrix((int)Math.Ceiling((double)(s1 / data_range)), s2);
            var result_p1 = new DenseVector(s2);
            double[] std_r;

            long stop_Value = 0, start_Value = 0, freq = 0;

            QueryPerformanceFrequency(ref freq);  //获取CPU频率
            QueryPerformanceCounter(ref start_Value); //获取初始前值

            var count1f = new DenseMatrix((int)Math.Ceiling((double)(s1 / data_range)), s2);
            double[] count1t = new double[s2];
            MathNet.Numerics.LinearAlgebra.Matrix<double> tmp_m1;

            MWArray[] argsOut = new MWArray[3];
            MWArray[] argsOut1 = new MWArray[2];
            MWArray[] argsIn = new MWArray[6];
            MWArray[] argsIn1 = new MWArray[5];
            MWArray[] argsIn1f = new MWArray[4];
            MWArray[] argsOutf1 = new MWArray[1];
            MWArray[] argsIn1f1 = new MWArray[7];
            MWArray[] argsOutf2 = new MWArray[1];
            int exitflag = 0;
            int allmins = 0;

            for (i = 0; i < s2; i++)
            {
                //s2 / data_range???
                for (j = 0; j < (int)Math.Ceiling((double)(s1 / data_range)); j++)
                {
                    int count1 = 0;
                    if ((j + 1) * data_range - 1 > max_m3.RowCount)
                        tmp_m1 = max_m3.SubMatrix(j * data_range, data_range - ((j + 1) * data_range - max_m3.ColumnCount), i, 1);
                    else
                        tmp_m1 = max_m3.SubMatrix(j * data_range, data_range, i, 1);
                    for (int ii = 0; ii < tmp_m1.RowCount; ii++)
                    {
                        for (int jj = 0; jj < tmp_m1.ColumnCount; jj++)
                        {
                            if (Math.Abs(tmp_m1[ii, jj]) > 0.9 * max_m3.SubMatrix(0, max_m3.RowCount, i, 1).Enumerate().Max())
                            {
                                count1++;
                            }
                        }
                    }
                    count1f[j, i] = count1;
                    count1t[i] = count1t[i] + count1;
                }
                count1t[i] = count1t[i] / Math.Ceiling((double)(s1 / data_range));
            }

            for (i = 0; i < s2; i++)
            {
                //s2 / data_range???
                for (j = 0; j < (int)Math.Ceiling((double)(s1 / data_range)); j++)
                {
                    str1t = "theta^" + count1f[j, i].ToString() + "/factorial(" + ((int)Math.Round(count1f[j, i])).ToString() + ")*exp(1)^(-theta)-" + (count1f[j, i] / data_range).ToString();
                    MWCharArray str1 = new MWCharArray(str1t);
                    argsIn[0] = str1;
                    argsIn[1] = str2;
                    argsIn[2] = 1;
                    argsIn[5] = 100;
                    argsOut[0] = result_p[j, i];
                    argsOut[1] = exitflag;
                    argsOut[2] = allmins;
                    if (count1f[j, i] <= count1t[i])
                    {
                        argsIn[3] = 0;
                        argsIn[4] = count1t[i];
                        fsolve_r1.fsolve_r1(3, ref argsOut, argsIn);
                        result_p[j, i] = ((MWNumericArray)argsOut[0]).ToScalarDouble();
                    }
                    else
                    {
                        argsIn[3] = count1t[i];
                        argsIn[4] = data_range;
                        fsolve_r1.fsolve_r1(3, ref argsOut, argsIn);
                        result_p[j, i] = ((MWNumericArray)argsOut[0]).ToScalarDouble();
                    }
                }
            }
            std_r = (double[])Std_t1(result_p);

            for (i = 0; i < s2; i++)
            {
                string str3 = "((1/(sqrt(2*pi)*" + std_r[i].ToString() + "))*exp(((theta-" + count1t[i].ToString() + ")^2)/" + "(-2*" + std_r[i].ToString() + "^2)))";
                str1tt = str1tt + "*" + str3;
                argsIn1f[0] = str1tt;
                argsIn1f[1] = str2;
                argsIn1f[2] = 0;
                argsIn1f[3] = data_range;
                integratef.integrate(1, ref argsOutf1, argsIn1f);
                result_p1[i] = ((MWNumericArray)argsOutf1[0]).ToScalarDouble();
                str1tt = str1tt + "/" + result_p1[i].ToString();
                str1tt = str1tt + "*" + str1ttf + "*" + str2f; ;
                argsIn1f1[0] = str1tt;
                argsIn1f1[1] = str2;
                argsIn1f1[2] = str2f;
                argsIn1f1[3] = 0;
                argsIn1f1[4] = data_range;
                argsIn1f1[5] = 0;
                argsIn1f1[6] = data_range;
                integratef1.integrate1(1, ref argsOutf2, argsIn1f1);
                result_p1[i] = ((MWNumericArray)argsOutf2[0]).ToScalarDouble();
            }

            //for (i = 0; i < s2; i++)
            //{
            //    MWCharArray str1tt1;
            //    //s2 / data_range???
            //    for (j = 0; j < (int)Math.Ceiling((double)(s1 / data_range)); j++)
            //    {
            //        string str3 = "((1/(sqrt(2*pi)*" + std_r[i].ToString() + "))*exp(((theta-" + count1t[i].ToString() + ")^2)/" + "(-2*" + std_r[i].ToString() + "^2)))";
            //        str1tt = str1tt + "*" + str3;
            //        str1tt1 = new MWCharArray(str1tt);                    
            //        argsIn1[0] = str1tt1;
            //        argsIn1[1] = str2;
            //        argsIn1[2] = result_p[j, i];
            //        argsIn1[3] = 0;
            //        argsIn1[4] = data_range;
            //        argsOut1[0] = result_p[j, i];
            //        argsOut1[1] = exitflag;
            //        fmincon_r.fmincon_r(2, ref argsOut1, argsIn1);
            //        result_p[j, i] = Result(((MWNumericArray)argsOut1[0]).ToScalarDouble());                    
            //    }
            //}
            MatlabWriter.Write("result_p1.mat", result_p, "result_p1");
            QueryPerformanceCounter(ref stop_Value);//获取终止变量值
            var times2 = (stop_Value - start_Value) / (double)freq * 1000;
            Console.WriteLine("RunTime " + times2 / 1000 + "s");
        }
    }
}




