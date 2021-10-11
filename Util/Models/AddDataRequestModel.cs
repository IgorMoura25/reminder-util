namespace IgorMoura.Util.Models
{
    public class AddDataRequestModel : DataRequestModel
    {
        public string UserId { get; set; }

        protected internal new AddDataRequestModel ShallowCopy()
        {
            return (AddDataRequestModel)MemberwiseClone();
        }
    }
}
