namespace Commits
{
    public class Commit
    {
        public string Hash { get; set; }

        public string Message { get; set; }

        public decimal Additions { get; set; }

        public decimal Deletions { get; set; }
    }
}
