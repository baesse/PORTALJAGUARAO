
function validacao() {


    if (document.form.protocolo.value=="") {

        alert("Por favor preencha o campo Protocolo com numero de protocolo e ano");
        document.form.protocolo.focus();
         return false;

    }
}

function validacaoLogin(){


    if (document.formlogin.usuario.value == "") {

        alert("Usuario e senha não podem ser em branco");

    }

}