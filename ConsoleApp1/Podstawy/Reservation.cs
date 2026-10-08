namespace Aplikacja.Podstawy
{
    public class Reservation
    {
        public User MadeBy { get; set; } // przez kogo zrealizowana

        //rezerwacja może być odwołana przez Admina
        // lub przez użytkownika, który ją zrealizował
        public bool CanBeCancelledBy(User user) => (user.IsAdmin || MadeBy == user);
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}
