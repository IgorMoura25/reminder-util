namespace IgorMoura.Util.Models
{
    public class UpdateDataRequestModel : DataRequestModel
    {
        public string UserId { get; set; }

        protected internal new UpdateDataRequestModel ShallowCopy()
        {
            return (UpdateDataRequestModel)MemberwiseClone();
        }
    }
}
