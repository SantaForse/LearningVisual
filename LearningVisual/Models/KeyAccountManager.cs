
using LearningVisual.Interfaces;
using LearningVisual.Models.AbstractModels;

namespace LearningVisual.Models;


internal class KeyAccountManager : Employee, IKeyAccountManager
{
    public List<ICustomer> Customers { get; set; } = new List<ICustomer>();
}
