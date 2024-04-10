using Square_Project;

var square1 = new Square(5, "green");
var square2 = new Square(2,"blue");
var square3 = new Square(15, "lightblue");

square1.GetInfo();
square2.GetInfo();
square3.GetInfo();

square1.SideLength = square2.SideLength * 3;
Console.WriteLine("Changed info:");
square1.GetInfo();