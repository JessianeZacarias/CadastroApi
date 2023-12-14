function createPessoa(){
    const primeiroNome = document.getElementById('firstname').value;
    const segundoNome = document.getElementById('middleName').value;
    const ultimoNome = document.getElementById('lastname').value;
    const cpf = document.getElementById('cpf').value;

    const data ={
        primeiroNome:primeiroNome,
        nomeMeio:segundoNome,
        ultimoNome:ultimoNome,
        cpf:cpf
    }

    console.log(data)

fetch('https://localhost:7097/api/Pessoas/Create', {
    method: 'POST',
    headers: {
        'Content-Type': 'application/json' 
    }, 
    body: JSON.stringify(data)
}).then(response => {
    if(!response.ok){
        alert("Erro ao criar pessoa");
    }
    alert("Pessoa criada com sucesso!");
    window.location.href = '../index.html';
})

}