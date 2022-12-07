<?php
if ($_SERVER["REQUEST_METHOD"] == "GET") {
    $response;
    if (isset($_GET["token"])) {
        require_once "./confing.php";
        $token = $_GET["token"];
        $query = "SELECT chiave FROM stringhe INNER JOIN utenti ON stringhe.userId = utenti.id WHERE utenti.token = '$token'";
        if($result = mysqli_query($conn, $query)){
            $chiavi = [];
            while($rowTemp = mysqli_fetch_array($result)){
                array_push($chiavi, $rowTemp["chiave"]);
            }
            $response = Array("status" => "ok", "value" => $chiavi);
        }else{
            $response = Array("status" => "error", "message" => "errore interno");
        }
    }else{
        $response = Array("status" => "error", "message" => "token assente");
    }
    sendJson($response);
}

function sendJson($response)
{
    header('Content-Type: application/json; charset=utf-8');
    echo (json_encode($response));
}
