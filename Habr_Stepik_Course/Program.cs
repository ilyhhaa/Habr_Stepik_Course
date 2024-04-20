//stepik Course from Habr
//https://habr.com/ru/articles/806707/
//i skipped first 10 tasks.

//1



/*У вас есть переменные x, y и op, которые содержат входные пользовательские данные.

Напишите код, который выполняет операции сложения/вычитания над переменными x, y  и записывает результат в переменную result.

Если op == "+" тогда result = x + y

Если op == "-" тогда result = x - y

Если op == "" тогда result = 0*/

/*internal class Program
{
     public class MainClass
     {
         public static void Main(string[] args)
         {
             int x, y;
             string op=string.Empty; //they leave {string op;} in cond;



             string[] inputValues = ReadInput();
             x = int.Parse(inputValues[0]);
             op = inputValues[1];
             y = int.Parse(inputValues[2]);

             int result = op switch
             {
                 "x" => x + y, //"*" => x*y,
                 "/" => x - y,//"/" => x/y
                 "" => 0 //same


             };



             Console.WriteLine(result);
         }

         public static string[] ReadInput()
         {
             string[] inputValues = new string[3];

             if (Console.ReadLine() is string input)
             {
                 inputValues = input.Split(' ');
             }

             return inputValues;
         }
     }
 }

 //next step is the same task but with "*","/";
    */

//2




/*У вас есть переменные x, y, которые содержат входные пользовательские данные.

    Напишите код, который сравнивает эти переменные и записывает результат в переменную result.

    Если x равно y тогда result = true

    Если x не равно y тогда result = false*/


/*public class MainClass
{
    public static void Main(string[] args)
    {
        int x, y;


        int[] inputValues = ReadInput();
        x = inputValues[0];
        y = inputValues[1];

    bool result = x == y ? true : false;



        Console.WriteLine(result.ToString().ToLower());
    }

    public static int[] ReadInput()
    {
        int[] inputValues = new int[2];

        if (Console.ReadLine() is string input)
        {
            string[] values = input.Split(' ');
            inputValues[0] = int.Parse(values[0]);
            inputValues[1] = int.Parse(values[1]);
        }

        return inputValues;
    }
}*/


//3


/*
 * У вас есть переменные role, которая содержит входные пользовательские данные.

Напишите код, который в зависимости от значения переменной role записывает соответствующий результат в переменную result.

1 — admin
2 — moderator
3 — user
default — guest
 */


/*public class MainClass
{
    public static void Main(string[] args)
    {
        int role = ReadInput();
        string result = role switch
        {
            1 => "admin",
            2 =>"moderator",
            3=>"user",
            _=> "guest"
        };


        Console.WriteLine(result);
    }

    public static int ReadInput()
    {
        string inputLine = Console.ReadLine();
        return int.Parse(inputLine);
    }
}*/


//4

/*У вас есть переменная age, которая принимает входные пользовательские данные.

Напишите код, который проверяет переменную age и записывает результат в переменную result.

Если age больше или равно 18 тогда записываем взрослый иначе записываем подросток.*/

/* public class MainClass
{
    public static void Main(string[] args)
    {
        int age = ReadInput();
        string result = age >= 18 ? "взрослый" : "подросток";


        Console.WriteLine(result);
    }

    public static int ReadInput()
    {
        string inputLine = Console.ReadLine();
        return int.Parse(inputLine);
    }
}
*/

//5


/*У вас есть переменная message, которая содержит входные пользовательские данные.

Напишите код, который в зависимости от длины строки message записывает количество * в переменную result.

Важно!

Учитывайте то что ваш код должен работать как с кириллицей так и с латиницей.*/

/*using System.Text;

public class MainClass
{
    public static void Main(string[] args)
    {
        string message = ReadInput();
        StringBuilder result = new StringBuilder();


        for (int i = 0; i < message.Length; i++)
        {

            result.Append('*');
        }

        Console.WriteLine(result.ToString());
    }

    public static string ReadInput()
    {
        string message = "";

        if (Console.ReadLine() is string input)
        {
            message = input;
        }

        return message;
    }
}
*/

//6

/*
У вас есть переменная n, которая содержит входные пользовательские данные.

n - число.

Напишите код, который определяет если число n положительное, тогда умножает его на 2 иначе оставляет как есть. */


