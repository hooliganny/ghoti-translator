CopyToClipboard = {
  copyToClipboard: function (text) {
    // const translatedTextElement = document.getElementById("translated-text");
    // const text = translatedTextElement.value;
    navigator.clipboard.writeText(text).then(
      function () {
        console.log("Async: Copying to clipboard was successful!");
      },
      function (err) {
        console.error("Async: Could not copy text: ", err);
      }
    );
  },
};
