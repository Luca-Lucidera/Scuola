<?php
$file = fopen("../dati.csv","r");
if($file){
    echo "<table>
    <tr>
        <th>Nome</th>
        <th>Cognome</th> 
        <th>Età</th>
    </tr>";
    while(!feof($file)){
        $riga = fgets($file);
        $elementi = explode(";",$riga);
        echo "<tr>";
        foreach($elementi as $valore){
            echo "<td>$valore</td>";
        }
        echo"</tr>";
    }
    echo "</table>";
    echo  '<p><a href="../index.html">Home page</a></p>';
}