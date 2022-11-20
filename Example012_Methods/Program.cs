// вид 1 = вызов метода
// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// Method1();


// Вид 2 - выводит на экран
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i<count)
//     {
//         System.Console.WriteLine(msg);
//         i++;
//     }

// }
// // Method21("Текст", 4); // если значения переменных по порядку
// Method21(count: 4, msg: "Текст"); // если значения переменных не по порядку


// Вид 3 - не принимает и что-то возвращает
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


// Вид 4 - что-то принимает и что-то возвращает
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;
//     while (i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);

// цикл FOR
// string Method4(int count, string text)
// {
//     string result = string.Empty;
//     for (int i=0; i<count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);


// цикл в цикле (таблица умножения)
    // for (int i=2; i<=10; i++)
    // {
    //     for (int j=2; j<=10; j++)
    //     {
    //         Console.WriteLine($"{i} x {j} = {i*j}");
    //     }
    //     Console.WriteLine();
    // }



// Работа с текстом
// Дан текст. В тексте нужно все пробеля заменить черточками,
// маленькие буквы "к" заменить большими "К",
// большие "С" заменить маленькими "с"

// string text = "- Я думаю, - сказал князь, улыбаясь, -что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int lenght = text.Length;
//     for (int i=0; i<lenght; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";

//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);




// сортировка в массиве
// int [] arr = {1,5,4,3,2,6,7,1,1};

// void Printarray (int[] array)
// {
//     int count = array.Length;
//     for (int i=0; i<count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i=0; i<array.Length-1; i++)
//     {
//        int minPosition = i;
//        for (int j = i+1; j<array.Length ; j++)
//        {
//         if (array[j]<array[minPosition]) minPosition = j;

//        } 
//        int temporary = array[i];
//        array[i] = array[minPosition];
//        array[minPosition] = temporary;


//     }
// }

// Printarray(arr);
// SelectionSort(arr);
// Printarray(arr);
