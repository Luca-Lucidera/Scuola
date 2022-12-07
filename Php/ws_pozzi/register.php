<?php
if ($_SERVER["REQUEST_METHOD"] == "GET") {
    $response;
    if (isset($_GET["username"]) &&  isset($_GET["password"])) {
        $username = $_GET["username"];
        $password = $_GET["password"];
        require_once "./confing.php";
        $query = "SELECT COUNT(*) as usersRow FROM utenti WHERE username = ? AND password = ?";
        if ($stmt = mysqli_prepare($conn, $query)) {
            mysqli_stmt_bind_param($stmt, "ss", $username, $password);
            if ($result = mysqli_stmt_execute($stmt)) {
                $result = mysqli_stmt_get_result($stmt);
                $row = mysqli_fetch_array($result);
                if ($row["usersRow"] == 0) {
                    $query = "INSERT INTO utenti (username, password) VALUES (?,?)";
                    if ($stmt = mysqli_prepare($conn, $query)) {
                        mysqli_stmt_bind_param($stmt, "ss", $username, $password);
                        if (mysqli_stmt_execute($stmt)) {
                            $response = array("status" => "ok", "value" => array());
                        } else {
                            $response = array("status" => "error", "message" => "errore interno");
                        }
                    } else {
                        $response = array("status" => "error", "message" => "errore interno");
                    }
                } else {
                    $response = array("status" => "error", "message" => "errore interno");
                }
            } else {
                $response = array("status" => "error", "message" => "errore interno");
            }
        } else {
            $response = array("status" => "error", "message" => "errore interno");
        }
    } else {
        if (!isset($_GET["username"]) && !isset($_GET["password"])) {
            $response = array("status" => "error", "message" => "Username e password assenti");
        } else if (!isset($_GET["username"])) {
            $response = array("status" => "error", "message" => "Username assente");
        } else {
            $response = array("status" => "error", "message" => "Password assente");
        }
    }
    sendJson($response);
}

function sendJson($response)
{
    header('Content-Type: application/json; charset=utf-8');
    echo (json_encode($response));
}
