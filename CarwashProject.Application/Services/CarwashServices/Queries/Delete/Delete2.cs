using CarwashProject.Application.Interfaces;
using CarwashProject.Common.Dto.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.CarwashServices.Queries.Delete;
public class Delete2 : IDelete2
{
    private readonly IAppDbContext _context;
    public Delete2(IAppDbContext context)
    {
        _context = context;
    }
    public ResultDto Execute(int id)
    {
        var service = _context.Services.Find(id);
        if (service == null)
        {
            return new ResultDto
            {
                IsSuccess = false,
                Message = "شناسه ی وارد شده یافت نشد",
                StatusCode = 404
            };

           
        }
        
        else
        {
            _context.Services.Remove(service);
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "خدمات شما با موفقیت حذف شد",
                StatusCode = 200
            };
        }
        
    }
}
