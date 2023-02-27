using LearningVisual.Interfaces;

namespace LearningVisual.Models;

internal class CEO : BaseEmployee, ICEO
{
    public bool BenificialOwner { get; set; } = true;
}
