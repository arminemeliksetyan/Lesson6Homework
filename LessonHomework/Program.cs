using System;

namespace LessonHomework
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //string statment = "I Like c#, it is realy hard, but I will do everythig for studing that.";
            //int count = 0;
            //int x = GetCount(statment, count);
            //Console.WriteLine(x);

            //task 219

            //int k = 5;
            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, };
            //for(int i = 0; i < ints.Length; i++)
            //{
            //    if(i % k ==0)
            //    {
            //        Console.WriteLine(ints[i]+" "+i);
            //    }
            //}

            //task 220
            //int negative = 0;
            //int positive = 0;
            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, -14, -15, };
            //for(int i = 0; i < ints.Length; i++)
            //{
            //    if(ints[i] < 0)
            //    {
            //        negative++;
            //    }
            //    else
            //    {
            //        positive++;
            //    }
            //}
            //Console.WriteLine(negative);
            //Console.WriteLine(positive);

            //task 221

            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, };
            //int a = 5, b = 11, sum = 0;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if(a < ints[i] && b > ints[i] ) {
            //        sum += ints[i];
            //    }
            //}
            //Console.WriteLine(sum);

            // task 222

            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, };
            //int a = 5, b = 11, sum = 1;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if(a < ints[i] && b > ints[i])
            //    {
            //        sum *= ints[i];
            //    }
            //}
            //Console.WriteLine(sum);

            //task 223

            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, };
            //int a = 5, b = 11, count = 0;
            //for(int i = 0; i< ints.Length; i++)
            //{
            //    if(a < ints[i] && b < ints[i])
            //    {
            //        count ++;
            //    }
            //}
            //Console.WriteLine(count);

            // task 224

            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 1115, };
            //int t = 100, count = 0;
            //for(int i =0; i< ints.Length; i++)
            //{
            //    if (ints[i]*ints[i] < t)
            //    {
            //        count += ints[i] * ints[i];
            //    }
            //}
            //Console.WriteLine(count);

            //task 226

            //int[] ints = { 111, 22, 333, 4444, 5, 64, 7, 88, 29, 10, 1, 32, 13, 14, 1115, };
            //int t = 100, count = 0;
            //for(int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] < t)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //task 227

            //int[] ints = { 10, 55, 60, 1, 2, 3, 4, 5, 50 };
            //int t = 50, sum = 1, count = 0;
            //for(int i= 1; i<ints.Length; i++)
            //{
            //    if (t % i == 0){
            //        sum += i;
            //        count ++;
            //    }
            //}
            //Console.WriteLine(sum/count);

            //task 228

            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19};
            //int t = 3, sum = 0;
            //for(int i = 0; i < ints.Length; i++)
            //{
            //    if(i % t ==0)
            //    {
            //        sum += ints[i];
            //    }
            //}
            //Console.WriteLine(sum);

            //task 229

            //int[] ints = { 1, 2, 3, 4, -5, -6, 7, 8, 9, 100, 11, 152, 13, 14, -15, 16, 517, 188, 19 };
            //int sum = 1;
            //for(int i = 0 ; i < ints.Length; i++)
            //{
            //    if (ints[i] - i > 0) {
            //        sum *= ints[i];
            //    }
            //}
            //Console.WriteLine(sum);

            //task 231

            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //int sum = 0;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] % 2 == 0)
            //    {
            //        sum += ints[i] * ints[i];
            //    }
            //}
            //Console.WriteLine(sum);

            //task 232

            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //int count = 0;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] % 2 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //task 233

            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //int sum = 0, product = 1;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] % 2 == 0)
            //    {
            //        sum += ints[i];
            //        product *= ints[i];
            //    }
            //}
            //Console.WriteLine(sum + " " + product);

            // task 234

            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //int sum = 0;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] % 2 == 1)
            //    {
            //        sum += ints[i] * ints[i];
            //    }
            //}
            //Console.WriteLine(sum);

            //task 235

            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //int count = 0;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] % 2 == 1)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //task 236

            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //int sum = 0, product = 1;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] % 2 == 1)
            //    {
            //        sum += ints[i];
            //        product *= ints[i];
            //    }
            //}
            //Console.WriteLine(sum + " " + product);

            // task 237


            //int[] ints = { 1, 2, 3, 4, 5, 6,0, 7, 8, 9, 10, 11, 12,0, 13, 14, 15,0, 16, 17, 18, 19 };
            //int count = 0;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);


            //task 238


            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //int sum = 1, count = 0;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] % 3 == 0)
            //    {
            //        sum += ints[i];
            //        count++;
            //            }
            //}
            //Console.WriteLine(sum / count);

            //task 239


            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //int sum = 0, count = 0;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] % 5 == 0)
            //    {
            //        sum += ints[i];
            //        count ++;
            //    }
            //}
            //Console.WriteLine(sum / count);


            // task 240

            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //int count = 0;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);


            // task 241

            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //int k = 4, sum = 0;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] % k == 0)
            //    {
            //        sum += ints[i];
            //    }
            //}
            //Console.WriteLine(sum);


            //task 242


            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //int m = 4, sum = 1;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] % m == 0)
            //    {
            //        sum *= ints[i];
            //    }
            //}
            //Console.WriteLine(sum);

            // task 243


            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //int k = 4, count = 0;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] % k == 0)
            //    {
            //        count ++;
            //    }
            //}
            //Console.WriteLine(count);

            //task 244


            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //int sum = 1;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] % 5 == 2)
            //    {
            //        sum *= ints[i];
            //    }
            //}
            //Console.WriteLine(sum);


            // task 245


            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //int sum = 0;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if ((ints[i] + i) % 3 == 0)
            //    {
            //        sum += ints[i] * ints[i];
            //    }
            //}
            //Console.WriteLine(sum);

            //task 247


            //int[] ints = { 1, 2, 3, 4, -5, 6, 7, 8, -9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //int count = 0, sum = 1;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] > i)
            //    {
            //        sum *= ints[i];
            //        count++;    
            //    }
            //}
            //Console.WriteLine(sum/count);

            //task 251

            //int[] ints = { 1, 2, 3, 4, -5, 6, 7, 8, -9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //int max = ints.Max();
            //Console.WriteLine(max);


            // task 252


            //int[] ints = { -1, 2, 3, 4, -5, 6, 7, 8, -9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //int min = ints.Min();
            //Console.WriteLine(min);


            //task 253


            //int[] ints = { 1, 2, 3, 4, -5, 6, 7, 8, -9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //int max = ints.Max();
            //int min = ints.Min();
            //Console.WriteLine(max+min);

            //task 254


            //int[] ints = { 1, 2, 3, 4, -5, 6, 7, 8, -9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //int max = ints.Max();
            //int min = ints.Min();
            //Console.WriteLine(max * min);

            //task 255


            //int[] ints = { 1, 2, 3, 4, -5, 6, 7, 8, -9, 10, 11, 12, 13, 124, 15, 16, 17, 18, 19 };
            //int max = ints.Max();
            //int maxIndex = ints.ToList().IndexOf(max);
            //Console.WriteLine(max+ maxIndex);


            //task 256


            //int[] ints = { 1, 2, 3, 4, -5, 6, 7, 8, -9, 10, 11, 12, 13, 124, 15, 16, 17, 18, 19 };
            //int min = ints.Min();
            //int minIndex = ints.ToList().IndexOf(min);
            //Console.WriteLine(min + minIndex);

            //task 1 with const and out
            //const int x = 10;
            //const int y = 20;
            //int z = getNumber(x, y, out int number);
            //Console.WriteLine(z);

            //task 2 with const , out

            //const string text = "Please write your name ";
            //string firstName = getName(text, out string name);
            //Console.WriteLine($"Hello {firstName} nice to meet you");

            //task 3 with const , out , ref

            //int y = 25;
            //int sqrt = getSqrt(ref y, out int t);

            //task in , out

            //int z = 75;
            //int count = devidionCount(in z, out int xx);


            //task enum , in , out
            //int time = 15;
            //string cwr = Shift(in time, out string cw);
            //Console.WriteLine(cw);


            //task ashxatavardzayin

            //decimal salary = 1000;
            //decimal ekPracent = 10;
            //decimal kensPracent = 5;
            //string name = "Armine";
            //decimal eksalary = Salary(name,salary, ekPracent, out decimal clearSalary);
            //decimal kensvchar = Salary(eksalary, kensPracent, out decimal clSalary);
            //Console.WriteLine(kensvchar.ToString());



            //task hashvel nmanatip tareri qanaky
            string text = "avs avs avs a";
            for (int i = 0; i < text.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                    {
                        count++;
                    }
                    //text.Remove(j);
                }
                Console.WriteLine("krknvox tarn e " + text[i] + " vory krknvum e " + count + " angam");

            }



        }

        static decimal Salary(string name,decimal salary, decimal ekPracent, out decimal clearSalary)
        {
            clearSalary = salary - ((salary / 100) * ekPracent);
            return clearSalary;
        }
        static decimal Salary(decimal salary, decimal kensVchar, out decimal clSalary)
        {
            clSalary = salary - ((salary / 100) * kensVchar);
            return clSalary;
        }

        static string Shift(in int time, out string cw)
        {
            if (time > (int)Shifts.Morning && time < (int)Shifts.Afternoon)
            {
                cw = "morning";
            }
            else if (time > (int)Shifts.Afternoon && time < (int)Shifts.Nignt)
            {
                cw = "afternoon";
            }
            else if (time < (int)Shifts.Morning)
            {
                cw = "nignt";
            }
            else
            {
                cw = "error";
            }
            return cw;
        }

        enum Shifts
        {
            Morning = 8,
            Afternoon = 16,
            Nignt = 24
        }

        //static int devidionCount(in int z, out int xx)
        //{
        //    if(z % 2 == 0)
        //    {
        //        xx = 1;
        //    }
        //    return xx;
        //}
        static int getSqrt(ref int y, out int t) 
        {
            t = y * y;
            return t;
        }
        static string getName(string text, out string name)
        {
            Console.Write(text);
            name = Console.ReadLine();
            return name;
        }

        static int getNumber(int x, int y, out int number)
        {
            if(x>y)
            {
                number = x;
            }
            else
            {
                number = y;
            }
            return number;

        }

        //static int GetCount(string statment, int count)
        //{
        //    for(int i = 0; i < statment.Length; i++)
        //    {
        //        for(int j = 0; j < statment.Length; j++)
        //        {
        //            if(i == j)
        //            {
        //                count++;
        //            }
        //        }
        //    }
        //    return count;
        //}

        //task 2




    }
}