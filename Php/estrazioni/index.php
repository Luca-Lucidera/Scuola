<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form action="" method="post">
        <p>email: <input type="email" name="email" id="email"></p>
        <p>password <input type="password" name="password" id="password"></p>
        <input type="submit" value="login">
    </form>
    <p>Non hai un account? <a href="./signup.php">Registrati</a></p>
</body>
</html>

<?php
if($_SERVER["REQUEST_METHOD"] == "POST"){
    $email = $_POST["email"];
    $password = $_POST["password"];
    require_once "config.php";
    
    $query = "SELECT *, count(*) as utente FROM user WHERE email = ? AND password = ?";
    if($stmt = mysqli_prepare($sql, $query)){
        mysqli_stmt_bind_param($stmt, "ss", $email, $password);
        if(mysqli_stmt_execute($stmt)){
            $result = mysqli_stmt_get_result($stmt);
            $row = mysqli_fetch_array($result);
            if($row["utente"] == 1){
                header("Location: home.php");
            }else{
                echo "Utente non trovato";
            }
        }
    }
}