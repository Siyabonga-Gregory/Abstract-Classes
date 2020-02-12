namespace AbstractClasses
{
    class Yaris:Toyota
    {
        public bool isTrackerInstalled;
        public string trackingCompany;

        public override string GetBasicDetails(){
            return this.make + "  " + 
                this.model + "  " + 
                this.variation + " " + 
                this.dateRelease.ToShortDateString() + " " + 
                this.price;
        }

        public override string GetTrackingDetails(){
            return this.isTrackerInstalled + " " + this.trackingCompany;
        }
    }
}
