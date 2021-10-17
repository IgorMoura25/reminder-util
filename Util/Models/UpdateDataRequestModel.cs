namespace IgorMoura.Util.Models
{
    public class UpdateDataRequestModel : DataRequestModel
    {
        public long UserId { get; set; }

        protected internal new UpdateDataRequestModel ShallowCopy()
        {
            return (UpdateDataRequestModel)MemberwiseClone();
        }
    }
}
