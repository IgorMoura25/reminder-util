namespace Util.Models
{
    public class ListDataRequestModel : DataRequestModel
    {
        public long UserId { get; set; }

        protected internal ListDataRequestModel ShallowCopy()
        {
            return (ListDataRequestModel)MemberwiseClone();
        }
    }
}
