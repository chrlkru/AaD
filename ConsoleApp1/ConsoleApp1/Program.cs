﻿Console.Write("Укажите путь к файлу: ");
var path = Console.ReadLine()!;
var text = File.ReadAllText(path);
Console.Write("Укажите ключ: ");
var key = int.Parse(Console.ReadLine()!);
Console.Write("Укажите путь к новому файлу: ");