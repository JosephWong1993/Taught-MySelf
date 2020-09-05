using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commom.SampleHarness
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
    public class SampleAttribute : Attribute
    {
        int _Chapter;
        public int Chapter { get { return _Chapter; } }

        int _Listing;
        public int ListingNumber { get { return _Listing; } }

        string _Description;
        public string Description { get { return _Description; } }

        public SampleAttribute(int chapter, int listingNumber, string description)
        {
            this._Chapter = chapter;
            this._Listing = listingNumber;
            this._Description = description;
        }
    }
}
