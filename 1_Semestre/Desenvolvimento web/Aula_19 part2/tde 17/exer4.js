//4 - Faça um script que receba um número, calcule e mostre a tabuada desse número.

let numero = Number(prompt("digite um numero:"))

for (let i = 1; i <= 10; i++){

    let resultado = numero * i

    alert(`${numero} X ${i} = ${resultado}`)
    console.log(resultado)
}