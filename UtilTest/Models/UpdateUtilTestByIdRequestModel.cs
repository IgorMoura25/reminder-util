using Util.Models;

namespace UtilTest.Models
{
    public class UpdateUtilTestByIdRequestModel : UpdateDataRequestModel
    {
        public long UtilTestId { get; set; }
        public string NewDescription { get; set; }
    }
}
