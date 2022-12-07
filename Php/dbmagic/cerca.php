<?php
    if($_SERVER["REQUEST_METHOD"] == "POST"){
        $id = $_POST["id"];
        $idSet = $_POST["idSet"];
        require_once "./config.php";
        if(isset($id) && isset($idSet)){
            $sql = "SELECT * FROM carte WHERE id = ? AND idSet = ?";
            $stmt = $conn->prepare($sql);
            $stmt->bind_param("ii", $id, $idSet);
            if($stmt->execute()){
                $result = $stmt->get_result();
                if($result->num_rows > 0){
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
        <p>id: <input type="text" name="id"></p>
        <p>idSet: <input type="text" name="idSet"></p>
        <input type="submit" value="cerca!">
    </form>
</body>
</html>