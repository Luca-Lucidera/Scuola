<?php
if($_SERVER["REQUEST_METHOD"] =="POST"){
    $nome = $_POST["nome"];
    $cognome = $_POST["cognome"];
    $email = $_POST["email"];
    $file = fopen("./../dati.csv","r");
    $riscrivi = [];
    while(!feof($file)){
        $riga = fgets($file);
        $singoli = explode(";",$riga);
        if($email == $singoli[2]){
            echo "email trovata";
            $singoli[0] == $nome;
            $singoli[1] == $cognome;
        }
        $tmp = "$signoli[0];$signoli[1];$signoli[2];$signoli[3]\n";
        array_push($riscrivi,$tmp);
    }
    fclose($file);
    $file = fopen("./../dati.csv","w");
    for ($i=0; $i < count($riscrivi); $i++) { 
       fwrite($file,$riscrivi[$i]);
    }
    fclose($file);
    echo "dati aggiornati!";
}