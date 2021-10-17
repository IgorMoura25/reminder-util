namespace IgorMoura.Util.Models
{
    public class DeleteDataRequestModel : DataRequestModel
    {
        public long UserId { get; set; }

        protected internal new DeleteDataRequestModel ShallowCopy()
        {
            return (DeleteDataRequestModel)MemberwiseClone();
        }
    }
}