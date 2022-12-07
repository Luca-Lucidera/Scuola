<?php
if($_SERVER['REQUEST_METHOD'] == 'POST'){
    $email = $_POST['email'];
    $file = fopen("./../dati.csv","r");
    $check = false;
    while(!feof($file)){
        $riga = fgets($file);
        $emailTrovata = explode(";",$riga);
        if($emailTrovata[2] == $email){
            $check = true;
            echo "
            <html>
            <head></head>
            <body>
            <form action='./modificapt2.php' method='post'>
            <p>Nome: <input type='text' name='nome'></p>
            <p>Cognome: <input type='text' name='cognome'></p>
            <input type='text' name='email' value='$email'></p>
            <input type='submit' value='cambia!'>
            </form>
            </body>
            </html>
            ";
        }
    }
    if($check == false) {
        echo "mail non trovata!";
    }
    fclose($file);
}