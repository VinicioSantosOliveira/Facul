//7 - Faça um script que apresenta a soma dos números múltiplos de 3 entre 0 e 100. 

let soma = 0

for (let i = 0; i <= 100; i++) {
    if (i % 3 == 0) {
        soma = soma + i
    }
}
alert(`a soma dos numeros multiplos de 3 entre 0 e 100 foi de ${soma}`)