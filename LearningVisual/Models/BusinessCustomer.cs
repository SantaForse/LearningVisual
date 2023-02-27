
using LearningVisual.Interfaces;
using LearningVisual.Models.AbstractModels;

namespace LearningVisual.Models;

internal class BusinessCustomer : Customer, IBusinessCustomer
{
    public string OrganizationNumber { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string ContactPerson { get; set; } = null!;
}
