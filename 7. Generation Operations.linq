<Query Kind="Statements" />

Console.WriteLine(Enumerable.Repeat("hello", 3));

Console.WriteLine(Enumerable.Range(1,10));

Console.WriteLine(Enumerable.Range('a', 'z'-'a' +1).Select(c=> (char)c));

Console.WriteLine(Enumerable.Range(1,10).Select(i=> new string('x',i)));

