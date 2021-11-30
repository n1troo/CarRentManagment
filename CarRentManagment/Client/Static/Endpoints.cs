namespace CarRentManagment.Client.Static
{
    public static class Endpoints
    {
        private static string Prefix = "api";

        public static string MakesEndpoint = $"{Prefix}/makes/";
        public static string VehiclesEndpoint = $"{Prefix}/vehicles/";
        public static string CustomersEndpoint = $"{Prefix}/customers/";
        public static string ModelsEndpoint = $"{Prefix}/models/";
        public static string KolorsEndpoint = $"{Prefix}/kolors/";
        public static string BookingsEndpoint = $"{Prefix}/bookings/";

    }
}
