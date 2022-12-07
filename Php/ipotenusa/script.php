<?php
    if($_SERVER["REQUEST_METHOD"] == "POST"){
        $_radio = $_POST['scelta'];
        $_cateto1 = $_POST['c1'];
        $_cateto2 = $_POST['c2'];
        if($_radio == "tri"){
            echo "Lunghezza ipotenusa: ".sqrt(($_cateto1 * $_cateto1)+($_cateto2 * $_cateto2));
        }
        else{
            echo "Area del triangolo: ".($_cateto1 * $_cateto2) / 2; 
        }
    }
?>