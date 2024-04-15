# basic-csharp-2024
부경대 2024 IoT 개발자과정 C# 리포지토리

## 1일차 (24.04.11)
- C# 소개
	- MS에서 개발한 차세대 프로그래밍 언어
	- 2000년 최초 발표. 개발자 : 앤더스 하일버그(파스칼, 델파이 개발자)
	- 1995년에 발표된 Java와 경쟁하기 위해 개발
	- 객체지향 언어, C/C++과 Java를 참조하여 개발
	- OS플랫폼 독립적, 메모리 관리 쉬움
	- 다양한 분야에서 사용 중
	- 2024년 12버전

- .NET Framework (CLR)
	- Windows OS에 종속적
	- OS 독립적인 새로운 틀을 제작시작(2022~) &rarr; .NET 5.0
	- 2024년(현재) &rarr; .NET 8.0
	- C/C++은 gcc 컴파일러, Java는 JDK, C#은 .NET 5.0 이상 필요
	- 이제는 신규개발 시, **.NET Framework는 사용하지 말것**

- Hello, C#!
	- Visual Studio 시작
	- 프로젝트 : 프로그램 개발 최소단위 그룹
	- 솔루션 : 프로젝트의 묶음

	```cs
	namespace hello_world // 소스의 가장 큰 단위 namespace == project
	{
		internal class Program  // 접근제한자 class 파일명
		{
			static void Main(string[] args) // 정적 void Main ...
			{   // C#에서는 모든 메서드(함수)의 첫글자는 대문자로 사용하는것 일반적
				// 문자열 " ", 문자 ' '
				// System 네임스페이스 > Console 클래스에 있는 정적메서드 WirteLine()
				Console.WriteLine("Hello, World!");
			}
		}
	}
	```

- 변수와 상수
	- C++과 동일 &rarr; 패스
	- 모든 C#의 객체는 Object를 조상으로 한다
	- 프로그램 메모리에는 스택(값형식 : 정수, 실수 ...), 힙(참조형식 : 클래스, 문자열, 리스트, 배열 ...)
	- 박싱(Boxing), 언박싱(Unboxing)

	```cs
	int a 20;	// 스택에 할당
	object b = a;	// 박싱(object 박스에 담는다) -> 힙에 올리는 것

	int c = (int) b;	// 언박싱(object를 각 타입으로 변환)
	```
	- 상수는 const 키워드 사용
	- var는 컴파일러가 자동으로 타입을 지정해주는 변수. 지역변수에만 사용 가능

- 연산자
	- C++과 동일
	- ++, -- : 파이썬에는 없음
	- and, or : C++, C#에서는 &&, || 임

- 흐름제어
	- C++과 동일
	- if, switch, while, do~while, for, break, continue, goto 모두 동일
	- **C#에는 foreach가 존재** = Python의 for item in [] 과 동일

	```cs
	int[] arr = { 1, 2, 3, 4, 5 };

	foreach (var item in arr)
	{
	Console.WriteLine($"현재 수 : {item}");
	}
	```

- 메서드(Method)
	- 함수와 동일. 구조적 프로그래밍 &rarr; 함수, 객체지향 &rarr; 메서드(파이썬 예외)
	- **매개변수 참조형식** 
		&rarr; C++에서 Pointer로 값을 사용할 때와 동일한 기능, **키워드 ref**

		```cs
		public static void RefSwap(ref int a, ref int b)
		{
			int temp = b;
			b = a;
			a = temp;
		}

		// 사용시에도 ref 키워드 사용
		RefSwap(ref x, ref y);
		```

	- 매개변수 출력형식  
		&rarr; 매개변수를 리턴값으로 사용하도록 대체해주는 방법(과도기적인 방법), **키워드 out**

		```cs
		// quotient : 나누기 몫
		// remainder : 나누기 나머지
        public static void Divide(int a, int b, out int quotient, out int remainder)
		{
			// ...
		}
		```

	- 매개변수 오버로딩  
		&rarr; 여러타입으로 같은 처리를 하는 메서드를 여러개 만들 때

	- 매개변수 가변길이  
		&rarr; 매개변수 개수를 동적으로 처리할 때

		```cs
        public static int Sum(params int[] argv)
		{
			// ...
		}
		```

	- 명명된 매개변수  
		&rarr; 매개변수 사용순서를 변경가능

		```cs
		public static void PrintProfile(string name, string phone)
		{
			// ...
		}

		PrintProfile(phone: "010-9999-8888", name: "홍길동");
		```

	- 기본값 매개변수  
		&rarr; 매개변수 값 미할당시 기본값으로 지정

		```cs
		public static void DefaultMethod(int a = 1, int b = 0)
		{
			// ...
		}

		DefaultMethod(10, 8); // a= 10, b = 8
		DefaultMethod(10);	// a= 10, b = 0
		DefaultMethod();	// a= 1, b = 0
		```

