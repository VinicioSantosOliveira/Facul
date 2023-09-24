//8 - Faça um script que leia números até que seja digitado um número negativo, ao final mostrar a média dos números digitados. 

let i = 0, soma = 0

while (true){
    let numero = Number(prompt("digite um numero:"))

    if (numero < 0){
        break
    }
    i++
    soma += numero
}
let media = soma / i

alert(`A media dos numeros digitados foi de ${media}`)