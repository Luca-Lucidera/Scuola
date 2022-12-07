<?php
if($_SERVER["REQUEST_METHOD"] == "GET"){
    $response = array();
    if(isset($_GET["token"]) && isset($_GET["key"]) && isset($_GET["string"])){
        require_once "./confing.php";
        $token = $_GET["token"];
        $chiave = $_GET["key"];
        $string = $_GET["string"];
        $query = "SELECT chiave FROM stringhe";
        if($result = mysqli_query($conn, $query)){
            $ok = false;
            while ($row = mysqli_fetch_array($result)) { //controllo per vedere se la chiave esiste già
                if($row["chiave"] == "counter"){
                   $ok = true;
                   $query = "UPDATE stringhe SET stringa = '$string' WHERE chiave = '".$row["chiave"]."'";
                   if(mysqli_query($conn, $query)){
                       $response = array("status" => "ok", "value" => array());
                   }else{
                       $response = array("status" => "errore", "message" => "errore interno");
                   }
                }else{
                    $response = array("status" => "errore", "message" => "errore interno");
                }
            }
            if(!$ok){ //se la chiave non esiste inserisce la nuova chiave e la stringa
                $query = "INSERT INTO stringhe (stringa, chiave, userId) VALUES ('$string', '$chiave', (select id from utenti where token = '$token'))";
                if($result = mysqli_query($conn, $query)){
                    $response = Array("status" => "ok", "value" => Array());
                }else{
                    $response = array("status" => "errore", "message" => "errore interno");
                }
            }
        }else{
            $response = array("status" => "errore", "message" => "errore interno");
        }
        
    }else{
        $token = $_GET["token"];
        $key = $_GET['key'];
        $string = $_GET["string"];
        $response = Array("status" => "error", "message" => "parametri mancanti, $token, $key, $string");
    }
    sendJson($response);
}

function sendJson($response)
{
    header('Content-Type: application/json; charset=utf-8');
    print_r(json_encode($response));
}