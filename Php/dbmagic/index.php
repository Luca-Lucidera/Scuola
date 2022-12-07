<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <a href="./insert.php">Inserisci carta</a>
    <a href="./cerca.php">Cerca carta</a>
    <?php
        require_once "./config.php";
        $query = "SELECT * FROM Carte";
        if($result = $conn->query($query)){
            if($result->num_rows > 0)
            echo "<table>
                <thead>
                <tr>
                    <th>#</th>
                    <th>idSet</th>
                    <th>Nome</th>
                    <th>Anno</th>
                    <th>Mana</th>
                    <th>Immagine</th>
                    <th>Azione</th>
                </tr>
                </thead>";
                while($row = $result->fetch_array()){
                    echo "<tr>";
                    echo "<td>".$row["id"]."</td>";
                    echo "<td>".$row["idSet"]."</td>";
                    echo "<td>".$row["nome"]."</td>";
                    echo "<td>".$row["anno"]."</td>";
                    echo "<td>".$row["mana"]."</td>";
                    echo "<td><img width='100' height='100' src='".$row["immagine"]."'></td>";
                    echo '<td><a href="./delete.php?id='  . $row["id"]. '&idSet=' . $row["idSet"] .'">Cancella carta</a></td>';
                    echo"</tr>";
                }
                echo "</table>";
        }
    ?>
</body>
<a href="./delete.php?id=row[id]&idSet=row[idSet]"></a>
</html>