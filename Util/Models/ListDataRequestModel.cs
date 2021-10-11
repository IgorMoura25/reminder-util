namespace IgorMoura.Util.Models
{
    public class ListDataRequestModel : DataRequestModel
    {
        public string UserId { get; set; }

        protected internal new ListDataRequestModel ShallowCopy()
        {
            return (ListDataRequestModel)MemberwiseClone();
        }
    }
}
