<?php
if ($_SERVER["REQUEST_METHOD"] == "GET") {
    $response;
    if (isset($_GET["username"]) && isset($_GET["password"])) {
        require_once "./confing.php";
        $username = $_GET["username"];
        $password = $_GET["password"];
        $query = "SELECT COUNT(*) as usersRow FROM utenti WHERE username = ? AND password = ?";
        if ($stmt = mysqli_prepare($conn, $query)) {
            mysqli_stmt_bind_param($stmt, "ss", $username, $password);
            if ($result = mysqli_stmt_execute($stmt)) {
                $result = mysqli_stmt_get_result($stmt);
                $row = mysqli_fetch_array($result);
                if ($row["usersRow"] == 1) {
                    $characters = '0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ';
                    $charactersLength = strlen($characters);
                    $randomToken = '';
                    for ($i = 0; $i < 50; $i++) {
                        $randomToken .= $characters[rand(0, $charactersLength - 1)];
                    }
                    $query = "UPDATE utenti SET token = ? WHERE username = ? and password = ?";
                    if ($stmt = mysqli_prepare($conn, $query)) {
                        mysqli_stmt_bind_param($stmt, "sss", $randomToken, $username, $password);
                        if (mysqli_stmt_execute($stmt)) {
                            $response = Array("status" => "ok", "value" => Array("token" => $randomToken));
                        } else {
                            $response = Array("status" => "error", "message" => "errore interno");
                        }
                    }
                    else {
                        $response = Array("status" => "error", "message" => "errore interno");
                    }
                }
                else {
                    $response = Array("status" => "error", "message" => "utente non registrato");
                }
            }
            else {
                $response = Array("status" => "error", "message" => "errore interno");
            }
        }
        else {
            $response = Array("status" => "error", "message" => "errore interno");
        }
    }else {
        $response = Array("status" => "error", "message" => "username o password mancanti");
    }
    sendJson($response);
}

function sendJson($response)
{
    header('Content-Type: application/json; charset=utf-8');
    echo (json_encode($response));
}
