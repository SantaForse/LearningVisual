using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisual.Interfaces
{
    internal interface IBaseEmployee
    {

        Guid Id { get; set; }

        string FirstName { get; set; } 

        string LastName { get; set; }

        string DisplayName => $"{FirstName} {LastName}";

        string Email => $"{FirstName.ToLower()}.{LastName.ToLower()}@domain.com";
    }
}
