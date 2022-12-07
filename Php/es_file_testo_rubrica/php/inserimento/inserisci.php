<?php
if($_SERVER["REQUEST_METHOD"] == "POST"){
    $nome = $_POST["nome"];
    $cognome = $_POST["cognome"];
    $telefono = $_POST["telefono"];
    $email = $_POST["email"];
    $file = fopen("dati.csv","a+");
    $csv = "$nome;$cognome;$telefono;$email\n";
    if(fwrite($file,$csv)){
        echo "Stringa salvata su file correttamente!";
    }
    else{
        echo "Errore nella scrittura!";
    }
    fclose($file);
}