// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.querySelector('input[type=button]').addEventListener('click', () => {
    const synth = window.speechSynthesis;
    let text = document.querySelector('span').innerText;
    let voice = synth.getVoices()[2]
    const utterThis = new SpeechSynthesisUtterance(text);
    utterThis.voice = voice;
    synth.speak(utterThis);
});