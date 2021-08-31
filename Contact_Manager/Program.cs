using System;
using System.Collections.Generic;

using static System.Console;

using System.Text.Json;
namespace ContactManager
{
    public class Program
    {
        public static AppActions app = new AppActions();
        public static Displey dsp = new Displey();
        public static List<Contact> contacts = new List<Contact>(3);

        static void Main()
        {
            app.LoadDB();
            dsp.ShowReseption();

            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0://Кнопка "Назад"
                        dsp.ShowReseption();
                        break;
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1://Все контакты
                        dsp.ContactShowAll();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2://Создание нового контакта
                        app.CreateNewContact();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3://Редактировать контакт
                        app.EditContact();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4://Удаление контакта
                        app.DeleteContact();
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5://Перемешение данных в указанный файл
                        app.ExportDB();
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6://Импорт данных из указаного файла
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7://Сохранение
                        app.UploadDB();
                        dsp.ShowReseption();
                        break;
                    default:
                        break;
                }
            }
            while (key.Key != ConsoleKey.Escape); //Выход из программы
            app.UploadDB();
            dsp.ShowEnd();
            ReadLine();
        }
    }
}