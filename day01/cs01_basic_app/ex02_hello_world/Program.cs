﻿namespace hello_world // 소스의 가장 큰 단위 namespace == project
{
    internal class Program  // 접근제한자 class 파일명
    {
        static void Main(string[] args) // 정적 void Main ...
        {   // C#에서는 모든 메서드(함수)의 첫글자는 대문자로 사용하는것 일반적이다
            // 문자열 " ", 문자 ' '
            // System 네임스페이스 > Console 클래스에 있는 정적메서드 WirteLine()
            //Console.WriteLine("Hello, World!");
            if (args.Length == 0)
            {
                Console.WriteLine("사용법 : hello_world.exe <이름>");
                return;
            }
            else
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
        }
    }
}
