<?php
if($_SERVER["REQUEST_METHOD"] == "POST"){
    $file = fopen("./../dati.csv","r");
    $c = 0;
    $email = $_POST["email"];
    $check = true;
    while(!feof($file) ){
        $riga = fgets($file);
        if($riga != ""){
            if($c<4){
                $c = $c+1;
                $singoli = explode(";",$riga);
                if($singoli[2] == $email) {
                    $check = false; //se trova una mail uguale interrompe il ciclo
                    break;
                }
            }
            else{
                $check = false;
            }
            echo "check: $check <br> c=$c";
            
        }
    }
    fclose($file);
    if($check){
        $file = fopen("./../dati.csv", "a+");
        $nome = $_POST["nome"];
        $cognome = $_POST["cognome"];
        $sesso = $_POST["sesso"];
        fwrite($file,"$nome;$cognome;$email;$sesso\n");
        fclose($file);
        echo "Registrazione effettuata con successo!";
    }
    else{
        echo"Locale pieno o email già presente!";
    }
}