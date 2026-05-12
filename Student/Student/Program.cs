using System;

class Student
{
    public string Name;
    public int[] Grades = new int[5];

    public double GetAverageGrade()
    {
        double sum = 0;
        for (int i = 0; i < Grades.Length; i++)
            sum += Grades[i];
        return sum / Grades.Length;
    }
}

class Program
{
    static int ReadGrade(string prompt)
    {
        int result;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out result) && result >= 1 && result <= 5)
                return result;
            else
                Console.WriteLine("Ошибка! Введите целое число от 1 до 5.");
        }
    }

    static void Main()
    {
        Console.WriteLine("=== ИНТЕРАКТИВНЫЙ ЖУРНАЛ ===");

        Student[] students = new Student[2];

        for (int j = 0; j < students.Length; j++)
        {
            students[j] = new Student();
            Console.Write($"\nИмя студента №{j + 1}: ");
            students[j].Name = Console.ReadLine();

            Console.WriteLine($"Оценки {students[j].Name}:");
            for (int i = 0; i < 5; i++)
            {
                students[j].Grades[i] = ReadGrade($"Предмет {i + 1}: ");
            }
        }

        Console.WriteLine("\n====================");
        Console.WriteLine("ИТОГОВАЯ ВЕДОМОСТЬ:");
        foreach (Student s in students)
        {
            Console.WriteLine($"{s.Name} -> {s.GetAverageGrade():F2} балла");
        }

        Console.ReadKey();
    }
}