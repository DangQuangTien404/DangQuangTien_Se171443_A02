namespace ServiceLayer.DTOs
{
    public class NewsArticleDto
    {
        public required string NewsArticleId { get; set; }
        public string? NewsTitle { get; set; }
        public string? Headline { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? NewsContent { get; set; }
        public string? NewsSource { get; set; }
        public short? CategoryId { get; set; }
        public bool? NewsStatus { get; set; }
        public short? CreatedById { get; set; }
        public short? UpdatedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public CategoryDto? Category { get; set; }
        public IList<DAL.Entities.Tag> Tag { get; set; } = new List<DAL.Entities.Tag>();
    }
}
