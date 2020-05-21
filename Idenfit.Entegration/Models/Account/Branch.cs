using System.ComponentModel.DataAnnotations;

namespace Idenfit.Entegration.Models.Audit
{
    public class Branch
    {
        public int module { get; set; }

        [StringLength(36, ErrorMessage = "Only UUID")]
        public string customer { get; set; }

        [StringLength(255, ErrorMessage = "The name value cannot exceed 255 characters. ")]
        public string name { get; set; }

        [StringLength(255, ErrorMessage = "The image value cannot exceed 255 characters. ")]
        public string image { get; set; }

        [StringLength(255, ErrorMessage = "The address value cannot exceed 255 characters. ")]
        public string address { get; set; }

        public float latitude { get; set; }

        public float longitude { get; set; }

        public int radius { get; set; }

        public int gmt { get; set; }

        [StringLength(200, ErrorMessage = "The city value cannot exceed 200 characters. ")]
        public string city { get; set; }

        [StringLength(200, ErrorMessage = "The country value cannot exceed 200 characters. ")]
        public string country { get; set; }

        [StringLength(15, ErrorMessage = "The phone value cannot exceed 15 characters. ")]
        public string phone { get; set; }

        [StringLength(255, ErrorMessage = "The email value cannot exceed 255 characters. ")]
        public string email { get; set; }

        [StringLength(10, ErrorMessage = "The zipCode value cannot exceed 10 characters. ")]
        public string zipCode { get; set; }

        [StringLength(100, ErrorMessage = "The taxOffice value cannot exceed 100 characters. ")]
        public string taxOffice { get; set; }

        public long taxNo { get; set; }

        [StringLength(200, ErrorMessage = "The executiveName value cannot exceed 200 characters. ")]
        public string executiveName { get; set; }

        [StringLength(15, ErrorMessage = "The executivePhone value cannot exceed 15 characters. ")]
        public string executivePhone { get; set; }

        [StringLength(2000, ErrorMessage = "The executivePhone value cannot exceed 2000 characters. ")]
        public string userInformationText { get; set; }

        [StringLength(50, ErrorMessage = "The executivePhone value cannot exceed 50 characters. ")]
        public string entegrationTag { get; set; }

        [StringLength(50, ErrorMessage = "The executivePhone value cannot exceed 50 characters. ")]
        public bool entegrationOn { get; set; }
    }
}