// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// 来源：https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/overview

/*
 * C# 是强类型语言
 * 意味着，每个变量、表达式和对象都有一个明确的、固定的数据类型
 * 并且编译器会严格执行关于这些类型的规则，从而禁止不兼容的类型之
 * 间进行隐式或“随意”的操作
 * 优点：编译阶段发现错误，避免运行时程序崩溃；
 *
 * 与之对应的，弱类型语言
 * 允许变量在运行时隐式地、自动地进行类型转换，而不会在编译时严格
 * 检查类型兼容性
*/

Console.WriteLine("==========");

// Hello World
// 来源：https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tutorials/hello-world

string aFriend = "Bill";
Console.WriteLine(aFriend);

aFriend = "Maira";
Console.WriteLine(aFriend);

Console.WriteLine("Hello " + aFriend);

// 字符串内插：将文本替换为变量的值
Console.WriteLine($"Hello {aFriend}");

string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

/*
 * 刚刚想新建一个文件来运行代码，发现并不可行，从而了解到顶层语句概念
 * 顶层语句
 * C# 9.0 引入的特性，可以直接在C#中编写代码，而无需显示地包含在类和方法中
 * (编译器会自动为顶层语句生成Main方法，并将顶层语句放入其中)
 * 一个项目只能有一个文件包含顶层语句，一般为Program.cs
*/

// 从字符串中删除空格
string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");
// TrimStart() 删除字符串开头的空格

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");
// TrimEnd() 删除字符串末尾的空格

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");
// Trim() 删除字符串两端的空格

// 在字符串中搜索和替换文本
string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.EndsWith("hello"));

Console.WriteLine("==========");

// C#中的数字

int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

// subtraction
c = a - b;
Console.WriteLine(c);

// multiplication
c = a * b;
Console.WriteLine(c);

// division
c = a / b;
Console.WriteLine(c);


/*
 * 方法
*/

// WorkWithIntegers();

void WorkWithIntegers()

{ 
 int a = 18;
 int b = 6;
 int c = a + b;
 Console.WriteLine(c);


 // subtraction
 c = a - b;
 Console.WriteLine(c);

 // multiplication
 c = a * b;
 Console.WriteLine(c);

 // division
 c = a / b;
 Console.WriteLine(c);
}

/*
 * 数学运算的优先级一样
 * 高阶运算先于低阶运算
*/

a = 5;
b = 4;
c = 2;
int d = a + b * c;
Console.WriteLine(d);

d = (a + b) * c;
Console.WriteLine(d);

d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine(d);

int e = 7;
int f = 4;
int g = 3;
int h = (e + f) / g;
Console.WriteLine(h);

/*
 * C# 的整数类型 有最小和最大限制
 */

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

/*
 * 当计算结果超出这些限制的值，结果将从一个限制覆盖到另一个限制范围
 */
int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

/*
 * 浮点数
 * 表示可能非常大或较小的非整型数
 * 现代计算机上，通常使用双精度而不是单精度数字
 * double，float
 */
double third = 1.0 / 3.0;
Console.WriteLine(third);

/*
 * decimal
 * 范围较小，但精度大于double
 */
decimal minDecimal = decimal.MinValue;
decimal maxDecimal = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {minDecimal} to {maxDecimal}");

double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine(area);

Console.WriteLine("==========");
