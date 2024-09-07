public class Lab1()
{

    private class Student(
        string numberLab,
        string fio,
        string group,
        string dateOfBirth,
        string city,
        string subjectSchool,
        string hobby)
    {
        private string NumberLab { get; } = numberLab;
        private string FIO { get; } = fio;
        private string Group { get; } = group;
        private string DateOfBirth { get; } = dateOfBirth;
        private string City { get; } = city;
        private string SubjectSchool { get; } = subjectSchool;
        private string Hobby { get; } = hobby;

        public void DisplayInformation() => Console.WriteLine(
                "\nЗадание 1.\n" +
                $"Лаб. работа: {NumberLab}\n" +
                $"ФИО: {FIO}\n" +
                $"Группа: {Group}\n" +
                $"Дата рождения: {DateOfBirth}\n" +
                $"Город: {City}\n" +
                $"Любимый предмет в школе: {SubjectSchool}\n" +
                $"Хобби: {Hobby}\n"
            );
    }

    public static void Student_Information()
    {
        Student student = new(
        "№1",
        "Дуров Михаил Михайлович",
        "ВМО91",
        "19.02.1931",
        "Rostov-on-Don",
        "Физика",
        "Программирование"
        );

        student.DisplayInformation();
    }


    public static void Calculation(
        double w = 12,
        double l = 2,
        double b = 5,
        double t = 15,
        double x = 31,
        double y = 1,
        double e = 3.12)

    {
        var s = w * l * l * l + b * t - x + y * w;

        var result = s * e;

        Console.WriteLine($"Задание 2.\nРезультат вычислений: {result}");
    }
}