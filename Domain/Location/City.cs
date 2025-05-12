using Domain.Attributes;

namespace Domain.Location
{
    [Auditable]
    public class City
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
