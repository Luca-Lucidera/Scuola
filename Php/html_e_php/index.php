<!DOCTYPE html>
<html>
<body>
    <h1>Prova</h1>
    <?php
    $frase = "tra bla bla";
    echo $frase."<br>";

    $misura = strlen($frase); //serve per prendere la lunghezza della stringa
    echo "Frase composta da ".$misura." lettere <br>";
    
    $quanteParole = str_word_count($frase); //quante parole ci sono nella frase
    echo "Frase composta da ".$quanteParole." parole<br>";
    
    $alContrario = strrev($frase);
    echo "Frase al contrario ".$alContrario."<br>";
    
    $daCercare = "bla";
    $posizione = strpos($frase,$daCercare);
    echo "Parola da cercare: ".$daCercare." trovata in posizione: ".$posizione."<br>";

    $daSostituire = "bla";
    $sostituto = "xxx";
    $frase = str_replace($daSostituire,$sostituto,$frase);
    echo "frase aggiornata: ".$frase."<br>";

    $x=1;
    while($x<5){
        echo "numero: ".$x."<br>";
        $x++;
    }
    for($i = 1; $i < 5; $i++){
        echo "numero col for ".$i."<br>";
    }
    ?>
</body>
</html>