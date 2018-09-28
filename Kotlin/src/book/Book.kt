package book
/*
Create a class, book.Book, with a title and an author.
Add a method, readPage(), that increases the value of a private variable, currentPage, by 1.
Create a subclass of book.Book; name it book.eBook.
*/

open class Book(val title : String, val author : String) {
    private var currentPage = 1

    open fun readPage() {
        currentPage++
    }
}