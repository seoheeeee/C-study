﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/21
 * 이름 : 이서희
 * 내용 : 델리게이트 실습하기 교재 p493
 * 
 * 대리자(Delegate)
 * - 대리자는 메서드에 대한 참조를 나타내는 형식으로 메서드를 대신 호출 해주는 역할
 * - 대리자를 익명 메서드로 많이 활용한다.
 */
namespace Ch09
{
   //대리자 선언
   public delegate int MyDelegate(int x, int y);
    public delegate int SumDelegate(int[] arr);


    internal class _1_Delegate
    {
       
        static void Main1(string[] args)
        {
            //대리자 초기화(메서드 참조)
            MyDelegate my1 = new MyDelegate(Plus);
            MyDelegate my2 = new MyDelegate(minus);


            //대리자 실행
            int r1 = my1(1, 2);
            int r2 = my2(2, 3);


            Console.WriteLine("r1 : "+r1);
            Console.WriteLine("r2 : "+r2);

            //대리자 활용(메서드의 매개변수로 대리자 선언)
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            int rs1 = Sum(arr, OddSum);//행위(메서드)를 전달하기 위해 대리자 사용
            int rs2 = Sum(arr, EvenSum);

            //대리자를 익명 메서드로 활용(람다식)
            var md = delegate (int x, int y) 
            {
                return x * y;
            };

            int result = md(2, 3);
            Console.WriteLine("result : "+result);

            //익명 메서드를 매개변수로 갖는 컬렉션 메서드
            List<int> dataset = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            dataset.ForEach(delegate (int n) //컬렉션에서는 이렇게 쓰는게 좋다
            {
                Console.Write(n + " ");
            });


            foreach(int n in dataset)
            {
                Console.Write(n+" ");
            }
            
        }

        public static int Plus(int x,int y)
        {
            return x + y;
        }

        public static int minus(int x, int y)
        {
            return x - y;
        }

        public static int OddSum(int[] arr)
        {
            int sum = 0;

            foreach(int n in arr)
            {
                if(n % 2 ==1)
                {
                    sum += n;
                }
            }

            return sum;
        }


        public static int EvenSum(int[] arr)
        {
            int sum = 0;

            foreach (int n in arr)
            {
                if (n % 2 == 0)
                {
                    sum += n;
                }
            }

            return sum;
        }

        public static int Sum(int[] arr,SumDelegate sumDelegate)
        {
            return sumDelegate(arr);
        }
    }
}
