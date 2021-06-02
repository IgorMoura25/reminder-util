using Util.Models;

namespace UtilTest.Models
{
    public class GetUtilTestByIdRequestModel : GetDataRequestModel
    {
        public long UtilTestId { get; set; }
    }
}
