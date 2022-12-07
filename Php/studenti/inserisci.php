<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    require_once "./config.php";
    $nome = $_POST["nome"];
    $cognome = $_POST["cognome"];
    $IdIstituto = $_POST["IdIstituto"];
    $anno = $_POST["anno"];
    $voto = $_POST["voto"];
    if (isset($nome) && isset($cognome) && isset($IdIstituto) && isset($anno) && isset($voto)) {
        $query = "INSERT INTO studenti (nome, cognome, IdIstituto, annoDiploma, voto) studenti values (?,?,?,?,?,?)";
        if ($stmt = mysqli_prepare($conn, $query)) {
            mysqli_stmt_bind_param($stmt, "ssssss", $nome, $cognome, $IdIstituto, $anno, $voto);
            if (mysqli_stmt_execute($stmt)) {
                mysqli_close($conn);
                header("Location: index.php");
            } else {
                echo "Errore nell'inserimento";
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
    <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]) ?>" method="POST">
        <p>Nome: <input type="text" name="nome"></p>
        <p>Cognome: <input type="text" name="cognome">
        <p>
            <?php
            require_once "./config.php";
            $query = "SELECT id, nomeScuola FROM istituto";
            if ($result = mysqli_query($conn, $query)) {
                if (mysqli_num_rows($result) > 0) {
                    echo "Istituto: <select name='IdIstituto'>";
                    while ($rows = mysqli_fetch_array($result)) {
                        echo "<option value='" . $rows["id"] . "'>" . $rows["nomeScuola"] . "</option>";
                    }
                    echo "</select>";
                }
            }
            mysqli_close($conn);
            ?>
        <p>Anno diploma: <input type="text" name="anno"></p>
        <?php
        echo "voto: <select name='voto'>";
        for ($i = 1; $i <= 10; $i++) {
            echo "<option value='$i'>$i</option>";
        }
        echo "</select>";
        ?>
        <p><input type="submit" value="inserisci studente!"></p>
    </form>
</body>

</html>