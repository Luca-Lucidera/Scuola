<html lang="it">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <a href="./crea.php">Inserisci impiegato</a>
    <?php
        require_once 'config.php';
        $query = "select * from impiegati";
        if($result = mysqli_query($conn,$query)){
            if(mysqli_num_rows($result)>0){
                echo "<table>
                <thead>
                <tr>
                    <th>#</th>
                    <th>Nome</th>
                    <th>Indirizzo</th>
                    <th>Salario</th>
                    <th>Azione</th>
                </tr>
                </thead>
                <tbody>";
                while($row = mysqli_fetch_array($result)){
                    echo "<tr>";
                    echo "<td>".$row['id']."</td>";
                    echo "<td>".$row['name']."</td>";
                    echo "<td>".$row['address']."</td>";
                    echo "<td>".$row['salary']."</td>";
                    echo "<td><a href='read.php?id=".$row["id"]."'>V</a>"."<a href='delete.php?id=".$row["id"]."'> C</a>"."</td>";
                    echo "</tr>";
                }
                echo "</tbody>
                </table>";
                mysqli_free_result($result);
            }
            else{
                echo "<p>Nessun record nella tabella trovato</p>";
            }
        }
        else{
            echo "Errore nella query!";
        }
        $conn->close();
    ?>
</body>
</html>