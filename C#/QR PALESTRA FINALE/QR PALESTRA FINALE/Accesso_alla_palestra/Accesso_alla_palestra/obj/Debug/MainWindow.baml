   M S B A M L   `   `   `  ????P  LAccesso_alla_palestra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Accesso_alla_palestraAccesso_alla_palestra  5   	   C ?QrWebCam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5(clr-namespace:QrWebCam;assembly=QrWebCamQrWebCam 5   	   &     Accesso_alla_palestra.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Accesso_alla_palestra     5   	   8qwc(clr-namespace:QrWebCam;assembly=QrWebCam     5   	     ? Title$  
MainWindow??5	   	   $	??500??6   $??909.5??6)   .??5
      ?  ? RowDefinitions 5   
   ?? 5      $	??469 ?6   .+?5   
   ?? -   5         ??Name$ 	camSelect??5   A   $??Center=?6T   $??Center=?6o   $??0??6?   $??304,0,346,447q?6?   $	??252??6?     QrWebCam.QrWebCamControl  5   
   -   5          Name$ webCam??5   5   $??
0,93,481,0q?6k   ?? 5   
   -   5         ??Name$ 	txt_debug??5      $
??Left=?6%   $	??183??6@   $??
438,39,0,0q?6M    ?? TextWrapping$
 Wrap=?6a   $	??Top=?6u   $	??437??6?   (  "System.Windows.Controls.WebBrowser  5   
   -   5          Name$	 web??5      $
??Left=?6"   $	??216??6=   $??456,243,0,0q?6J   $	??Top=?6_   $	??419??6w   ?? 5   
   -   5         ??Name$ 	lbl_tempo??5      $?? ??6#   $
??Left=?6.   $??	10,39,0,0q?6I   $	??Top=?6\   $??49??6t   $	??395??6?   5      5      