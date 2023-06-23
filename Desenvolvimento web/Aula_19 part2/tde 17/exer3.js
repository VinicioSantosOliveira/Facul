//3 - Faça um script que leia o nome e a idade de uma pessoa e informe se a pessoa é maior de idade ou não.
//Exemplo: ‘João você tem 30 anos, é maior de idade’.

let nome = prompt("Informe seu nome:")
let idade = Number(prompt("Informe sua idade:"))

if (idade >= 18){
    alert(`${nome} você tem ${idade} anos, é maior de idade`)
}
else{
    alert(`${nome} você tem ${idade} anos, é menor de idade`)
}