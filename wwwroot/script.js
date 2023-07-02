let counterValue = 0;
function Increment() { counterValue++; document.getElementById("TheCounter").innerText = counterValue.toString(); }

const xsltProcessor = new XSLTProcessor();
const ownerDocument = document.implementation.createDocument("", "test", null);

function InitTHisShit() {
    let xhr = new XMLHttpRequest();
    console.log("Inititated this shit");
    xhr.open("GET", "/StyleXmlOb.xslt", false);

    xhr.onload = () => {
        if (xhr.readyState === xhr.DONE && xhr.status === 200) {
            xsltProcessor.importStylesheet(xhr.responseXML);
        }
    }
    xhr.send();
}





function doSmthNew() {
    let xhr3 = new XMLHttpRequest();
    console.log("started new method");
    xhr3.open("GET", "/GetWeather", false);
    xhr3.onload = () => {
        if (xhr3.readyState === xhr3.DONE && xhr3.status === 200) {
            console.log(xhr3.responseXML);
            let y = xsltProcessor.transformToDocument(xhr3.responseXML.documentElement, ownerDocument);
            console.log(y);
            console.log(y.documentElement);
            console.log(y.children[0].innerHTML);
            document.getElementById("weatherSlot").innerHTML = y.children[0].innerHTML;
        }
    }
    xhr3.send(); 
}


InitTHisShit();