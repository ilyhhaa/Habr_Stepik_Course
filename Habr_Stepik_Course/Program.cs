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