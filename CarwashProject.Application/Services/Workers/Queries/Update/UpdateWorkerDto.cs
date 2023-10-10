﻿namespace CarwashProject.Application.Services.Workers.Queries.Update;

public class UpdateWorkerDto 
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }
    public decimal Bonus { get; set; }
}
