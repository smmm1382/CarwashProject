using CarwashProject.Application.Interfaces;
using CarwashProject.Application.Services.CarwashServices.Queries.GetWorker;
using CarwashProject.Common.Dto.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.CarwashServices.Queries.GetServiceById
{
    public class GetServiceById : IGetServiceById
    {
        private readonly IAppDbContext _context;
        public GetServiceById(IAppDbContext context)
        {
            _context = context;
        }
        public ResultDto<ServiceDto> Execute(int id)
        {
            var service = _context.Services.Where(t => t.Id == id).Select(t => new ServiceDto
            {
                Name = t.Name,
                Price = t.Price,
            }).FirstOrDefault();
            if (service == null)
            {
                return new ResultDto<ServiceDto>
                {
                    IsSuccess = false,
                    Message = "error",
                    StatusCode = 404
                };
            }
            return new ResultDto<ServiceDto>
            {
                IsSuccess = true,
                Message = "ok",
                StatusCode = 200,
                Data = service
            };
        }
    }
}
