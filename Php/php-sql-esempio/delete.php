<?php
    if(isset($_POST["id"]) && !empty(trim($_POST["id"]))){
        require_once './config.php';
        $sql = "DELETE FROM impiegati WHERE id = ?";
        if($stmt = mysqli_prepare($conn, $sql)){
            mysqli_stmt_bind_param($stmt, "i", $param_id);
            $param_id = trim($_POST["id"]);
            if(mysqli_stmt_execute($stmt)){
                header("Location: index.php");
                exit();
            }
            else{
                header("Location: index.php");
                exit();
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
    <form method="post">
        <input type="hidden" name="id" value=<?php echo trim($_GET["id"]);?> >
        <p>Sicuro che lo vuoi eliminare?</p>
        <p><input type="submit" value="Si">
        <a href="./index.php">No</a></p>
    </form>
</body>
</html>