using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab10
{
    class Program
    {
        static void Main()
        {
            var lines = File.ReadAllLines("data.txt");
            List<Person> people = lines.Select(x =>
            {
                var data = x.Split(';');
                return new Person(Convert.ToInt32(data[0]), data[1], data[2], data[3]);
            }).ToList();

            var SortedPeople = people.OrderBy(x => x.LastName).ThenBy(x => x.Name);

            using (StreamWriter writer = new StreamWriter("result.txt"))
            {
                foreach (var item in SortedPeople)
                {
                    writer.WriteLine($"[{item.Id}] {item.Name} {item.LastName} : {item.Phone}");
                }
            }
            /*using StreamWriter writer = new StreamWriter("result.txt");
            foreach (var item in SortedPeople)
            {
                writer.WriteLine($"[{item.Id}] {item.Name} {item.LastName} : {item.Phone}");
            }*/

            //writer.Close();
        }
    }
}
