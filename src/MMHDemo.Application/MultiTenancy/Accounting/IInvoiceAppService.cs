using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using MMHDemo.MultiTenancy.Accounting.Dto;

namespace MMHDemo.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
