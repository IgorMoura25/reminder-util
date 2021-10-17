namespace IgorMoura.Util.Models
{
    public class GetDataRequestModel : DataRequestModel
    {
        public long UserId { get; set; }

        protected internal new GetDataRequestModel ShallowCopy()
        {
            return (GetDataRequestModel)MemberwiseClone();
        }
    }
}
