<?php
if($_SERVER["REQUEST_METHOD"] == "POST"){
    $nome = $_POST["nome"];
    $cognome = $_POST["cognome"];
    $eta = $_POST["eta"];
    $file = fopen("../dati.csv","a+");
   
        if(fwrite($file,"$nome;$cognome;$eta\n")){
        echo "File scritto correttamente";
    }
    else
    {
        echo "file non esistente";
    }
}