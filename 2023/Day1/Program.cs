var lines = File.ReadAllLines("input.txt");

var result = 0;

foreach (var line in lines)
{
    var digitsLine = line.Select(c => int.TryParse(c.ToString(), out _) ? c.ToString() : "").Where(c => c != "");
    var number = int.Parse(digitsLine.First().ToString()) * 10 + int.Parse(digitsLine.Last().ToString());

    result += number;
}

Console.WriteLine(result);