- 클래스
	- C++의 클래스, 객체와 유사(문법이 다소 상이)
	- 생성자는 new를 사용해서 객체 생성
	- 종료자(파괴자)는 C#에서 거의 사용 x
	- 생성자 오버로딩 &rarr; 파라미터 개수에 따라서 사용가능, 기본적인 메서드 오버로딩하고 기능 동일
	- this 키워드 &rarr; C++ : this-> | C# : this. (파이썬의 self.와 동일)
	- 접근한정자(Access Modifier)
		- public : 모든 곳에서 접근
		- private : 외부에서 접근 불가(default)
		- protected : 외부에서 접근 불가. 단, 파생(상속)클래스에서는 사용 가능
		- internal : 같은 어셈블리(네임스페이스)내에서는 public과 동일
		- protected internal, private protected : 난이도 있는 한정자

	- C#에는 C++과 같은 다중상속이 없음. C++ 다중상속으로 생기는 문제점을 해결하기 위해서 다중상속을 아예 없앰
		- 다중상속이 필요함을 해결 &rarr; 인터페이스

		```cs
		class BaseClass {
			// 부모클래스
		}
		
		class DerivedClass : BaseClass {
			// 파생(자식) 클래스
		}
		```

- 구조체
	- 객체지향이 없었을 때 좀 더 객체지향적인 프로그래밍을 위하여 만들어진 부분 (C에서)
	- class이후로 사용빈도가 완전히 줄어든 구조
	- 구조체 스택(값형식), 클래스 힙(참조형식)
	- C#에서는 구조체를 안써도 됨

