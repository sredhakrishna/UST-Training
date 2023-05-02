﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Carpool
{
    public class Member
    {
        private long _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _contactNumber;
        private string _licenseNumber;
        private DateTime _licenseStartDate;
        private DateTime _licenseExpiryDate;

        public long Id 
        { 
          get { return _id; } 
          set { _id = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
            }
        }
        public string ContactNumber
        {
            get { return _contactNumber; }
            set
            {
                _contactNumber = value;
            }
        }
        public string LicenseNumber
        {
            get { return _licenseNumber; }
            set
            {
                _licenseNumber = value;
            }
        }
        public DateTime LicenseStartDate
        {
            get { return _licenseStartDate; }
            set
            {
                _licenseStartDate = value;
            }
        }
        public DateTime LicenseExpiryDate
        {
            get { return _licenseExpiryDate; }
            set
            {
                _licenseExpiryDate = value;
            }
        }
       
        public Member()
        {

        }
        public Member( long id, string firstName, string lastName, string email, string contactNumber, string licenseNumber, DateTime licenseStartDate, DateTime licenseExpiryDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            ContactNumber = contactNumber;
            LicenseNumber = licenseNumber;
            LicenseStartDate = licenseStartDate;
            LicenseExpiryDate = licenseExpiryDate;
            
    }
    public override string ToString()
        {
            return string.Format($"Member:{_firstName},{_lastName}\n" + $"Member contact details:{_contactNumber},{_email}");
        }

        public override bool Equals(object obj)
        {
            Member m= obj as Member;

            if (m.Email.ToLower() == Email.ToLower() && m.ContactNumber == ContactNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
    }
