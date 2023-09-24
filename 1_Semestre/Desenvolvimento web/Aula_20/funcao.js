function alo(){ //funçao simples
    alert("alo!")
}
function olaNome(nome){ //funçao com parametro
    alert("Ola "+ nome +". bem vindo ao curso!") //concatenaçao de strings
}
function saudacao(){                                   //.value pega apenas oque foi digitado
    const nome = document.getElementById('nome').value //pega um elemento pelo id
    if (nome != ''){ //comparando se esta vazio
        alert(`Ola ${nome}. Bem vindo ao curso`) //interpolaçao de strings //tem que usar ` (crase(à))
    } else{
        alert('Informe seu nome.')
        document.getElementById('nome').focus() //colocando foco em um elemento
    }
}

function mouseCima(){
    alert("O mouse esta em cima.")
}
function mouseSaiu(){
    alert("O mouse saiu.")
}

function textoMudou(){
    alert("O texto foi alterado.")
}

function emFoco(){
    const user = document.getElementById('user')
    user.style.border = '5px solid green'
    user.style.backgroundColor = 'grey'
}
function semFoco(){
    const user = document.getElementById("user")
    user.style.border = "1px solid black"
    user.style.backgroundColor = "white"
}