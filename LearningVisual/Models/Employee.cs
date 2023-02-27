using LearningVisual.Interfaces;

namespace LearningVisual.Models;

internal abstract class Employee : IEmployee

{

    public Guid Id { get; set; } = Guid.NewGuid();

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

}




