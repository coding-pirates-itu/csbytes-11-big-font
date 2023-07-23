var chars = new Dictionary<char, string[]>()
{
    {'0',
        new[]
        {
            " xXx ",
            "x   x",
            "X   X",
            "x   x",
            " xXx ",
        }
    },
    {'1',
        new[]
        {
            " X",
            "xX",
            " X",
            " X",
            " X",
        }
    },
    {'2',
        new[]
        {
            " xXx ",
            "x   x",
            "  xx ",
            " x   ",
            "XXXXX",
        }
    },
    {'3',
        new[]
        {
            " xXx ",
            "x   x",
            "   x ",
            "x   x",
            " xXx ",
        }
    },
};

Console.Write("Enter string: ");
var str = Console.ReadLine();
if (string.IsNullOrEmpty(str)) return;

var x = 0;
foreach (var ch in str)
{
    var width = PrintChar(ch, x);
    x += width + 1;
}

Console.ReadKey(true);


int PrintChar(char ch, int x)
{
    if (!chars.TryGetValue(ch, out var lines)) return 0;

    var y = Console.CursorTop;

    foreach (var line in lines)
    {
        Console.CursorLeft = x;
        Console.WriteLine(line);
    }

    Console.CursorTop = y;

    return lines[0].Length;
}
