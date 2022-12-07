<?php
session_start();
require("./fpdf184/fpdf.php");
if(!isset($_SESSION['user'])){
    header("Location: index.php");
}
if(!isset($_COOKIE['user'])) {
    echo "Il Cookie '" . 'user' . "' non è impostato!";
  } else {
    $pdf = new FPDF();
    $pdf->AddPage();
    $pdf->SetFont('Arial','B',16);
    $pdf->Cell(40,10,$_COOKIE['user']);
    $pdf->Output();
  }
?>