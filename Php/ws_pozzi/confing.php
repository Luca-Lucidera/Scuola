<?php
DEFINE("SERVER","localhost");
define("USERNAME","root");
define("PASSWORD","");
define("DB","db_ws_pozzi");

$conn = mysqli_connect(SERVER, USERNAME, PASSWORD, DB);
if(!$conn)
    die("errore di connessione");
