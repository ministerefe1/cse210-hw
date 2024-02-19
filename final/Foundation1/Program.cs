// Video class
class Video
{
    // Attributes
    private string title;
    private string author;
    private int length;
    private List<Comment> comments;

    // Constructor
    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        this.comments = new List<Comment>();
    }

    // Methods
    public void AddComment(string commentText, string commenterName)
    {
        Comment newComment = new Comment(commentText, commenterName);
        comments.Add(newComment);
    }

    public int GetNumComments()
    {
        return comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length: {length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumComments()}");

        foreach (Comment comment in comments)
        {
            Console.WriteLine($"Comment: {comment.CommentText} by {comment.CommenterName}");
        }
        Console.WriteLine();
    }
}

// Comment class
class Comment
{
    // Attributes
    private string commentText;
    private string commenterName;

    // Constructor
    public Comment(string commentText, string commenterName)
    {
        this.commentText = commentText;
        this.commenterName = commenterName;
    }

    // Properties
    public string CommentText { get { return commentText; } }
    public string CommenterName { get { return commenterName; } }
}

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Create and add videos with comments
        Video video1 = new Video("Title 1", "Author 1", 120);
        video1.AddComment("Great video!", "User1");
        video1.AddComment("Nice content!", "User2");
        video1.AddComment("Keep it up!", "User3");
        videos.Add(video1);

        Video video2 = new Video("Title 2", "Author 2", 180);
        video2.AddComment("Awesome video!", "User4");
        video2.AddComment("I learned a lot.", "User5");
        videos.Add(video2);

        Video video3 = new Video("Title 3", "Author 3", 150);
        video3.AddComment("Very informative.", "User6");
        video3.AddComment("Loved the presentation.", "User7");
        videos.Add(video3);

        // Display information for each video
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}
