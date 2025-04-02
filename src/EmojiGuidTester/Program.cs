// See https://aka.ms/new-console-template for more information

using EmojiGUID;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello 🌍!");
Console.WriteLine("\U0001F44B");
var guid = EmojiGuid.GenerateEmojiGuid();
Console.WriteLine(guid);
Console.WriteLine(guid.GetHashCode());