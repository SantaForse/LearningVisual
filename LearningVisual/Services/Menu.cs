
using LearningVisual.Interfaces;
using LearningVisual.Models;
using Newtonsoft.Json;

namespace LearningVisual.Services;

internal class Menu
{

    private List<ICustomer> customers = new List<ICustomer>();  
    private List<IBaseEmployee> employees= new List<IBaseEmployee>();
    private FileService file = new FileService();

    public string FilePath { get; set; } = null!;

          
    public void WelcomeMenu()
    {
        Console.Clear();
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
        Console.WriteLine("Add a new customer");
        Console.WriteLine("1. Business customer");
        Console.WriteLine("2. Private customer");
        Console.Write("Choose a type of customer you want to create: ");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1": CreateBusinessCustomer(); break;
            case "2": CreatePrivateCustomer(); break;
        }

        file.Save(FilePath, JsonConvert.SerializeObject(new { customers, employees }));
    }

    private void CreateBusinessCustomer()
    {
        Console.Clear();
        Console.WriteLine("Add a new business customer");

        IBusinessCustomer customer = new BusinessCustomer();
        Console.Write("Write organization number: ");
        customer.OrganizationNumber = Console.ReadLine() ?? "";

        Console.Write("Write company name number: ");
        customer.CompanyName = Console.ReadLine() ?? "";

        Console.Write("Write copmanys address: ");
        customer.Address = Console.ReadLine() ?? "";

        Console.Write("Write phone number: ");
        customer.Phone = Console.ReadLine() ?? "";

        Console.Write("Write email address: ");
        customer.Email = Console.ReadLine() ?? "";

        Console.Write("Write contact persons name: ");
        customer.ContactPerson = Console.ReadLine() ?? "";

        customers.Add(customer);
    }

    private void CreatePrivateCustomer()
    {
        Console.Clear();
        Console.WriteLine("Add a new private customer");


        IPrivateCustomer customer = new PrivateCustomer();
         Console.Write("Write your first name: ");
        customer.FirstName = Console.ReadLine() ?? "";

        Console.Write("Write your last name ");
        customer.LastName = Console.ReadLine() ?? "";

        Console.Write("Write an address: ");
        customer.Address = Console.ReadLine() ?? "";

        Console.Write("Write a phone number: ");
        customer.Phone = Console.ReadLine() ?? "";

        Console.Write("Write an email address: ");
        customer.Email = Console.ReadLine() ?? "";

        customers.Add(customer);
    }

    private void OptionTwo()
    {

        Console.Clear();
        Console.WriteLine("Add a new employee");
        Console.WriteLine("1. CEO");
        Console.WriteLine("2. CFO");
        Console.WriteLine("3. Assistant");
        Console.WriteLine("4. Key Account Manager");
        Console.WriteLine("Choose a type of employee you want to create: ");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1": CreateCEO(); break;
            case "2": CreateCFO(); break;
            //case "3": CreateAssistant(); break;
            //case "4": CreateKeyAccountManager(); break;
        }

    }


    private void CreateCEO()
    {
        Console.Clear();
        Console.WriteLine("Add a new CEO");


        ICEO employee = new CEO();
        Console.Write("Write your first name: ");
        employee.FirstName = Console.ReadLine() ?? "";

        Console.Write("Write your last name ");
        employee.LastName = Console.ReadLine() ?? "";

        Console.Write("Is the person a beneficial owner? (y/n) ");
        var answer = Console.ReadLine();
        employee.BeneficialOwner = (answer?.ToLower() == "y");

        employees.Add(employee);
    }

    private void CreateCFO()
    {
        Console.Clear();
        Console.WriteLine("Add a new CFO");


        ICFO employee = new CFO();
        Console.Write("Write your first name: ");
        employee.FirstName = Console.ReadLine() ?? "";

        Console.Write("Write your last name ");
        employee.LastName = Console.ReadLine() ?? "";

        Console.WriteLine("Write an email of the manager: ");
        var email = Console.ReadLine();
        var manager = employees.FirstOrDefault(x => x.Email == email);
        if (manager != null)
        {
            employee.Manager = manager; 
        }
        
        employees.Add(employee);
    }











    private void OptionThree()
    {

    }

    private void OptionFour()
    {

    }
}
