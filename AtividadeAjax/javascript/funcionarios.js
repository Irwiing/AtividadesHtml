window.addEventListener('load', () => {
    let obj = Object.keys(localStorage)
    
    const data = []
    for (const key in obj) {
        data.push(JSON.parse(localStorage.getItem(obj[key])))
    }
    const html = document.getElementById("funcionarios")
    let htmlContent = ""
    
    data.forEach(funcionario => {
        htmlContent = htmlContent + `
        <div class="funcionario">
                <div>
                    <label for="id">ID</label>
                    <span>${funcionario.id}</span>
                    <br />
                    <label for="nome">Nome</label>
                    <span>${funcionario.nome}</span>
                    <br />
                    <label for="telefone">Telefone</label>
                    <span>${funcionario.telefone}</span>
                    <br />
                    <label for="salario">Salario</label>
                    <span>R$${funcionario.salario}</span>
                    <br />
                    <label for="estadocivil">Estado Civil</label>
                    <span>${funcionario.estadocivil}</span>    
                    <br />
                    <label for="idade">Idade</label>
                    <span>${funcionario.idade}</span>
                    <br />
                </div>
                
                <div>
                    <label for="cep">CEP</label>
                    <span>${funcionario.cep}</span>
                    <br />
                    <label for="logradouro">Logradouro</label>
                    <span>${funcionario.logradouro}</span>
                    <br />
                    <label for="complemento">Complemento</label>
                    <span>${funcionario.complemento}</span>
                    <br />
                    <label for="bairro">Bairro</label>
                    <span>${funcionario.bairro}</span>
                    <br />
                    <label for="localidade">Localidade</label>
                    <span>${funcionario.localidade}</span>
                    <br />
                    <label for="uf">UF</label>
                    <span>${funcionario.uf}</span>
                    <br />
                </div>
            </div>            
        `
    });
    html.innerHTML = htmlContent
    console.log(data)
})