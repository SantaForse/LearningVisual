namespace LearningVisual.Interfaces;

internal interface IBusinessCustomer : ICustomer
{
    string OrganizationNumber { get; set; }
    
    string CompanyName { get; set; }

    string ContactPerson { get; set; }
}
