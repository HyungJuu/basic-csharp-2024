﻿// 파이썬용 라이브러리 사용등록
using IronPython.Hosting;

namespace ex15_pythons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("파이썬 실행예제");

            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();
            var path = engine.GetSearchPaths();

            // Python 경로 설정. @(리소스 키워드)
            path.Add(@"C:\DEV\Langs\Python311"); // 기본 파이썬 경로
            path.Add(@"C:\DEV\Langs\Python311\DLLs");
            path.Add(@"C:\DEV\Langs\Python311\Lib");
            path.Add(@"C:\DEV\Langs\Python311\Lib\site-packages");

            path.Add(@"C:\Users\user\AppData\Roaming\Python311\site-packages");
            path.Add(@"C:\Users\user\AppData\Roaming\Python311\site-packages\win32");
            path.Add(@"C:\Users\user\AppData\Roaming\Python311\site-packages\win32\lib");

            // 실행시킬 Python 파일 경로 설정
            var filePath = @"C:\Sources\basic-csharp-2024\day03\cs03_basic_app\ex15_pythons\Test.py";
            var source = engine.CreateScriptSourceFromFile(filePath);

            // Python 실행
            source.Execute(scope);

            var PythonFunc = scope.GetVariable<Func<int, int, int>>("sum");
            var result = PythonFunc(10, 7);
            Console.WriteLine($"Python 함수 실행 = {result}");

            var PythonGreeting = scope.GetVariable<Func<string>>("sayGreeting");
            var greeting = PythonGreeting();
            Console.WriteLine($"결과 = {greeting}");
        }
    }
}
