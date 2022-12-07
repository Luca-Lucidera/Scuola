<?php
    define("SERVER","localhost");
    define("USERNAME","root");
    define("PASSWORD","");
    define("DATABASE", "dbstudenti");
    $conn =  mysqli_connect(SERVER,USERNAME,PASSWORD,DATABASE);
    if(!$conn){
        die("errore di connessione: ".mysqli_connect_error());
    }
?>