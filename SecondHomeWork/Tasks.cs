using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomeWork
{
    class Tasks
    {
        //Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.

        public static string Exercise1(float A, float B)
        {
            float rezult = 0;

            string Message = "";

            if (A == B)
            {
                rezult = A * B;

                Message = $"При A = B , A * B = {rezult}";
            }
            else if (A > B)
            {
                rezult = A + B;

                Message = $"При A > B , A + B = {rezult}";
            }
            else
            {
                rezult = A - B;

                Message = $"При A < B , A - B = {rezult}";
            }

            return Message;
        }

        //Пользователь вводит 2 числа(X и Y). Определить какой четверти принадлежит точка с координатами(X, Y)

        public static string Exercise2(float X, float Y)
        {
            
            string Message = "";
            
            if (X==0)
            {
                if (Y>0)
                {
                    Message = $"Точка с координатами ( {X} : {Y} ), лежит на верхней части оси Y";
                }
                else if (Y==0)
                {
                    Message = $"Точка с координатами ( {X} : {Y} ), лежит на начальной точке оси координат";
                }
                else
                {
                    Message = $"Точка с координатами ( {X} : {Y} ), лежит на нижней части оси Y";
                }
            }
            else if (X > 0)
            {
                if (Y==0)
                {
                    Message = $"Точка с координатами ( {X} : {Y} ), лежит на правой части оси X";
                }
                else if (Y>0)
                {
                    Message = $"Точка с координатами ( {X} : {Y} ), лежит на I четверти оси координат";
                }
                else
                {
                    Message = $"Точка с координатами ( {X} : {Y} ), лежит на IV четверти оси координат";
                }
            }
            else
            {
                if (Y == 0)
                {
                    Message = $"Точка с координатами ( {X} : {Y} ), лежит на леовой части оси X";
                }
                else if (Y > 0)
                {
                    Message = $"Точка с координатами ( {X} : {Y} ), лежит на II четверти оси координат";
                }
                else
                {
                    Message = $"Точка с координатами ( {X} : {Y} ), лежит на III четверти оси координат";
                }
            }
            return Message;
        }

        //Пользователь вводит 3 числа(A, B и С). Выведите их в консоль в порядке возрастания.
        public static string Exercise3 (float A, float B, float C)
        {
            string Message = "";

            if (A == B && B == C)
            {
                Message = A + " " + B + " " + C;
            }
            else if ((A == B || A == C) && (A > C || A > B))
            {
                if (A == B)
                {
                    Message = A + " " + B + " " + C;
                }
                else
                {
                    Message = A + " " + C + " " + B;
                }
            }
            else if ( ( B == C ) && ( ( B > A ) || ( B < A ) ) )
            {
                if ( B > A )
                {
                    Message = B + " " + C + " " + A;
                }
                else
                {
                    Message = A + " " + B + " " + C;
                }
            }
            else if ((A > B) && ((B > C) || ((B < C) && (A > C))))
            {
                if ( B > C )
                {
                    Message = A + " " + B + " " + C;
                }
                else
                {
                    Message = A + " " + C + " " + B;
                }
            }
            else if ((B > A) && ((A > C) || ((A < C) && (B > C))))
            {
                if ( A > C )
                {
                    Message = B + " " + A + " " + C;
                }
                else
                {
                    Message = B + " " + C + " " + A;
                }
            }
            else
            {
                if ( B > A )
                {
                    Message = C + " " + B + " " + A;
                }
                else
                {
                    Message = C + " " + A + " " + B;
                }
            }

            return Message;
        }

        //Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AXX+BX+C=0.
        public static string Exercise4(float A, float B, float C)
        {
            string Message = "";

            double X, X1, X2, D;

            D = B * B - 4 * A * C;

            if (D < 0)
            {
                Message = $" Нет решения для уравнения {A}*X*X + {B}*X + {C} = 0 , т.к. дескриминант = {D} меньше 0 ";
            }
            else if (D == 0)
            {
                X = -B / 2 * A;
                Message = $" Для уравнения {A}*X*X + {B}*X + {C} = 0, при дескриминанте равном нулю решением для уравнения будет X={X} ";
            }
            else
            {
                X1 = (-B + Math.Sqrt(D)) / 2 * A;
                X2 = (-B - Math.Sqrt(D)) / 2 * A;
                Message = $" Для уравнения {A}*X*X + {B}*X + {C} = 0,  решением для уравнения будет X1={X1} и X2={X2} ";
            }

            return Message;
        }

        //Пользователь вводит двузначное число.Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.
        public static string Exercise5(int A)
        {
            string Message = "";

            int des = 0, ed = 0;

            des = A / 10;
            ed = A % 10;

            if (A > 99 || A < 10)
            {
               Message = "Необходимо двухзначное число большее 10 и меньшее 99";
            }

            switch (A)
            {
                case 10:
                    Message = "Десять";
                    break;
                case 11:
                    Message = "Одинадцать";
                    break;
                case 12:
                    Message = "Двенадцать";
                    break;
                case 13:
                    Message = "Тринадцать";
                    break;
                case 14:
                    Message = "Четырнадцать";
                    break;
                case 15:
                    Message = "Пятнадцать";
                    break;
                case 16:
                    Message = "Шестнадцать";
                    break;
                case 17:
                    Message = "Семнадцать";
                    break;
                case 18:
                    Message = "Восемндацать";
                    break;
                case 19:
                    Message = "Девятнадцать";
                    break;
            }

            switch (des)
            {
                case 20:
                    Message = "Двадцать";
                    break;
                case 30:
                    Message = "Тридцать";
                    break;
                case 40:
                    Message = "Сорок";
                    break;
                case 50:
                    Message = "Пятьдесят";
                    break;
                case 60:
                    Message = "Шестьдесят";
                    break;
                case 70:
                    Message = "Семь";
                    break;
                case 80:
                    Message = "Восемьдесят";
                    break;
                case 90:
                    Message = "Девяносто";
                    break;

            }

            switch (ed)
            {
                case 1:
                    Message = Message + " Один";
                    break;
                case 2:
                    Message = Message + " Два";
                    break;
                case 3:
                    Message = Message + " Три";
                    break;
                case 4:
                    Message = Message + " Четыре";
                    break;
                case 5:
                    Message = Message + " Пять";
                    break;
                case 6:
                    Message = Message + " Шесть";
                    break;
                case 7:
                    Message = Message + " Семь";
                    break;
                case 8:
                    Message = Message + " Восемь";
                    break;
                case 9:
                    Message = Message + " Девять";
                    break;
            }

            return Message;
        }
    }
}
