<?php
session_start(); //inizio la sessione
if (isset($_SESSION['user'])) { //controllo se ho impostato il nome utente nella sessione
    header("Location: bivio.php"); //se si rimando l'utente alla pagina di login
}

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    if (!empty($_POST['nome']) && !empty($_POST['password'])) {
        $file = fopen("./ing.csv", 'r');
        $trovato = false;
        while (!feof($file)) {
            $riga = fgets($file);
            if ($riga != "") {
                $singoli = explode(";", $riga);
                $singoli[1] = str_replace("\r\n", "", $singoli[1]);
                if ($singoli[0] == $_POST['nome'] && $singoli[1] == $_POST['password']) {
                    $_SESSION['user'] = $_POST['nome']; //imposto il campo user con il valore del nome
                    $trovato = true;
                }
            }
        }
        fclose($file);
        if ($trovato) {
            header("Location: bivio.php");
        } else {
            header("Location: index.php");
        }
    }
}
