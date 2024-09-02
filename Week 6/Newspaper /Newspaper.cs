class Newspaper
{
    // Fields
    private string title; 
    private double cost; 

    // List of NewspaperArticle objects
    private List<NewspaperArticle> articles;


    // Constructor
    public Newspaper(string title, double cost)
    {
        this.title = title;
        this.cost = cost;
        // Initialize the list of articles (empty list at the beginning)
        articles = new List<NewspaperArticle>();
    }

    // Methods

    // A method to add new articles to the list of articles
    public void AddArticle(string title, string text, string caption, string filename)
    {
        // Create a new NewspaperArticle object using constructor of NewspaperArticle class
        NewspaperArticle article = new NewspaperArticle(title, text, caption, filename);
        // Add the article to the list of articles
        articles.Add(article);
    }


    // A method to display all articles in the newspaper
    public void Display()
    {
        Console.WriteLine("Newspaper Details:"); 
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Cost: " + cost);
        Console.WriteLine("Articles:"); 

        // Loop through all articles in the list and display them
        foreach (NewspaperArticle article in articles)
        {
            article.Display();
        }
    }
}