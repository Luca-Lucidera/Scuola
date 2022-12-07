<?php
session_start();
if (!isset($_SESSION['user'])) {
    header('Location: index.php');
}
if($_SERVER['REQUEST_METHOD'] == 'POST'){
    $nome = $_POST['nome'];
    $cognome = $_POST['cognome'];
    $cf = $_POST['cf'];
    $tp = $_POST['tp'];
    $file = fopen('./patenti.csv','w+');
    fwrite($file,"$nome;$cognome;$cf;$tp\n");
    fclose($file);
    echo "Registrazione effettuata con successo!";
}
?>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <form action="./inserisci.php" method="post">
    <p>Nome: <input type="text" name="nome" id="nome"></p>
    <p>Cognome: <input type="text" name="cognome" id="cognome"></p>
    <p>CF: <input type="text" name="cf" id="cf"></p>
    <p>tipo patente: <input type="text" name="tp" id="tp"></p>
    <input type="submit" value="registra!">
    </form>
</body>

</html>