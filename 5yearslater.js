// the answer done in the browser console in 20 minutes.

var input = "Hello, I like cats. Do you like cats? No? Are you sure? Why don't you like cats? Are you sure? I like you.";
var words = input.replaceAll(".", "").replaceAll("?", "").split(" ");
var uniqueWords = new Set(words);
var uniqueWordsArr = [...uniqueWords];
var output = uniqueWordsArr.map(x => ({ [x]: words.filter(y => y === x).length}))
console.log(output)
// {Hello,: 1}
// {I: 2}
// {like: 4}
// {cats: 3}
// {Do: 1}
// {you: 5}
// {No: 1}
// {Are: 2}
// {sure: 2}
// {Why: 1}
// {don't: 1}
