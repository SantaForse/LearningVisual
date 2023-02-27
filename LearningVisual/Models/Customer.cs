
using LearningVisual.Interfaces;

namespace LearningVisual.Models;

internal class Customer : ICustomer
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Address { get; set; } = null!;

}
