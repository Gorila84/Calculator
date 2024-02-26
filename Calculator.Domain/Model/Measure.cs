namespace Calculator.Domain.Model
{
    public class Measure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Material> Materials { get; set; }
    }
}