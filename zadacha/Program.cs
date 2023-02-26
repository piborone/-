//  Написать программу, которая из массива строк формирует массив из строк, 
//  длина которых меньше либо равна 3 символа. Первоначальный массив 
//  можно ввести с клавиатуры, либо задать на старте выполнений алгоритма.*
 
 string [] FillArray (string [] array)
 {
	for (int i = 0; i < array.Length; i++)
	{
		Console.WriteLine($"Введите {i} значение:");
		array[i] = Convert.ToString(Console.ReadLine());
	}
	return array;
}

string [] Poisk (string [] array) // поиск элементов удовлетоваряющих условию
{
	int countNecessaryValue = 0;
	string arrayValue = string.Empty;
	for (int i = 0; i < array.Length; i++)
	{
		arrayValue = array[i];
		if (arrayValue.Length <= 3) countNecessaryValue++;
	}
	string [] endArray = new string [countNecessaryValue];
	int index = 0;
	for (int i = 0; i < array.Length; i++)
	{
		arrayValue = array[i];
		if (arrayValue.Length <= 3)
		{
			endArray[index] = array[i];
			index++;
		}
	}
	return endArray;
}

void PrintArray (string [] array) // вывод массива
{
	if (array.Length == 0) Console.WriteLine("Массив не имеет значений!");
		for (int i = 0; i < array.Length; i++)
		{
			Console.Write($"  [{array[i]}]");
            
		}
        System.Console.WriteLine();
}

Console.WriteLine("Создадим массив из нескольких значений");
System.Console.WriteLine("Какое колличество значений будем вводить?");

int Array = int.Parse(Console.ReadLine());
string [] startArray = new string [Array];

FillArray(startArray);

string [] endArray = Poisk(startArray);

System.Console.WriteLine();
Console.WriteLine("Первоначальный массив:");

PrintArray(startArray);

Console.WriteLine("Массив значений с длинной меньше или равной 3 символам:");
PrintArray(endArray);