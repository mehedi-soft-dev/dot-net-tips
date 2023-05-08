using IndexerExample;

int[] numbers = { 1, 2, 3, 4, 5 };
MyList list = new MyList(numbers);

Console.WriteLine(list[0]); // Output: 1
Console.WriteLine(list[4]); // Output: 5

list[2] = 10;
Console.WriteLine(list[2]);