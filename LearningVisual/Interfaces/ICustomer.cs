namespace LearningVisual.Interfaces;

internal interface ICustomer
{
    Guid Id { get; set; }

    string Name { get; set; }

    string Email { get; set; }

    string Phone { get; set; }

    string Address { get; set; }
}
