using librari_hm.Models;

namespace librari_hm
{
    public class BookService
    {
        private List<BookModel> _books = new()
        {
            new BookModel { Id = 1, Title = "Book 1", Author = "Author 1", Genre = "Genre 1", Year = 2020 },
            new BookModel { Id = 2, Title = "Book 2", Author = "Author 2", Genre = "Genre 2", Year = 2021 },
            new BookModel { Id = 3, Title = "Book 3", Author = "Author 3", Genre = "Genre 3", Year = 2022 }
        };

        public List<BookModel> GetAllBooks()
        {
            return _books;
        }

        public void AddBook(BookModel Book)
        {
            Book.Id = _books.Count + 1;
            _books.Add(Book);
        }
    }
}
