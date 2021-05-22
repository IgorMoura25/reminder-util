using System;

namespace Util.Models
{
    public class AddDataRequestModel : DataRequestModel
    {
        public long UserId { get; set; }

        protected internal AddDataRequestModel ShallowCopy()
        {
            return (AddDataRequestModel)MemberwiseClone();
        }
    }
}
