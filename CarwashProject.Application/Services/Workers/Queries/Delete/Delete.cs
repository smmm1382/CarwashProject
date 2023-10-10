using CarwashProject.Application.Interfaces;
using CarwashProject.Common.Dto.Result;
using CarwashProject.Dto;


namespace CarwashProject.Application.Services.Workers.Queries.Delete;

public class Delete : IDelete
{
    private readonly IAppDbContext _context;
    public Delete(IAppDbContext context)
    {
        _context = context;
    }

    public ResultDto Execute(int id)
    {
        
        var worker = _context.Workers.Find(id);
        if (worker == null)
        {
            return new ResultDto
            {
                IsSuccess = false,
                Message = "شناسه ی وارد شده یافت نشد",
                StatusCode = 404
            };
        }
        _context.Workers.Remove(worker);
        _context.SaveChanges();

        return new ResultDto
        {
            IsSuccess = true,
            Message = "کارگر شما با موفقیت حذف شد",
            StatusCode = 200
        };
    }
}




