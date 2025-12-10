using AITech.Entity.Entities.Common;

namespace AITech.Entity.Entities
{
    public class Team:BaseEntity
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string TwiterUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string LinledinUrl { get; set; }
        public string GithubUrl { get; set; }

    }
}
