namespace SmartDelivery
{
    public abstract partial class Shipment
    {
        private string trackingStatus = "In Transit";

        public string TrackingStatus
        {
            get { return trackingStatus; }
            protected set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    trackingStatus = value;
            }
        }

        public virtual string GetTrackingStatus()
        {
            return TrackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            if (string.IsNullOrWhiteSpace(newStatus))
                return;

            trackingStatus = newStatus;
            OnTrackingStatusChanged(newStatus);
        }

        
        partial void OnTrackingStatusChanged(string newStatus);
    }
}