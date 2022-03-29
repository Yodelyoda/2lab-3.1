using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab_3._2
{
    class Program
    {
        public enum Spec { KOMPNAUK, INFORMAT, MATEM };

        public string specStr[] = {"«Комп’ютерні науки»", "«Інформатика»", "«Математика»"};
        public struct Student
        {
            public string prizv;
            public int kurs;
            public int spec;
            public int FIZrate;
            public int MATrate;
            public int PROGrate;
        };

    static void Main(string[] args)
        {
        Console.OutputEncoding = Encoding.Default;
        Console.Write("Введіть N: ");
        int N = Convert.ToInt32(Console.ReadLine()); 

        Student p = Create(N);
        Print(p, N);

            for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Середній бал для " + i + " студента: " + AverageMark(p, N, i));
        }
        Console.WriteLine();
        Console.WriteLine("Найбільший середній бал: " + MaxAverageMark(p, N));
        Console.WriteLine("Процент студентів, які отримали з фізики оцінки 4 або 5: " + Proc(p, N) + "%");
        Console.WriteLine();
        }
        static Student Create(int N)
        {
            Student p = new Student();
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Студент № " + i + ":");
                Console.Write("Прізвище студента: ");
                p.prizv = Console.ReadLine();
                Console.Write("Курс: ");
                p.kurs = Convert.ToUInt32(Console.ReadLine());
                Console.Write("спеціальність (0 - математика, 1 - інформатика, 2 - комп'ютерні науки): ");
                p.spec = Convert.ToInt32(Console.ReadLine());
                Console.Write("Оцінки з фізики: ");
                p.FIZrate = Convert.ToInt32(Console.ReadLine());
                Console.Write("Оцінки з математики: ");
                p.MATrate = Convert.ToInt32(Console.ReadLine());
                Console.Write("Оцінки з програмування: ");
                p.PROGrate = Convert.ToInt32(Console.ReadLine());
            }
            return p;
        }
        static void Print(Student p, int N)
        {
            Console.WriteLine("====================================================================================================================");
            Console.WriteLine("| № | Прізвище студента |  Курс |   Спеціальність  | Фізики | Математики | Програмування |");
            for (int i = 0; i < N; i++)
            {
                Console.Write("| " + " " + i + " ");
                Console.Write("| " + " " + p.prizv + " ");
                Console.Write("| " + " " + p.kurs + " ");
                Console.Write("| " + " " + specStr[p.spec] + " ");
                Console.Write("| " + " " + p.FIZrate + " ");
                Console.Write("| " + " " + p.MATrate + " ");
                Console.Write("| " + " " + p.PROGrate + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("====================================================================================================================");
            Console.WriteLine();
        }
        static int AverageMark(Student p, int N, int i)
        {
            int sum = p.FIZrate + p.MATrate + p.PROGrate;
            return sum / 3;
        }
        static int MaxAverageMark(Student p, int N)
        {
            int max = 0;
            for (int i = 0; i < N; i++)
            {
                int sum = p.FIZrate + p.MATrate + p.PROGrate;
                int average = sum / 3;

                if (average > max)
                    max = average;
            }
            return max;
        }
        static int Proc(Student p, int N)
        {
         
            int kilk = 0;
            for (int i = 0; i < N; i++)
            {
                if (p.FIZrate == 4 || p.FIZrate == 5)
                    kilk++;
            }
            kilk = (kilk * 100) / N;
            return kilk;
        }
    }
}


  