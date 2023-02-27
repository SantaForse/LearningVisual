
using LearningVisual.Interfaces;
using LearningVisual.Models;
using System.Net.Http.Headers;

namespace LearningVisual.Services;

internal class Menu
{
    public void WelcomeMenu()
    {
        Console.WriteLine("ADMINISTRATION APPLICATION");
        Console.WriteLine("1.Add a new customer.");
        Console.WriteLine("2.Add a new employee.");
        Console.WriteLine("3.Show all customers.");
        Console.WriteLine("4.Show all employees.");
        Console.Write("Choose an option:");
        var option = Console.ReadLine();


        switch(option)
        {
            case "1": OptionOne(); break;
            case "2": OptionTwo(); break;
            case "3": OptionThree(); break;
            case "4": OptionFour(); break;
        }
    }
    private void OptionOne()
    {
        Console.Clear();
        Console.WriteLine("Add a new custoemr");
        Console.WriteLine("1. Business customer");
        Console.WriteLine("2. Private customer");
        Console.WriteLine("Choose a type of customer you want to create: ");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1": CreateBusinessCustomer(); break;
            case "2": CreatePrivateCustomer(); break;
        }
    }

    private void CreateBusinessCustomer()
    {
        Console.Clear();
        Console.WriteLine("Add a new custoemr");
    }

    private void CreatePrivateCustomer()
    {
        Console.WriteLine("");
    }

    private void OptionTwo()
    {

    }

    private void OptionThree()
    {

    }

    private void OptionFour()
    {

    }
}
