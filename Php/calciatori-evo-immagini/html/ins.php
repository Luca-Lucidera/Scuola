<html lang="en">

<head>
  <meta charset="UTF-8" />
  <meta http-equiv="X-UA-Compatible" content="IE=edge" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0" />
  <title>Document</title>
</head>

<body>
  <form method="post" action="./../php/inserimento.php">
    <p>Nome <input type="text" name="nome" /></p>
    <p>Cognome <input type="text" name="cognome" /></p>
    <p>Eta <input type="text" name="eta" /></p>

    <?php
    $dir = opendir("../images/");
    while ($entryName = readdir($dir)) {
      $dirArray[] = $entryName;
    }
    closedir($dir);
    $indexCount = count($dirArray);
    echo $indexCount . " Files<br />";
    echo "<select name='immagini'>";
    for ($index = 0; $index < $indexCount; $index++) {
      if ($dirArray[$index]!= "." && $dirArray[$index] != "..") {
        $type = filetype($dirArray[$index]);
        echo "<option value=" . $dirArray[$index] . ">" . $dirArray[$index] . "</option>";
      }
    }
    echo "</select>";
    ?>
    <input type="submit" value="invia i dati" />
  </form>
  <p><a href="../index.html">Home page</a></p>
</body>

</html>