/*public class MainClass
{
    public static void Main(string[] args)
    {
        int n = ReadInput();
        int result = n < 0 ? n : n * 2;


        Console.WriteLine(result);
        Console.ReadLine();
    }

    public static int ReadInput()
    {
        string inputLine = Console.ReadLine();
        return int.Parse(inputLine);
    }
}*/

//7
/*
 * У вас есть переменная n, которая содержит входные пользовательские данные.

n всегда содержит четное число.

Напишите код, который возвращает сумму всех четных чисел до n (включительно) и записывает результат в переменную result. 

Например:

Eсли n = 4 тогда 2 + 4 = 6

Eсли n = 6 тогда 2 + 4 + 6 = 12

Eсли n = 8 тогда 2 + 4 + 6 + 8 = 20


 */

/*public class MainClass
{
    public static void Main(string[] args)
    {
        int n = ReadInput();
        int result = 0;

        for (int i = 0; i <=n;i++)
        {
            if (i%2==0)
            {
                result += i;
            }
        }



        Console.WriteLine(result);
        Console.ReadLine();
    }

    public static int ReadInput()
    {
        string inputLine = Console.ReadLine();
        return int.Parse(inputLine);
    }
}*/

//8
/*У вас есть переменная n, которая содержит входные пользовательские данные.

n всегда содержит нечетное число.

Напишите код, который возвращает сумму всех нечетных чисел до n (включительно) и записывает результат в переменную result. 

Например:

Eсли n = 3 тогда 1 + 3 = 4

Eсли n = 5 тогда 1 + 3 + 5 = 9

Eсли n = 7 тогда 1 + 3 + 5 + 7 = 16*/


/* public class MainClass
{
    public static void Main(string[] args)
    {
        int n = ReadInput();
        int result = 0;

        for (int i = 0; i <= n; i++)
        {
            if (i % 2 != 0)
            {
                result += i;
            }
        }


        Console.WriteLine(result);
    }

    public static int ReadInput()
    {
        string inputLine = Console.ReadLine();
        return int.Parse(inputLine);
    }
}*/

//9

/*
 * У вас есть переменная n, которая содержит входные пользовательские данные.

n всегда содержит целое число.

Напишите код, который возвращает произведение всех целых чисел до n (включительно) и записывает результат в переменную result. 

Например:

Eсли n = 3 тогда 1 x 3 = 3

Eсли n = 5 тогда 1 x 3 x 5 = 15

Eсли n = 7 тогда 1 x 3 x 5 x 7 = 105

//ошибка в условии речь идет о нечетных числах
 */

/*public class MainClass
{
    public static void Main(string[] args)
    {
        int n = ReadInput();
        int result = 1;

        for (int i = 0; i <= n; i++)
        {
            if (i % 2 != 0)
            {
                result *= i;
            }
        }


        Console.WriteLine(result);
    }

    public static int ReadInput()
    {
        string inputLine = Console.ReadLine();
        return int.Parse(inputLine);
    }
}*/


//10

/*У вас есть переменная n, которая содержит входные пользовательские данные.

n - натуральное число.

Напишите код, который определяет, будет ли это число: нечётным, кратным 7.

Логический результат записать в переменную result.*/



/*public class MainClass
{
    public static void Main(string[] args)
    {
        int n = ReadInput();
        bool result = (n % 2 != 0 && n % 7 == 0) ? true : false;


        Console.WriteLine(result.ToString().ToLower());
    }
public static int ReadInput()
    {
        string inputLine = Console.ReadLine();
        return int.Parse(inputLine);
    }
}*/

//11

/*У вас есть переменная n, которая содержит входные пользовательские данные.

n - натуральное число.

Напишите код, который определяет, будет ли это число: четным, кратным 6.

Логический результат записать в переменную result.*/


/*public class MainClass
{
    public static void Main(string[] args)
    {
        int n = ReadInput();
        bool result = (n % 2 == 0 && n % 6 == 0) ? true : false;


        Console.WriteLine(result.ToString().ToLower());
    }

    public static int ReadInput()
    {
        string inputLine = Console.ReadLine();
        return int.Parse(inputLine);
    }
}*/


//12

