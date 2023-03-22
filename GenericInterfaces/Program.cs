// See https://aka.ms/new-console-template for more information
using GenericInterfaces;

Console.WriteLine("Hello, World!");

Computer computer = new()
{
    ID = 1,
    Name = "Monster"
};

ComputerManager cm = new();
cm.Insert(computer);
Computer c = cm.GetByID(computer.ID);

