using LearningVisual.Interfaces;
using LearningVisual.Models.AbstractModels;

namespace LearningVisual.Models;

internal class CEO : BaseEmployee, ICEO
{
    public bool BenificialOwner { get; set; } = true;
    public bool BeneficialOwner { get ; set ; }
}
