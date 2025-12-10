using AITech.WebUI.DTOs.AboutDtos;
using AITech.WebUI.DTOs.AboutItemsDtos;
using AITech.WebUI.DTOs.SocialDtos;

namespace AITech.WebUI.Models
{
    public class AboutViewModel
    {
        public ResultAboutDto About { get; set; }
        public List<ResultAboutItemsDto> AboutItems { get; set; }
        public List<ResultSocialDto> Social { get; set; }
    }
}
