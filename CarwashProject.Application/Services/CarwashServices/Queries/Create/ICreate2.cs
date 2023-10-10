using CarwashProject.Common.Dto.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.CarwashServices.Queries.Create;

public interface ICreate2
{
    ResultDto<CreateServiceDto> Execute(CreateServiceDto createService);
}
