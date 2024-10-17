function replaceWords() {
    const walker = document.createTreeWalker(document.body, NodeFilter.SHOW_TEXT, null, false);
    let node;
    console.log("Hello :)");
    while (node = walker.nextNode()) {
        node.nodeValue = node.nodeValue.replace(/Google/g, 'Pivert');
    }
}

// Run the replacement function after the page loads
window.onload = replaceWords;