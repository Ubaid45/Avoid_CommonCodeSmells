using CommonCodeSmells.Better_LongParameterList;

namespace CommonCodeSmells.BetterLongParameterList
{
    public class ReservationQuery
    {
        public ReservationQuery(DateRange dateRange, User user, int locationId, LocationType locationType, int? customerId = null)
        {
            DateRange = dateRange;
            User = user;
            LocationId = locationId;
            LocationType = locationType;
            CustomerId = customerId;
        }

        public DateRange DateRange { get; private set; }
        public User User { get; private set; }
        public int LocationId { get; private set; }
        public LocationType LocationType { get; private set; }
        public int? CustomerId { get; private set; }
    }
}