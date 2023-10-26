// the answer done in the browser console in 20 minutes.

var input = "Hello, I like cats. Do you like cats? No? Are you sure? Why don't you like cats? Are you sure? I like you.";
var words = input.replaceAll(".", "").replaceAll("?", "").split(" ");
var uniqueWords = new Set(words);
var uniqueWordsArr = [...uniqueWords];
var output = uniqueWordsArr.map(x => ({ [x]: words.filter(y => y === x).length}))
console.log(output)
