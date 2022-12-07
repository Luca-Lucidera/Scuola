<?php
    if($_SERVER["REQUEST_METHOD"] == "POST"){//metodo per ricevere le info dal form
        $name = $_POST['nome'];
        $surname = $_POST['cognome'];
        $genere = $_POST['genere'];
        if(empty($name)){
            echo "Nome assente"."<br>";
        }
        else{
            echo $name."<br>";
        }
        if(empty($surname)){
            echo "Cognome assente"."<br>";
        }
        else{
            echo $surname."<br>";
        }
        if(empty($genere)){
            echo "la persona si identifica in una pizzetta della LIDL"."<br>";
        }
        else{
            echo $genere."<br>";
        }
    }
?>