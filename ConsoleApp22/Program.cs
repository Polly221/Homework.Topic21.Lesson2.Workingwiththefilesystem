using System.IO;

Console.Write("Введите путь к  файлу: ");
string filePath = Console.ReadLine()! + ".txt";
FileInfo fileInfo = new FileInfo(filePath);

if (File.Exists(filePath))
    {
    Console.WriteLine("Файл существует.");
    Console.WriteLine("Размер: " + fileInfo.Length + " байт");
    Console.WriteLine("Последнее изм.: " + fileInfo.LastWriteTime);
    Console.WriteLine("Расширение: " + fileInfo.Extension);
}
else
    {
    Console.WriteLine("Файл не найден.");
    }