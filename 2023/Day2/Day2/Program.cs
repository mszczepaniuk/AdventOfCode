var lines = File.ReadAllLines("input.txt");
//var lines = new[] {
//"two1nine",
//"eightwothree",
//"abcone2threexyz",
//"xtwone3four",
//"4nineeightseven2",
//"zoneight234",
//"7pqrstsixteen"
//};

var digitsMap = new Dictionary<string, string>
{
    { "one", "o1ne" }, { "two", "t2wo" }, { "three", "t3hree" }, { "four", "f4our" }, { "five", "f5ive" }, { "six", "s6ix" }, { "seven", "s7even" }, { "eight", "e8ight" }, { "nine", "n9ine" }
};

var result = 0;

foreach (var line in lines)
{
    var updatedLine = line;
    foreach (var (key, value) in digitsMap)
    {
        updatedLine = updatedLine.Replace(key, value);
    }

    updatedLine = string.Concat(updatedLine.Select(c => int.TryParse(c.ToString(), out _) ? c.ToString() : "").Where(c => c != ""));
    var number = int.Parse(updatedLine.First().ToString()) * 10 + int.Parse(updatedLine.Last().ToString());
    Console.WriteLine(number);
    result += number;
}

Console.WriteLine(result);