using PACM.Common;
using System.Collections.Generic;

namespace PACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer(): this(0)
        {

        }

        public Customer(int customerId)
        {
            Id = customerId;
            AddressList = new List<Address>();
        }

        public int Id { get; private set; }
        public int CustomerType { get; set; }
        public string FirstName { get; set; }
        public string FullName 
        { 
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        private string _lastName;
        public string LastName 
        {
            get 
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string EmailAddress { get; set; }
        public List<Address> AddressList { get; set; }

        public override bool Validate()
        {
            var isValid = true;

            if(string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(EmailAddress))isValid = false;

            return isValid;
        }

        public override string ToString() => FullName;

        public string Log() => "ID: " + Id + " Name: " + FullName + " Email: " + EmailAddress + " Status: " + EntityState.ToString();
    }
}
