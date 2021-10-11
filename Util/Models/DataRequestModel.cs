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
