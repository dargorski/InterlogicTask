using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using InterlogicTask.Models.Blocks.UspBlock;

namespace InterlogicTask.Models.Pages
{
    [ContentType(GUID = "EEC77137-F38E-4162-98F0-433EC365167B", DisplayName = "USP Calculation Page")]
    [SiteImageUrl]
    public class UspCalculationPage : SitePageData
    {
        [Display(GroupName = SystemTabNames.Content, 
            Order = 10)]
        public virtual string PageTitle { get; set; }

        [Display(GroupName = SystemTabNames.Content, 
            Name = "Main USP Block", 
            Order = 20)]
        public virtual UspPropositionBlock MainUsp {get; set; }
        
        [Display(GroupName = SystemTabNames.Content, 
            Name = "Bottom USP Blocks",
            Order = 30)]
        [AllowedTypes(typeof(UspPropositionBlock))]
        public virtual ContentArea BottomUspBlocksContentArea { get; set; }
    }
}