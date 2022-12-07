<?php
    if($_SERVER["REQUEST_METHOD"] == "POST"){
        require_once "./config.php";
        $id = $_POST["id"];
        $anno = $_POST["anno"];
        $nome = $_POST["nome"];
        $setCarta =  $_POST["idSet"];
        $mana = $_POST["mana"];
        $url = $_POST["url"];
        $stmt = $conn->prepare('INSERT INTO carte values (?,?,?,?,?,?)');
        $stmt->bind_param('iissis',$id, $setCarta, $nome, $anno, $mana, $url); // 's' specifies the variable type => 'string'
        if($stmt->execute()){
            $result = $stmt->get_result();
            $conn->close();
            header("Location: index.php");
        }else{
            $conn->close();
            header("Location: index.php");
        }
        
        
        
    }
    else{
        require_once "./config.php";
        $sql = "SELECT id, nome FROM setCarte";
        $result = $conn->query($sql);

        if ($result->num_rows > 0) {
            echo "<form method='post'>
            <p>Id: <input type='text' name='id'></p>
            <p>Nome: <input type='text' name='nome'></p>
            <p>Mana: <input type='number' name='mana'></p>
            <p>Anno <input type='text' name='anno'></p>
            <p>Url: <input type='text' name='url'></p>
            IdSet: <select id='idSet' name='idSet'>
            ";
            // output data of each row
            while($row = $result->fetch_assoc()) {
                echo "<option value='".$row["id"]."'>".$row["nome"]."</option>";
            }
            echo "</select>
                <p><input type='submit' value='inserisci'></p>
            ";
            echo "</form>";
        } else {
            echo "0 results";
        }
        $conn->close();
    }
?>