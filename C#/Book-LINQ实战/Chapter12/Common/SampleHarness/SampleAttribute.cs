using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.SampleHarness
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
    public class SampleAttribute : Attribute
    {
        private int _Chapter;
        public int Chapter { get { return _Chapter; } }

        private int _ListingNumber;
        public int ListingNumber { get { return _ListingNumber; } }

        private string _Description;
        public string Description { get { return _Description; } }

        public SampleAttribute(int chapter, int listingNumber, string description)
        {
            _Chapter = chapter;
            _ListingNumber = listingNumber;
            _Description = description;
        }
    }
}
