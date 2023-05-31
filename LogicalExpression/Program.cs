using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите выражение:");
            string str = Console.ReadLine();
            string simbol;
            str = str.Replace(" ", "");
            simbol = SymbolSearch(str, out int id);

            int[] numbers = ParseInt(str, simbol);

            if (Answer(str, simbol, id, numbers))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadKey();
    }
    
    static bool Answer(string text, string simbol, int id, int[] numbers)
    {
        if (simbol == ">")
        {
            if (numbers[0] > numbers[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        if(simbol == ">=")
        {
            if (numbers[0] >= numbers[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        if (simbol == "<=")
        {
            if (numbers[0] <= numbers[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        if (simbol == "<")
        {
            if (numbers[0] < numbers[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        if (simbol == "==")
        {
            if (numbers[0] == numbers[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        if (simbol == "!=")
        {
            if (numbers[0] != numbers[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            throw new Exception("Неверный символ условия");
        }
    }

    static string SymbolSearch(string text, out int id)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '>')
            {
                id = i;
                if (text[i+1] == '=')
                {
                    return ">=";
                }
                else
                {
                    return ">";
                }
            }
            if (text[i] == '<')
            {
                id = i;
                if (text[i + 1] == '=')
                {
                    return "<=";
                }
                else
                {
                    return "<";
                }
            }
            if (text[i] == '=')
            {
                if(text[i+1] == '=')
                {
                    id = i;
                    return "==";
                }
                else
                {
                    throw new Exception("Неверный символ");
                }
            }
            if (text[i] == '!')
            {
                if (text[i + 1] == '=')
                {
                    id = i;
                    return "!=";
                }
                else
                {
                    throw new Exception("Неверный символ");
                }
            }
        }
        throw new Exception("Символ не был найден");
    }

    static int[] ParseInt(string text, string simbol)
    {
        string[] numbers = text.Split(simbol);
        int[] num = new int[2];
        num[0] = int.Parse(numbers[0]);
        num[1] = int.Parse(numbers[1]);
        return num;
    }
}