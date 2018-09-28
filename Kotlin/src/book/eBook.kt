package book

import kotlin.test.assertEquals

/*
book.eBook also takes in a format, which defaults to "text".
In eBooks, counting words makes more sense than pages. Override the readPage() method to increase the word count by 250, the average number of words per page from typewriter days.
*/

class eBook(title : String, author : String, val format : String = "text") : Book(title, author) {
    internal var currentWordCount = 0

    val WORDS_PER_PAGE = 250

    override fun readPage() {
        currentWordCount += WORDS_PER_PAGE
    }
}

fun main(args : Array<String>) {
    val eBook : eBook = eBook("Fire from the Deep", "Vince Vincerton")
    eBook.readPage()
    eBook.readPage()
    assertEquals(500, eBook.currentWordCount)
}
