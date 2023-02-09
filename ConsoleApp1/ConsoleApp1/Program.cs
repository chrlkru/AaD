Console.Write("Укажите путь к файлу: ");
var path = Console.ReadLine()!;
var text = File.ReadAllText(path);
Console.Write("Укажите ключ: ");