<?php
session_start();
if(!isset($_SESSION['user'])){
    header('Location: index.php');
}
if($_SERVER['REQUEST_METHOD'] == 'POST'){
    $file = fopen('./patenti.csv','r');
    $persona = "";
    while(!feof($file)){
        $riga = fgets($file);
        $singoli = explode(';',$riga);
        if($singoli[0] == $_POST['nome'] && $singoli[1] == $_POST['cognome']){
            foreach($singoli as $value){
                $persona.= $value." ";
            } 
        }
    }
    fclose($file);
    if($persona != ""){
        echo $persona."<br>";
        $cookie_name = "user";
        $cookie_value = "$persona";
        setcookie($cookie_name, $cookie_value, time() + 180, "/");
        echo "<a href='pdf.php'>Crea il pdf</a>";
    }
    else{
        echo "Persona non trovata!";
    }
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
    <form action="./cerca.php" method="post">
        <p>Nome: <input type="text" name="nome" id="nome"></p>
        <p>Cognome: <input type="text" name="cognome" id="cognome"></p>
        <input type="submit" value="Cerca!">
    </form>
</body>
</html>