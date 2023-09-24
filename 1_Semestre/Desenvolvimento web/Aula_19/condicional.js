//prompt recebe o input do usuario
let numero = prompt("digite um numero: ")

if(numero > 5){
    alert("é maior")
}
else if(numero == 5){
    alert("é igual")
   //console.log(numero) //imprime no console do navegador
}
else{
    alert("é menor")
}


let opcao = Number(prompt("digite um numero de 1 a 4"))

switch(opcao){
    case 1:
        alert("opçao 1")
        break
    case 2:
        alert("opçao 2")
        break
    case 3:
        alert("opçao 3")
        break
    case 4:
        alert("opçao 4")
        break
    default:
        alert("Selecione uma opçao valida")
}