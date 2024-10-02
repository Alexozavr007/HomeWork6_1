using HomeWork6_1_1;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

var Id1 = Guid.NewGuid();
var Id5 = Guid.NewGuid();

var name0 = "Intel i867";
var name7 = "Intel i321";

var products = new List<Product> { 
    new Product {
        Id = Guid.NewGuid(),
        Cost = 120,
        Name = name0,
        Description = "popa",
        Quantity = 5
    },
    new Product {
        Id = Id1,
        Cost = 160,
        Name = "Intel i9",
        Description = "popi",
        Quantity = 3
    },
    new Product {
        Id = Guid.NewGuid(),
        Cost = 100,
        Name = "Intel i3",
        Description = "popo",
        Quantity = 10
    },
    new Product {
        Id = Guid.NewGuid(),
        Cost = 160,
        Name = "Intel i9 11200",
        Description = "popu",
        Quantity = 3
    },
    new Product {
        Id = Guid.NewGuid(),
        Cost = 120,
        Name = "Intel i7",
        Description = "popb",
        Quantity = 51
    },
    new Product {
        Id = Id5,
        Cost = 160,
        Name = "Intel i4",
        Description = "popp",
        Quantity = 323
    },
    new Product {
        Id = Guid.NewGuid(),
        Cost = 120,
        Name = "Intel i10",
        Description = "popt",
        Quantity = 43
    },
    new Product {
        Id = Guid.NewGuid(),
        Cost = 160,
        Name = name7,
        Description = "popa",
        Quantity = 3
    },
    new Product {
        Id = Guid.NewGuid(),
        Cost = 120,
        Name = "Intel i4",
        Description = "popca",
        Quantity = 23
    },
    new Product {
        Id = Guid.NewGuid(),
        Cost = 160,
        Name = "Intel i49",
        Description = "pop34",
        Quantity = 34
    }
};

Console.WriteLine("1) Виведіть на екран значення за індексом > 1, 5, 0, 7");
Console.WriteLine(products[1].ToString());
Console.WriteLine(products[5].ToString());
Console.WriteLine(products[0].ToString());
Console.WriteLine(products[7].ToString());
Console.WriteLine();

Console.WriteLine("2) Знайдіть та виведіть індекси > 1, 5 за властивістю Id");
var idx1 = products.FindIndex(x => x.Id == Id1);
var idx5 = products.FindIndex(x => x.Id == Id5);
Console.WriteLine($"Index of {Id1} is {idx1}");
Console.WriteLine($"Index of {Id5} is {idx5}");

Console.WriteLine();

Console.WriteLine("3) Знайдіть та виведіть індекси > 0, 7 за властивістю Name");
var idx0 = products.FindIndex(x => x.Name == name0);
var idx7 = products.FindIndex(x => x.Name == name7);
Console.WriteLine($"Index of {name0} is {idx0}");
Console.WriteLine($"Index of {name7} is {idx7}");