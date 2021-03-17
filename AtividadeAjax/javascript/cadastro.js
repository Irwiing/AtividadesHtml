
const nome = document.getElementById("nome")
const telefone = document.getElementById("telefone")
const salario = document.getElementById("salario")
const estadocivil = document.getElementById("estadocivil")
const idade = document.getElementById("idade")
const cep = document.getElementById("cep")
const logradouro = document.getElementById("logradouro")
const complemento = document.getElementById("complemento")
const bairro = document.getElementById("bairro")
const localidade = document.getElementById("localidade")
const uf = document.getElementById("uf")
const register = document.getElementById("register")

cep.addEventListener("keyup", (event) => {
    const cep = event.target.value
    
    if (cep.length != 8){
        return
    } else {
        findCEP(cep)
        return
    }
})

estadocivil.addEventListener("change", (event) => {
    const estadocivil = event.target.value
    if(estadocivil == "casado"){
        window.alert("É necessário enviar a documentação de seu/sua esposo(a)")
    }

})

idade.addEventListener("blur", (event) => {
    const idade = event.target
    if(idade.value < 18){
        document.getElementById('aviso-idade').style.display = "block"
        idade.classList.add("erro")
        register.disabled = true
    }else {
        document.getElementById('aviso-idade').style.display = "none"
        idade.classList.remove("erro")
        register.disabled = false
    }
})

salario.addEventListener("blur", (event) => {
    const salario = event.target.value

    if(salario > 10000){
        document.getElementById('aviso-salario').style.display = "block"
    }else {
        document.getElementById('aviso-salario').style.display = "none"
    }
})

register.addEventListener("click", (event) => {
    const id = Object.keys(localStorage).length +1;
    
    const funcionario = {
        id,
        nome: nome.value,
        telefone: telefone.value,
        salario: salario.value ,
        estadocivil: estadocivil.value,
        idade: idade.value,
        cep: cep.value ,
        logradouro: logradouro.value ,
        complemento: complemento.value,
        bairro: bairro.value ,
        localidade: localidade.value ,
        uf: uf.value 
    }
    
    window.localStorage.setItem(id, JSON.stringify(funcionario))
    window.alert("CADASTRO EFETUADO COM SUCESSO!")
})

const findCEP = async (cep) => {
    const res = await fetch(`https://viacep.com.br/ws/${cep}/json/`).then( res => {
        return res.json();
    })

    changeValues(res)
}

const changeValues = (res) => {
    logradouro.value = res.logradouro
    complemento.value = res.complemento
    bairro.value = res.bairro
    localidade.value = res.localidade
    uf.value = res.uf
}