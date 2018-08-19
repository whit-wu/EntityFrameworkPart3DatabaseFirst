using System.ComponentModel.DataAnnotations;


namespace EntityFameworkPart3DatabaseFirst
{
    public class CUSTOMER_CONFIG
    {
        [StringLength(int.MaxValue, MinimumLength = 2)]
        public string MIDDLE_NAME { get; set; }
    }


    [MetadataType(typeof(CUSTOMER_CONFIG))]
    public partial class CUSTOMER
    {
    }
   
}
