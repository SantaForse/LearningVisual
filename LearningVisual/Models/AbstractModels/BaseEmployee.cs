using LearningVisual.Interfaces;

namespace LearningVisual.Models.AbstractModels;

internal abstract class BaseEmployee : IBaseEmployee
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;
}
