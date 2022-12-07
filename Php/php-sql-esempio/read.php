<?php
    if(isset($_GET["id"]) && !empty(trim($_GET["id"]))){
        require_once './config.php';
        $sql = "SELECT * FROM impiegati WHERE id = ?";
        if($stmt = mysqli_prepare($conn, $sql)){
            mysqli_stmt_bind_param($stmt, "i", $param_id);
            $param_id = trim($_GET["id"]);
            if(mysqli_stmt_execute($stmt)){
                $result = mysqli_stmt_get_result($stmt);
                if(mysqli_num_rows($result) == 1){
                    $row = mysqli_fetch_array($result, MYSQLI_ASSOC);
                    $name = $row["name"];
                    $address =  $row["address"];
                    $salary = $row["salary"];
                }else{
                    header("Location: index.php");
                    exit();
                }
            }
        }
    }
?>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <p>Nome: <?php echo $name; ?></p>
    <p>Indirizzo: <?php echo $address; ?></p>
    <p>Salario: <?php echo $salary; ?></p>
    <a href="index.php">home</a>
</body>
</html>