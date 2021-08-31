using static System.Console;

namespace ContactManager
{
    public class Displey
    {
        public void ShowReseption()
        {
            ShowSign();
            ShowMenu();
            ShowAmount();
        }
        public void ShowFrame(string title)
        {
            ShowSign();
            WriteLine(title + "\n");
        }

        public string RequestUser(string msg)
        {
            Write(msg);
            return ReadLine();
        }

        public void ShowSign()
        {
            Clear();
            WriteLine(
                "-------------------------Приложение:-------------------------\n" +
                "----------------------Контакт менеджер-----------------------\n" +
                "------------------Формат файлов xml, json--------------------\n");
        }
        public void ShowMenu()
        {
            WriteLine(
                "   Меню\n" +
                " Escape - выход\n" +
                " 0 - Вернуться на главный экран (этот)\n" +
                " 1 - Показать все контакты\n" +
                " 2 - Добавить новый контакт\n" +
                " 3 - Редактировать контакт по ID\n" +
                " 4 - Удалить контакт по ID\n" +
                " 5 - Перемещение данных в указанный файл\n" +
                " 6 - Импортировать данные из указанного файла\n" +
                " 7 - Сохраниться :)\n\n");
        }
        public void ShowAmount()
        {
            WriteLine(
                $"В базе {Program.contacts.Count} контактов");
        }

        public void ShowEnd()
        {
            ShowSign();
            WriteLine();
            WriteLine(
                "----------------Работа приложения завершена-------------------\n" +
                "---------------------Файл базы сохранён----------------------\n" +
                "--------------------Спасибо за внимание----------------------\n");
        }
        public void ContactShowAll()
        {
            ShowSign();
            foreach (var contact in Program.contacts)
            {
                ContactShowOne(contact);
            }
            ShowAmount();
            WriteLine("\n\n 0 - Вернуться на главный экран \n");
        }
        public void ContactShowOne(Contact contact)
        {
            WriteLine($"id: {contact.ContactID}");
            WriteLine($"contact: {contact.Surname} {contact.Name} {contact.Patronymic}");
            WriteLine($"birth: {contact.DateOfBirth.YearBirth}.{contact.DateOfBirth.MonthBirth}.{contact.DateOfBirth.DayBirth}\tage: {contact.DateOfBirth.AgeNow()}");
            WriteLine($"M_phone: {contact.PhoneNumbers.Mobile}");
            WriteLine($"W_phone: {contact.PhoneNumbers.Work}");
            WriteLine($"W_email: {contact.Email.Work}");
            WriteLine($"city: {contact.City}");
        }
    }
}