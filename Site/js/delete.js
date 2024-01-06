function excluir(){
    fetch('https://localhost:7097/api/Pessoas/Delete',{
        method: 'DELETE' 
    })
    .then(response => response.json())
    .then(data => console.log(data))
    .catch(error => console.error(error))
}



        


