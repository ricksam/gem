using System.Collections.Generic;

namespace GEM.Models
{
        public class Combo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string DefaultValue{ get; set; }
        public string DefaultText{ get; set; }
        public string SelectedItem { get; set; }
        public List<ComboItem> Items { get; set; }
        public string OnChange { get; set; }
    }

    public class ComboItem
    {
        public string Value { get; set; }
        public string Text { get; set; }

    }
}