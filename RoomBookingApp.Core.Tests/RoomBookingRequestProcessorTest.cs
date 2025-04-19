using RoomBookingApp.Core.Models;
using RoomBookingApp.Core.Processors;
using Shouldly;
using System.ComponentModel.DataAnnotations;

namespace RoomBookingApp.Core
{
    public class RoomBookingRequestProcessorTest
    {
        [Fact]
        public void Should_Return_Room_Booking_Response_Response_With_Request_Values()
        {
            //arrange
            var request = new RoomBookingRequest
            {
                FullName = "John Doe",
                Email = "test@request.com",
                Date = DateTime.Now,
            };

            var processor = new RoomBookingRequestProcessor();

            //act
            RoomBookingResult result = processor.BookRoom(request);

            //assert
            //Assert.NotNull(result);
            //Assert.Equal(request.FullName, result.FullName);
            //Assert.Equal(request.Email, result.Email);
            //Assert.Equal(request.Date, result.Date);

            result.ShouldNotBeNull();
            result.FullName.ShouldBe(request.FullName);
            result.Email.ShouldBe(request.Email);
            result.Date.ShouldBe(request.Date);
        }
    }
}
