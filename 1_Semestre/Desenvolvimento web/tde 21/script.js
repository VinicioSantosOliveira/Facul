function adicionar(){
    const task = document.getElementById('task').value
    const li = document.createElement('li')

    li.classList.add('red')
    
    if (task != '' && li != ''){
        li.textContent = task

        const btnRemove = document.createElement('button')
        btnRemove.textContent = 'Remover'
        btnRemove.style.marginLeft = '20px'
        btnRemove.type = 'button'
        btnRemove.addEventListener('click',function(){
            li.remove()
        })

        const btnConcluir = document.createElement('button')
        btnConcluir.textContent = 'Concluir'
        btnConcluir.style.marginLeft = '20px'
        btnConcluir.type = 'button'

        btnConcluir.addEventListener('click',function(){
            const concluidos = document.getElementById('concluidos')

            li.removeChild(btnConcluir)
            concluidos.appendChild(li)

            li.classList.remove('red')
            li.classList.add('green')
        })

        li.appendChild(btnRemove)
        li.appendChild(btnConcluir)

        const pendentes = document.getElementById('pendentes')
        pendentes.appendChild(li)
    } else{
        alert('Preencha os campos')
    }   
}

function mudarPlanoDeFundo() {
    const elemento = document.getElementById('body');
    elemento.classList.toggle('preto');
  }

