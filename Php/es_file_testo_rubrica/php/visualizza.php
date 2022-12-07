<?php
$file = fopen("./inserimento/dati.csv","r");
if($file){
    while(!feof($file)){
        $riga = fgets($file);
        $diviso = explode(";",$riga);
        foreach ($diviso as $index) {
            echo $index."<br>";
        }   
    }
    fclose($file);
}
else{
    echo "File dati inesistente!";
}