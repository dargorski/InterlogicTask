using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer.Web;

namespace InterlogicTask.Models.Blocks.UspBlock
{
    [SiteContentType(GUID = "8B2AC275-5113-4E00-AD50-8D7ECEC8B862")]
    [SiteImageUrl]
    public class UspPropositionBlock : SiteBlockData
    {
        [Required]
        [Display(Name = "Block Title", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Title { get; set; }

        [Required]
        [Display(Name = "Price", GroupName = SystemTabNames.Content, Order = 20)]
        [Range(0, int.MaxValue)]
        public virtual int Price { get; set; }
        
        [Display(Name = "Price description (shown below price value)", 
            GroupName = SystemTabNames.Content,
            Order = 30)]
        [UIHint(UIHint.Textarea)]
        public virtual string PriceDescription { get; set; }
        
        [MaxLength(100)]
        [UIHint(UIHint.Textarea)]
        [Display(Name = "Additional description (shown between price description and list of services)", 
            GroupName = SystemTabNames.Content, 
            Order = 40)]
        public virtual string AdditionalDescription { get; set; }

        [Required]
        public virtual IList<string> ServicesList { get; set; }
    }
}