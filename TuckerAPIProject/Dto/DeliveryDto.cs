namespace TuckerAPIProject.Dto
{
    public class DeliveryDto
    {
        public DateTime Date { get; set; }

        public string? Summary { get; set; }

        public string Location { get; set; }

        public PackageDto Package { get; set; }

        public TruckerInfoDto TruckerInfo { get; set; }

        public AccountDto Account { get; set; }
    }
}