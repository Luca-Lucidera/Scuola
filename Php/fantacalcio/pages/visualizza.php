<?php
$filename = fopen("./dati.csv","r");//apro il file in lettura
if($filename)//se il file esiste
{
    while(!feof($filename))//continua fino alla fine del file
    {
        $riga = fgets($filename);
        $singoli = explode(";",$riga);
        foreach($singoli as $valore){
            echo "$valore<br>";
        }
    }
    fclose($filename);
}
else
    echo "Il file non esiste";