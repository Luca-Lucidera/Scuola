<?php
$file = fopen("../dati.csv","r");
$max = 0;
while(!feof($file)){
    $tmp = fgets($file);
    $max++;
}
$daEspellere = rand(0,$max);
$daRiscrivere = [];
echo "da espellere: $daEspellere <br>";
$c = 0;
while(!feof($file)){
    $riga = fgets($file);
    if($c != $daEspellere){
        array_push($daRiscrivere,$riga);
    }
    else{
        echo "Espulso: $riga";
    }
    $c++;
}
fclose($file);
$file = fopen("./../dati.csv", "w");
for ($i=0; $i < count($daRiscrivere); $i++) { 
    fwrite($file,$daRiscrivere[$i]);
}
fclose($file);