
<html lang="it">
<head>
</head>
<body>
<?php
     if(isset($_COOKIE["ultimo_donatore"])){
        echo "Nome dell ultimo donatore: ".$_COOKIE['ultimo_donatore'];
     }
?>
    <form action="elabora.php" method="post">
        Nome: <input type="text" name="name"><br>
        Importo: <input type="text" name="importo"><br>
        <input type="submit" value="Send">
    </form>
</body>
</html>