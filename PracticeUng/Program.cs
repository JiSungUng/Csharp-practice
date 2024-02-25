﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Console.WriteLine("Test");

            https://blog.hexabrain.net/135

            Ctrl + S: 현재 파일 저장
            Ctrl + C: 복사
            Ctrl + X: 잘라내기
            Ctrl + V: 붙여넣기
            Ctrl + Z: 실행 취소
            Ctrl + Y: 다시 실행
            Ctrl + F: 찾기
            Ctrl + H: 찾기 및 바꾸기
            Ctrl + D: 현재 선택과 일치하는 다음 항목 찾기
            Ctrl + Shift + L: 현재 줄 삭제
          
            디버깅 단축키
            F5: 디버깅 시작
            F9: 중단점 설정/해제
            F10: 한 단계씩 코드 실행(단계별 실행)
            F11: 함수 호출 내부로 들어가기(단계별 실행)
            Shift + F11: 함수 호출 빠져나오기(단계별 실행)
            
             
             
            byte a = 200;
            sbyte b = -126;
            short c = 30000;
            ushort d = 40000;
            int e = 100000000;
            uint f = 1000000000;
            long g = 1000000000000000000;
            ulong h = 10000000000000000000;

            Console.WriteLine("a={0}, b={1}, c={2}, 
            d={3}, e={4}, f={5}, g={6}, h={7}", a, b, c, d, e, f, g, h);
            char a = '안';
            string b = "녕하세요";

            Console.WriteLine("{0}{1}", a, b);
            // 문자는 '' -> 작은따옴표
            // 문자열은 " " -> 큰따옴표
             
            int a = 12345;
            Console.WriteLine("|{0,15}|", a);       // |     12345|
            Console.WriteLine("|{0,-15}|", a);      // |12345     |
            Console.WriteLine("|{0,15:N0}|", a);    // |     12,345|
            Console.WriteLine("|{0,-15:N0}|", a);   // |12,345     | 

            int a = 500;
            float b = a; // 암시적 변환으로 별도의 구문이 필요하지 않음 

            Console.WriteLine("a={0}, b={1}", a, b);

            double c = 123.45;
            int d = (int)c;

            Console.WriteLine("c={0}, d={1}", c, d);

            int a = 500;
            float b = 60.44f;
            string c = a.ToString();
            string d = b.ToString();

            Console.WriteLine("a={0}, b={1}, c={2}, d={3}", a, b, c, d);

            string e = "123";
            string f = "123.456";
            int g = int.Parse(e);
            float h = float.Parse(f);

            Console.WriteLine("e={0}, f={1}, g={2}, h={3}", e, f, g, h);
           
            
            const int a = 50;

            a = 60; // 오류 발생!

            Console.WriteLine(a);
            int num = 1;

            do
            {
                Console.WriteLine("num: {0}", num++);
            } while (num <= 10); // 마지막 세미콜론;

            int[] arr = { 1, 2, 5, 7, 4, 9, 8, 10, 4, 7, 11 };

            foreach (int i in arr)
                Console.WriteLine("i: {0}", i);

            int sum = 0;

            while (true)
            {
                Console.Write("수를 입력하세요: ");
                string line = Console.ReadLine(); // 값을 입력받는 부분!
                if (line == "end") break; // end가 입력되면 무한 루프를 빠져나온다.
                sum += int.Parse(line); // 문자열을 숫자로 변환한다!
            }

            Console.WriteLine("지금까지 입력된 수를 모두 더합니다: " + sum);

            Console.WriteLine("{0}", Division(40, 10));
             */



        }

        static int Division(int a, int b)
        {
            return a / b;
        }

    }
}
