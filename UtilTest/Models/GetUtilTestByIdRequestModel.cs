using IgorMoura.Util.Models;

namespace IgorMoura.UtilTest.Models
{
    public class GetUtilTestByIdRequestModel : GetDataRequestModel
    {
        public long UtilTestId { get; set; }
    }
}
