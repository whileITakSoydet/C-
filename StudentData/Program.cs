using lessonClassWork;

internal class Program
{
    private static void Main(string[] args)
    {
        Student stud = new Student();

        Console.WriteLine("Введите номер группы: ");
        stud.Group = Console.ReadLine();
        Console.WriteLine("Введите имя студента: ");
        stud.Name = Console.ReadLine();
        Console.WriteLine("Введите возраст студента: ");
        int.TryParse(Console.ReadLine(), out int age);
        stud.Age = age;
        Console.WriteLine("Введите оценки(у) по первому предмету если введете 0 или не число ввод прекратиться:");
        setMark(stud, 0);
        Console.WriteLine("Введите оценки(у) по второму предмету если введете 0 или не число ввод прекратиться:");
        setMark(stud, 1);
        Console.WriteLine("Введите оценки(у) по третьему предмету если введете 0 или не число ввод прекратиться:");
        setMark(stud, 2);
        Console.WriteLine("\n\tДанные по студенту:");
        stud.ShowStudent();
        Console.ReadKey();
    }
    private static void setMark(Student stud, int subject)
    {
        while (true)
        {
            Console.Write("Ввод: ");
            int.TryParse(Console.ReadLine(), out int mark);
            if (mark == 0)
            {
                break;
            }
            else
            {
                stud.SetScore(subject, mark);
            }
        };
    }

}