# 🎓 Экзаменационная работа

**Фамилия Имя:** Шмаков Владимир
**Вариант:** 25
**Дата:** 12 мая 2026

---

## 📋 Задание

> Класс «Студент» и средний балл.
> Создать класс Student с полями: Имя и массив из 5 оценок.
> Добавить метод GetAverageGrade().
> Создать двух студентов, выставить им оценки, вывести имя и средний балл каждого.

---

## 🛠️ Технологии

| Компонент | Описание |
|-----------|----------|
| **Язык** | C# |
| **Среда разработки** | Visual Studio Community |
| **Тип проекта** | Консольное приложение (.NET) |

---

## ⚙️ Установка и запуск

1. Скачайте и установите **Visual Studio Community** с [официального сайта](https://visualstudio.microsoft.com/ru/vs/community/)
2. При установке выберите рабочую нагрузку «**Разработка классических приложений .NET**»
3. Клонируйте репозиторий или скачайте архив с кодом
4. Откройте файл решения (`.sln`) в Visual Studio
5. Нажмите **F5** или кнопку **▶ Пуск** для запуска
6. Введите данные студентов в консоли и получите средний балл

---

## 💻 Код решения

```csharp
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

---

📸 Скриншот работы приложения

<img src="./1.png">

---

📝 Примечания
Программа запрашивает имена двух студентов и по 5 оценок для каждого

Оценки проверяются на корректность — только целые числа от 1 до 5

При вводе некорректного значения программа попросит повторить ввод

Средний балл выводится с точностью до двух знаков после запятой