package com.oneapm.iterator;

public class BookListIterator<E> implements Iterator<E> {

	private int index  = 0;
	private BookList<E> bookList =null ;
	
	public BookListIterator(BookList bookList) {
		this.bookList = bookList ;
	}
	
	@Override
	public boolean hasNext() {
		// TODO Auto-generated method stub
		return index < bookList.size();
	}

	@Override
	public E next() {
		// TODO Auto-generated method stub
		E obj = bookList.getBook(index) ;
		++index ;
		return obj ;
	}

}
