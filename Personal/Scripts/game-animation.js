 //-------------\\
//** Game Menu **\\

$('#menu-start').on('click', showStart);
$('#menu-options').on('click', showOptions);
$('#menu-contact').on('click', showContact);
$('#menu-credits').on('click', showCredits);
$('#sound').on('click', toggleSound);

// Show 'Start Menu'
function showStart() {
    $('#game-menu-start').removeClass('hide');
    $('#game-menu-start').toggleClass('flip');
    $('#game-menu').addClass('hide');
}

// Show 'Options Menu'
function showOptions() {
    $('#game-menu-options').removeClass('hide');
    $('#game-menu').addClass('hide');
}

// Show 'Contact Menu'
function showContact() {
    $('#game-menu-contact').removeClass('hide');
    $('#game-menu').addClass('hide');
}

// Show 'Credits Menu'
function showCredits() {
    $('#game-menu-credits').removeClass('hide');
    $('#game-menu').addClass('hide');
}

// Show 'Main Game Menu'
function showGameMenu(e) {
    e.parentNode.classList.add('hide');
    $('#game-menu').removeClass('hide');
}

function toggleSound() {

}

 //-----------------\\
//** Playing Cards **\\

$('.playing-cards .playing-card').on('click', flipCard);

// Flips the card that was clicked
function flipCard() {
    $(this).toggleClass('flip');
};

 //---------\\
//** Tests **\\

$('#test-deal-cards').on('click', testDealCards);

function testDealCards() {
    $('.test-cards').addClass('deal');
}