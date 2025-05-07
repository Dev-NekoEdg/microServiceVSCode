namespace serviceCode.Domain.Config
{

public class BookList{
    public Book[] Books { get; set; } = [];
}

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public int Price { get; set; }
        public bool IsActive { get; set; }
    }
    
}