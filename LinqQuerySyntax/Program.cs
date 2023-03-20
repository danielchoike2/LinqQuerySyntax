using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class famousPeople
    {
        public string Name { get; set; }
        public int? BirthYear { get; set; } = null;
        public int? DeathYear { get; set; } = null;
    }
    public class Program
    { 
        static void Main(string[] args)
        {
            IList<famousPeople> stemPeople = new List<famousPeople>() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
     };
            // LINQ QUERY A
            var bdaysAfter1900  = stemPeople.Where(s => s.BirthYear > 1900).OrderByDescending (s => s.BirthYear). ToList < famousPeople>();


            foreach (var t in bdaysAfter1900)
            {
                Console.WriteLine($"{t.Name}\nBorn: {t.BirthYear}");
            }
            Console.WriteLine();
            // LINQ Query B

            var containsL = stemPeople.Where(s => s.Name.Contains("ll"));
            foreach (var t in containsL)
            {
                Console.WriteLine($"{t.Name}");
            }
            Console.WriteLine();
            // LINQ Query C 

            var bdayCount1 = stemPeople.Count(s=>s.BirthYear > 1950);

            Console.WriteLine($"The number of people with a birthyear after 1950 is: {bdayCount1}");
            Console.WriteLine();
            // LINQ Query D

            var bdayCount2 = stemPeople.Where(s => s.BirthYear >= 1920 && s.BirthYear <= 2000).OrderByDescending (s => s.BirthYear). ToList < famousPeople>();

            foreach (var t in bdayCount2)
            {
                Console.WriteLine($"{t.Name}\nBorn: {t.BirthYear}");
            }
            Console.WriteLine();

            var bdayCount2Count = bdayCount2.Count();
            Console.WriteLine($"The number of people with a birthday that is between 1920 & 2000 is {bdayCount2Count}");
            Console.WriteLine();

            // LINQ Query E

            var BirthDaySort = stemPeople.OrderBy(s => s.BirthYear). ToList < famousPeople>();

            foreach (var t in BirthDaySort)
            {
                Console.WriteLine($"{t.Name}\nBorn: {t.BirthYear}");
            }
            Console.WriteLine();

            //LINQ Query F 
            var DeathDaySort = stemPeople.Where(s => s.DeathYear > 1960 && s.DeathYear < 2015).OrderBy(s => s.DeathYear).ToList<famousPeople>();

            foreach (var t in DeathDaySort)
            {
                Console.WriteLine($"{t.Name}\nDied: {t.DeathYear}");
            }
            Console.WriteLine();
        }
    }
}