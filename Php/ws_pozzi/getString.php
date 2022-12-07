<?php
if($_SERVER["REQUEST_METHOD"] == "GET"){
    if(isset($_GET["token"]) && isset($_GET["key"])){
        require_once "./confing.php";
        $token = $_GET["token"];
        $key = $_GET["key"];
        $query = "SELECT stringa FROM stringhe INNER JOIN utenti ON stringhe.userId = utenti.id WHERE utenti.token = '$token' AND stringhe.chiave = '$key'";
        if($result = mysqli_query($conn, $query)){
            $stringa = mysqli_fetch_array($result);
            $response = Array("status" => "ok", "value" => $stringa["stringa"]);
        }else{
            $response = Array("status" => "error", "message" => "errore interno");
        }
    }else{
        $response = Array("status" => "error", "message" => "dio cane");
    }
    sendJson($response);
}

function sendJson($response)
{
    header('Content-Type: application/json; charset=utf-8');
    print_r(json_encode($response));
}