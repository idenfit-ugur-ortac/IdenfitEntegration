using System.ComponentModel.DataAnnotations;

namespace Idenfit.Entegration.Models.Account
{
    public class Customer
    {
        public int module { get; set; }

        [StringLength(255, ErrorMessage = "The name value cannot exceed 255 characters. ")]
        public string name { get; set; }

        [StringLength(255, ErrorMessage = "The image value cannot exceed 255 characters. ")]
        public string image { get; set; }

        [StringLength(255, ErrorMessage = "The address value cannot exceed 255 characters. ")]
        public string address { get; set; }

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
    }
}