   M S B A M L   `   `   `  ????M  IAccountingAndSales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:AccountingAndSales.WindowsAccountingAndSales.Windows  5      ,    &AccountingAndSales.Windows.MainWindows   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v22.2, Version=22.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aU QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      MCustom@http://schemas.microsoft.com/winfx/2006/xaml/presentation/ribbon  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      4local(clr-namespace:AccountingAndSales.Windows  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      -   5          ? Title$  MainWindows??5	      $
??1200??5
      $	??600??5       ? WindowStartupLocation$ CenterScreen=?5      .??5      ? $??0,0,0,0q?6   .+?5   
   .  (Microsoft.Windows.Controls.Ribbon.Ribbon  $??	0,0,0,397q?6      QuickAccessToolBar 5      @  :Microsoft.Windows.Controls.Ribbon.RibbonQuickAccessToolBar  5      $??23??62   $	??Top=?6>   .@?5      9  3Microsoft.Windows.Controls.Ribbon.RibbonSplitButton  8  2Microsoft.Windows.Controls.Ribbon.RibbonMenuButton   SmallImageSource$# /Images/RaibbonHeaderItem.png??6/   .@?5      ;  5Microsoft.Windows.Controls.Ribbon.RibbonSplitMenuItem  -   5        $??About Us??5      6  0Microsoft.Windows.Controls.Ribbon.RibbonMenuItem   ImageSource$ /Images/AboutMe.png??5        5      -   5        $??
Contact Us??5      $ /Images/ContactUs.png??5        5      -   5        $
??Exit??5!      $ /Images/Exit.png??5"      5#      5$         ApplicationMenu 5(      =  7Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenu  5)      .@?5*      A  ;Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenuItem  -   5        $??Define Users??5,      $ /Images/AddUser.png??5-        5.      -   5        $??Define User Access??50      $  /Images/UserPermission.png??51        52      -   5        $??Change Password??54      $ /Images/ChangeUser.png??55        56      -   5        $$??Definitoin Of System Component??58      $ /Images/SystemSetting.png??59        5:      -	   5        $??Customer Definition??5<      $ /Images/Backup.png??5=        5>      -
   5        $#??User Login And Logout Control??5@      $" /Images/UserInputAndExit.png??5A        5B      -   5        $??Preparing a Backup File??5D      $ /Images/Backup.png??5E      5G      .@?5J      1	  +Microsoft.Windows.Controls.Ribbon.RibbonTab	  $??0,0,0,1q?6   $??Items??60   .@?5L      3
  -Microsoft.Windows.Controls.Ribbon.RibbonGroup
  .@?5M      4  .Microsoft.Windows.Controls.Ribbon.RibbonButton  -   5           Label$ Items Display??5O         LargeImageSource$ /Images/Items.png??5P      5Q      
  5S      $	??555??5T      $??85??5U      $??
Show Items??5V      .@?5W        -   5        $??0,4,0,0q?5X      $ Price Managment??5Z         SmallImageSource$  /Images/ExpensivePrice.png??5[        5\      -   5        $??0,17,0,0q?5]      $ Inventory Items??5_      $  /Images/ItemsInventory.png??5`        5a      -   5        $??50,4,0,0q?5b      $ Sales Chart??5d      $ /Images/PriceChart.png??5e      5f      5g      	  5m      $??0 0 0 1q?6   $??Sales??60   .@?5o      
  .@?5p        -   5        $ 
Add Orders??5p   *   $ /Images/order.png??6=   6b   5q      
  5t      $??Sales Group??6%   $??76??6:   .@?5u        -   5        $ Show Receipts??5u   *   $ /Images/reciept.png??6@   $??
0,10,10,15q?6g   6{     5v      $ Sales Reports??6*   $ /Images/salesreport.png??6@   $??
0,10,10,15q?6k     5w      -   5        $ Customer Reports??5w   *   $  /Images/customerreport.png??6C   $??
0,10,10,15q?6q   6?     5x      $ Receipt Reports??6*   $ /Images/receiptreport.png??6B   $??
0,10,10,15q?6o     5y      $ Item Reports??6*   $ /Images/itemreport.png??6?   $??
0,10,10,15q?6i     5z      $ User Reports??6*   $ /Images/userreport.png??6?   $??
0,10,10,15q?6i     5{      $ Profit and Loss Reports??6*   $" /Images/profitlossreport.png??6J   $??
0,10,10,15q?6z     5|      $ Sales Chart??6*   $ /Images/saleschart.png??6>   $??
0,10,10,15q?6h   5}      5      	  5?      $??	Inventory??6   	  5?      $??0,0,0,-5q?6   $??	Reporting??61   .@?5?      
  .@?5?        -   5        $ Base Reporting??5?   *   $ /Images/BaseReporting.png??6A   6n   5?        5?      -   5        $ Add Receipts??5?   &   $ /Images/reciept.png??6;   $??
0,10,10,15q?6b   6v     5?      $ Sales Reports??6&   $ /Images/salesreport.png??6<   $??
0,10,10,15q?6g     5?      -   5        $ Customer Reports??5?   &   $  /Images/customerreport.png??6?   $??
0,10,10,15q?6m   6?     5?      $ Receipt Reports??6&   $ /Images/receiptreport.png??6>   $??
0,10,10,15q?6k     5?      $ Item Reports??6&   $ /Images/itemreport.png??6;   $??
0,10,10,15q?6e     5?      $ User Reports??6&   $ /Images/userreport.png??6;   $??
0,10,10,15q?6e     5?      $ Profit and Loss Reports??6&   $" /Images/profitlossreport.png??6F   $??
0,10,10,15q?6v     5?      $ Sales Chart??6&   $ /Images/saleschart.png??6:   $??
0,10,10,15q?6d   5?      5?      ]? 5?   
   $??67??5?      $??	0,518,0,0q?5?      $	??Top=?5?      	 J? Opacity$
	 0.89Q?5?      
 J? RenderTransformOrigin$
 	0.5,0.444&?5?      ??5?      ?? 5?       ?? 
StartPoint$ 0.5,0&?6&    ?? EndPoint$ 0.5,1&?69   .??5?      ?  ? Color$ 	#FFBDC8F3??6#   ? 5?       ? Offset$ 1Q?6#   $ 	#FFF6F3F3??6.   5?      5?      ?? 5?   
   $??7,520,979,12q?5?      $??Current User FullName :??5?      $??18(?5?      ?? 5?   
   -   5        $??LabelCurrentUser??5?      $??217,520,801,12q?5?      $??Saeed Rajabi??5?       ? Cursor$
 Hand??5?      $??18(?5?      $
??Bold"?5?      $
 0.449,0.568&?5?      ?? 5?   
   $??485,520,614,12q?5?      $??Enter Time :??5?      $??18(?5?      $
 0.495,0.669&?5?      ?? 5?   
   -   5        $??LableEnterTime??5?      $??597,520,455,12q?5?      $??12:00??5?      $
 Hand??5?      $??18(?5?      $
??Bold"?5?      $
 0.5,0.5&?5?      ?? 5?   
   $??860,520,27,12q?5?      $&?? Accounting And Sales Application??5?      $
 Hand??5?      $??Dubai)?5?      $??18(?5?      $??Italic$?5?      $
??Bold"?5?      ???	#FFE67BCD$
 0.5,0.5&?5?      ?? 5?   
   $??34??5?      $??47??5?      $??820,523,0,0q?5?      $
??Left=?5?      $	??Top=?5?      $??/Images/Application.png??5?      5?      5?      