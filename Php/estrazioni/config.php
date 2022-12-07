<?php
define("HOST", "localhost");
define('USER', 'root');
define('PASSWORD', '');
define('DB', 'scommesse');

$sql = mysqli_connect(HOST, USER, PASSWORD, DB);

if (!$sql)
    die("errore di connessione");

$query = "SELECT id FROM numeri";
if($result = mysqli_query($sql, $query)){
    if(mysqli_num_rows($result) <= 90){
        for ($i=1; $i <= 90; $i++) { 
            $query = "INSERT INTO numeri (numero) VALUES($i)";
            $result = mysqli_query($sql, $query);
        }
    }
}