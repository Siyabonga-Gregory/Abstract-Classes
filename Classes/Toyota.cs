using System;

namespace AbstractClasses
{
    // Base Abstract Class
    abstract class Toyota 
    {
        public string make { get; set; }
        public string model { get; set; }
        public string variation { get; set; }
        public DateTime dateRelease { get; set; }
        public double price { get; set; }

        public abstract string GetBasicDetails();
        public abstract string GetTrackingDetails();
    }
}
