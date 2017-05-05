namespace DressingApp.Model
{
    public class DressModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string HotResponse { get; set; }
        public string ColdResponse { get; set; }

        public DressModel(int id, string description, string hotResponse, string coldResonse)
        {
            Id = id;
            Description = description;
            HotResponse = hotResponse;
            ColdResponse = coldResonse;
        }
    }
}
