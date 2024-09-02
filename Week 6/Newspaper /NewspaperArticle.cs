class NewspaperArticle 
{
    // Fields 
    private string title; 
    private string text; 
    private StockPhoto photo;

    // Constructor
    public NewspaperArticle(string title, string text, string caption, string filename)
    {
        title = title;
        text = text;

        // Create a new StockPhoto object using constructor of StockPhoto class
        photo = new StockPhoto(caption, filename);
    }

    // Methods
    public void Display()
    {
        Console.WriteLine("Article Details:"); 
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Text: " + text);
        photo.Display();
    }
}