using LearningVisual.Interfaces;

namespace LearningVisual.Models.AbstractModels;

internal abstract class Employee : BaseEmployee, IEmployee

{
    public IBaseEmployee Manager { get; set; } = null!;
}




