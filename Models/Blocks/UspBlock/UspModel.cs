using System.Collections.Generic;

namespace InterlogicTask.Models.Blocks.UspBlock
{
    public class UspModel
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public string PriceDescription { get; set; }
        public string AdditionalDescription { get; set; }
        public IEnumerable<string> ServicesList { get; set; }
    }
}