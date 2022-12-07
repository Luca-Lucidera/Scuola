<?php
require("./fpdf184/fpdf.php");
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $nome = $_POST['nome'];
    $cognome = $_POST['cognome'];
    $cf = $_POST['cf'];
    $data = $_POST['data'];
    $nonEsiste = true;
    $file = fopen("./dati.csv", "r");
    while (!feof($file)) {
        $riga = fgets($file);
        if ($riga != "") {
            $singoli = explode(";", $riga);
            if ($singoli[2] == $cf) {
                $nonEsiste = false;
            }
        }
    }
    fclose($file);
    if ($nonEsiste == true) {
        $data1 = new DateTime($data);
        $oggi = new DateTime("now");
        if($data1->diff($oggi)->y >= 12){
            $daSalvare = "$nome;$cognome;$cf;$data\n";
            $pdf = new FPDF();
            $pdf->AddPage();
            $pdf->SetFont('Arial', 'B', 16);
            $pdf->Cell(40, 10, $daSalvare);
            $pdf->Output();
            $file = fopen("./dati.csv","a+");
            fwrite($file,$daSalvare);
            fclose($file);
        }
        else{
            echo "SEI TROPPO PICCOLO! $data1->diff($oggi)->y";
        }
    }
}
