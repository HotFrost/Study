using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EpiserverSiteEmpty.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "e2c7d9c9-4a87-4ecd-b99f-b5b315d4eab4", Description = "")]
    public class StartPage : PageData
    {
        [CultureSpecific]
        [Display(Name = "Main body",Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
        GroupName = SystemTabNames.Content,Order = 1)]

        public virtual XhtmlString MainBody { get; set; }

    }
}