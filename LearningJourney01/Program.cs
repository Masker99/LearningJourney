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

// 元组

/*
 * 属于结构类型
 * 元组不可变
 * 可以使用with来创建一个新元组，原始元组的修改副本
 */
var pt = (X: 1, Y: 2);
var pt2 = pt with { Y = 10 };
Console.WriteLine($"The point 'pt2' is at {pt2}.");

var subscript = (A: 0, B: 0);
subscript = pt;
Console.WriteLine(subscript);

var namedData = (Name: "Morning observation", Temp: 17, Wind: 4);
var person = (FirstName: "", LastName: "");
var order = (Product: "guitar picks", style: "triangle", quantity: 500, UnitPrice: 0.10m);

// 类型

/*
Point pt3 = new Point(1, 1);
var pt4 = pt3 with { Y = 10 };
double slopeResult = pt4.Slope();
Console.WriteLine($"The slope of {pt4} is {slopeResult}");
Console.WriteLine($"The two points are {pt3} and {pt4}");

public record Point(int X, int Y)
{
 public double Slope() => (double)Y / (double)X;
}
*/

/*
 * => 通常用来表达只有一行返回值的方法
 */

// 结构、类、接口类型

/*
 * class 是应用类型， struct 是一个值类型
 * 值类型的变量在内存中内联存储实例的内容
 * 引用类型的变量存储指向实例存储空间的引用或指针
 */

Console.WriteLine("==========");

// 分支
ExploreIf();

void ExploreIf()
{
 int a = 5;
 int b = 3;
 if (a + b > 10)
 {
  Console.WriteLine("The answer is greater than 10");
 }
 else
 {
  Console.WriteLine("The answer is not greater than 10");
 }

 int c = 4;
 if ((a + b + c > 10) && (a > b))
 {
  Console.WriteLine("The answer is greater than 10");
  Console.WriteLine("And the first number is greater than the second");
 }
 else
 {
  Console.WriteLine("The answer is not greater than 10");
  Console.WriteLine("Or the first number is not greater than the second");
 }

 if ((a + b + c > 10) || (a > b))
 {
  Console.WriteLine("The answer is greater than 10");
  Console.WriteLine("Or the first number is greater than the second");
 }
 else
 {
  Console.WriteLine("The answer is not greater than 10");
  Console.WriteLine("And the first number is not greater than the second");
 }
}

// 循环
int counter = 0;
while (counter < 10)
{
 Console.WriteLine($"Hello World! The counter is {counter}");
 counter++;
}

counter = 0;
do
{
 Console.WriteLine($"Hello World! The counter is {counter}");
 counter++;
} while (counter < 10);

for (counter = 0; counter < 10; counter++)
{
 Console.WriteLine($"Hello World! The counter is {counter}");
}

// 嵌套循环
for (int row = 1; row < 11; row++)
{
 for (char column = 'a'; column < 'k'; column++)
 {
  Console.WriteLine($"The cell is ({row}, {column})");
 }
}

int sum = 0;
for (int number = 1; number < 21; number++)
{
 if (number % 3 == 0)
 {
  sum = sum + number;
 }
}
Console.WriteLine($"The sum is {sum}");

Console.WriteLine("==========");

// 集合

List<string> names = ["<name>", "Ana", "Felipe"];
foreach (var name in names)
{
 Console.WriteLine($"Hello {name.ToUpper()}!");
}

// 修改列表内容
Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
 Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

Console.WriteLine($"The list has {names.Count} people in it");

