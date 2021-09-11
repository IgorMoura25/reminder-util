using System;
using System.Collections.Generic;
using System.Text;

namespace IgorMoura.Util.Models
{
    public class UpdateDataRequestModel : DataRequestModel
    {
        public long UserId { get; set; }

        protected internal UpdateDataRequestModel ShallowCopy()
        {
            return (UpdateDataRequestModel)MemberwiseClone();
        }
    }
}
