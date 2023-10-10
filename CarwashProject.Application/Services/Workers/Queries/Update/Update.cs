using CarwashProject.Application.Interfaces;
using CarwashProject.Common.Dto.Result;
using CarwashProject.Dto;



namespace CarwashProject.Application.Services.Workers.Queries.Update;

public class Update : IUpdate
{
    private readonly IAppDbContext _context;
    public Update(IAppDbContext context)
    {
        _context = context;
    }

    public ResultDto<UpdateWorkerDto> Execute(UpdateWorkerDto updateWorker)
    {

        var worker = _context.Workers.Find(updateWorker.Id);

        if (worker == null)
        {
            new ResultDto
            {
                IsSuccess = false,
                Message = "شناسه ی وارد شده یافت نشد",
                StatusCode = 404
            };
        }
        else
        {
            worker.FirstName = updateWorker.FirstName;
            worker.LastName = updateWorker.LastName;
            worker.Age = updateWorker.Age;
            worker.Bonus = updateWorker.Bonus;
            worker.Salary = updateWorker.Salary;
        }

        _context.SaveChanges();

        return new ResultDto<UpdateWorkerDto>
        {
            IsSuccess = true,
            StatusCode = 200,
            Message = "ویرایش با موفقیت انجام شد",
            Data = updateWorker
        };
    }
}

