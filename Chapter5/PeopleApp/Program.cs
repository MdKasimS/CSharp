using Packt.Shared;


internal class Program
{
    public static Person? bob;
    public static Person? alice;
    static void PersonClass()
    {
        Console.WriteLine("{0} was borned on {1: dddd, d MMMM yyyy}",
        arg0: bob.Name,
        arg1: bob.DateOfbirth);

        Console.WriteLine("{0} was borned on {1:d MMMM yyyy}",
        arg0: alice.Name,
        arg1: alice.DateOfbirth);

        bob.FavoriteAncientWonder = WondersOfTheAncientWorld.GreatPyramidOfGiza;

        alice.FavoriteAncientWonder = WondersOfTheAncientWorld.HangingGardensOfBabylon;

        Console.WriteLine("{0}'s favorite wonder is {1}. Its integer value is {2}",
        arg0: bob.Name,
        arg1: bob.FavoriteAncientWonder,
        arg2: bob.FavoriteAncientWonder.GetHashCode());

        Console.WriteLine("{0}'s favorite wonder is {1}. Its integer value is {2}",
        arg0: alice.Name,
        arg1: alice.FavoriteAncientWonder,
        arg2: alice.FavoriteAncientWonder.GetHashCode());

        bob.BucketList = (WondersOfTheAncientWorld)21;
        alice.BucketList = WondersOfTheAncientWorld.LighthouseOfAlexandria | WondersOfTheAncientWorld.HangingGardensOfBabylon;

        Console.WriteLine("{0} have 2 location in her bucketlist. Those are {1}",
        arg0: bob.Name,
        arg1: bob.BucketList);

        Console.WriteLine("{0} have 2 location in her bucketlist. Those are {1}",
        arg0: alice.Name,
        arg1: alice.BucketList);

        bob.Children.Add(new Person
        {
            Name = "Mahedi",
            DateOfbirth = new DateTime(2029, 7, 7)
        });

        bob.Children.Add(new Person
        {
            Name = "Sophia",
            DateOfbirth = new DateTime(2030, 9, 13)
        });

        bob.Children.Add(new Person
        {
            Name = "Bibi Fatima",
            DateOfbirth = new DateTime(2031, 5, 4)
        });

        Console.WriteLine("{0} has {1} children as : ",
        arg0: bob.Name,
        arg1: bob.Children.Count);

        foreach (Person p in bob.Children)
        {
            Console.WriteLine(p.Name);
        }

        Console.WriteLine("Program have {0}'s total objects {1}",
        arg0: bob.ToString(),
        arg1: Person.CountOfPersonObject);

        Console.WriteLine("{0} was borned on {1}. [Object instantiated at -> {2}]",
        arg0: bob.Name,
        arg1: bob.HomePlanet,
        arg2: bob.Instantiated);
    }

    static void BankClass()
    {
        BankAccount.InterestRate = 0.012M;

        var jonesAccount = new BankAccount
        {
            AccountName = alice.Name,
            Balance = 1_00_000
        };

        var smithsAccount = new BankAccount
        {
            AccountName = bob.Name,
            Balance = 1_00_000
        };

        Console.WriteLine("{0}'s account name is {1} with balance {2:C}",
        arg0: bob.Name,
        arg1: smithsAccount.AccountName,
        arg2: smithsAccount.Balance);

        Console.WriteLine("{0}'s account name is {1} with balance {2:C}",
        arg0: alice.Name,
        arg1: jonesAccount.AccountName,
        arg2: jonesAccount.Balance);

    }

    private static void Main(string[] args)
    {
        bob = new Person
        {
            Name = "Bob Smith",
            DateOfbirth = new DateTime(1998, 5, 4),
        };

        alice = new Person
        {
            Name = "Alice Jones",
            DateOfbirth = new DateTime(1998, 3, 7)
        };

        // Console.WriteLine(bob.ToString());
        PersonClass();
        // BankClass();
    }
}