using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Collections.Generic;

namespace HW_11
{
     partial class Menu
    {
        //private void FilterCountriesByMistoUnknown()
        //{
        //    var collection = sortingPersons
        //        .Where(e => string.IsNullOrEmpty(e.misto));
        //    Console.Write(collection.ToLineList(
        //        "\nСписок країн, для яких не вказано місто"));
        //    KeyPressWaiting();
        //}

        //private void FilterPersonsByAgeHasValue()
        //{
        //    var collection = sortingPersons.Where(e => e.age.HasValue);
        //    Console.Write(collection.ToLineList(
        //        "\nСписок осіб, для яких вказано значення віку"));
        //    KeyPressWaiting();
        //}

        private void FilterPolicemanByStartDepartment()
        {
            Console.Write("\n\tПочаток назви: ");
            string nameStart = Console.ReadLine();
            var collection = sortingPolicemans
                .Where(e => e.Department.StartsWith(nameStart,
                StringComparison.InvariantCultureIgnoreCase));
            Console.Write(collection.ToLineList(string.Format(
                "\nСписок осіб, які находяться в одному віділку \"{0}\"",
                nameStart)));
            KeyPressWaiting();
        }

        private void FilterPolicemanByStartSname()
        {
            Console.Write("\n\tФрагмент назви: ");
            string nameSubstring = Console.ReadLine();
            var collection = sortingPolicemans
                .Where(e => e.SecondNamePoliceman.IndexOf(nameSubstring,
                StringComparison.InvariantCultureIgnoreCase) >= 0);
            Console.Write(collection.ToLineList(string.Format(
                "\nСписок поліцейськиз, Прізвище яких містить \"{0}\"",
                nameSubstring)));
            KeyPressWaiting();
        }

        private void FilterСitizensByStartSname()
        {
            Console.Write("\n\tФрагмент назви: ");
            string nameSubstring = Console.ReadLine();
            var collection = sortingСitizens
                .Where(e => e.SecondNameСitizen.IndexOf(nameSubstring,
                StringComparison.InvariantCultureIgnoreCase) >= 0);
            Console.Write(collection.ToLineList(string.Format(
                "\nСписок Жителів, Прізвище яких містить \"{0}\"",
                nameSubstring)));
            KeyPressWaiting();
        }

        //private bool lox1()
        //{
        //    Console.Write("\n\t: Введіть номер телефону :");
        //    string Parol = Console.ReadLine();
        //    var collection = sortingPolicemans
        //        .Where(e => e.P.StartsWith(Parol,
        //        StringComparison.InvariantCultureIgnoreCase));
        //    Console.Write(collection.ToLineList(string.Format(
        //        "\nСписок осіб, які находяться в одному віділку \"{0}\"",
        //        Parol)));
        //    KeyPressWaiting();
        //    return false;
        //}
        public ICollection<Сitizen>
    Сitizens { get { return dataSet.Сitizens; } }

        public bool Lox2()
        {
            Console.Write("\n\tВведіть номер телефону : ");
            string Parol = Console.ReadLine();
            
            foreach (var item in Сitizens)
            {
                if (Parol == item.PhoneNumber)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }       return false;

        }

        public bool Lox1()
        {
            Console.Write("\n\tВведіть номер телефону : ");
            string Parol = Console.ReadLine();
            foreach (var item in sortingPolicemans)
            {
                if (Parol == item.NamePoliceman)
                {
                    return true;
                }

            }
            return false;

        }


    }
}
