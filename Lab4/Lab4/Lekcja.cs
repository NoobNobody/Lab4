/*
using (var sr = new StreamReader("sample.txt"))
{
    var line = sr.ReadLine();
    while (line != null)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }
}

//Otwieramy stream pliku sample.txt

using (var sr = new StreamReader("sample.txt"))
{
    var line = sr.ReadToEnd();
    Console.WriteLine(line);
}

//Nadpisuje elementy do naszego pliku


//Dopisuje elementy do naszego pliku
using (var sw = new StreamWriter("sample.txt", append: true))
{
    sw.WriteLine("LOL");
    sw.WriteLine("xD");
}
*/

