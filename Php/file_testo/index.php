<?php
    if($_SERVER["REQUEST_METHOD"] == "POST"){
        $_c = fopen("file.csv","a+");
        $a = $_POST["testo"]."\n";
        $data = date("d-m-y"); //il trattino è come se fosse un separatore
        $_da_scrivere = "$data: $a"; 
        if(fwrite($_c, $_da_scrivere)){
            $datetmp = date("H:i:s");
            echo "cosa scritta all'ora: $datetmp";
        }
        else
        {
            echo "Errore di scrittura";
        }
        fclose($_c);
        $_c = fopen("file.txt","r");
        if($_c){ //controllo se il file esiste
            while(!feof($_c)){//legge fino alla fine del file
                $line = fgets($_c);//leggo la riga
                echo "$line <br>";//la faccio vedere
            }
        }
        fclose($_c);
    }
    
?>