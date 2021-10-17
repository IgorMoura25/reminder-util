namespace IgorMoura.Util.Models
{
    public class ListDataRequestModel : DataRequestModel
    {
        public long Offset { get; set; }
        public long Count { get; set; }
        public long UserId { get; set; }

        protected internal new ListDataRequestModel ShallowCopy()
        {
            return (ListDataRequestModel)MemberwiseClone();
        }
    }
}
