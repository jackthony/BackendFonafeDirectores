using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Departamento.Mappers;
using Empresa.Presentation.Ubigeo.Mappers;
using Empresa.Presentation.Ubigeo.Responses;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.Ubigeo.Presenters
{
    public class ListDepartamentoResponsePresenter : IPresenterDelivery<List<DepartamentoResult>, LstItemResponse<DepartamentoResponse>>
    {
        public LstItemResponse<DepartamentoResponse> Present(List<DepartamentoResult> input)
        {
            return new LstItemResponse<DepartamentoResponse>
            {
                LstItem = DepartamentoResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
