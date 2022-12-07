<?php
$file = fopen("./dati.csv","r");
    echo "<table> <tr>
    <th> Persona</th>
    <th>Nome</th>
    <th>Numero</th>
    </tr>";
    while(!feof($file)){
        echo "<tr>";
        $riga = fgets($file);
        $ArrayElementiRiga = explode(";",$riga);
        $lunghezza = count($ArrayElementiRiga);
        for ($i=0; $i < $lunghezza; $i++) { 
            if($lunghezza -1 == $i){
                echo "<td><img src='$ArrayElementiRiga[$i]'></td>";
            }else{
                echo "<td>$ArrayElementiRiga[$i]</td>";
            }
        }
        echo"</tr>";
    }
    echo "</table>";
?>