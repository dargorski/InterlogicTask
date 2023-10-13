using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using InterlogicTask.Models.Blocks.UspBlock;
using UIHint = EPiServer.Web.UIHint;

namespace InterlogicTask.Models.Pages
{
    [ContentType(GUID = "EEC77137-F38E-4162-98F0-433EC365167B", DisplayName = "USP Calculation Page")]
    [SiteImageUrl]
    public class UspCalculationPage : SitePageData
    {
        [Required]
        [Display(GroupName = SystemTabNames.Content, 
            Name = "Page Title",
            Order = 10)]
        public virtual string PageTitle { get; set; }
        
        [Display(GroupName = SystemTabNames.Content, 
            Name = "Main USP Block", 
            Order = 20)]
        public virtual UspPropositionBlock MainUsp {get; set; }
        
        [Display(GroupName = SystemTabNames.Content, 
            Name = "Bottom USP Blocks",
            Order = 30)]
        [AllowedTypes(typeof(OptionUspPropositionBlock))]
        public virtual ContentArea BottomUspBlocksContentArea { get; set; }
        
        [Required]
        [Display(GroupName = SystemTabNames.Content, 
            Name = "Add Options Text",
            Order = 40)]
        public virtual string AddOptionsText { get; set; }
        
        [Required]
        [Display(GroupName = SystemTabNames.Content, 
            Name = "Calculation Title",
            Order = 40)]
        [UIHint(UIHint.Textarea)]
        public virtual string CalculationTitle { get; set; }
        
        [Required]
        [Display(GroupName = SystemTabNames.Content, 
            Name = "Minimum Number Of Employees",
            Order = 42)]
        [Range(1, 1000)]
        public virtual int MinimumNumberOfEmployees { get; set; }
        
        [Required]
        [Display(GroupName = SystemTabNames.Content, 
            Name = "Maximum Number Of Employees",
            Order = 44)]
        [Range(1, 1000)]
        public virtual int MaximumNumberOfEmployees { get; set; }
        
        [Required]
        [Display(GroupName = SystemTabNames.Content, 
            Name = "Preselected Number Of Employees",
            Order = 46)]
        [Range(1, 1000)]
        public virtual int PreselectedNumberOfEmployees { get; set; }
        
        [Display(GroupName = SystemTabNames.Content, 
            Name = "Employees Text (displayed below employees slider)",
            Order = 48)]
        [Required]
        public virtual string EmployeesText { get; set; }
        
        [Required]
        [Display(GroupName = SystemTabNames.Content, 
            Name = "Main Option Cost Heading",
            Order = 50)]
        public virtual string MainOptionCostHeading { get; set; }
        
        [Required]
        [Display(GroupName = SystemTabNames.Content, 
            Name = "Additional Option Cost Heading",
            Order = 60)]
        public virtual string AdditionalOptionCostHeading { get; set; }
        
        [Required]
        [Display(GroupName = SystemTabNames.Content, 
            Name = "Final Price Heading",
            Order = 70)]
        public virtual string FinalPriceHeading { get; set; }
        
        [Required]
        [Display(GroupName = SystemTabNames.Content, 
            Name = "Cost For Employee Text",
            Order = 80)]
        public virtual string CostForEmployeeText { get; set; }
        
        [Required]
        [Display(GroupName = SystemTabNames.Content, 
            Name = "Summarized Cost Text",
            Order = 90)]
        public virtual string SummarizedCostText { get; set; }
        
        [Display(GroupName = SystemTabNames.Content,
            Name = "Button Text",
            Order = 100)]
        [Required]
        public virtual string ButtonText { get; set; }
        
        [Display(GroupName = SystemTabNames.Content,
            Order = 110,
            Name = "Button Url")]
        [Required]
        public virtual Url ButtonLink { get; set; }
    }
}