
namespace Inficare.Bank.Domain.Models
{
    public class Customer: CommonModel
    {
        public string Name { get; set; }
        public string PanNumber { get; set; }
        public int BankId { get; set; }
        public virtual Bank Bank { get; set; }
    }
}
