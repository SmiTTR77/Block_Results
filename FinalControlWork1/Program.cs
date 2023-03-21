/* 
Task: Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
["hello", "2", "world", ".-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

string[] CreateArray(int size)
{
	string[] array = new string[size];

	for (int i = 0; i < size; i++)
	{
		Console.Write("Input a something: ");
		array[i] = Console.ReadLine();
	}
	return array;
}

void ShowArray(string[] array)
{
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");
	Console.WriteLine();
}

string[] MaxThreeChar(string[] array)
{
	int j = 0;
	string[] tempArray = new string[array.Length];

	for (int i = 0; i < array.Length; i++)
		if (array[i].Length <= 3)
		{
			tempArray[j] = array[i];
			j++;
		}

	string[] modifiedArray = new string[j];
	for (int i = 0; i < j; i++)
		modifiedArray[i] = tempArray[i];
	return modifiedArray;
}

Console.Write("Input a size array: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] newArray = CreateArray(size);
Console.WriteLine("Original array: ");
ShowArray(newArray);

string[] updatedArray = MaxThreeChar(newArray);
Console.WriteLine("Updated array:");
ShowArray(updatedArray);