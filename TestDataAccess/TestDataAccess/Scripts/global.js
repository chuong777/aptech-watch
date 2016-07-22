$(document)
    .ready(function() {
        $('[data-toggle="tooltip"]').tooltip();
        setupRating();
    });

function addBookToCart(e) {
    $.ajax({
        url: '/Cart/AddBookToCart',
        data: { 'bookId': e.getAttribute("bookId"), 'fromUrl': e.getAttribute("fromUrl") },
        type: "POST",
        success: function (data) {
            if (data.Success) {
                showPopup(data.Message);
                increaseCartCountBy(1);
                e.setAttribute("onclick", "removeBookFromCart(this)");
                e.getElementsByClassName("text")[0].textContent = "Remove from cart";
            } else {
                if (data.Link) {
                    window.location.href = data.Link;
                } else {
                    showPopup(data.Message);
                }
            }
        },
        error: function (data) {
            showPopup("Can't connect to server");
        }
    });
}

function removeBookFromCart(e) {
    $.ajax({
        url: '/Cart/RemoveBookFromCart',
        data: { 'bookId': e.getAttribute("bookId"), 'fromUrl': e.getAttribute("fromUrl") },
        type: "POST",
        success: function (data) {
            if (data.Success) {
                showPopup(data.Message);
                increaseCartCountBy(-1);
                e.setAttribute("onclick", "addBookToCart(this)");
                e.getElementsByClassName("text")[0].textContent = "Add to cart";
            } else {
                if (data.Link) {
                    window.location.href = data.Link;
                } else {
                    showPopup(data.Message);
                }
            }
        },
        error: function (data) {
            showPopup("Can't connect to server");
        }
    });
}

function addBookToLove(e) {
    $.ajax({
        url: '/Love/AddBookToLove',
        data: { 'bookId': e.getAttribute("bookId"), 'fromUrl': e.getAttribute("fromUrl") },
        type: "POST",
        success: function (data) {
            if (data.Success) {
                showPopup(data.Message);
                increaseLoveCountBy(1);
                e.setAttribute("onclick", "removeBookFromLove(this)");
                e.getElementsByClassName("text")[0].textContent = "UnLove";
            } else {
                if (data.Link) {
                    window.location.href = data.Link;
                } else {
                    showPopup(data.Message);
                }
            }
        },
        error: function (data) {
            showPopup("Can't connect to server");
        }
    });
}

function removeBookFromLove(e) {
    $.ajax({
        url: '/Love/RemoveBookFromLove',
        data: { 'bookId': e.getAttribute("bookId"), 'fromUrl': e.getAttribute("fromUrl") },
        type: "POST",
        success: function (data) {
            if (data.Success) {
                showPopup(data.Message);
                increaseLoveCountBy(-1);
                e.setAttribute("onclick", "addBookToLove(this)");
                e.getElementsByClassName("text")[0].textContent = "Love";
            } else {
                if (data.Link) {
                    window.location.href = data.Link;
                } else {
                    showPopup(data.Message);
                }
            }
        },
        error: function (data) {
            showPopup("Can't connect to server");
        }
    });
}

function commentForABook(e) {
    e = e.parentElement.parentElement;
    var bookId = e.getAttribute("bookId");
    var shortMessage = e.getElementsByClassName("short-message")[0].value;
    var rate = e.getElementsByClassName("rate-it")[0].getAttribute("value");
    var message = e.getElementsByClassName("message")[0].value;
    var fromUrl = e.getAttribute("fromUrl");
    $.ajax({
        url: '/Comment/CommentForABook',
        data: {
            'bookId': bookId,
            'shortMessage': shortMessage,
            'rate': rate,
            'message': message,
            'fromUrl': fromUrl
        },
        type: "POST",
        success: function (data) {
            if (data.Success) {
                showPopup(data.Message);
                increaseCommentCountBy(1);
            } else {
                if (data.Link) {
                    window.location.href = data.Link;
                } else {
                    showPopup(data.Message);
                }
            }
        },
        error: function (data) {
            showPopup("Can't connect to server");
        }
    });
}

function showPopup(message) {
    if (message) {
        $("#popup-message").html(message);
        $("#popup").fadeIn(1000).delay(1000).fadeOut(1000);
    }
}

function increaseCartCountBy(value) {
    var count = parseInt($("#cartCount").html());
    count += value;
    $("#cartCount").html(count);
}

function increaseLoveCountBy(value) {
    var count = parseInt($("#loveCount").html());
    count += value;
    $("#loveCount").html(count);
}

function increaseCommentCountBy(value) {
    var count = parseInt($("#commentCount").html());
    count += value;
    $("#commentCount").html(count);
}

function setupRating() {
    /*RATING*/
    var rating;
    $(".rate")
        .each(function () {
            rating = this.getAttribute("value");
            rating = parseFloat(rating).toFixed(1);
            var i = 1;
            for (i = 1; i <= rating; i++) {
                this.children[i - 1].className = "fa fa-star";
            }
            if (i-1 < rating) {
                this.children[i - 1].className = "fa fa-star-half-o";
                i++;
            }
            for (; i <= 5; i++) {
                this.children[i - 1].className = "fa fa-star-o";
            }
        });
    $(".rate-it")
        .children()
        .mouseenter(function () {
            rating = this.getAttribute("value");
            rating = Number(rating);
            for (var i = 1; i <= rating; i++) {
                this.parentElement.children[i - 1].className = "fa fa-star";
            }
        });
    $(".rate-it")
        .children()
        .mouseleave(function () {
            rating = this.parentElement.getAttribute("value");
            rating = Number(rating);
            for (var i = 1; i <= rating; i++) {
                this.parentElement.children[i - 1].className = "fa fa-star";
            }
            for (var i = rating + 1; i <= 5; i++) {
                this.parentElement.children[i - 1].className = "fa fa-star-o";
            }
        });
    $(".rate-it")
        .children()
        .click(function () {
            rating = this.getAttribute("value");
            rating = Number(rating);
            this.parentElement.setAttribute("value", rating);
            for (var i = 1; i <= rating; i++) {
                this.parentElement.children[i - 1].className = "fa fa-star";
            }
            for (var i = rating + 1; i <= 5; i++) {
                this.parentElement.children[i - 1].className = "fa fa-star-o";
            }
        });
}