/*У вас есть переменные x1, x2, x3, которые содержат входные пользовательские данные.

Напишите код, который находит максимальное и минимальное число из x1, x2, x3
и записывает результат в переменную result.*/

/*public class MainClass
{
    public static void Main(string[] args)
    {
        int x1, x2, x3;
        

        int[] inputValues = ReadInput();
        x1 = inputValues[0];
        x2 = inputValues[1];
        x3 = inputValues[2];

        int maxNumber = x1;
        int minNumber = x1;

        string result = $"минимальное: {inputValues.Min()}, максимальное:{inputValues.Max()}";

        Console.WriteLine(result);
    }

    public static int[] ReadInput()
    {
        int[] inputValues = new int[3];

        if (Console.ReadLine() is string input)
        {
            string[] values = input.Split(' ');
            for (int i = 0; i < 3; i++)
            {
                inputValues[i] = int.Parse(values[i]);
            }
        }

        return inputValues;
    }
}*/

//13

/*
 * У вас есть переменная stars, которая содержит входные пользовательские данные.

Значение переменной stars от 1 до 5. 

1 — ★
2 — ★★
3 — ★★★
4 — ★★★★
5 — ★★★★★

Напишите код, который проверяет значение переменной stars и записывает результат в переменную result.
 */

/*public class MainClass
{
    public static void Main(string[] args)
    {
        int stars = ReadInput();
        string result = string.Empty;

        for (int i = 0; i < stars; i++)
        {
            result += "★";
        }


        Console.WriteLine(result);
        Console.ReadLine();
    }

    public static int ReadInput()
    {
        string inputLine = Console.ReadLine();
        return int.Parse(inputLine);
    }
}*/

//14

/*
 У вас есть переменные x, y и direction которые содержат входные пользовательские данные.

x, y содержат числа - стартовая позиция игрока. 

direction содержит направление движения, одного из: up, down, left, right.

 y = 0 - самая верхняя точка
y = 100 - самая нижняя

x=0 - левая тоочка
х=100 - правая точка*/

/*public class MainClass
{
    public static void Main(string[] args)
    {
        int x, y;
        string direction = string.Empty;



        string[] inputValues = ReadInput();
        x = int.Parse(inputValues[0]);
        y = int.Parse(inputValues[1]);
        direction = inputValues[2];

        string result = direction switch
        {

        };






        Console.WriteLine(result);
    }

    public static string[] ReadInput()
    {
        string[] inputValues = new string[3];

        if (Console.ReadLine() is string input)
        {
            string[] values = input.Split(' ');
            for (int i = 0; i < 3; i++)
            {
                inputValues[i] = values[i];
            }
        }

        return inputValues;
    }
}*/

//15

/*У вас есть переменная n, которая содержит входные пользовательские данные.

Напишите код, который проверяет является ли значение n негативным, позитивным или равно 0 и записывает результат в переменную result.

Если n позитивное число тогда result = "Число позитивное"

Если n негативное число тогда result = "Число негативное"

Если n равно 0 число тогда result = "Число равно 0"*/

/*public class MainClass
{
    public static void Main(string[] args)
    {
        int n = ReadInput();
        string result = "";

        // Проверяем значение 'n'
        if (n > 0)
        {
            result = "Число позитивное";
        }
        else if (n < 0)
        {
            result = "Число негативное";
        }
        else
        {
            result = "Число равно 0";
        }



        Console.WriteLine(result);
    }

    public static int ReadInput()
    {
        string inputLine = Console.ReadLine();
        return int.Parse(inputLine);
    }
}*/


//16

/*
 У вас есть переменная n которая содержит входные пользовательские данные.

n - положительное целое число

У вас есть положительное целое число n, представляющее количество шляп и 
количество людей. Нужно определить общее количество способов, которыми n шляп можно
вернуть n людям таким образом, что ни одна шляпа не возвращается к своему владельцу (т.е., ни один человек не получает свою собственную шляпу).
Эта задача известна как "проблема шляпного чека" или "проблема нарушения перестановок".

Ответ на эту задачу представляет собой количество !n нарушений n-элементного набора.

Нарушение — это такая перестановка элементов множества, при которой ни один элемент не появляется в исходном положении.

Результат записать в виде числа в переменную result. 

О классическое олимпиаДНОе
 */

