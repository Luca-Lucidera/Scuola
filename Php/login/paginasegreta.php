<?php
session_start();
if(!isset($_SESSION['user_id'])){
    header('Location: index.php');
}else{
    echo "Benvenuto utente $_SESSION[user_id]";
}