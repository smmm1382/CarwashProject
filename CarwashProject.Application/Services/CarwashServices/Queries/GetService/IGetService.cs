using CarwashProject.Common.Dto.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.CarwashServices.Queries.GetWorker;

public interface IGetService
{
    ResultDto<List<ServiceDto>> Execute();
}
