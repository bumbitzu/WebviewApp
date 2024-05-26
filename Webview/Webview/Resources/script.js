function testJs(element) {
    if (element.innerText == "Test Js")
    {
        element.innerText = "JS is working"
    }
    else
    {
        element.innerText = "Test Js"
    }
}