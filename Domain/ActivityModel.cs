using System;
using Microsoft.AspNetCore.Mvc.DataAnnotations;


namespace Domain
{
    public class ActivityModel
    {

        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private string companyName = string.Empty;

        public Guid Id { get; set; }

        public string Title  { get; set; }

        public string Description  { get; set; }

        public string Category  { get; set; }

        public DateTime Date {get; set;}

        public string City {get; set;}

        public string Venue {get; set;}

        // public virtual ICollection<QBContactPhoneNumberModel> QBContactPhoneNumber { get; set; }

        // public virtual ICollection<QBContactEmailModel> QBContactEmail { get; set; }

        // public virtual ICollection<QBContactAddressModel> QBContactAddress { get; set; }

        // public virtual ICollection<QBContactCommentModel> QBContactComment { get; set; }
    }

}