using IgorMoura.Util.Models;

namespace IgorMoura.UtilTest.Models
{
    public class UpdateUtilTestByIdRequestModel : UpdateDataRequestModel
    {
        public long UtilTestId { get; set; }
        public string NewDescription { get; set; }
    }
}
