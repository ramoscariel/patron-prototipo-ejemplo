using SQLite;


namespace patron_prototipo_ejemplo.Data
{
    public class Figure
    {
        [PrimaryKey,AutoIncrement]public int Id { get; set; }
        public Color FillColor { get; set; }
        public Color StrokeColor {  get; set; }
        public List<int> Points { get; set; }
    }
}
