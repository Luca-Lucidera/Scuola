<?php
if($_SERVER["REQUEST_METHOD"] =="POST"){
    $nome = $_POST["nome"];
    $cognome = $_POST["cognome"];
    $file = fopen("./../dati.csv","r");
    while(!feof($file)){
        $riga = fgets($file);
        $singoli = explode(";",$riga);
        if($singoli[0] == $nome && $singoli[1] == $cognome){
            echo "Persona trovata: $riga";
        }
    }
    fclose($file);
}