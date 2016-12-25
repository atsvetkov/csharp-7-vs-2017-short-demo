using System;

public static class IntegerParser
{
    private const int MinDigit = '0';
    private const int MaxDigit = '9';

    public static (bool success, int result) TryParse(object number)
    {
        switch (number)
        {
            case int i:
                return (true, i);
            case string s:
                (bool isParsed, int value) ParseString(string str)
                {
                    var res = 0;
                    for (var i = 0; i < str.Length; i++)
                    {
                        var charCode = (int)str[i];
                        if (charCode < MinDigit || charCode > MaxDigit)
                        {
                            return (false, res);
                        }

                        res = res * 10 + (charCode - MinDigit);
                    }

                    return (true, res);
                }

                return ParseString(s);
            default:
                throw new NotSupportedException($"{nameof(IntegerParser)} only accepts strings ans integers, type '{number.GetType()}' is not supported");
        }
    }
}