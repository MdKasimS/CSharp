using System;
using System.Reflection.Metadata;

namespace Packt.Shared
{
    public class Person
    {
        private string? name;
        private DateTime dateOfbirth;
        private WondersOfTheAncientWorld favoriteAncientWonder;
        private WondersOfTheAncientWorld bucketList;
        private List<Person> children = new List<Person>();

        private static int countOfPersonObject = 0;
        private const string? species = "Homo Sapien";
        private readonly string? homePlanet;
        private readonly DateTime instantiated = DateTime.Now;

        public string? Name { get => name; set => name = value; }
        public DateTime DateOfbirth { get => dateOfbirth; set => dateOfbirth = value; }
        public WondersOfTheAncientWorld FavoriteAncientWonder { get => favoriteAncientWonder; set => favoriteAncientWonder = value; }
        public WondersOfTheAncientWorld BucketList { get => bucketList; set => bucketList = value; }
        public List<Person> Children { get => children; set => children = value; }
        public static int CountOfPersonObject { get => countOfPersonObject; set => countOfPersonObject = value; }
        public string? Species { get => species; }

        public string? HomePlanet => homePlanet;

        public DateTime Instantiated => instantiated;

        public Person()
        {
            ++CountOfPersonObject;
            homePlanet = "Earth";
        }
    }

}