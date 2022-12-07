<?php
if($_SERVER["REQUEST_METHOD"] =="POST"){
    $name = $_POST["name"];
    $password = $_POST["pass"];
    $file = fopen("./dati.csv","r");
    $check = false;
    while (!feof($file)) {
        $riga = fgets($file);
        if($riga != ""){
            $singoli = explode(";",$riga);
            $passMD5 = md5($password);
            if($name == $singoli[0] && $singoli[1] == $passMD5){
                $check = true;
                break;
            }
        }
    }
    fclose($file);
    if($check){
        echo "benvento";
    }
    else{
        echo "login errata!";
    }
}
?>