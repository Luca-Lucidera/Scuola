<?php
session_start();
if(isset($_SESSION['user_id'])){
    header('Location: paginasegreta.php');
}
if(!empty($_POST['email']) && !empty($_POST['password'])){
    if(($_POST['email'] == 'email') && ($_POST['password'] == "password")){
        $_SESSION['user_id'] = $_POST['email'];
        header("Location: paginasegreta.php");
    }
    else{
        header("Location: index.php");
    }   
}