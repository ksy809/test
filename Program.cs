using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //코드 2-50
        // var global = 52; -- 지역변수가 아닌 곳에는 var 변수 사용 불가
        static void Main(string[] args)
        {
            // 코드 2-1
            Console.WriteLine("Hello C# Programming .. !");

            // 코드 2-2
            Console.WriteLine(52);

            // 코드 2-3
            // 325를 출력합니다.
            Console.WriteLine(52 + 273);

            // 코드 2-4
            // 결과를 예측해봅시다.
            Console.WriteLine(5 + 3 * 2);

            // 코드 2-5
            Console.WriteLine(10 % 5);
            Console.WriteLine(7 % 3);

            // 코드 2-6
            Console.WriteLine(1 + 2);
            Console.WriteLine(1 - 2);
            Console.WriteLine(1 * 2);
            Console.WriteLine(1 / 2);
            Console.WriteLine(1 % 2);

            // 코드 2-7
            Console.WriteLine(4 % 3);
            Console.WriteLine(-4 % 3);
            Console.WriteLine(4 % -3);
            Console.WriteLine(-4 % -3);

            // 코드 2-8
            Console.WriteLine(52.273);

            // 코드 2-9
            Console.WriteLine(0);
            Console.WriteLine(0.0);

            // 코드 2-10
            Console.WriteLine(1.0 + 2.0);
            Console.WriteLine(1.0 - 2.0);
            Console.WriteLine(1.0 * 2.0);
            Console.WriteLine(1.0 / 2.0);

            // 코드 2-11
            Console.WriteLine(5.0 % 2.2);

            // 코드 2-12
            Console.WriteLine('A');
            Console.WriteLine('가');
            Console.WriteLine('나');

            // 코드 2-13
            Console.WriteLine("안녕하세요");

            // 코드 2-14
            Console.WriteLine("한빛\t아카데미");
            Console.WriteLine("한빛\n아카데미");
            Console.WriteLine("\"\"\"");

            // 코드 2-15
            Console.WriteLine("가나다" + "라마" + "바사아" + "자차카타" + "파하");

            // 코드 2-16
            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("안녕하세요"[1]);
            Console.WriteLine("안녕하세요"[3]);

            // 코드 2-17
            Console.WriteLine("안녕하세요"[100]);

            // 코드 2-18
            Console.WriteLine('가' + '힣');

            // 코드 2-19
            Console.WriteLine(true);
            Console.WriteLine(false);

            // 코드 2-20
            Console.WriteLine(52 < 273);
            Console.WriteLine(52 > 273);

            // 코드 2-21
            Console.WriteLine(!true);
            Console.WriteLine(!false);
            Console.WriteLine(!(52 < 273));
            Console.WriteLine(!(52 > 273));

            // 코드 2-22
            Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
            Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);

            // 코드 2-23
            int a = 273;
            int b = 52;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            // 코드 2-24
            int c = 2147483640;
            int d = 52273;

            Console.WriteLine(c + d);

            // 코드 2-25,26
            int e = 2000000000;
            int f = 1000000000;
            Console.WriteLine(e + f);

            // 코드 2-27
            uint unsignedInt = 4147483647;
            ulong unsignedLong = 11223372036854775808;
            
            Console.WriteLine(unsignedInt);
            Console.WriteLine(unsignedLong);

            // 코드 2-28
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            // 코드 2-29
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            // 코드 2-30
            double g = 52.273;
            double h = 103.32;

            Console.WriteLine(g + h);
            Console.WriteLine(g - h);
            Console.WriteLine(g * h);
            Console.WriteLine(g / h);

            // 코드 2-31
            char i = 'a';
            Console.WriteLine(i);

            // 코드 2-32
            Console.WriteLine("int: " + sizeof(int));
            Console.WriteLine("long: " + sizeof(long));
            Console.WriteLine("float: " + sizeof(float));
            Console.WriteLine("double: " + sizeof(double));
            Console.WriteLine("char: " + sizeof(char));

            // 코드 2-33
            char j = 'a';
            char k = 'b';

            Console.WriteLine(j + k);
            Console.WriteLine(j - k);
            Console.WriteLine(j * k);
            Console.WriteLine(j / k);
            Console.WriteLine(j % k);

            // 코드 2-34
            string message = "안녕하세요";

            Console.WriteLine(message + "!");
            Console.WriteLine(message[0]);
            Console.WriteLine(message[1]);
            Console.WriteLine(message[2]);

            // 코드 2-35
            // Console.WriteLine("string: " + sizeof(string));
            // string 자료형은 sizeof 연산자로 자료형의 크기를 구할 수 없어 오류가 남  -- 그래서 주석처리함

            // 코드 2-36
            bool one = 10 < 0;
            bool other = 20 > 100;

            Console.WriteLine(one);
            Console.WriteLine(other);

            // 코드 2-37
            int output = 0;
            output += 52;
            output += 273;
            output += 103;

            Console.WriteLine(output);

            // 코드 2-38
            int output1 = 0;
            output1 = output1 + 52;
            output1 = output1 + 273;
            output1 = output1 + 103;

            Console.WriteLine(output1);

            // 코드 2-39
            string output3 = "hello ";
            output3 += "world ";
            output3 += "!";

            Console.WriteLine(output3);

            // 코드 2-40
            string output4 = "hello ";
            output4 = output4 + "world ";
            output4 = output4 + "!";

            Console.WriteLine(output4);

            // 코드 2-41
            int number = 10;
            number++;
            Console.WriteLine(number);
            number--;
            Console.WriteLine(number);

            // 코드 2-42(1)
            int number5 = 10;
            Console.WriteLine(number5);
            Console.WriteLine(number5++);
            Console.WriteLine(number5--);
            Console.WriteLine(number5);

            // 코드 2-42(2)
            int number6 = 10;
            Console.WriteLine(number6);
            Console.WriteLine(++number6);
            Console.WriteLine(--number6);
            Console.WriteLine(number6);

            // 코드 2-43
            int number1 = 10;
            Console.WriteLine(number1);
            Console.WriteLine(number1); number1 += 1;
            Console.WriteLine(number1); number1 -= 1;
            Console.WriteLine(number1);

            // 코드 2-44
            int number2 = 10;
            Console.WriteLine(number2++);
            Console.WriteLine(++number2);
            Console.WriteLine(number2--);
            Console.WriteLine(--number2);

            // 코드 2-45
            int number3 = 10;
            Console.WriteLine(number3);
            number3++;
            number3++;
            Console.WriteLine(number3);
            Console.WriteLine(number3);
            number3--;
            number3--;
            Console.WriteLine(number3);

            // 코드 2-46
            // 변수를 선언합니다.
            int _int = 273;
            long _long = 522731033265;
            float _float = 52.273F;
            double _double = 52.273;
            char _char = '글';
            string _string = "문자열";

            // 출력합니다.
            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());

            // 코드 2-47
            Console.WriteLine((273).GetType());
            Console.WriteLine((522731033265L).GetType());
            Console.WriteLine((52.273F).GetType());
            Console.WriteLine((52.273).GetType());
            Console.WriteLine(('자').GetType());
            Console.WriteLine(("문자열").GetType());

            // 코드 2-48
            var number8 = 100;

            // 코드 2-49
            var number9 = 10.2;
            // number9 = "변경"; -- string을 double로 사용 못 함

            // 코드 2-50
            var local = 273; //지역변수라서 사용 가능

            // 코드 2-51
            var number10 = 20;

            // 코드 2-52
            var numberA = 100L;   // long 자료형
            var numberB = 100.0;  // double 자료형
            var numberC = 100.0F; // float 자료형

            // 코드 2-53
            Console.WriteLine(123456 + 65432l);

            // 코드 2-54
            Console.WriteLine(123456 + 65432L);

            // 코드 2-55
            string input = Console.ReadLine();
            Console.WriteLine("input: " + input);

            // 코드 2-56
            // long 자료형을 int 자료형으로 변환합니다.
            long longNumber = 2147483647L + 2147483647L;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);

            // 코드 2-57
            var l = (int)10.0;
            var m = (float)10;
            var n = (double)10;

            // 코드 2-58
            // long자료형을 int자료형으로 변환합니다
            long longNumber3 = 2147483647L + 214783647L;
            int intNumber2 = (int)longNumber3;
            Console.WriteLine(intNumber2);

            // 코드 2-59
            long longNumber1 = 52273;
            int intNumber1 = (int)longNumber1;
            Console.WriteLine(intNumber1);

            // 코드 2-60
            // long 자료형을 int 자료형으로 변환
            long longNumber2 = 2147483647L + 2147483647L;
            int longToInt = (int)longNumber2;
            Console.WriteLine(longToInt);

            // double 자료형을 int 자료형으로 변환
            double doubleNumber = 52.27310332;
            int doubleToInt = (int)doubleNumber;
            Console.WriteLine(doubleToInt);

            // 코드 2-61
            // int 자료형의 숫자를 생성합니다.
            int intNumber5 = 2147483647;

            // int 자료형을 long 자료형으로 자동 변환
            long intToLong = intNumber;
            Console.WriteLine(intToLong);

            // int 자료형을 double 자료형으로 자동 변환
            double intToDouble = intNumber;
            Console.WriteLine(intToDouble);

            // 코드 2-62
            //string 자료형을 int 자료형으로 변환합니다.
            /*
            string numberString = "52273";
            int intNumber3 = (int)numberString;
            Console.WriteLine(intNumber3);
            */ //오류 발생으로 주석처리

            // 코드 2-63
            Console.WriteLine(int.Parse("52"));
            Console.WriteLine(long.Parse("273"));
            Console.WriteLine(float.Parse("52.273"));
            Console.WriteLine(double.Parse("103.32"));

            Console.WriteLine(int.Parse("52").GetType());
            Console.WriteLine(long.Parse("273").GetType());
            Console.WriteLine(float.Parse("52.273").GetType());
            Console.WriteLine(double.Parse("103.32").GetType());

            // 코드 2-64
            Console.WriteLine(int.Parse("52.273"));
            Console.WriteLine(int.Parse("abc"));

            // 코드 2-65
            Console.WriteLine((52).ToString());
            Console.WriteLine((52.273).ToString());
            Console.WriteLine(('a').ToString());
            Console.WriteLine((true).ToString());
            Console.WriteLine((false).ToString());

            Console.WriteLine((52).ToString().GetType());
            Console.WriteLine((52.273).ToString().GetType());
            Console.WriteLine(('a').ToString().GetType());
            Console.WriteLine((true).ToString().GetType());
            Console.WriteLine((false).ToString().GetType());

            // 코드 2-66
            double number7 = 52.273103;
            Console.WriteLine(number7.ToString("0.0"));
            Console.WriteLine(number7.ToString("0.00"));
            Console.WriteLine(number7.ToString("0.000"));
            Console.WriteLine(number7.ToString("0.0000"));

            // 코드 2-67
            Console.WriteLine(52 + 273);
            Console.WriteLine("52" + 273);
            Console.WriteLine(52 + "273");
            Console.WriteLine("52" + "273");

            // 코드 2-68
            int number4 = 52273;
            string outputA = number4 + "";
            Console.WriteLine(outputA);

            char character = 'a';
            string outputB = character + "";
            Console.WriteLine(outputB);
            Console.WriteLine();

            // 코드 2-69
            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("False"));
            Console.WriteLine(bool.Parse("false"));

            // 코드 2-70
            int output5 = int.MinValue;
            Console.WriteLine(-output5);
        }
    }
}