/*public class MainClass
{
    public static void Main(string[] args)
    {
        int n = ReadInput();
        int result;

        result = Calculate(n);

        Console.WriteLine(result);
    }

    public static int Calculate(int n)
    {
        int[] dp = new int[n + 1];
        dp[0] = 1;
        dp[1] = 0;

        for (int i = 2; i <= n; i++)
            dp[i] = (i - 1) * (dp[i - 1] + dp[i - 2]);

        return dp[n];

    }

    public static int ReadInput()
    {
        return int.Parse(Console.ReadLine());
    }
}*/



/*У вас есть переменные n, m, k, которые содержат входные пользовательские данные.

Волшебник продает волшебные мечи принцам, желающим убить дракона. У каждого меча есть основная характеристика – число драконьих голов, которые он срубает за один удар. Драконы имеют свои характеристики, включая число голов и скорость регенерации голов.

Число n, представляющее число голов, которые меч срубает одним ударом.

Число m, представляющее число голов дракона.

Число k, представляющее число голов, которые дракон может отрастить за раз.

Напишите код, который определяет, сможет ли принц убить дракона, используя определенный меч, и если да, то сколько ударов потребуется. При этом, бои принцев с драконами всегда протекают одинаково: принц атакует дракона, а затем прячется за щитом; дракон атакует огненным дыханием и может восстановить потерянные головы.

Если принц может убить дракона, ваше решение должно записать в переменную result количество ударов, необходимых для убийства дракона.

Если убить дракона таким мечом невозможно, ваше решение должно записать в переменную result значение -1.

А это было в qulix.
 */


/*public class MainClass
{
    public static void Main(string[] args)
    {
        Tuple<int, int, int> triple = ReadInput();
        int n = triple.Item1;
        int m = triple.Item2;
        int k = triple.Item3;
        
        
        int result = 0;

        

        while (m > 0)
        {

            if (n < k && m != n)
            {
                result = -1;
                break;
            }
            m -= n;
            result++;
            if (m <= 0)
            {
                break;
            }
            m += k;
        }

        

        Console.WriteLine(result);

         static Tuple<int, int, int> ReadInput()
    {

        int n = 5;
        int m = 10;
        int k = 6;
        return Tuple.Create(n, m, k);
    }
}
    }*/

//18

/*У вас есть переменные message, k которые содержат входные пользовательские данные.

message - строка состоящая из маленьких букв английского алфавита.

k - целое число со значением от -100000 до 100000.

Напишите код, который выполнит следующие действия в зависимости от значения k:

Если k положительное, решение должно создать строку, являющуюся k-ой степенью строки message.
То есть, результатом будет строка, в которой строка message повторяется k раз.
 
Если k отрицательное, решение должно попытаться найти корень степени k из строки message.
Для этого длина строки message должна быть кратной k.
 
Если строка message имеет такую структуру, что можно найти корень, то решение должно создать строку корень степени k.
В противном случае, решение должно создать строку NO SOLUTION.
 
Если k равно нулю, функция должна вернуть пустую строку.
Результат записать в виде новой строки в переменную result. 

Sample Input 1:
ab | 2
Sample Output 1:
abab
Sample Input 2:
ab | 4
Sample Output 2:
abababab
Sample Input 3:
abababab | -2
*/

/*
using System.Text;

public class MainClass
{
    public static void Main(string[] args)
    {
        var pair = ReadInput();
        string message = pair.Item1;
        int k = pair.Item2;
        string result = "";

        if (k > 0)
        {
            result = new StringBuilder(message.Length * k).Insert(0, message, k).ToString();
        }
        else if (k < 0)
        {
            if (message.Length % Math.Abs(k) != 0)
            {
                result = "NO SOLUTION";
            }
            else
            {
                string possibleRoot = message.Substring(0, message.Length / Math.Abs(k));
                if (new StringBuilder(message.Length).Insert(0, possibleRoot, Math.Abs(k)).ToString() == message)
                {
                    result = possibleRoot;
                }
                else
                {
                    result = "NO SOLUTION";
                }
            }
        }
        else
        {
            result = "";
        }


        Console.WriteLine(result);
    }

    public static Tuple<string, int> ReadInput()
    {
        string[] input = Console.ReadLine().Trim().Split(" | ");
        string message = input[0];
        int k = int.Parse(input[1]);
        return Tuple.Create(message, k);
    }
}*/

