<?php
// Usiamo la libreria 
require("qrcode.php");
 
// ECC Level, livello di correzione dell'errore (valori possibili in ordine crescente: L,M,Q,H - da low a high)
$errorCorrectionLevel = 'L';

// Matrix Point Size, dimensione dei punti della matrice (da 1 a 10)
$matrixPointSize = 4;

// I dati da codificare nel QRcode
$data = "http://www.e-terna.net";

// Il File da salvare (deve essere salvato in una directory scrivibile dal web server)
$filename = 'qrcode'.md5($data.'|'.$errorCorrectionLevel.'|'.$matrixPointSize).'.png';

// Generiamo il QRcode in formato immagine PNG
QRcode::png($data, $filename, $errorCorrectionLevel, $matrixPointSize, 2);

// Per visualizzare il QRcode basta inserire $filename nell'attributo src del tag img