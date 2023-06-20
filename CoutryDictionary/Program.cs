using CountryDictionary;
using System.Collections.Generic;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("Добро пожаловать в мой словарь");
        string rus, eng;
        Glossary dictionary = new Glossary();
        while (true)
        {
            Console.WriteLine("Нажмите 1 - чтобы вывести все слова словаря\n2 - чтобы дабавить слово в словарь\n" +
                "3 - чтобы удалить слово\n4 - завершить работу со словарем\n5 - найти перевод слова");
            int.TryParse(Console.ReadLine(), out int choice);
            switch (choice)
            {
                case 1: 
                    dictionary.ShowWords(); 
                    break;
                case 2:
                    Console.WriteLine("Введите слово на русском: ");
                    rus = Console.ReadLine();
                    Console.WriteLine("Введите его перевод: ");
                    eng = Console.ReadLine();
                    dictionary.AddWords(rus, eng);
                    break;
                case 3:
                    Console.WriteLine("Если слово будет на русском введите 1 любое другое значение значит что слово будет на английском");
                    if (int.TryParse(Console.ReadLine(), out int x))
                    {
                        if (x == 1)
                        {
                            Console.WriteLine("Вводите:");
                            rus = Console.ReadLine();
                            dictionary.DellRussianWords(rus);
                        }
                        else
                        {
                            Console.WriteLine("Enter:");
                            eng = Console.ReadLine();
                            dictionary.DellEnglishWords(eng);
                        }
                    }                    
                    break;
                case 4:
                    return;
                case 5:
                    Console.WriteLine("Если слово будет на русском введите 1 любое другое значение значит что слово будет на английском");
                    if(int.TryParse(Console.ReadLine(), out int y))
                    {
                        if(y == 1)
                        {
                            Console.WriteLine("Вводите:");
                            rus = Console.ReadLine();
                            Console.WriteLine(dictionary.GetRussianWord(rus));
                        }
                        else
                        {
                            Console.WriteLine("Enter:");
                            eng = Console.ReadLine();
                            Console.WriteLine(dictionary.GetEnglishWord(eng));
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Неверно введеные данные");
                    break;
            }
        }
    }
}