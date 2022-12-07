<?php
$file = fopen("./../dati.csv","r");
echo "<table>
<tr>
    <th>Nome</th>
    <th>Cognome</th> 
    <th>Email</th>
    <th>Sesso</th>
</tr>";
while(!feof($file)){
    $riga = fgets($file);
    echo "<tr>";
    if($riga != ""){
        $singoli = explode(";",$riga);
        echo "<td>$singoli[0]</td>
            <td>$singoli[1]</td>
            <td>$singoli[2]</td>";
            echo "<td><image src='./../$singoli[3].png'></td>";
    }
    echo "</tr>";
}
echo "</table>";