<?php
if($_SERVER["REQUEST_METHOD"] == "GET"){
    if(isset($_GET["token"]) && isset($_GET["key"])){
        require_once "./confing.php";
        $token = $_GET["token"];
        $key = $_GET["key"];
        $query = "DELETE FROM stringhe WHERE chiave = ? AND userId = (select id from utenti where token = ?)";
        if($stmt = mysqli_prepare($conn, $query)){
            mysqli_stmt_bind_param($stmt, "ss", $key, $token);
            if(mysqli_stmt_execute($stmt)){
                $response = array("status" => "ok", "value" => array());
            }else{
                $response = array("status" => "error", "message" => "errore interno al server");
            }
        }else{
            $response = array("status" => "error", "message" => "errore interno al server");
        }
    }else{
        $response = array("status" => "error", "message" => "token o key mancanti");
    }
    sendJson($response);
}

function sendJson($response)
{
    header('Content-Type: application/json; charset=utf-8');
    echo (json_encode($response));
}