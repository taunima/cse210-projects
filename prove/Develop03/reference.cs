public class Reference
{
    public string book;
    public int chapter;
    public int verseStart;
    public int? verseEnd;

    public Reference(string book, int chapter, int verseStart, int? verseEnd = null)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseEnd;
    }

    public override string ToString()
    {
        return verseEnd.HasValue
            ? $"{book} {chapter}:{verseStart}-{verseEnd}"
            : $"{book} {chapter}:{verseStart}";
    }
}