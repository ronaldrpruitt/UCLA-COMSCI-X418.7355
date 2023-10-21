namespace week7_rpruitt
{
    public static class Alerts
    {
        public delegate void Alert(string message);

        public static void AlertHelper(Alert delegateAlert, string message)
        {
            delegateAlert(message);
        }

        public static string GuestSignedInOverage(int num)
        {
            return $"Guest has been signed in over {num} days";
        }
    }
}
