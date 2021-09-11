using System;
using System.Collections.Generic;
using System.Text;

namespace IgorMoura.Util.Models
{
    public class DataRequestModel
    {
        protected internal DataRequestModel ShallowCopy()
        {
            return (DataRequestModel)MemberwiseClone();
        }
    }
}
