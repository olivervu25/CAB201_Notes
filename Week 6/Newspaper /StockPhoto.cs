class StockPhoto
{
    // Fields 
    private string caption; 
    private string filename; 

    // Properties

    public string Caption
    {
        get { return caption; }
        set { caption = value; }
    }

    // Caution: the Filename property is read-only, it is set private so it can only be set in the constructor
    public string Filename
    {
        get { return filename; }
        private set { filename = value; }
    }

    // Constructor
    public StockPhoto(string caption, string filename)
    {
        Caption = caption;
        Filename = filename;
    }

    // Methods
    public void Display()
    {
        Console.WriteLine("Photo Details:"); 
        Console.WriteLine("Caption: " + Caption);
        Console.WriteLine("Filename: " + Filename);
    }


}