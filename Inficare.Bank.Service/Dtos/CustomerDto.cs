
namespace Inficare.Bank.Service.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Domain.Models.Bank Bank { get; set; }
    }
}
