<?php
if($_SERVER["REQUEST_METHOD"] == "POST"){
    $nomeDonatore = $_POST["name"]; //prendo il nome di ha donato
    $importoDonato = $_POST["importo"]; //prendo l'importo
    $file = fopen("./donazioni.csv","r"); //apro il file in lettura
    $soldiTotaliDonati = 0; //dichiaro l'importo totale già guadagnato
    while(!feof($file)){ //legge fino alla fine del file
        $riga = fgets($file); //prendo la riga
        if($riga != ""){ //controllo se la riga è vuota
            $singoliElementi = explode(";",$riga); //faccio divido la riga con i ;
            $soldiTotaliDonati = $soldiTotaliDonati + $singoliElementi[1]; //aggiungo l'importo presente nella riga
        }
    }
    fclose($file); //chiudo il file
    $file = fopen("./donazioni.csv","a+"); //apro il file in append con il puntatore a fine file
    if($soldiTotaliDonati + $importoDonato < 10000){ //se l'importo totale è minore di 10K allora aggiunge l'importo
        fwrite($file,"$nomeDonatore;$importoDonato\n");
        $nome_cookie = "ultimo_donatore"; // il nome del cookie come se fosse una variabile
        $valore_cookie = $nomeDonatore;  // il valore del cookie
        setcookie($nome_cookie,$valore_cookie, time() + (86400 * 30),"/");
        echo "donazione effettuata correttamente! ";
        echo "<a href='./index.php'>Vai alla home!</a>";
    }
    fclose($file); //chiudo il file
    


}