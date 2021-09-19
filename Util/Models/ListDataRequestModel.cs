namespace IgorMoura.Util.Models
{
    public class ListDataRequestModel : DataRequestModel
    {
        public string UserId { get; set; }

        protected internal ListDataRequestModel ShallowCopy()
        {
            return (ListDataRequestModel)MemberwiseClone();
        }
    }
}
