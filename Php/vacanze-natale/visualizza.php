<?php
session_start();
if(!isset($_SESSION['user'])){
    header('Location: index.php');
}
else{
    $file = fopen('./patenti.csv','r');
    while(!feof($file)){
        $riga = fgets($file);
        $singoli = explode(';',$riga);
        foreach($singoli as $singleValue){
            echo "$singleValue ";
        }
        echo "<br>";
    }
    fclose($file);
}