//Somar
function somar(){
    const numero1 = Number(document.getElementById('num1').value)
    const numero2 = Number(document.getElementById('num2').value)

    if (numero1 != '' && numero2 != ''){
        let soma = numero1 + numero2
        document.getElementById('resultado1').innerHTML = 'Resultado: ' + soma
    }else{
        alert('Preencha os dois campos.')
    }
}
function limpar1(){
    document.getElementById('num1').value = ''
    document.getElementById('num2').value = ''
    document.getElementById('resultado1').innerHTML = 'Resultado: '
    document.getElementById('num1').focus()
}
//Subtraçao
function subtrair(){
    const numero1 = Number(document.getElementById('numero1').value)
    const numero2 = Number(document.getElementById('numero2').value)

    if (numero1 != '' && numero2 != ''){
        let subtrair = numero1 - numero2
        document.getElementById('resultado2').innerHTML = 'Resultado: ' + subtrair
    }else{
        alert('Preencha os dois campos.')
    }
}
function limpar2(){
    document.getElementById('numero1').value = ''
    document.getElementById('numero2').value = ''
    document.getElementById('resultado2').innerHTML = 'Resultado: '
    document.getElementById('numero1').focus()
}

//Divisao
function dividir(){
    const numero1 = Number(document.getElementById('number1').value)
    const numero2 = Number(document.getElementById('number2').value)

    if (numero1 != '' && numero2 != ''){
        let dividir = numero1 / numero2
        document.getElementById('resultado3').innerHTML = 'Resultado: ' + dividir
    }else{
        alert('Preencha os dois campos.')
    }
}
function limpar3(){
    document.getElementById('number1').value = ''
    document.getElementById('number2').value = ''
    document.getElementById('resultado3').innerHTML = 'Resultado: '
    document.getElementById('number1').focus()
}

//Multiplicaçao
function multiplicar(){
    const numero1 = Number(document.getElementById('numberOne').value)
    const numero2 = Number(document.getElementById('numberTwo').value)

    if (numero1 != '' && numero2 != ''){
        let multiplicar = numero1 * numero2
        document.getElementById('resultado4').innerHTML = 'Resultado: ' + multiplicar
    }else{
        alert('Preencha os dois campos.')
    }
}
function limpar4(){
    document.getElementById('numberOne').value = ''
    document.getElementById('numberTwo').value = ''
    document.getElementById('resultado4').innerHTML = 'Resultado: '
    document.getElementById('numberOne').focus()
}







//Exercício 2

function calcular(){
    const ap1 = Number(document.getElementById('ap1').value)
    const ap2 = Number(document.getElementById('ap2').value)
    const as = Number(document.getElementById('as').value)

    let nota = ap1 + ap2 + as
    let msg = `Nota: ${nota}`
    document.getElementById('msg').innerHTML = msg

    if (nota >= 6){
        document.getElementById('msg').innerHTML = `Nota: ${nota}. Aprovado. Parabéns.`
    } else {
        document.getElementById('msg').innerHTML = `Nota: ${nota}. Reprovado. Reforce seus estudos para a realização da AF.`
    }
}

function clean(){
    document.getElementById('ap1').value = ''
    document.getElementById('ap2').value = ''
    document.getElementById('as').value = ''
    document.getElementById('msg').innerHTML = 'Nota: '
    document.getElementById('ap1').focus()
}
//verificaçao ap1
function verificaAp1(){
    const ap1 = Number(document.getElementById('ap1').value)
    if (ap1 < 0 || ap1 > 1.5){
        alert('Nota inválida. Digite uma nota entre 0 e 1.5')
        document.getElementById('ap1').value = ''
    }
}
//verificaçao ap2
function verificaAp2(){
    const ap2 = Number(document.getElementById('ap2').value)
    if (ap2 < 0 || ap2 > 2.5){
        alert('Nota inválida. Digite uma nota entre 0 e 2.5')
        document.getElementById('ap2').value = ''
    }
}
//verificaçao as
function verificaAs(){
    const as = Number(document.getElementById('as').value)
    if (as < 0 || as > 6){
        alert('Nota inválida. Digite uma nota entre 0 e 6')
        document.getElementById('as').value = ''
    }
}