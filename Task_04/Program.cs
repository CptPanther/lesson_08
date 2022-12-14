using System.Xml.Linq;
using static System.Console;

namespace Task_04
{
    internal class Program
    {
        static void Main()
        {
            XDocument writeBook = new XDocument();

            XElement person = new XElement("person");

            Write("ФИО: ");
            string fullName = ReadLine();
            XAttribute nameAttr = new XAttribute("name", fullName);

            Write("Улица: ");
            string street = ReadLine();
            Write("Номер дома: ");
            string homeNumber = ReadLine();
            Write("Номер квартиры: ");
            string flatNumber = ReadLine();

            XElement addressElem = new XElement("Address",
                new XElement("Street", street),
                new XElement("HomeNumber", homeNumber),
                new XElement("FlatNumber", flatNumber)
                );

            Write("Номер мобильного телефона: ");
            string mobilePhoneNumber = ReadLine();
            Write("Номер домашнего телефона: ");
            string homePhoneNumber = ReadLine();

            XElement phonesElem = new XElement("Phones",
                new XElement("MobilePhone", mobilePhoneNumber),
                new XElement("FlatPhone", homePhoneNumber)
                );

            person.Add(nameAttr);
            person.Add(addressElem);
            person.Add(phonesElem);

            writeBook.Add(person);

            writeBook.Save("WriteBook.xml");

            WriteLine("Запись произведена успешно.");
            ReadKey(true);
        }
    }
}
