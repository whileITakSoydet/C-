using CoderDecoder;

internal class Pr0gram
{
    private static void Main()
    {
        List<UnlistedPhone> phoneList = new List<UnlistedPhone>();
        CreateContact(ref phoneList);
        while (true)
        {
            Console.WriteLine("Выберите действие: 1 - Добавить номер в контакт\t2 - Вывести список контактов \n3 - Удалить контакт \t4 - Завершить работу\t5 - Очистить консоль");
            int.TryParse(Console.ReadLine(), out int choose);
            switch (choose)
            {
                case 1:
                    CreateContact(ref phoneList);
                    break;
                case 2:
                    foreach (UnlistedPhone phone in phoneList)
                    {

                        Console.WriteLine(phone);
                    }
                    break;
                case 3:
                    Console.WriteLine("Введите номер который хотите удалить");
                    int.TryParse(Console.ReadLine(), out int number);
                    if (number >= 0 && number < phoneList.Count)
                    {
                        phoneList.RemoveAt(number);
                    }
                    else
                    {
                        Console.WriteLine("Такого номера в списке нет");
                    }
                    break;
                case 4:
                    return;
                case 5:
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Неверные Данные");
                    break;
            }
        }
    }

    private static void CreateContact(ref List<UnlistedPhone> phoneList)
    {
        UnlistedPhone phoneFreak;
        string name, phone;
        Console.WriteLine("Введите имя");
        name = Console.ReadLine();
        Console.WriteLine("Введите нномер телефона");
        phone = Console.ReadLine();
        Console.WriteLine("Введите 0 чтобы применить простой шифр или 1 чтобы сложный:");
        int.TryParse(Console.ReadLine(), out int number);
        if (number == 0)
        {
            phoneFreak = new UnlistedPhone(name, phone, false);
        }
        else if (number == 1)
        {
            phoneFreak = new UnlistedPhone(name, phone, true);
        }
        else
        {
            Console.WriteLine("Введенные данные не верны");
            return;
        }
        phoneList.Add(phoneFreak);
    }
}