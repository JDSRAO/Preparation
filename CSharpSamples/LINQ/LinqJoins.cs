using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.LINQ
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public partial class Pet
    {
        public string Name { get; set; }
        public Person Owner { get; set; }
    }

    class Cat : Pet
    { }

    class Dog : Pet
    { }

    public static class DataClass
    {
        internal static List<Person> Persons { get; set; }
        internal static List<Pet> Pets { get; set; }

        public static void GetData(out List<Person> persons, out List<Pet> pets)
        {
            Person magnus = new Person { FirstName = "Magnus", LastName = "Hedlund" };
            Person terry = new Person { FirstName = "Terry", LastName = "Adams" };
            Person charlotte = new Person { FirstName = "Charlotte", LastName = "Weiss" };
            Person arlene = new Person { FirstName = "Arlene", LastName = "Huff" };
            Person rui = new Person { FirstName = "Rui", LastName = "Raposo" };

            Pet barley = new Pet { Name = "Barley", Owner = terry };
            Pet boots = new Pet { Name = "Boots", Owner = terry };
            Pet whiskers = new Pet { Name = "Whiskers", Owner = charlotte };
            Pet bluemoon = new Pet { Name = "Blue Moon", Owner = rui };
            Pet daisy = new Pet { Name = "Daisy", Owner = magnus };

            persons = new List<Person> { magnus, terry, charlotte, arlene, rui };
            pets = new List<Pet> { barley, boots, whiskers, bluemoon, daisy };
        }

        public static void CreateData()
        {
            Person magnus = new Person { FirstName = "Magnus", LastName = "Hedlund" };
            Person terry = new Person { FirstName = "Terry", LastName = "Adams" };
            Person charlotte = new Person { FirstName = "Charlotte", LastName = "Weiss" };
            Person arlene = new Person { FirstName = "Arlene", LastName = "Huff" };
            Person rui = new Person { FirstName = "Rui", LastName = "Raposo" };

            Pet barley = new Pet { Name = "Barley", Owner = terry };
            Pet boots = new Pet { Name = "Boots", Owner = terry };
            Pet whiskers = new Pet { Name = "Whiskers", Owner = charlotte };
            Pet bluemoon = new Pet { Name = "Blue Moon", Owner = rui };
            Pet daisy = new Pet { Name = "Daisy", Owner = magnus };

            Persons = new List<Person> { magnus, terry, charlotte, arlene, rui };
            Pets = new List<Pet> { barley, boots, whiskers, bluemoon, daisy };
        }

        public static void SimpleJoinQuery()
        {
            var query = from person in Persons
                        join pet in Pets on person equals pet.Owner
                        select new
                        {
                            Name = $"{person.FirstName} {person.LastName}",
                            PetName = pet.Name
                        } into orderList
                        orderby orderList.Name
                        select orderList;

            var list = query.ToList();

            foreach (var item in query)
            {
                Console.WriteLine($"{item.Name} owns {item.PetName}");
            }

            foreach (var pet in Pets)
            {
                Console.WriteLine($"{pet.Name} is owned bt {pet.Owner.FirstName}");
            }
        }


        public static void CompositeJoinQuery()
        {
            Person magnus = new Person { FirstName = "Magnus", LastName = "Hedlund" };
            Person terry = new Person { FirstName = "Terry", LastName = "Adams" };
            Person charlotte = new Person { FirstName = "Charlotte", LastName = "Weiss" };
            Person arlene = new Person { FirstName = "Arlene", LastName = "Huff" };
            Person rui = new Person { FirstName = "Rui", LastName = "Raposo" };
            Person phyllis = new Person { FirstName = "Phyllis", LastName = "Harris" };

            Cat barley = new Cat { Name = "Barley", Owner = terry };
            Cat boots = new Cat { Name = "Boots", Owner = terry };
            Cat whiskers = new Cat { Name = "Whiskers", Owner = charlotte };
            Cat bluemoon = new Cat { Name = "Blue Moon", Owner = rui };
            Cat daisy = new Cat { Name = "Daisy", Owner = magnus };

            Dog fourwheeldrive = new Dog { Name = "Four Wheel Drive", Owner = phyllis };
            Dog duke = new Dog { Name = "Duke", Owner = magnus };
            Dog denim = new Dog { Name = "Denim", Owner = terry };
            Dog wiley = new Dog { Name = "Wiley", Owner = charlotte };
            Dog snoopy = new Dog { Name = "Snoopy", Owner = rui };
            Dog snickers = new Dog { Name = "Snickers", Owner = arlene };


            List<Person> people =
                new List<Person> { magnus, terry, charlotte, arlene, rui, phyllis };
            List<Cat> cats =
                new List<Cat> { barley, boots, whiskers, bluemoon, daisy };
            List<Dog> dogs =
                new List<Dog> { fourwheeldrive, duke, denim, wiley, snoopy, snickers };

            var query = from person in Persons
                        join cat in cats on person equals cat.Owner
                        join dog in dogs on new { Owner = person, Letter = cat.Name.Substring(0,1) }
                        equals new { Owner = dog.Owner, Letter = dog.Name.Substring(0,1) }
                        select new
                        {
                            CatName = cat.Name,
                            DogName = dog.Name
                        };

            var list = query.ToList();

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"{item.Name} owns {item.PetName}");
            //}

           
        }
    }
}
