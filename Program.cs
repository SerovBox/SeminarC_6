//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
int[] CreatNewArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}
void ShowNewArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] reverseArray(int[] array)
{
    int k = array.Length;
    for(int i = 0; i < k/2; i++)
    {
        int temp = array[i];
        array[i] = array[k - 1 - i];
        array[k - 1 - i] = temp;
    }
    return array;
}
Console.WriteLine("Input size of array: ");
int count_of_elements = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min: ");
int minV = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max: ");
int maxV = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreatNewArray(count_of_elements, minV, maxV);
ShowNewArray(newArray);
Console.Write("->");
int[] reversedArray = reverseArray(newArray);
ShowNewArray(newArray);
*/

//Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: a и b (пользователь)
//F(i) = F(i-1) + F(i-2)
//4 5 9 14 23 (N = 5)
/*
void Fibonachi(int count, int a, int b)
{
    int[] fibArray = new int[count];
    fibArray[0] = a;
    fibArray[1] = b;
    for(int i = 2; i < count; i++)
        fibArray[i] = fibArray[i-1] + fibArray[i-2];
    ShowArray(fibArray);
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.WriteLine("Input count of elem: ");
int count_elem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input first: ");
int first_elem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second: ");
int second_elem = Convert.ToInt32(Console.ReadLine());

Fibonachi(count_elem, first_elem, second_elem);
*/

//Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник с сторонами такой длины.
// каждая сторона треугольника меньше суммы двух других сторон.
/*
bool Triangle(int side1, int side2, int side3)
{
    if(side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2)
        return true;
    else return false; 
}

Console.WriteLine("Input first: ");
int first_side = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second: ");
int second_side = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third: ");
int third_side = Convert.ToInt32(Console.ReadLine());

bool result = Triangle(first_side, second_side, third_side);
if (result == true)
{
    Console.WriteLine("Triangle exists");
}
else Console.WriteLine("Triangle does not exist");
*/

//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
/*
string BinarSyst(int num)
{
    string binresult = string.Empty;
    while(num != 0)      // != -> не равно 0
    {
        binresult = num % 2 + binresult;
        num /= 2;
    }
    return binresult;
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

string res = BinarSyst(number);
Console.WriteLine($"your number {number} in binar syst is {res}");
*/
/*
y = k1*x + b1
y = k2*x + b2 <------------|
                           |
k1*x+b1 = k2*x+b2          |
k1*x-k2*x = b2-b1          |
x (k1-k2) = b2-b1 => x ____|

k1 and k2
*/
//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2 --- 1, -7, 567, 89, 223-> 3

/*
int[] NumbersUser(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = " ";

        while (input[i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input[i].ToString();
            i++;
        }
        else
        {
            temp += input[i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}

void newArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Input your numbers: ");
int[] numbers = NumbersUser(Console.ReadLine());
newArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"The number is greater than 0 = {sum}");
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
Console.WriteLine("Input b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Two straight lines will intersect X: {x}, Y: {y}");
*/