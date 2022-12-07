<?php
$file = fopen("../dati.csv","r");
if($file){
    echo "<table>
    <tr>
        <th>Nome</th>
        <th>Cognome</th> 
        <th>Età</th>
        <th>Immagine</th>
    </tr>";
    while(!feof($file)){
        $riga = fgets($file);
        if(!$riga != " "){//se la riga non è vuota fa tutta
            $elementi = explode(";",$riga);
            echo "<tr>";
            for ($i=0; $i < count($elementi); $i++) { 
                if(count($elementi) - 1 != $i){
                    echo "<td>$elementi[$i]</td>";
                }
                else{
                    echo"<td><image src='$elementi[$i]' width='50' height='50'></td>";
                }
            }
            foreach($elementi as $valore){
            }
            echo"</tr>";
        }   
    }
    echo "</table>";
    echo  '<p><a href="../index.html">Home page</a></p>';
}