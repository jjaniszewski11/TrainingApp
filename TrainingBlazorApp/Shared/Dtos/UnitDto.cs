namespace TrainingBlazorApp.Shared.Dtos
{
    public class UnitDto
    {
        public long Id { get; set; }
        public string Shortcut { get; set; }
        public string Name { get; set; }
        public string PrimaryUnit { get; set; }
        public double PrimaryUnitConverter { get; set; }
        public int CommaOffset { get; set; }
    }
}
