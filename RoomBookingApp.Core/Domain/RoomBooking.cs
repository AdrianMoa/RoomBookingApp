using RoomBookingApp.Core.Models;

namespace RoomBookingApp.Core.Domain
{
    public class RoomBooking : RoomBookingBase
    {
        // Additional properties and methods specific to RoomBooking can be added here
        public int RoomId { get; set; }
        public int? Id { get; set; }
    }
}
