using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books { get; }
        public IEnumerator<Book> GetEnumerator()
        {
            LibraryIterator IBookIterator = new LibraryIterator(this.books);
            return IBookIterator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int index;

            public Book Current
            {
                get
                {
                    return this.books[this.index];
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return this.Current;
                }
            }

            public LibraryIterator(List<Book> books)
            {
                this.Reset();
                this.books = books;
            }

            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }

            public bool MoveNext()
            {
                this.index++;
                return this.index < this.books.Count;
            }

            public void Reset()
            {
                this.index = -1;
            }
        }

    }
}
