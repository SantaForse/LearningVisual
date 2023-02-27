using LearningVisual.Interfaces;

namespace LearningVisual.Models;

internal abstract class Employee : BaseEmployee, IEmployee

{
    public IBaseEmployee Manager { get; set; } = null!;
}




