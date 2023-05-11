Stack<int> intStack = new Stack<int>();
intStack.Push(10);
intStack.Push(20);
intStack.Push(30);

Console.WriteLine(intStack.Pop());  // Output: 30

Stack<string> stringStack = new Stack<string>();
stringStack.Push("Hello");
stringStack.Push("World");

Console.WriteLine(stringStack.Pop());  // Output: World