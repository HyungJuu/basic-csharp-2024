using System.Reflection;

namespace ex14_attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("리플렉션!");

            int a = int.MaxValue;
            Type type = a.GetType();
            Console.WriteLine(type.FullName); // System.Int32

            float f = float.MaxValue;
            Console.WriteLine(f.GetType()); // System.Single

            double d = double.MaxValue;
            Console.WriteLine(d.GetType()); // System.Double

            FieldInfo[] fields = type.GetFields(); // 타입 객체에서 어떤 필드가 있는지 모두 확인
            foreach (var item in fields)
            {
                Console.WriteLine($"Type : {item.FieldType}, Name : {item.Name}");
            }

           
        }
    }
}
