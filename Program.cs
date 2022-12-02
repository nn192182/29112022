/*
void ShowNewArray(int[] array)
{
    for (int i=0; i < array.Length; i++)
         {
            Console.Write(array[i] + " ");
         }    
}  
//i 0 1 2 3 4 5 
//i < k (i = 0; k = 6)
//i = 0 - > k - 1 - 0  0<5->5 -> 5 1 2 3 4 0
//i = 1 -> k=4 1<->4  -> 5 4 2 3 1 0    <--|
//i = 2->  k=3 2<->3  -> 5 4 3 2 1 0 ++    |
//i = 3->  k=2 3<->2  -> 5 4 2 3 1 0 ------

int ReverseArray(int [] array)
{
    int k = array.Length; //4 5 1 2  -> 2 5 1 4 -> 2 1 5 4 - > 2 5 1 4 - > 4 5 1 2
    for(int i = 0; i < k/2 ; i++)
    {
        int temp = array[i];
        array[i] = array[k-1-i];
        array[k-1-i] = temp;
    }
    return array;
}

Console.WriteLine(" Input size of array: ");
int count_elements = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Input min possible value of element: ");
int fminValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Input max possible value of element: ");
int maxValue  = Convert.ToInt32(Console.ReadLine());

int [] newArray  = CreateNewArray(count_of_elements, minValue, maxValue);
ShowNewArray(newArray);
Console.WriteLine();
// int [] reversedArray = ReverseArray (newArray);
// ShowNewArray(reversedArray);

ShowNewArray(ReverseArray(newArray));

//Не используя рекурсию, вывести первые N чисел Фиюоначчи. Первые два числа Фибоначчи а и в (пользователь)
//F(i) = F(i -1) + F(i -2)
// 4 5 9 14 23 (N = 5)

//1 1 -> 1+1 =2; 1+2=3; 2+3=5;
// 1 1 2 3 5
// 3 4 7 11


/*
void Fibonachi(int count, int a, int b)
{
    int [] fibArray = new int [count];
    fibArray[0] = a;
    fibArray[1] = b;
    for (int i = 2; i < count; i ++)
         fibArray[i] = fibArray[i-1] + fibArray[i-2];

    ShowArray(fibArray);
}

void SwowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]+" ");
}

Console.WriteLine(" Input count of elements: ");
int count_elem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Input count first element: ");
int first_elem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Input second element: ");
int second_elem  = Convert.ToInt32(Console.ReadLine());

Fibonachi(count_elem, first_elem, second_elem);
*/

//Напишите программу , которая принимает на вход три числа и проверяет
// может ли существовать треугольник со сторонами такой длины
// каждая сторона треугольника меньше суммы двух других сторон
 
 /*
 bool Triangle(int side1, int side2, int side3)
 {
    if (side1 + side2 > side3 && side2 + side3 > side1 && side3 + side1 > side2)
        return true;
    else return false;    
 }

 Console.WriteLine("Input first side: ");
int first_side = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Input second side: ");
int second_side = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Input third side: ");
int third_side = Convert.ToInt32(Console.ReadLine());

bool result = Triangle(first_side, second_side, third_side);
if (result == true)

    Console.WriteLine("Triangle exists");

else Console.WriteLine(" Triangle does not exist");    
*/

//10|2
//10 5 | 2

/*
string BinarSyst (int num)
{
    string binResult =string.Empty;
    while (num != 0)
    {
        binResult = num % 2 + binResult; //10%2-> 0 => binresult = 0
         num/=2;                                 // 5 % 2 ->1 => 10
    }
    return binResult;
}
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

string res = BinarSyst(number);
Console.WriteLine($"Your number {number} in binar syst is {res}: ");
*/
/*
y = k1*x +b1
y = k2*x +b2

k1x +b1 = k2*x +b2
k1*x - k2*x = b2-b1
x(k1-k2)=b2-b1
x = (b2-b1)/k1-k2

k1 = k2  //paralell

*/

//Задача 43: Напишите программу, которая найдёт точку пересечения 
//двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*

bool Point(int b1, int k1, int b2, int k2)
 {
    if int k1 = int k2
        return Parallel;    
    else return (int x = int b2 - int b1) / (int k1-int k2);    
 }

 Console.WriteLine("Input first element b1 : ");
int b1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Input  element k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Input  element b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input  element k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

bool result = Point(x);
if (result = int k1 = int k2)

    Console.WriteLine("Point of intersection is ");

else Console.WriteLine(" Parallel ");    

*/

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 
//0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3



/*
 bool SummNumbers (int M, int M1, int M2)
 { 
   
    if (M  > 0 && M1 > 0 && M2 > 0)
        return result  
 }

 Console.WriteLine("Input M: ");
int M = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Input M1: ");
int M1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Input M2: ");
int M2 = Convert.ToInt32(Console.ReadLine());

bool result = SummNumbers(M + M1+ M2);


    Console.WriteLine($"Summa positive numbers is {result} ");
*/


