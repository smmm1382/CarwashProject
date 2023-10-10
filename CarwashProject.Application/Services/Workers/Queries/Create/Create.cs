using CarwashProject.Application.Interfaces;
using CarwashProject.Common.Dto.Result;
using CarwashProject.Domain.Entities;
using CarwashProject.Dto;


namespace CarwashProject.Application.Services.Workers.Queries.Create;

public class Create : ICreate
{
    private readonly IAppDbContext _context;
    public Create(IAppDbContext context)
    {
        _context = context;
    }

    public ResultDto<CreateDto> Execute(CreateDto worker)
    {
        Worker worker1 = new Worker()
        {
            FirstName = worker.FirstName,
            LastName = worker.LastName,
            Age = worker.Age,
            Bonus = 0,
            Salary = 0
        };

        _context.Workers.Add(worker1);
        _context.SaveChanges();

        return new ResultDto<CreateDto>
        {
            IsSuccess = true,
            Message = "با موفقیت انجام شد",
            StatusCode = 200,
            Data = worker
        };
    }


}
