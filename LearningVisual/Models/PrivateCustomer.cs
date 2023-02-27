
using LearningVisual.Interfaces;
using LearningVisual.Models.AbstractModels;

namespace LearningVisual.Models;

internal class PrivateCustomer : Customer, IPrivateCustomer
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;
}
