<?php
if($_SERVER["REQUEST_METHOD"] == "POST"){
    $nome = $_POST['nome'];
    $cognome = $_POST['cognome'];
    $file = fopen("../dati.csv","r");
    $tutto = [];
    while(!feof($file)){
        $riga = fgets($file);
        $singolo = explode(";",$riga);
        //echo "$singolo[0] $singolo[1] $singolo[2] \n";
        if ($singolo[0] != $nome && $singolo[1] != $cognome){
            array_push($tutto,$riga);//inserisce un elemento nell'array
        }
        
    }
    fclose($file);

    $file = fopen("../dati.csv","w");
    $csv;
    for ($i=0; $i < count($tutto) - 1; $i++) { 
        $riga = $tutto[$i];
        $singoli = explode(";",$riga);
        $csv .= "$singoli[0];$singoli[1];$singoli[2]";
        
    }
    fwrite($file,$csv);
    fclose($file);
}