using System;

namespace IgorMoura.Util.Models
{
    public class AddDataRequestModel : DataRequestModel
    {
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public long UserId { get; set; }

        protected internal new AddDataRequestModel ShallowCopy()
        {
            return (AddDataRequestModel)MemberwiseClone();
        }
    }
}
