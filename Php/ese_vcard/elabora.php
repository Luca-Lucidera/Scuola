<?php
$nome = $_POST["nome"];
$cognome = $_POST["cognome"];
$tel = $_POST["telefono"];
$email = $_POST["email"];
$vcard = "BEGIN:VCARD
VERSION:2.1
N:$nome $cognome
TEL;CELL;VOICE:$tel
EMAIL;PREF;INTERNET:$email
END:VCARD";
echo '<img src="http://chart.apis.google.com/chart?chs=500x500&cht=qr&chld=H&chl='.urlencode($vcard).'">';
?>