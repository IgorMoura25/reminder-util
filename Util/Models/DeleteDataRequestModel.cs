namespace IgorMoura.Util.Models
{
    public class DeleteDataRequestModel : DataRequestModel
    {
        public long UserId { get; set; }

        protected internal DeleteDataRequestModel ShallowCopy()
        {
            return (DeleteDataRequestModel)MemberwiseClone();
        }
    }
}