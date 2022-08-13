// Условные виды методов.
// Вид 1. Ничего не принимает и не возвращает. (void)

// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }

// Method1();



// // Вид 2. Что-то принимает, но ничего не возвращает.(void)

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// Method2("Сообщение из Метод2");

// void Method21(int count, string msg) //выводит необходимое кол-во раз какой-то текст.
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }

// Method21(4, msg: "текст из Метод21"); // если использовать именованные аргументы, как тут msg:, тогда можно не соблюдать порядок. 
// //Иначе надо передавать аргументы в том порядке, в котором они указаны в методе.


// // Вид 3. Ничего не принимает что-то возвращает. (генерация случайных данных, например)

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// // Вид 4. Что-то принимает и что-то возвращает. (применяются чаще всего)

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; // пустая строка, аналог = ""; но более грамотная запись.
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "F");
// Console.WriteLine(res);

// string Method41(int count, string text) // с использованием конструкции for
// {

//     string result = String.Empty; // пустая строка, аналог = ""; но более грамотная запись.
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res41 = Method41(10, "U");
// Console.WriteLine(res41);

// for (int i = 2; i <= 10; i++) // циклы через for. Очень часто используются. Тут внешний и внутренний цикл.
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// // Задача!
// // Дан текст. В тексте нужно все пробелы заменить черточками,
// // маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// // маленькими “с”.

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//             + " ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + " Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty" //в строке каждый символ находится по своему индексу, как в массиве.
// //             012
// // s[3] = "r";
// string Replace(string text, char oldValue, char newValue) //char - конкретный символ.
// {
//     string result = String.Empty;
//     int length = text.Length; // метод, .Length возвращает кол-во символов в строке.
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         //если встречаем символ для замены, то в новую строку с результатом пишем замененый символ, если нет, то оставляем старый.
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '-'); //char пишутся в одинарных кавычках!
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine();

// Задача. Упорядочить массив методом сортировки выбором
// 6 8 3 2 1 4 5 7

int[] arr = { 6, 8, 3, 2, 1, 4, 5, 7, 1, 4 }; //для этого алгоритма не важно, есть ли повторяющиеся символы.

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortMinMax(int[] array) //метод сортировки выбором от меньшего к большему
{
    for (int i = 0; i < array.Length - 1; i++) //внешний цикл, который изначально находит наименьший элемент.
    //array.Length - 1 пишется во внешнем цикле чтобы дойти до конца массива, т.к. внутренний цикл берет i+1 (следующий элемент)
    //если не указать -1, то не дойдем до последнего элемента массива.
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        // внутренний цикл, который берет следующий после минимального элемент, сравнивает его с остальными и при необходимости меняет местами элементы.
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temp = array[i]; //эта часть меняет элементы местами.
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

void SelectionSortMaxMin(int[] array) //сортировка в обратном порядке. От большего к меньшему.
{
    for (int i = 0; i < array.Length - 1; i++) //внешний цикл, который изначально находит наименьший элемент.
    //array.Length - 1 пишется во внешнем цикле чтобы дойти до конца массива, т.к. внутренний цикл берет i+1 (следующий элемент)
    //если не указать -1, то не дойдем до последнего элемента массива.
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        // внутренний цикл, который берет следующий после минимального элемент, сравнивает его с остальными и при необходимости меняет местами элементы.
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temp = array[i]; //эта часть меняет элементы местами.
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}

PrintArray(arr);
SelectionSortMinMax(arr);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
SelectionSortMaxMin(arr);
PrintArray(arr);
