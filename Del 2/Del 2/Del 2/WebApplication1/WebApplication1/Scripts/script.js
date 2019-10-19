var redirect = function () {
    document.location.href = "Index.chtml"
}

//Colour coding of prices
var priceCells = document.getElementsByClassName("priceCell");
for (var index = 0; index < priceCells.length; index++) {

    var text = priceCells[index].textContent.substr(1, priceCells[index].textContent.length - 1);
    var find = ',';
    var re = new RegExp(find, 'g');
    var actualPrice = parseFloat(text.replace(re, ''));
    if (actualPrice > 500000) {
        priceCells[index].style.color = "red";
    }

}


//Show average price for each section
var sections = document.getElementsByClassName("section");

for (var i = 0; i < sections.length; i++) {
    var sectionPrices = sections[i].getElementsByClassName("priceCell");
    var sum = 0;
    for (var j = 0; j < sectionPrices.length; j++) {
        var actualPrice = parseFloat(sectionPrices[j].textContent.substr(1, sectionPrices[j].textContent.length - 1).replace(new RegExp(',', 'g'), ''));
        sum += actualPrice;
    }
    var average = (sum / sectionPrices.length).toFixed(2);
    sections[i].getElementsByClassName("sectionHeader")[0].innerHTML += " <span style='color:#42a5f5'>[Average Price: <span style='color:#ec407a'>R" + average + "</span>]</span>";

}