/19

/*У вас есть переменная n которая содержит входные пользовательские данные.

Напишите код, который определяет, есть ли у числа n брэйк-пойнт.

"брэйк-пойнтом" называется такая точка в числе, при которой число можно разделить на две "равные" части, где сумма чисел слева и справа от этой точки равна.

Например, число 35190 можно разделить на 351 и 90, потому что 3 + 5 + 1 = 9 и 9 + 0 = 9. А например у числа 555 такого брэйк-пойнта нет, так как оно нельзя разделить на две равные части.

Логический результат записать в переменную result. 

Важно!

Каждая цифра числа является отдельным числом для целей данной задачи.
Например, число 123 = 1 + 2 + 3, а не 123 = 1 + 23 или 123 = 12 + 3.*/


/*
public class MainClass
{
    public static void Main(string[] args)
    {
        int n = ReadInput();
        bool result = false;

        result = HasBreakpoint(n);

        Console.WriteLine(result.ToString().ToLower());
    }

    public static bool HasBreakpoint(int number)
    {
        string strN = number.ToString();
        for (int i = 1; i < strN.Length; i++)
        {
            string left = strN.Substring(0, i);
            string right = strN.Substring(i);

            int sumLeft = left.Sum(c => c - '0');
            int sumRight = right.Sum(c => c - '0');

            if (sumLeft == sumRight)
            {
                return true;
            }
        }
        return false;

    }

    public static int ReadInput()
    {
        return int.Parse(Console.ReadLine());
    }
}*/

    //20

/*У вас есть переменная n которая содержит входные пользовательские данные.

n - (0 < n < 100) - количество голов драконьей стаи.

На планете обитают драконы, и сила драконьей стаи зависит от количества голов у каждого дракона. Однако, чтобы максимально увеличить силу стаи, необходимо распределить головы между драконами так, чтобы их произведение было максимальным.

Напишите код, который по заданному количеству голов драконьей стаи n определит максимальную силу этой стаи, учитывая, что каждый дракон должен иметь одинаковое количество голов.

Результат записать в переменную result. 

 

Важно!

Для максимальной силы стаи нужно распределить головы так, чтобы произведение было максимальным.
Если количество голов меньше или равно 2, то максимальная сила равна количеству голов.
В остальных случаях, разбейте количество голов на множители 3 и, если останется одна голова, добавьте один множитель 2.
 

Возможные подсказки, которые могут вам помочь в поиске решения:

Разбейте количество голов на множители 3 и учтите остаток от деления.

Если количество голов меньше или равно 2, максимальная сила стаи равна количеству голов.

В зависимости от остатка от деления на 3, определите количество троек и одну или две головы в остатке.

Максимальная сила стаи будет равна произведению всех множителей (троек и, возможно, двойки).

Убедитесь, что ваш алгоритм корректно обрабатывает случаи, когда количество голов равно 0, 1 или 2.

*/

/*
public class MainClass
{
    public static void Main(string[] args)
    {
        int n = ReadInput();
        int result = 0;

        if (n <= 2)
        {
            result = n;
        }

        long power = 1;
        while (n > 4)
        {
            power *= 3;
            n -= 3;
        }

        power *= n;

        result = (int)power;

        Console.WriteLine(result);
    }

    
    

    public static int ReadInput()
    {
        return int.Parse(Console.ReadLine());
    }
}
*/

     //21

/*
 У вас есть переменная data, которая содержит входные пользовательские данные.

data - список из элементов целых чисел.

Напишите код, который определяет все ли числа в списке data четные и записывает логический результат в переменную result.

Sample Input 1:
[2, 4, 6, 8, 10]
*/

/*using System.Text.Json;

public class MainClass
{
    public static void Main(string[] args)
    {
        List<int> data = ReadInput();
        bool result = data.Exists(c => c % 2 != 0) ? false : true;

            

            

        Console.WriteLine(result.ToString().ToLower());
    }

    public static List<int> ReadInput()
    {
        List<int> data = null;

        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            data = JsonSerializer.Deserialize<List<int>>(input);
        }

        return data ?? new List<int>();
    }
}*/    

