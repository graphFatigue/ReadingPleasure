using ReadingPleasure.Domain.Enum;

namespace ReadingPleasure.Common.DTOs.Reader
{
    public class UpdateReaderDto
    {
        public int WordsPerMinute { get; set; }
        public Sex Sex { get; set; }
    }
}
