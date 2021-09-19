namespace IgorMoura.Util.Models
{
    public class DeleteDataRequestModel : DataRequestModel
    {
        public string UserId { get; set; }

        protected internal DeleteDataRequestModel ShallowCopy()
        {
            return (DeleteDataRequestModel)MemberwiseClone();
        }
    }
}