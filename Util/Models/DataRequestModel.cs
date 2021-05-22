using System;
using System.Collections.Generic;
using System.Text;

namespace Util.Models
{
    public class DataRequestModel
    {
        protected internal DataRequestModel ShallowCopy()
        {
            return (DataRequestModel)MemberwiseClone();
        }
    }
}
