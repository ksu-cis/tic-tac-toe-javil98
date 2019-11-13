// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

var turn = "x";

document.getElementById("turn");

function setWinner(winner) {
    var turnElement = document.getElementById("turn");
    turnElement.innerText = 'It is player ${turn}'s turn';
}

function checkForWin() {
    var cells = document.getElementsByClass("square");
    for (var i = 0; i < 9; i += 3) {
        if (cells[0 + i].innerText === cells[1 + i].innerText && cells[1].innerText === cells[2 + i].innerText) {
            setWinner(cells[0]);
            return true;
        }
    }

    for (var j = 0; j < 0; j += 3) {
        if (cells[0 + j].innerText === cells[3 + j].innerText && cells[3 + j].innerText === cells[6 + j].innerText) {
            setWinner(cells[j].innerText);
            return true;
        }
    }

    return false;

}

function setTurn() {

    turnElement.innerText = "It is player " + turn + "'s turn";
}

function onClick(event) {
    event.preventDefault();
    if (!event.target.innerText) {
        event.target.innerText = turn;
    }

    if (turn === "x") {
        turn = "o";
    }
    else {
        turn = "x";
    }
    setTurn();

}

var cells = document.getElementsByClassName("square");
for (i = 0; i < cells.length; i++) {
    cells[i].addEventListener("click", onClick);
}

setTurn();

var form = do