<?php
if($_SERVER["REQUEST_METHOD"] == "POST"){
    $nome = $_POST["nome"];
    $cognome = $_POST["cognome"];
    $ruolo = $_POST["ruolo"];
    $squadra = $_POST["squadra"];
    $file = fopen("dati.csv","a+");
    $csv = "$nome;$cognome;$ruolo;$squadra\n";
    if(fwrite($file,$csv)){
        echo "Ho scritto!";
    }
    else
    {
        echo "Errore nella scrittura";
    }
}