- 튜플(C# 7.0 이후 반영)
	- 한꺼번에 여러개의 데이터를 리턴하거나 전달할 때 유용
	- 값 할당 후 변경불가

- **인터페이스 ★★**
	- 클래스 &rarr; 객체의 청사진 | 인터페이스 &rarr; 클래스의 청사진
	- 클래스가 어떠한 메서드를 가져야 하는지를 약속하는 것
	- 다중상속의 문제를 단일상속으로도 해결할 수 있도록 만든 주체
	- 명명 시, 제일 앞에 I를 적음
	- 인터페이스의 메서드에는 구현을 작성하지 않음
	- 인터페이스는 약속
	- 클래스 &rarr; '상속한다' **vs** 인터페이스 &rarr; '구현한다'
	- 클래스 : 상속시 별다른 문제없음 **vs** 인터페이스 : 구현시 약속을 지키지 않으면 오류표시
	- 인터페이스에서 약속한 메서드를 미구현 시 &rarr; 빌드 X

	![인터페이스설명](https://raw.githubusercontent.com/HyungJuu/basic-csharp-2024/main/images/cs001.png)

- 추상클래스(abstract)
	- Virtual 메서드하고도 유사
	- 추상클래스 단순화 &rarr; 인터페이스

- **프로퍼티**
	- 클래스의 멤버변수 변형. 일반 변수와 유사
	- 멤버변수의 접근제한자를 public으로 했을 때의 객체지향적 문제점(코드오염 등)을 해결하기 위해서
	- get 접근자 / set 접근자
	- set 값 할당시 잘못된 데이터가 들어가지 않도록 막아야 함
	- Java에서는 Getter 메서드 / Setter 메서드로 사용

## 2일차 (24.04.12)
- **TIP**
	- C#에서 빌드 시 오류 : 프로세스 액세스 오류
		- 원인 : 빌드하고자 하는 프로그램이 백그라운드 상에서 실행중이기 때문
		- 해결 : **Ctrl + Shift + ESC(작업관리자)** &rarr; 해당 프로세스 작업 끝내기 &rarr; 재빌드

- 컬렉션(배열, 리스트, 인덱서)
	- 모든 배열은 System.Array 클래스를 상속한 하위 클래스
	- 기본적인 배열의 사용법, Python 리스트와도 동일
	- 배열 분할 : C# 8.0 &larr; 파이썬의 배열 슬라이스를 도입
	- 컬렉션, 파이썬의 리스트, 스택, 큐, 딕셔너리와 동일
		- ArrayList
		- Stack
		- Queue
		- Hashtable(== Dictionary)
	- yield : foreach를 사용할 수 있는 객체로 만들기

- 일반화(Generic) 프로그래밍
	- 파이썬 : 변수에 값을 넣을 때 제약사항 x
	- 타입의 제약을 해소하고자 만든 기능 &rarr; ArrayList 등(단, 박싱(언방싱) 등 성능의 문제가 있음)
	- **하나의 메서드로 여러 타입의 처리를 해줄 수 있는 프로그래밍 방식**
	- 일반화 컬렉션
		- List<T>
		- Stack<T>, Queue<T>
		- Dictionary<TKey, TValue>

- 예외처리
	- 소스코드 상 문법적 오류 : 오류(Error)
	- 실행 중 생기는 오류 : 예외(Exception)

	```cs
	try
	{
		// .. 예외가 발생할 것 가은 소스코드
	}
	catch (Exception ex)
	{	// 모든 예외클래스의 조상 = Exception(예: IndexOutOfRangeException)
		// 어떤 예외클래스를 써야할지 모르면 무조건 Exception 클래스 사용
		Console.WriteLine(ex.Message);
	}
	finally
	{
		// 예외발생 유무에 상관없이 항상 실행
	}
	```

- 대리자와 이벤트
	- 메서드 호출 시 매개변수 전달
	- 대리자 호출 시 함수(메서드) 자체를 전달
	- 이벤트 : 컴퓨터 내에서 발생하는 객체의 사건들
	- 익명 메서드 사용
	- delegate &rarr; event
	- 윈폼개발 &rarr; 이벤트기반(Event driven) 프로그래밍

- **TIP**
	- C# 영역을 지정하여 관리할 수 있는 주석이 있음
	- #region ~ #endregion : 영역을 Expend 또는 Collapse 가능
	
	![region주석](https://raw.githubusercontent.com/HyungJuu/basic-csharp-2024/main/images/cs002.png)

## 3일차 (24.04.15)
- 람다식
	- 익명 메서드를 만드는 방식 중에 하나 : delegate, lambda expression
	- 익명 메서드시 코딩량을 줄여줌. 프로퍼티 사용시에도 코딩량이 줄어듬
	- 익명 메서드 사용할 때마다 대리자를 선언해야 하기 때문에
		- Func, Action을 MS에서 미리 만들어둠

- LINQ(Lanuguage INtergrated Query)
	- C#에 통합된 데이터 질의 기능(DB SQL과 거의 동일)
	- group by에 집계함수가 필수가 아닌 것 외에는 SQL과 거의 동일
	- 단, 키워드 사용순서가 다른 것 인지!
	- 기존의 C# 로직을 사용해야할 경우도 있음

- 애트리뷰트
	- 리플렉션 object.GetType();
	- [Obsolete("다음 버전 사용불가!")]


- 파이썬 실행
- Winform UI 개발 + 파일, 스레드
- 가비지 컬렉션

## 4일차
- WPF
- 예제 프로젝트