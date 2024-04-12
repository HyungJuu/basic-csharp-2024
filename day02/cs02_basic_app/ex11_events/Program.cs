namespace ex11_events
{
    delegate int MyDelegate(int a, int b);
    delegate void EventHandler(string message); // EventHandler 대리자
    class CustomNotifier
    {
        // 이벤트 등록
        public event EventHandler SomethingHappened;

        public void DoSomething(int number)
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 == 0)
            {
                SomethingHappened($"{number} : 짝!");
            }
        }
    }   // 원래부터 만들어져 있는 부분 (우리가 구현하는 것 X)

    internal class Program
    {
        public static void MyHandler(string message)
        {
            Console.WriteLine($"[{DateTime.Now.ToShortTimeString()}] : {message}");
        }

        static void Main(string[] args)
        {
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);

            #region "익명 메서드"
            MyDelegate callback; // 대리자
            // 메서드 이름이 존재 x
            // 익명 메서드 : 한번 사용 후 다시 호출할 필요가 없을 때 사용
            callback = delegate (int a, int b)
            {
                return a + b;
            };

            var result = callback(10, 4);
            #endregion
        }
    }
}
