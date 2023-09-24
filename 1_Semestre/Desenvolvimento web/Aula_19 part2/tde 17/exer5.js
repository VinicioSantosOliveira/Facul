//5 - Crie um script que leia três notas e imprima a média das notas e informe se o aluno está aprovado ou não.
//A média para aprovação é 6.

let nota1, nota2, nota3, media

nota1 = Number(prompt("Digite a primeira nota:"))
nota2 = Number(prompt("Digite a segunda nota:"))
nota3 = Number(prompt("Digite a terceira nota:"))

media = (nota1 + nota2 + nota3)/ 3

if (media >= 6){
    alert(`A media foi ${media} e o aluno foi aprovado`)
}
else{
    alert(`A media foi ${media} e o aluno foi reprovado`)
}