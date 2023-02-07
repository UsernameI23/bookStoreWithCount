using System;

namespace bookStore
{
    class book
    {
        private static int _transactions = 0;
        private int _IDd;
        private string _Title;
        private string _Author;
        
        public book()
        {
            _IDd = 0;
            _Title = " ";
            _Author = " ";
        }
        public book(int i, string Title, string Author)
        {
            _IDd = i;
            _Title = Title;
            _Author = Author;

        }
        public int GetTrans()
        {
            return _transactions;
        }
        public int GetID()
        {
            return _IDd;
        }
        public string GetTitle()
        {
            return _Title;
        }
        public string GetAuthor()
        {
            return _Author;
        }
        public void SetTrans(int _trans)
        {
            _transactions += _trans;
        }
        public void SetID(int identification)
        {
            _IDd = identification;
        }
        public void SetTitle(string title)
        {
            _Title = title;
        }
        public void SetAuthor(string author)
        {
            _Author = author;
        }
    }
    class myStore
    {
        static void Main(string[] args)
        {
            book book30 = new book();
            book30.SetTrans(1);
            book30.SetID(30);
            book30.SetTitle("1984");
            book30.SetAuthor("George Orwell");

            book book20 = new book();
            book20.SetTrans(1);
            Console.WriteLine("Please enter the member ID: ");
            book20.SetID(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter Title of Book: ");
            book20.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the Author: ");
            book20.SetAuthor(Console.ReadLine());

            book book10 = new book(10, "It", "Stephen King");
            book30.SetTrans(1);

            Console.WriteLine("Please enter the member ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Title of Book: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the Author: ");
            string tempAuthor = Console.ReadLine();
            book book40 = new book(tempID, tempTitle, tempAuthor);
            book40.SetTrans(1);

            Console.WriteLine($"The store has {book10.GetTrans()} new titles");
            displayBooks(book10);
            displayBooks(book20);
            displayBooks(book30);
            displayBooks(book40);
        }

        static void displayBooks(book member)
        {
            Console.WriteLine("Here's your Book Store information");
            Console.WriteLine($"Book ID: {member.GetID()}");
            Console.WriteLine($"Book Name: {member.GetTitle()}");
            Console.WriteLine($"Book Name: {member.GetAuthor()}");
        }
        
    }

}