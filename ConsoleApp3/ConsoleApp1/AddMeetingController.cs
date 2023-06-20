using ConsoleApp1.Contracts;
using ConsoleApp1.Domain;

namespace ConsoleApp1
{
    public class AddMeetingController : IController
    {
        const int MaximumRoomLenght = 25;
        const int MaximumNameLenght = 50;

        private IRepository repository;
        public AddMeetingController()
        {
            repository = Factory.GetRepository();
        }

        public IController ExecuteAction()
        {
            var nextController = new MenuItemController();

            Console.WriteLine("Start date:");
            var dateParsingResult = DateTime.TryParse(Console.ReadLine(), out var startTime);
            if (!dateParsingResult)
            {
                RaiseError("Error! Invalid Start date");
                return nextController;
            }

            Console.WriteLine("Duration in minutes: ");
            var durationParsingResult = int.TryParse(Console.ReadLine(), out var duration);
            if (!durationParsingResult)
            {
                RaiseError("Error! Invalid meeting duration");
                return nextController;
            }

            Console.WriteLine("Room: ");
            var room = Console.ReadLine();
            if (string.IsNullOrEmpty(room))
            {
                RaiseError("Error! Empty room");
                return nextController;
            }

            if (room.Length > MaximumRoomLenght)
            {
                RaiseError($"Error! Room should not be longer than {MaximumRoomLenght} symbols");
                return nextController;
            }

            Console.WriteLine("Name: ");
            var name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                RaiseError("Error! Empty name");
                return nextController;
            }

            if (name.Length > MaximumNameLenght)
            {
                RaiseError($"Error! Room should not be longer than {MaximumNameLenght} symbols");
                return nextController;
            }

            var meeting = new Meeting
            {
                StartDate = startTime,
                Duration = duration,
                Name = name,
                Room = new Room { Name = room }
            };

            repository.AddMeeting(meeting);

            return nextController;
        }

        void RaiseError(string error)
        {
            //Console.WriteLine(error);
            throw new ArgumentException(error);
        }
    }
}
