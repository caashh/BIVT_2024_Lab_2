using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(0.9, 1.23);
        //program.Task_1_2(0.9, 1.23);
        //program.Task_1_3(0.9, 1.23);
        //program.Task_1_4(0.9, 1.23, -0.1);
        //program.Task_1_5(0.9, 1.23);
        //program.Task_1_6(0.9, 1.23);
        //program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_1_9(0.9);
        //program.Task_1_10(0.9);
        //program.Task_2_1(10);
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 2);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(10);
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(10);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(1.2, 0.2, -4);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        //program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;
        double r = 2;

        if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10,-3))
        {
            answer = true;
        }

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        if (y >= 0 && y + Math.Abs(x) <= 1)
        {
            answer = true;
        }

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        if (a > 0)
        {
            if (a > b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }
        }
        if (a <= 0)
        {
            if (a < b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }
        }
        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        if (a < b)
        {
            answer = a;
        }
        else
        {
            answer = b;
        }

        if (answer > c)
        {
            answer = answer;
        }
        else
        {
            answer = c;
        }

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        double diam = Math.Sqrt(r / double.Pi) * 2;
        double diag = Math.Sqrt(s) * Math.Sqrt(2);
        if (diam >= diag)
        {
            answer = true;
        }

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        double diam = Math.Sqrt(r / double.Pi) * 2;
        double st = Math.Sqrt(s);
        if (diam <= st)
        {
            answer = true;
        }

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        if (Math.Abs(x) > 1)
        {
            answer = 1;
        }
        else
        {
            answer = Math.Abs(x);
        }

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        if (Math.Abs(x) >= 1)
        {
            answer = 0;
        }
        else
        {
            answer = x * x - 1;
        }

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        if (x <= -1)
        {
            answer = 0;
        }
        if (-1 < x & x <= 0)
        {
            answer = x + 1;
        }
        if (x > 0)
        {
            answer = 1;
        }
        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;


        if (x <= -1)
        {
            answer = 1;
        }
        if (-1 < x & x <= 1)
        {
            answer = -x;
        }
        if (x > 1)
        {
            answer = -1;
        }

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        double sumrost = 0;

        for (int i = 0; i < n; i++)
        {
            sumrost += double.Parse(Console.ReadLine());
        }
        answer = sumrost / n;
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (((y - b) * (y - b) + (x - a) * (x - a)) < (r * r))
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        for (int i = 0; i < n; i++)
        {
            if (double.Parse(Console.ReadLine()) < 30)
            {
                answer += 0.2;
            }
        }

        Console.WriteLine(answer);
            return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((y * y + x * x) < (r2 * r2) && (y * y + x * x) > (r1 * r1))
            {
                answer++;
            }
        }
        Console.WriteLine(answer);

        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            if ((double.Parse(Console.ReadLine()) <= norm))
            {
                answer++;
            }
        }

        Console.WriteLine(answer);
            return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (y > 0 && y < Math.Sin(x) && x > 0 && x < Math.PI)
            {
                answer++;
            }
        }

            return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("1");
                answer1++;
            }
            else if (x <= 0 && y >= 0)
            {
                Console.WriteLine("2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("3");
                answer3++;
            }
            else
            {
                Console.WriteLine("4");
            }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        

            return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            
            if (answerLength > Math.Sqrt(x * x + y * y))
            {
                answerLength = Math.Sqrt(x * x + y * y);
                answer = i + 1;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);


    

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        for (int i = 0; i < n; i++)
        {
            double result = double.Parse(Console.ReadLine());
            if (answer > result)
            {
                answer = result;
            }
        }

            return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        for (int i = 0; i < n * 4; i++)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());
            int a4 = int.Parse(Console.ReadLine());
            if (a1 > 3 &&  a2 > 3 && a3 > 3 && a4 > 3)
            {
                answer++;
            } 
        }

            return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        for (int i = 0; i < n * 4; i++)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());
            int a4 = int.Parse(Console.ReadLine());
            avg = avg + a1 + a2 + a3 + a4;
            bool a = (a1 > 2 && a2 > 2 && a3 > 2 && a4 > 2);
            if (a == false)
            {
                answer++;
            }
        }
        avg = avg / (n * 4);

            return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        if (r < 0)
        {
            return 0;
        }

        switch (type)
        {
            case 0:
                answer = Math.Round(r * r, 2); break;
            case 1:
                answer = Math.Round(r * r * Math.PI, 2); break;
            case 2:
                answer = Math.Round(r * r * Math.Sqrt(3) / 4, 2); break;
            default:
                return 0;
        }

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        if (A <= 0 || B <= 0)
        {
            return 0;
        }
        switch (type)
        {
            case 0:
                answer = Math.Round(A * B, 2); break;
            case 1:
                answer = Math.Round(Math.PI * Math.Abs(A * A - B * B), 2); break;
            case 2:
                answer = Math.Round(A / 2 * Math.Sqrt(B * B - A * A / 4), 2); break;
            default:
                return 0;
        }
        Console.WriteLine(answer);
        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;
        
        // code here

        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;
        double r = 0;
        while (double.TryParse(Console.ReadLine(), out r))
        {
            if (r < 30)
            {
                answer += 0.2;
            }
        }
        Console.WriteLine(answer);

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;
        double x = 0, y = 0;

        while (double.TryParse(Console.ReadLine(), out x) && double.TryParse(Console.ReadLine(), out y))
        {
            if (y > 0 && y < Math.Sin(x) && x > 0 && x < Math.PI)
            {
                answer ++;
            }
        }
        Console.WriteLine(answer);

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_7 answer

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_8 answer

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;
        double result = 0;

        while (double.TryParse(Console.ReadLine(), out result))
        {
            if (answer > result)
            {
                answer = result;
            }
        }
        Console.WriteLine(answer);

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_11 answer

        return (answer, avg);
    }
    public double Task_3_12(double r, int type)
    {
        double answer = 0;

        // code here;

        // end
        // answer should be equal to the task_2_12 answer

        return answer;
    }
    public double Task_3_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;

        // end
        // answer should be equal to the task_2_13 answer

        return answer;
    }
    #endregion
}
