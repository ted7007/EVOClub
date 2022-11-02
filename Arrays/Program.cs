

// объявление:
#region массивы

////тип_переменной[] название_массива;

//// определение массива
//int[] numbers;


//// определение массива и выделение памяти для 4-х элементов; каждый элемент равен дефолтному значению его типа
//int[] nums = new int[4];

//// сразу указали значения для массива, все массивы по факту равны
//int[] nums2 = new int[4] { 1, 2, 3, 5 };

//int[] nums3 = new int[] { 1, 2, 3, 5 };

//int[] nums4 = new[] { 1, 2, 3, 5 };

//int[] nums5 = { 1, 2, 3, 5 };


//// Также и с другими типами
//string[] people = { "Tom", "Sam", "Bob" };

#endregion

#region работа с индексом

//int[] numbers = { 1, 2, 3, 5 };

//// получение элемента массива
//Console.WriteLine(numbers[3]);  // ?

//// получение элемента массива в переменную
//var n = numbers[1];     // ?
//Console.WriteLine(n);  // ?

//// изменим второй элемент массива
//numbers[1] = 505;

//Console.WriteLine(numbers[1]);  // ?

////Console.WriteLine(numbers[6]);

#endregion

#region Получение элементов с конца

//int[] numbers = { 1, 2, 3, 5 };

//Console.WriteLine(numbers[numbers.Length - 1]);  
//Console.WriteLine(numbers[numbers.Length - 2]);  
//Console.WriteLine(numbers[numbers.Length - 3]);

#region оператор ^

//Console.WriteLine(numbers[^1]);  // 5 - первый с конца или последний элемент
//Console.WriteLine(numbers[^2]);  // 3 - второй с конца или предпоследний элемент
//Console.WriteLine(numbers[^3]);  // 2 - третий элемент с конца


#endregion

#endregion

#region перебор

//int[] numbers = { 1, 2, 3, 4, 5 };
//foreach (int i in numbers)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//int i = 0;
//while (i < numbers.Length)
//{
//    Console.WriteLine(numbers[i]);
//    i++;
//}

////Как ещё можно?

#endregion

#region Многомерные массивы
///*
//        0 1 2
//        3 4 5
//*/

//int[,] nums1;
//int[,] nums2 = new int[2, 3];
//int[,] nums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
//int[,] nums4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
//int[,] nums5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
//int[,] nums6 = { { 0, 1, 2 }, { 3, 4, 5 } };

//int[,,] nums7 = new int[2, 3, 4];

    #region перебор

//    int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };
//    foreach (int i in numbers)
//        Console.Write($"{i} ");
//Console.WriteLine();
#region перебор в виде таблицы

//for (int i = 0; i < numbers.GetLength(0); i++)
//{
//    for (int j = 0; j < numbers.GetLength(1); j++)
//    {
//        Console.Write($"{numbers[i, j]} \t");
//    }
//    Console.WriteLine();
//}

#endregion

#endregion

#endregion
