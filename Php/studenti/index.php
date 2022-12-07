<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <p><a href="./inserisci.php">Inserisci studente</a></p>
    <p><a href="./ricerca.php">Cerca uno studente</a></p>
    <?php
        require_once "./config.php";
        $query = "SELECT * FROM studenti";
        if($result = mysqli_query($conn, $query)){
            if(mysqli_num_rows($result) > 0){
                echo 
                "<table>
                    <thead>
                        <tr>
                            <th>id</th>
                            <th>nome</th>
                            <th>cognome</th>
                            <th>idIstituto</th>
                            <th>annoDiploma</th>
                            <th>voto</th>
                        </tr>
                    </thead>
                    <tbody>";
                    
                while($rows = mysqli_fetch_array($result)){
                    echo 
                        "<tr>".
                            "<td>".$rows["id"]."</td>".
                            "<td>".$rows["nome"]."</td>".
                            "<td>".$rows["cognome"]."</td>".
                            "<td>".$rows["IdIstituto"]."</td>".
                            "<td>".$rows["annoDiploma"]."</td>".
                            "<td>".$rows["voto"]."</td>".
                            '<td><a href="./inserisci.php?id='.$rows["id"].'">Scarica pdf</a></td>'.
                        "</tr>";
                }
                echo
                    "</tbody>
                </table>";
                mysqli_free_result($result);
            }
            else{
                echo "db vuoto";
            }
        }
        else{
            echo "Errore di connessione";
        }
        mysqli_close($conn);
    ?>
</body>
</html>