using ApiUdemy.Data.Models;
using ApiUdemy.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiUdemy.Data.Services
{
    public class BooksService
    {
        private ApplicationDbContext _context;
        public BooksService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddBookWithAuthors(BookVM book)
        {
            var _book = new LibBook()
            {
                Book_Title = book.Book_Title,
                Description = book.Description,
                Edition = book.Edition,
                isRead = book.isRead,
                readTime = book.isRead ? book.readTime.Value : null,
                Genre = book.Genre,
                addedDate = DateTime.Now,
                PublisherId = book.PublisherId
            };
            _context.LibBook.Add(_book);
            _context.SaveChanges();

            foreach (var item in book.Authorids)
            {
                var _book_author = new Book_Author()
                {
                    BookId = _book.BookId,
                    AuthorId = item
                };
                _context.Book_Authors.Add(_book_author);
                _context.SaveChanges();
            }

        }
        public List<LibBook> GetAllBooks() => _context.LibBook.ToList();

        public BookWithAuthorsVM GetBookById(int id)
        {
            var _bookWithAuthors = _context.LibBook.Where(n=>n.BookId==id).Select(book => new BookWithAuthorsVM()
            {
                Book_Title = book.Book_Title,
                Description = book.Description,
                Edition = book.Edition,
                isRead = book.isRead,
                readTime = book.isRead ? book.readTime.Value : null,
                Genre = book.Genre,
                PublisherName = book.Publisher.Publisher_Name,
                AuthorNames = book.Book_Authors.Select(n=>n.Author.AuthorName).ToList()
            }).FirstOrDefault();
            return _bookWithAuthors;
        }
        
        public BookWithAuthorsVM GetBooksofAuthor(string _authorName)
        {
            var _booksOfAuthors = _context.LibBook.Where(n => n.Book_Authors.Equals(_authorName)).Select(book => new BookWithAuthorsVM()
            {
                Book_Title = book.Book_Title,
                Description = book.Description,
                Edition = book.Edition,
                isRead = book.isRead,
                readTime = book.isRead ? book.readTime.Value : null,
                Genre = book.Genre,
                PublisherName = book.Publisher.Publisher_Name,
                AuthorNames = book.Book_Authors.Select(n => n.Author.AuthorName).ToList()
            }).FirstOrDefault();
            return _booksOfAuthors;
        }
        public LibBook UpdateBook(int id, BookVM book)
        {
            var _book = _context.LibBook.FirstOrDefault(n => n.BookId == id);
            if (_book != null)
            {
                _book.Book_Title = book.Book_Title;
                _book.Description = book.Description;
                _book.Edition = book.Edition;
                _book.isRead = book.isRead;
                _book.readTime = book.isRead ? book.readTime.Value : null;
                _book.Genre = book.Genre;
                _context.SaveChanges();
            }
            return _book;
        }
        public void DeleteBookById(int id)
        {
            var _book = _context.LibBook.FirstOrDefault(n => n.BookId == id);
            if(_book != null)
            {
                _context.LibBook.Remove(_book);
                _context.SaveChanges();
            }
        }
    }
}
