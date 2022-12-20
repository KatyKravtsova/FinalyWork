// Написать программу, которая из имеющего массива строк формирует массив из строк,
// размер которых меньше либо равна 3 символа
//Первоначальный массив можно ввести с клавиатуры
Console.WriteLine("Создадим массив.\nКакое колличество строк будем вводить?");
int countArrayValue = int.Parse(Console.ReadLine());

string [] Array = new string [countArrayValue];
 
 string [] FillArray (string [] array)
 {
	for (int i = 0; i < countArrayValue; i++)
	{
		Console.WriteLine($"Введите {i} значение:");
		array[i] = Console.ReadLine();
	}
	return array;
}

string [] SortArray (string [] array)
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

void PrintArray (string [] array)
{
	if (array.Length == 0) Console.WriteLine("Массив пустой");
		for (int i = 0; i < array.Length; i++)
		{
			Console.Write($"  [{array[i]}]");
		}
}

FillArray(Array);

string [] endArray = SortArray(Array);

Console.WriteLine("\n Введенный массив:");
PrintArray(Array);

Console.WriteLine("\n Массив значений с длинной < либо = 3 символа:");
PrintArray(endArray);