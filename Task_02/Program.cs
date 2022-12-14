using System.Collections.Generic;
using static System.Console;

namespace Task_02
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, string> phoneBook= new Dictionary<string, string>();

            WritingPhoneBook(phoneBook);
            Clear();
            ReadPhoneBook(phoneBook);

        }

        // Запись в телефонную книгу
        static void WritingPhoneBook(Dictionary<string, string> sourceBook)
        {
            while (true)
            {
                Write("Введите ФИО абонента: ");
                string name = ReadLine();

                if (name == string.Empty) break;

                Write("Введите номер абонента: ");
                string phoneNumber = ReadLine();

                sourceBook.Add(phoneNumber, name);
                WriteLine();
            }
        }

        // Чтение телефонной книги
        static void ReadPhoneBook(Dictionary<string, string> sourceBook)
        {
            while (true)
            {
                Write("Введите номер: ");
                string phoneNumber = ReadLine();

                if (phoneNumber == string.Empty) break;

                if (sourceBook.TryGetValue(phoneNumber, out string name))
                    WriteLine($"Абонентом данного номера является:\n{name}");
                else WriteLine("Пользователя с данным номером нет в списке.\n");
                WriteLine();
            }
        }
    }
}
