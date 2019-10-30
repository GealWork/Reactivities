using Microsoft.AspNetCore.Mvc.DataAnnotations;


namespace Domain
{
    public class QBContactModel
    {

        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private string companyName = string.Empty;

        public int Id { get; set; }

        public string FirstName  { get; set; }

        public string LastName  { get; set; }

        public string CompanyName  { get; set; }

        public bool IsActive { get; set; }

        // public virtual ICollection<QBContactPhoneNumberModel> QBContactPhoneNumber { get; set; }

        // public virtual ICollection<QBContactEmailModel> QBContactEmail { get; set; }

        // public virtual ICollection<QBContactAddressModel> QBContactAddress { get; set; }

        // public virtual ICollection<QBContactCommentModel> QBContactComment { get; set; }
    }

}