// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello, GIT!");
using Batch1_DET_2022;
using BATCH1_DET_2022;


    class MyClass
    {
    public static void Main()
    {

        //  internal static void Main()
        //{


        //  CompanyManager mgr = new CompanyManager { Name = "Balaji", Surname = "R", Phone = "8970751939" };
        //Company company = new Company { Name = "SSL", Address = "Global city", Manager = mgr, Phone = "654765", Website = "SON" };

        //Console.WriteLine(company.ToString());

        //}
        //}

        List<Animal> Animals = new List<Animal>();
    Animals.Add(new Dog());
    Animals.Add(new Cat());

    foreach (Animal a in Animals)
        Console.WriteLine(a.ToString());
}
}