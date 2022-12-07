<?php
$servername = "localhost";
$username = "root";
$password = "";
$database = "dbbonde";

// Create connection
$conn = new mysqli($servername, $username, $password, $database);

// Check connection
if ($conn->connect_error) {
  die("Errore di connessione: " . $conn->connect_error);
}
?>