// 搜索列表
var index = names.IndexOf("Felipe");
if (index == -1)
{
 Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else
{
 Console.WriteLine($"The name {names[index]} is at index {index}");
}

index = names.IndexOf("Not Found");
if (index == -1)
{
 Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else
{
 Console.WriteLine($"The name {names[index]} is at index {index}");
}

// 排序
/*
 * Sort 方法是按照常规顺序对列表的所有项进行排序
 */
names.Sort();
foreach (var name in names)
{
 Console.WriteLine($"Hello {name.ToUpper()}!");
}

List<int> fibonacciNumbers = [1, 1];

Console.WriteLine(fibonacciNumbers.Count);

var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

fibonacciNumbers.Add(previous + previous2);

foreach (var item in fibonacciNumbers)
{
 Console.WriteLine(item);
}

Console.WriteLine("==========");

// 模式匹配

string bankRecords = """
                     DEPOSIT,   10000, Initial balance
                     DEPOSIT,     500, regular deposit
                     WITHDRAWAL, 1000, rent
                     DEPOSIT,    2000, freelance payment
                     WITHDRAWAL,  300, groceries
                     DEPOSIT,     700, gift from friend
                     WITHDRAWAL,  150, utility bill
                     DEPOSIT,    1200, tax refund
                     WITHDRAWAL,  500, car maintenance
                     DEPOSIT,     400, cashback reward
                     WITHDRAWAL,  250, dining out
                     DEPOSIT,    3000, bonus payment
                     WITHDRAWAL,  800, loan repayment
                     DEPOSIT,     600, stock dividends
                     WITHDRAWAL,  100, subscription fee
                     DEPOSIT,    1500, side hustle income
                     WITHDRAWAL,  200, fuel expenses
                     DEPOSIT,     900, refund from store
                     WITHDRAWAL,  350, shopping
                     DEPOSIT,    2500, project milestone payment
                     WITHDRAWAL,  400, entertainment
                     """;

double currentBalance = 0.0;

/*
 * StringReader
 * 一个用于把字符串当做文本流来读取的类
 */
var reader = new StringReader(bankRecords);

string? line;

while ((line = reader.ReadLine()) is not null)
{
 if (string.IsNullOrWhiteSpace(line)) continue;
 
 // Split the line based on comma delimiter and trim each part
 string[] parts = line.Split(',');

 string? transactionType = parts[0]?.Trim();
 
 if (double.TryParse(parts[1].Trim(), out double amount))
 {
  // Update the balance based on transaction type
  if (transactionType?.ToUpper() is "DEPOSIT")
   currentBalance += amount;
  else if (transactionType?.ToUpper() is "WITHDRAWAL")
   currentBalance -= amount;

  Console.WriteLine($"{line.Trim()} => Parsed Amount: {amount}, New Balance: {currentBalance}");
 }
}

/*
 * yield return
 * 边生成边遍历，节省内存
 * 利于处理无线或大数据流
 * 
 */



currentBalance = 0.0;

foreach (var transaction in TransactionRecords(bankRecords))
{
 /* 
 if (transaction.type == TransactionType.Deposit)
  currentBalance += transaction.amount;
 else if (transaction.type == TransactionType.Withdrawal)
  currentBalance -= transaction.amount;
 */
 
 /*
  * switch 表达式
  * 更紧凑，可以直接返回值，可以匹配复杂模式
  * case 分支顺序很重要，必须满足“穷尽匹配”规则
  */
 
 /*
 currentBalance += transaction switch
 {
  (TransactionType.Deposit, var amount) => amount,
  (TransactionType.Withdrawal, var amount) => -amount,
  _ => 0.0, // 放在最后
 };
 */
 
 currentBalance += transaction switch
 {
  Deposit d => d.Amount,
  Withdrawal w => -w.Amount,
  _ => 0.0,
 };
 
 //Console.WriteLine($"{transaction.type} => Parsed Amount: {transaction.amount}, New Balance: {currentBalance}");
 Console.WriteLine($"{transaction} => New Balance: {currentBalance}");
}

//static IEnumerable<(TransactionType type, double amount)> TransactionRecords(string inputText)
static IEnumerable<object?> TransactionRecordType(string inputText)
{
 var reader = new StringReader(inputText);
 string? line;
 
 while ((line = reader.ReadLine()) is not null)
 {
  string[] parts = line.Split(',');

  string? transactionType = parts[0]?.Trim();
  /* 
  if (double.TryParse(parts[1].Trim(), out double amount))
  {
   // Update the balance based on transaction type
   if (transactionType?.ToUpper() is "DEPOSIT")
    yield return (TransactionType.Deposit, amount);
   else if (transactionType?.ToUpper() is "WITHDRAWAL")
    yield return (TransactionType.Withdrawal, amount);
  }
  else {
   yield return (TransactionType.Invalid, 0.0);
  }
  */
  if (double.TryParse(parts[1].Trim(), out double amount))
  {
   if (transactionType?.ToUpper() is "DEPOSIT")
    yield return new Deposit(amount, parts[2]);
   else if (transactionType?.ToUpper() is "WITHDRAWAL")
    yield return new Withdrawal(amount, parts[2]);
  }
  yield return default;
 }
}

public enum TransactionType
{
 Deposit,
 Withdrawal,
 Invalid
}

public record Deposit(double Amount, string description);
public record Withdrawal(double Amount, string description);