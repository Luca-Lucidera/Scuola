<?php
    if($_SERVER["REQUEST_METHOD"] == "GET"){
       
        $id = $_GET["id"];
        $idSet = $_GET["idSet"];
        if(isset($id) && isset($idSet)){
            require_once './config.php';
            $sql = "DELETE FROM carte WHERE id = ? AND idSet = ?";
            $stmt = $conn->prepare($sql);
            $stmt->bind_param("ii", $id, $idSet);
            if($stmt->execute()){
                $result = $stmt->get_result();
                $conn->close();
                header("Location: index.php");
            }else{
                $conn->close();
                header("Location: index.php");
            }
        }
    }
?>