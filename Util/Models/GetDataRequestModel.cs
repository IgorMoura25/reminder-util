namespace IgorMoura.Util.Models
{
    public class GetDataRequestModel : DataRequestModel
    {
        public string UserId { get; set; }

        protected internal GetDataRequestModel ShallowCopy()
        {
            return (GetDataRequestModel)MemberwiseClone();
        }
    }
}
