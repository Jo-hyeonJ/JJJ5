using System;
using System.ComponentModel.Design;

namespace JJJ5
{
    internal class Program
    {
    
        // void : 없다, 반환형이 없음, 정의되지 않다.
        static void SayHello()
        {
            Console.WriteLine("Hello");
        }

        // 함수를 정의한다.
        static void ShowCircleRound(float radius)
        {
            float circleRound = radius * 2f * 3.1415f;
            Console.WriteLine($"원의 둘레는 {circleRound}");
        }

        // 반환형이 있는 함수 : 10을 반환하는 함수

        static int GetNum()
        {
            return 10;
        }
        
        // 함수의 오버로딩
        // 함수는 함수명과 매개변수로 구분된다.
        // 따라서 동명의 함수라도 매개 변수가 다르다면 서로 구분된다. 
        static int Sum(int a, int b) // int 2개를 매개 변수로 받는 함수
        {
            return a + b; // a와 b의 값을 더한 뒤에 반환한다.
        }
        static int Sum(int a, int b, int c) // int 3개를 매개 변수로 받는 함수
        {
            return a+b + c;
        }

        static string Buy(int money)
        {
            Console.WriteLine($"투입 금액 : {money}");
            Console.WriteLine("1. 콜라(1200), 2. 물(1000), 3. 커피(1500)");
            Console.WriteLine("0. 나가기");
            string drink = string.Empty;
            int select = 0;

            // do-while문 : 내용을 실행한 후 조건식을 확인해 반복시킨다.
            do
            {
                Console.Write("선택 : ");
                select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 0:
                        Console.WriteLine("종료합니다");
                        break;
                    case 1:
                        if (money < 1200)
                        {
                            Console.WriteLine("돈이 부족합니다.");
                            break;
                        }
                        drink = "콜라";
                        break;
                    case 2:
                        if (money < 1000)
                        {
                            Console.WriteLine("돈이 부족합니다.");
                            break;
                        }
                        drink = "물";
                        break;
                    case 3:
                        if (money < 1500)
                        {
                            Console.WriteLine("돈이 부족합니다.");
                            break;
                        }
                        drink = "커피";
                        break;
                    default:
                        {
                            Console.WriteLine("잘못된 선택입니다");
                        }
                        break;
                }
            }
            while (drink == string.Empty&& select != 0);
            return drink; // 리턴문을 만나면 값을 반환하고 함수는 끝이난다.
        }

        // Q. 어떤 수의 제곱수를 반환하는 함수를 만들어보자.

        // int형 값을 매개변수로 받아서 int형 값을 반환하는 함수다.
        static int Square(int x)
        {
            return x * x;
        }

        // Q. 함수를 호출하면 "Monday"를 출력하는 함수
        // 반환형이 없고 매개변수가 없는 함수
        static void MM()
        {
            Console.WriteLine("Monday");
        }

        // Q. 입력 값의 홀짝을 반환하는 함수

        static bool IsEven(int number) // 이 값은 짝수가 맞는가?
        {
            return number % 2 == 0;
        }

        static void Sniffle(int x)
        {
            int check = x % 2;
            if (check == 0)
            {
                Console.WriteLine($"{x}는 짝수입니다.");
            }
            else if (check == 1)
            {
                Console.WriteLine($"{x}는 홀수입니다.");
            }
        }



        // Q. 과일 가게에서 사과를 산다고 생각해보자
        // 사과의 가격은 1개당 1000원이라고 했을 때
        // 내가 돈을 내면 최대로 살 수 있는 사과의 개수를 반환하는 함수

        static int Apple(int money)
        {
            int apple;
            apple = money / 1000;

            return apple;

        }

        static void Damage(int damage)
        {
            Console.WriteLine($"{damage}를 받음");
        }

        static void Damage(int damage, float ratio)
        {
            int fianlDamage = (int)(damage * ratio);
            Damage(fianlDamage);
        }

        // 디폴트 매개변수 : 매개변수의 기본값
        // Func함수를 호출하면서 매개변수를 전달하지 않으면 count는 100이다.
        static void Func(int count = 100)
        {
            Console.WriteLine($"Func : {count}");
        }


        static void Main(string[] args)
        {
            // 1교시
            #region
            /*
               // 메소드 (함수)
               // = 어떠한 일련의 동작.

               // 한정자 반환형식 함수명 (매개변수 목록)
               // 실행 코드
               // return 결과


               // 반지름을 주면 원의 둘레를 계산해서 출력한다고 생각해보자

               float radius = 0f;
               Console.Write("반지름 : ");
               radius = float.Parse(Console.ReadLine());
               Console.WriteLine($"원의 둘레는 : {radius * 2f * 3.1415f}");

               ShowCircleRound(3f);
               ShowCircleRound(4f);
               ShowCircleRound(5f);

               SayHello();
               int num2 = GetNum();
               Console.WriteLine(num2);

               string drink = Buy(200);
               if (drink != string.Empty)
               {
                   Console.WriteLine($"{drink}를 구매했다.");
               }
            */
            #endregion

            #region
            /*  Console.WriteLine("1. 월요일 출력하기");
              MM();

              Console.WriteLine("2. 입력값 홀짝 알아보기");
              Console.Write("입력 : ");
              int A = int.Parse(Console.ReadLine());
              Sniffle(A);
              Console.WriteLine($"15는 짝수인가? : {IsEven(15)}");

              Console.WriteLine("3. 입력값 제곱하기");
              Console.Write("입력 : ");
              int B = int.Parse(Console.ReadLine());
              Console.WriteLine($"{B}의 제곱 값은 {Square(B)}입니다.");

              Console.WriteLine("4. 1000원짜리 사과 몇개 살 수 있는지");
              Console.Write("가진 돈 입력 : ");
              int C = int.Parse(Console.ReadLine());

              Console.WriteLine($"{C}원으로 살 수 있는 사과의 개수는 : {Apple(C)}개 이다.");
  */
            #endregion

            Func();

            
        }
    }
}