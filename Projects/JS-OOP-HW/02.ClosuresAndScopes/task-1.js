function solve(){
	var library = (function(){
	    var books = [],
		 titles = [],
		 isbns = [],
         categories = [];
	
		function addBook(book){ //to category
		    var id;
		    if(!book.title || !book.author || !book.category || !book.isbn){
			    throw new Error('Invalid input parameters');
		    }
		    if(book.title.length < 2 || book.title.length > 100){
			    throw new Error ('Book title name must be between 2 and 100 characters');
		    }
		    if(titles.indexOf(book.title) !== -1){
		        throw new Error('Duplicate title name');
		    }
		    if(isNaN(book.isbn) || !(book.isbn.toString().length === 10 || book.isbn.toString() === 13) || isbns.indexOf(book.isbn) !== -1){
			    throw new Error ('Invalid ISBN number');
		    }
		    if(book.author === ''){
		        throw new Error('Author name must be non-empty string');
		    }
		    if(book.category.length < 2 || book.category.length > 100){
			    throw new Error('Book category name must be between 2 and 100 characters');
		    }
		    book.ID = books.length + 2;
		    titles.push(book.title);
		    isbns.push(book.isbn);

		    if(categories.indexOf(books.category) === -1){
			    categories.push(book.category);
		    }	
		    books.push(book);
		    return books;
        }

		function listBooks(obj){ // pass author, category or empty/undefined
			if(!!obj){
			    var result = books.filter(function(book){
 				    return book.category === obj.category;
		        });
		    return result;
          }
	    return books;
    }

	function listCategories(){
		return categories;
	}

	return {
		books: {
			list: listBooks,
			add: addBook
		    },
		categories: {
			list: listCategories
		    }
	    };
	}());

	return library;

}

solve();

module.exports = solve;

//"tap": "tap --timeout 240 test/tap/*.js",



