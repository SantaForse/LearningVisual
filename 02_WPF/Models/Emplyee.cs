﻿using System;

namespace _02_WPF.Models;

internal interface IEmployee
{
    Guid Id { get; set; } 

    string FirstName { get; set; }

    string LastName { get; set; }

    string Email { get; set; }

    string DisplayName => $"{FirstName} {LastName}";
}

    internal class Emplyee : IEmployee

    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

    }