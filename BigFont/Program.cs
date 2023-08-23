var chars = new Dictionary<char, string[]>()
{
    {'0',
        new[]
        {
            " XXX ",
            "X   X",
            "X   X",
            "X   X",
            "X   X",
            " XXX ",
        }
    },
    {'1',
        new[]
        {
            " X",
            "XX",
            " X",
            " X",
            " X",
            " X",
        }
    },
    {'2',
        new[]
        {
            " XXX ",
            "X   X",
            "   X ",
            " XX  ",
            "X    ",
            "XXXXX",
        }
    },
    {'3',
        new[]
        {
            " XXX ",
            "X   X",
            "   X ",
            "    X",
            "X   X",
            " XXX ",
        }
    },
    {'4',
        new[]
        {
            "  X X",
            " X  X",
            "X   X",
            "XXXXX",
            "    X",
            "    X",
        }
    },
    {'5',
        new[]
        {
            "XXXXX",
            "X    ",
            "XXXX ",
            "    X",
            "X   X",
            " XXX ",
        }
    },
    {'6',
        new[]
        {
            " XXX ",
            "X    ",
            "XXXX ",
            "X   X",
            "X   X",
            " XXX ",
        }
    },
    {'7',
        new[]
        {
            "XXXXX",
            "    X",
            "   X ",
            "  X  ",
            "  X  ",
            "  X  ",
        }
    },
    {'8',
        new[]
        {
            " XXX ",
            "X   X",
            " XXX ",
            "X   X",
            "X   X",
            " XXX ",
        }
    },
    {'9',
        new[]
        {
            " XXX ",
            "X   X",
            "X   X",
            " XXXX",
            "    X",
            " XXX ",
        }
    },
    {'.',
        new[]
        {
            "  ",
            "  ",
            "  ",
            "  ",
            "xx",
            "XX",
        }
    },
};

Console.Write("Enter string: ");
var str = Console.ReadLine();
if (string.IsNullOrEmpty(str)) return;

Console.WriteLine();
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
