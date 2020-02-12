namespace AbstractClasses
{
    class Tazz:Toyota{
        public override string GetBasicDetails(){
            return this.make + "  " + 
                this.model + "  " + 
                this.variation + " " + 
                this.dateRelease.ToShortDateString() + " " + 
                this.price;
        }

        public override string GetTrackingDetails(){
            return "Can not handle a tracker device";
        }
    }
}
