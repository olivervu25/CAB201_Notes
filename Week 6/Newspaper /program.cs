class TestNewspaper 
{
    static void Main() 
    {
        // Create a new Newspaper object using constructor of Newspaper class
        Newspaper newspaper = new Newspaper("Brisbane Times", 3.50);

        // Add new articles to the newspaper
        newspaper.AddArticle("New Mayor Elected", "The new mayor of Brisbane has been elected", "Mayor", "mayor.jpg");
        newspaper.AddArticle("New Library Opens", "A new library has opened in the city", "Library", "library.jpg");

        // Display the newspaper
        newspaper.Display();
    }
}