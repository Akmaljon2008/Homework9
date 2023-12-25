using Domain.Models;
using Infrastructure.Servise;
var d1 = new Employe();
d1.id = 1;
d1.firstName = "Andrew";
d1.lastName = "Tate";
d1.age = 35;
var d2 = new Employe();
d2.id = 2;
d2.firstName = "Tristan";
d2.lastName = "Tate";
d2.age = 30;
var ser = new Servise();
ser.AddEmployes(d1);
ser.AddEmployes(d2);

foreach (var item in e1)
{
    System.Console.WriteLine(item.id);
    System.Console.WriteLine(item.firstName);
    System.Console.WriteLine(item.lastName);
    System.Console.WriteLine(item.age);
}
ser.CountEmployes(e1);

var d3 = new Employe();
d3.id = 1;
d3.firstName = "Umedjon";
d3.lastName = "Nyazov";
d3.age = 27;
ser.UpdateEmploye(d3);

foreach (var item in e1)
{
    System.Console.WriteLine(item.id);
    System.Console.WriteLine(item.firstName);
    System.Console.WriteLine(item.lastName);
    System.Console.WriteLine(item.age);
}
ser.DeleteEmploye(2);
foreach (var item in e1)
{
    System.Console.WriteLine(item.id);
    System.Console.WriteLine(item.firstName);
    System.Console.WriteLine(item.lastName);
    System.Console.WriteLine(item.age);
}

