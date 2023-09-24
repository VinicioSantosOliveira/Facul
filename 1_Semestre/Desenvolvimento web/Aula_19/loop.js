for(let i = 1; i <= 10; i++){ //estrutura do for, tres parametros
    if (i != 5){ //imprime numeros diferente de 5
        console.log(i)
    }
}

let numero = 0

while (numero < 5){
    numero = prompt("digite um numero: ")
}

let texto = "sim"

while (True){
    texto = prompt("voce deseja continuar?")

    if (texto == "nao"){
        break
    }
}