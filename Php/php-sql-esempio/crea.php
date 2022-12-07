<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <form method="post">
        <p>Nome: <input type="text" name="nome" id="nome"></p>
        <p>Indirizzo: <input type="text" name="indirizzo" id="indirizzo"></p>
        <p>Salario <input type="text" name="salario" id="salario"></p>
        <input type="submit" value="ADD!">
    </form>
    <a href="index.php">Torna alla home</a>
</body>

</html>
<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $nome = trim($_POST["nome"]);
    $indirizzo = trim($_POST["indirizzo"]);
    $salario = $_POST["salario"];
    require_once "config.php";
    if ($nome != "" && $indirizzo != "" && empty($salario) == false) {
        $query = "INSERT INTO impiegati(name,address,salary) VALUES (?,?,?)";
        if ($stmt = mysqli_prepare($conn, $query)) {
            mysqli_stmt_bind_param($stmt, "sss", $nome, $indirizzo, $salario);
            if (mysqli_stmt_execute($stmt)) {
                header("location: index.php");
                $conn->close();
                exit();
            } else {
                echo "error";
            }
        }
    } else {
        echo "Inserire i campi correttamente";
    }
}
?>