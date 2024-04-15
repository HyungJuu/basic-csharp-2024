using System.Reflection;

namespace ex14_attributes
{
    class MyClass
    {
        [Obsolete("이 메서드는 다음버전에서 폐기됩니다. NewMethod()를 사용하세요.", false)]  // ture는 아예 사용불가
        /// <summary>
        /// 올드메서드(이렇게 쓰세요)
        /// </summary>

        public void OldMethod() // 최초에 제작 메서드
        {
            Console.WriteLine("Old Method!");
        }

        /// <summary>
        /// 뉴메서드.(제발 이렇게 쓰세요)
        /// </summary>
        public void NewMethod() // 개선한 메서드
        {
            Console.WriteLine("New Method!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region '리플렉션'
            Console.WriteLine("리플렉션!"); // GetType(); 만 알고 있으면됨

            int a = int.MaxValue;
            Type type = a.GetType();
            Console.WriteLine(type.FullName); // System.Int32

            float f = float.MaxValue;
            Console.WriteLine(f.GetType()); // System.Single

            double d = double.MaxValue;
            Console.WriteLine(d.GetType()); // System.Double
            Console.WriteLine();

            // Advanced 개발시에 필요한 내용
            FieldInfo[] fields = type.GetFields(); // 타입 객체에서 어떤 필드가 있는지 모두 확인
            foreach (var item in fields)
            {
                Console.WriteLine($"Type : {item.FieldType}, Name : {item.Name}");
            }

            MethodInfo[] methods = type.GetMethods(); // 타입 객체에서 어떤 필드가 있는지 모두 확인
            foreach (var item in methods)
            {
                Console.WriteLine($"Type : {item.DeclaringType}, Name : {item.Name}");
            }
            Console.WriteLine();
            #endregion

            // 애트리뷰트
            Console.WriteLine("애트리뷰트!");

            MyClass myClass = new MyClass();
            myClass.OldMethod();
            myClass.NewMethod();
        }
    }
}
