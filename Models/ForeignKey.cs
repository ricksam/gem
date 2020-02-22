namespace GEM.Models{
    public class ForeignKey
    {
        public string Table { get; set; }
        public string Column { get; set; }
        public string ReferenceTable { get; set; }
        public string ReferenceColumn { get; set; }
    }
}