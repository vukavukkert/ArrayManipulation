using System;


class MenuTask
{
    private static int n = 0;
    private static int[] arr;
    public static void Menu(ref int num)
    {
        Console.WriteLine(" Введите номер от 1 до 7 ");
        Console.WriteLine(" 1 - Создать массив ");
        Console.WriteLine(" 2 - Вывести элементы массива");
        Console.WriteLine(" 3 - Сортировка выбором");
        Console.WriteLine(" 4 - Пирамидальная сортировка ");
        Console.WriteLine(" 5 - Сортировка «Пузырькам»");
        Console.WriteLine(" 6 - Шейкер сортировка ");
        Console.WriteLine(" 7 - Выход ");
        num = int.Parse(Console.ReadLine());
        switch (num)
        {
            case 1:
                Console.WriteLine("Введите количество элементов "); 
                n = int.Parse(Console.ReadLine());
                CreateArray(ref arr, n); break;
            case 2: Print(arr); break;
            case 3: SortChoice(ref arr); break;
            case 4: //HeapSort(ref arr);
                    break;
            case 5: BubbleSort(ref arr); break;
            case 6: ShakerSort(ref arr); break;
            default:
                break;
        }
    }

    private static void ShakerSort(ref int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            for(int i = left; i < right; i++)
            {
                if (arr[i] > arr[i + 1]) Swap(ref arr[i], ref arr[i + 1]);
            }
            right--;

            for (int i = right; i > left; i--)
            {
                if (arr[i] < arr[i + 1]) Swap(ref arr[i], ref arr[i + 1]);
            }
            left++;
        }
    }

    private static void BubbleSort(ref int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - i; j++)
            {
                if (arr[i] > arr[j+ 1])
                {
                    Swap(ref arr[i], ref arr[j + 1]);
                }
            }
        }
    }

    private static void HeapSort(ref int[] arr)
    {
        //later
    }


    private static void SortChoice(ref int[] arr)
    {
        for(int i = 0; i < arr.Length - 1; i++)
        {
            int min = i;
            for(int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }
            Swap(ref arr[i], ref arr[min]);
        }
    }

    private static void Swap(ref int i, ref int j)
    {
        int swap = i;
        i = j;
        j = swap;
    }
    private static void Print(int[] arr)
    {
        Console.Write(String.Join(" ", arr));
        Console.WriteLine();
    }

    private static void CreateArray(ref int[] arr, int n)
    {
        int[] newarr = new int[n];
        Console.WriteLine("Введите Элементы: ");
        for (int v = 0; v < n; v++)
        {
            newarr[v] = int.Parse(Console.ReadLine());
        }
        arr = newarr;
    }
}

