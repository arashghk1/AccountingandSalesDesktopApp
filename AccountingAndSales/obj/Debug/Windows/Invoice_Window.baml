   M S B A M L   `   `   `  ????M  IAccountingAndSales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:AccountingAndSales.WindowsAccountingAndSales.Windows  5   	   /    )AccountingAndSales.Windows.Invoice_Window   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v22.2, Version=22.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aU QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:AccountingAndSales.Windows     5   	   -   5          ? Title$  Invoice_Window??5   	   $	??750??6    $
??1100??6-   
??????  ? AllowsTransparency .  ? WindowStartupLocation$ CenterScreen=?6m    ? WindowStyle$
 None=?6?   .??5	      ? -   5        $??IsMasterGrid??5	       ? RowDefinitions 5   
   ?? 5      $??80??6   $	??100??6+   $	??50* ?6;   ?? 5      $	??320??6   $	??380??6,   $
??181* ?6<   ?? 5      $
??144* ?6    ? ColumnDefinitions 5   
   ?? 5      $	??420??6   ?? 5      $	??700??6   .+?5   
   ?? $??1??6   $??0??6   $??4q?6.   
???p?$??2??6]    ?? CornerRadius$ 30??6q   ._?5      ?? -   5        $??UpRectangle??5      $??1??6+   $??0??68   $??2??6H   
??????? ?? RadiusX$ 30??6i    ?? RadiusY$ 30??6v   5      5      ?? 5   
   $??2??6   $??0??6   $??2q?6.   
???p?$??2??6]   $ 30??6q   ._?5       ?? -   5        $??IsLableContentRectangle??5       $??2??67   $??0??6D   $??2??6T   
???????$ 30??6u   $ 30??6?   	 ?? StrokeMiterLimit$	 12Q?6?   $??2??6?   5"      5#      ?? 5%   
   -   5        
 ??Name$
 Header_Rectangle??5)      $??0??5%      $??0??6!   $
??1100??5&      $	??100??5'      $??2??5(      $
??Left=?5*      $??Center=?5+      ???	#FF34495E$ 15??5-      $ 15??5.      
???   ?5/      ?? 51   
   $??0??6   $??0??6   $??89,4,0,0q?52      $
??Left=?53      $	??Top=?54      $&?? Accounting And Sales Application??55      $??Caliber Light)?56      $??22(?57      $??Normal$?58      $
??Bold"?59      
???????$??37??5:       $	??302??6,   ?? 5;   
   $??0??6   $??0??6   $??
139,43,0,0q?5<      $
??Left=?5=      $	??Top=?5>      $!??Create And Register Invoice??5?      $??Caliber Light)?5@      $??18(?5A      $??Normal$?5B      $??DemiBold"?5C      
???????$??32??5D       $	??208??6,   ?? 5E   
   $??0??6   $??0??6   $??79??5F      $??84??5G      $??8,5,0,0q?5H      $
??Left=?5I      $	??Top=?5J      $ ??/Images/AddInvoiceLogo.png??5K      ?? 5L   
   $??0??6   $??0??6   $??49??5M      $??45??5N      $??	94,36,0,0q?5O      $
??Left=?5P      $	??Top=?5Q      $'??!/Images/ReciptWindowSmallLogo.png??5R      ?? 5T   
   -   5        $??0??5T      $??77??5U      $??79??5V      $??	583,6,0,0q?5W      $
??Left=?5X      $	??Top=?5Y       ? Cursor$
 Hand??5Z      $??/Images/Exit.png??5[      $??1??6*   6:   ?? 5]   
   -   5         ??Name$ SearchTextBoxForProduct??5^      $??112,274,236,60q?5_      $??5,3,3,3q?5`      ???	#FFD42AE3$??0,0,0,2q?5b      }?. $??Caliber)?5d      $??16(?5e       ?? 	MaxLength$ 60??5f      $??1??6   $??1??6)    J? RenderTransformOrigin$ 0.5,0.5&?69   .??6Y   z?5g      V? 5h      .~?5i      ?? ?? 5j       ?? AngleX$ -0.781Q?6$   ?? 5k      T? 5l       T? X$ -0.586Q?6)   5m      .??5n   '   ??5o      ?? 5p       ?? 
TargetType" ??6    ?? 	Resources 5q       ?? Property ?? Value??%_   '??       ?? 5r      " ??6    .?5s      ??  ?@??CornerRadius$ 10??6=   5t      5u      5w      .??5x      5y      ?? 5z   
   $??122,279,0,0q?5{      $
??Left=?5|      $	??Top=?5}      
??????? J? IsHitTestVisible .  $??Search Product Here ...??5?      $??1??6,   $??1??69   $??16??6I   $	??126??6U   ??5?      ?? 5?      " ??6   .?5?      ??  ? y?$ 	Collapsed=?63    ?? Triggers 5?      ?? 5?       ?? Binding 6&   ?? *Text+ ?? ElementName$ SearchTextBoxForProduct?? ?? Value  6d   .a?5?      ??  ? y?$ Visible=?6;   5?      5?      5?      ?? 5?   
   -   5        $??Btn_ProductAddedInInvoice??5?      $	??143??5?      $??32??5?      $??114,313,0,0q?5?      $
??Left=?5?      $	??Top=?5?      ???	#FF2865DE???	#FF517A90$??Product Add??5?      $
??Bold"?5?      
???????   RoundCorner#???   5?      $??1??63   $??1??6@   {?.  6g   &   System.Windows.Controls.DataGrid  5?   
   -	   5          Name$ ShowingCustomerDataGrid??5?      $??0??5?      $??12,92,21,105q?5?         AutoGenerateColumns .  $ 0.5,0.5&?5?      $??1??6-    J? Effect 5?      3  -System.Windows.Media.Effects.DropShadowEffect  5?         Columns 5?      0  *System.Windows.Controls.DataGridTextColumn  5?      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 5?         Header$ ID??5?      1  +System.Windows.Controls.DataGridBoundColumn    Binding  5?      ?? *Customer_ID+!   HeaderStyle! 5?      ?? 5?      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6    .?5?      ??  ? ??$ Calibri)?6;   ?? 5?       ? ??$ 12(?69   ?? 5?       ? ??$
 Bold"?6;   ?? 5?       ? ??$ Center=?6K   ?? 5?       ? ??
 ?   ?6;   5?      "   ElementStyle" 5?      ?? 5?      " ??6    .?5?      ??  ? ?? ?#17202A6;   ?? 5?       ? ??$ Calibri)?6;   ?? 5?       ? ??$ 12(?69   ?? 5?       ? ??$ Center=?6D   ?? 5?       ? ??$
 Bold"?6;   5?      5?        5?      $	 100 5?      $ FullName??5?        5?      ?? *Customer_FullName+! 5?      ?? 5?      "  6    .?5?      ??  ? ??$ Calibri)?6;   ?? 5?       ? ??$ 12(?69   ?? 5?       ? ??$
 Bold"?6;   ?? 5?       ? ??$ Center=?6K   ?? 5?       ? ??
 ?   ?6;   5?      " 5?      ?? 5?      " ??6    .?5?      ??  ? ?? ?#17202A6;   ?? 5?       ? ??$ Calibri)?6;   ?? 5?       ? ??$ 12(?69   ?? 5?       ? ??$ Center=?6D   ?? 5?       ? ??$
 Bold"?6;   5?      5?        5?      $	 150 5?      $ Address??5?        5?      ?? *Customer_Address+! 5?      ?? 5?      "  6    .?5?      ??  ? ??$ Calibri)?6;   ?? 5?       ? ??$ 12(?69   ?? 5?       ? ??$
 Bold"?6;   ?? 5?       ? ??$ Center=?6K   ?? 5?       ? ??
 ?   ?6;   5?      " 5?      ?? 5?      " ??6    .?5?      ??  ? ?? ?#17202A6;   ?? 5?       ? ??$ Calibri)?6;   ?? 5?       ? ??$ 12(?69   ?? 5?       ? ??$ Center=?6D   ?? 5?       ? ??$
 Bold"?6;   5?      5?        5?      $ 95 5?      $ 
Tel Number??5?        5?      ?? *Customer_PhoneNumber+! 5?      ?? 5?      "  6    .?5?      ??  ? ??$ Calibri)?6;   ?? 5?       ? ??$ 12(?69   ?? 5?       ? ??$
 Bold"?6;   ?? 5?       ? ??$ Center=?6K   ?? 5?       ? ??
 ?   ?6;   5?      " 5     ?? 5     " ??6    .?5     ??  ? ?? ?#17202A6;   ?? 5      ? ??$ Calibri)?6;   ?? 5      ? ??$ 12(?69   ?? 5      ? ??$ Center=?6D   ?? 5      ? ??$
 Bold"?6;   5	     5     # ? ContextMenu# 5     ?? 5     .@?5     m? $??Edit Customer??6   $ m? Icon$ 5     ?? 5     $??20??5  !   $??20??5  !   $??/Images/UserLogin.png??5  !   5     m? 5     $??Delete Customer??6   $ 5     ?? 5     $??20??5  !   $??20??5  !   $??/Images/UserLogin.png??5  !   5!     m? 5"     $??Close??6   $ 5#     ?? 5$     $??20??5%  !   $??20??5&  !   $??/Images/UserLogin.png??5'  !   5)     5+     5-     ?? 5/  
   -
   5        $ SearchTextBoxCustomer??50     $??19,272,101,63q?51     $??5,3,3,3q?52     ???	#FFD42AE3$??0,0,0,2q?54     }?. $??Calibri)?56     $??16(?57     $ 60??58     $??1??6   $??0??6)   .??69   ??59     ?? 5:     " ??6    5;     ??%_   '??       ?? 5<     " ??6    .?5=     ??  ?@??CornerRadius$ 10??6=   5>     5?     5A     .??5B     5C     ?? 5D  
   -   5        $??SaerchTextBoxTextBlock??5E     $??
30,276,0,0q?5F     $
??Left=?5G     $	??Top=?5H     
??????? .  $??Shearch Customer Here ...??5K     $??1??6.   $??0??6;   $??16??6K   $	??136??6W   ??5L     ?? 5M     " ??6   .?5N     ??  ? y?$ 	Collapsed=?63    5O     ?? 5P      6&   ?? *Text+$ SearchTextBoxCustomer??  6b   .a?5Q     ??  ? y?$ Visible=?6;   5R     5T     5V     ?? 5X  
   -   5        % ??Name$% Btn_CreateInvoice??5Y     $	??143??5Z     $??32??5[     $??
29,311,0,0q?5\     $
??Left=?5]     $	??Top=?5^     ???	#FF2865DE???	#FF517A90$??Create Invoice??5a     $
??Bold"?5b     
???????#???   5d     $??1??63   $??0??6@   6P   ?? 5f  
   $??1??6   $??0??6   $??Customer Selected??6-   $??15(?6I   $
??Bold"?6W   $??Italic$?6i   
??? ? ?$??18,6,260,328q?6?   ?? 5g  
   $??3??6   
????  ?$??1??6+   $??0??68   $??14,36,256,323q?6H   ?? 5h  
   $??36??5i     $??35??5j     $
 Hand??5k     $??/Images/Arrow.png??5l     $??1??5m     $??0??6   $??164,20,220,307q?6*     5n  
   -   5        $! ShowingAddedProductDataGrid??5n      .  $??2??6T   $??1??6a   $??105,65,10,84q?6q    5o       5p      5r       5s     $ 80 5t     $ 
Product ID??5v       5u     ?? *
Product_ID+! 5w     ?? 5x     "  6    .?5y     ??  ? ??$ Calibri)?6;   ?? 5z      ? ??$ 12(?69   ?? 5{      ? ??$
 Bold"?6;   ?? 5|      ? ??$ Center=?6K   ?? 5}      ? ??
 ?   ?6;   5~     " 5?     ?? 5?     " ??6    .?5?     ??  ? ?? ?#17202A6;   ?? 5?      ? ??$ Calibri)?6;   ?? 5?      ? ??$ 12(?69   ?? 5?      ? ??$ Center=?6D   ?? 5?      ? ??$
 Bold"?6;   5?     5?       5?     $	 140 5?     $ Product Name??5?       5?     ?? *Product_Name+! 5?     ?? 5?     "  6    .?5?     ??  ? ??$ Calibri)?6;   ?? 5?      ? ??$ 12(?69   ?? 5?      ? ??$
 Bold"?6;   ?? 5?      ? ??$ Center=?6K   ?? 5?      ? ??
 ?   ?6;   5?     " 5?     ?? 5?     " ??6    .?5?     ??  ? ?? ?#17202A6;   ?? 5?      ? ??$ Calibri)?6;   ?? 5?      ? ??$ 12(?69   ?? 5?      ? ??$ Center=?6D   ?? 5?      ? ??$
 Bold"?6;   5?     5?       5?     $	 120 5?     $ Last Buying Price??5?       5?     ?? *InvoiceProduct_BuyingPrice+! 5?     ?? 5?     "  6    .?5?     ??  ? ??$ Calibri)?6;   ?? 5?      ? ??$ 12(?69   ?? 5?      ? ??$
 Bold"?6;   ?? 5?      ? ??$ Center=?6K   ?? 5?      ? ??
 ?   ?6;   5?     " 5?     ?? 5?     " ??6    .?5?     ??  ? ?? ?#17202A6;   ?? 5?      ? ??$ Calibri)?6;   ?? 5?      ? ??$ 12(?69   ?? 5?      ? ??$ Center=?6D   ?? 5?      ? ??$
 Bold"?6;   5?     5?       5?     $	 120 5?     $ Last Selling Price??5?       5?     ?? *InvoiceProduct_SellingPrice+! 5?     ?? 5?     "  6    .?5?     ??  ? ??$ Calibri)?6;   ?? 5?      ? ??$ 12(?69   ?? 5?      ? ??$
 Bold"?6;   ?? 5?      ? ??$ Center=?6K   ?? 5?      ? ??
 ?   ?6;   5?     " 5?     ?? 5?     " ??6    .?5?     ??  ? ?? ?#17202A6;   ?? 5?      ? ??$ Calibri)?6;   ?? 5?      ? ??$ 12(?69   ?? 5?      ? ??$ Center=?6D   ?? 5?      ? ??$
 Bold"?6;   5?     5?       5?     $	 102 5?     $ Product Quantity??5?       5?     ?? *InvoiceProduct_Count+! 5?     ?? 5?     "  6    .?5?     ??  ? ??$ Calibri)?6;   ?? 5?      ? ??$ 12(?69   ?? 5?      ? ??$
 Bold"?6;   ?? 5?      ? ??$ Center=?6K   ?? 5?      ? ??
 ?   ?6;   5?     " 5?     ?? 5?     " ??6    .?5?     ??  ? ?? ?#17202A6;   ?? 5?      ? ??$ Calibri)?6;   ?? 5?      ? ??$ 12(?69   ?? 5?      ? ??$ Center=?6D   ?? 5?      ? ??$
 Bold"?6;   5?     5?     # 5?     ?? 5?     .@?5?     m? $??Edit Customer??6   $ 5?     ?? 5?     $??20??5?  !   $??20??5?  !   $??/Images/UserLogin.png??5   !   5     m? 5     $??Delete Customer??6   $ 5     ?? 5     $??20??5  !   $??20??5  !   $??/Images/UserLogin.png??5	  !   5     m? 5     $??Close??6   $ 5     ?? 5     $??20??5  !   $??20??5  !   $??/Images/UserLogin.png??5  !   5     5     5     ?? 5  
   -   5        $??Btn_ClosedInvoice??5     $	??144??5     $??32??5     $??346,230,0,0q?5     $
??Left=?5     $	??Top=?5     ???	#FF2865DE???	#FF517A90$??Invoice Closed??5"     $
??Bold"?5#     
???????#???   5%     $??2??63   $??1??6@   {?.  6g   ?? 5'  
   -   5        $ ??Btn_ProductDeleteInInvoice??5(     $	??143??5)     $??32??5*     $??158,230,0,0q?5+     $
??Left=?5,     $	??Top=?5-     ???	#FF2865DE???	#FF517A90$??Delete Product??50     $
??Bold"?51     
???????#???   53     $??2??63   $??1??6@   {?.  6g   ?? 54  
   $??Invoice Information??6   $??15(?6.   $
??Bold"?6<   $??Italic$?6N   
??? ? ?$??30??6u   $??2??6?   $??0??6?   $??13,2,255,256q?6?   ?? 55  
   $??3??6   
????  ?$??2??6+   $??0??68   $??8,29,262,256q?6H   ?? 56  
   $
 Hand??57     $%??/Images/LoadInformationLogo.png??58     $??2??59     $??0??6   $??156,6,214,234q?6*   ?? 5;  
   -   5        & ??Name$!& SystemUserRegisterNameLabel??5;  -   $??2??6   $??0??6   $??....................??6R   $??13(?6q   
???  ??$??30??6?   $??190,90,19,168q?6?   ?? 5<  
   -   5        $& DateTimeLabel??5<  -   $??2??6   $??0??6   $??....................??6D   $??13(?6c   
???  ??$??30??6?   $??190,55,19,203q?6?   ?? 5=  
   $??2??6   $??0??6   $??System User Register :??6-   $??13(?6N   $??DemiBold"?6\   $??30??6s   $??15,55,260,203q?6   ?? 5>  
   $??2??6   $??0??6   $??
DateTime :??6-   $??13(?6B   $??DemiBold"?6P   $??30??6g   $??15,90,260,168q?6s   ?? 5?  
   $??2??6   $??0??6"   $??15,134,255,38q?63   .+?5A     ?? $??Customer Name :??6   $??13(?6.   $??DemiBold"?6<   $??30??6S   ?? 5B     $??Invoice ID :??6   $??13(?6+   $??DemiBold"?69   $??30??6O   ?? 5C     $??Invoice Total Price :??6   $??13(?64   $??DemiBold"?6B   $	??Top=?6X   $??2??6p   $??0??6}   ?? 5D     $??Invoice Buying Price :??6   $??13(?65   $??DemiBold"?6C   $	??Top=?6Y   $??2??6q   $??0??6~   5F     ?? 5H  
   -   5        $??ContainerLablePanel??5H  2   $??2??6   $??0??6"   $??190,134,29,40q?6M   .+?5J     ?? -   5        $& CustomerNameLabel??5J     $??....................??6/   $??13(?6N   
???  ??$??30??6n   ?? 5K     -   5        $& InvoiceIDLabel??5K     $??0??6,   $??13(?68   
???  ??$??30??6W   ?? 5L     -   5        $& TotalPriceLabel??5L     $??0??6-   $??13(?69   
???  ??$??30??6X   ?? 5M     -   5        $& TotalBuyingPriceLabel??5M     $??0??63   $??13(?6?   
???  ??$??30??6_   5N     ?? 5P  
   $??2??6   $??1??6!   $	??150??61   $??3??6=   
????  ?$??117,33,413,252q?6T   ?? 5Q  
   $??35??5R     $??35??5S     $??
267,24,0,0q?5T     $
??Left=?5U     $	??Top=?5V     $
 Hand??5W     $??/Images/Arrow.png??5X     $??2??6(   $??1??65     5Y  
   -   5        $ ShowingProductDataGrid??5Y      .  $??1??6O   $??1??6\   $??104,92,12,105q?6l    5Z       5[      5]       5^     $ 80 5_     $ 
Product ID??5a       5`     ?? *
Product_ID+! 5b     ?? 5c     "  6    .?5d     ??  ? ??$ Caliber)?6;   ?? 5e      ? ??$ 12(?69   ?? 5f      ? ??$
 Bold"?6;   ?? 5g      ? ??$ Center=?6K   ?? 5h      ? ??
 ?   ?6;   5i     " 5l     ?? 5m     " ??6    .?5n     ??  ? ?? ?#17202A6;   ?? 5o      ? ??$ Caliber)?6;   ?? 5p      ? ??$ 12(?69   ?? 5q      ? ??$ Center=?6D   ?? 5r      ? ??$
 Bold"?6;   5t     5v       5x     $	 180 5y     $ Product Name??5{       5z     ?? *Product_Name+! 5|     ?? 5}     "  6    .?5~     ??  ? ??$ Caliber)?6;   ?? 5      ? ??$ 12(?69   ?? 5?      ? ??$
 Bold"?6;   ?? 5?      ? ??$ Center=?6K   ?? 5?      ? ??
 ?   ?6;   5?     " 5?     ?? 5?     " ??6    .?5?     ??  ? ?? ?#17202A6;   ?? 5?      ? ??$ Caliber)?6;   ?? 5?      ? ??$ 12(?69   ?? 5?      ? ??$ Center=?6D   ?? 5?      ? ??$
 Bold"?6;   5?     5?       5?     $	 150 5?     $ Product Selling Price??5?       5?     ?? *Product_LastPrice+! 5?     ?? 5?     "  6    .?5?     ??  ? ??$ Caliber)?6;   ?? 5?      ? ??$ 12(?69   ?? 5?      ? ??$
 Bold"?6;   ?? 5?      ? ??$ Center=?6K   ?? 5?      ? ??
 ?   ?6;   5?     " 5?     ?? 5?     " ??6    .?5?     ??  ? ?? ?#17202A6;   ?? 5?      ? ??$ Caliber)?6;   ?? 5?      ? ??$ 12(?69   ?? 5?      ? ??$ Center=?6D   ?? 5?      ? ??$
 Bold"?6;   5?     5?       5?     $	 150 5?     $ Product Buying Price??5?       5?     ?? *Product_LastBuyingPrice+! 5?     ?? 5?     "  6    .?5?     ??  ? ??$ Caliber)?6;   ?? 5?      ? ??$ 12(?69   ?? 5?      ? ??$
 Bold"?6;   ?? 5?      ? ??$ Center=?6K   ?? 5?      ? ??
 ?   ?6;   5?     " 5?     ?? 5?     " ??6    .?5?     ??  ? ?? ?#17202A6;   ?? 5?      ? ??$ Caliber)?6;   ?? 5?      ? ??$ 12(?69   ?? 5?      ? ??$ Center=?6D   ?? 5?      ? ??$
 Bold"?6;   5?     5?       5?     $	 150 5?     $ Product Available??5?       5?     ?? *Product_LastInventory+! 5?     ?? 5?     "  6    .?5?     ??  ? ??$ Caliber)?6;   ?? 5?      ? ??$ 12(?69   ?? 5?      ? ??$
 Bold"?6;   ?? 5?      ? ??$ Center=?6K   ?? 5?      ? ??
 ?   ?6;   5?     " 5?     ?? 5?     " ??6    .?5?     ??  ? ?? ?#17202A6;   ?? 5?      ? ??$ Caliber)?6;   ?? 5?      ? ??$ 12(?69   ?? 5?      ? ??$ Center=?6D   ?? 5?      ? ??$
 Bold"?6;   5?     5?     # 5?     ?? 5?     .@?5?     m? $??Edit Customer??6   $ 5?     ?? 5?     $??20??5?  !   $??20??5?  !   $??/Images/UserLogin.png??5?  !   5?     m? 5?     $??Delete Customer??6   $ 5?     ?? 5?     $??20??5?  !   $??20??5?  !   $??/Images/UserLogin.png??5?  !   5?     m? 5?     $??Close??6   $ 5?     ?? 5?     $??20??5?  !   $??20??5?  !   $??/Images/UserLogin.png??5?  !   5?     5?     5      ?? 5  
   $??1??6   $??1??6    $??Product Selected??6-   $??15(?6H   $??Italic$?6V   $
??Bold"?6i   
??? ? ?$??94,5,456,327q?6?   ?? 5  
   $??3??6   
????  ?$??1??6+   $??1??68   $??94,38,458,321q?6H   ?? 5  
   $??36??5     $??35??5     $
 Hand??5     $??/Images/Arrow.png??5     $??1??6(   $??218,18,426,309q?68   $??1??6P   ?? 5
  
   $??1??6   $??2??6    $??Product Added Is : ??6-   $??15(?6K   $??Italic$?6Y   $
??Bold"?6l   
??? ? ?$??133,7,406,251q?6?   ?? 5  
     MyLabel#??[ 6   $??1??62   $??1??6B   $?? ??6O   $??12(?6Z   $??Italic$?6h   
???  ??$??112,61,67,276q?6?   ?? 5  
   -   5        $" ProductCountQuantity_TextBox??5     $??464,277,20,62q?5     $??5,3,3,3q?5     ???	#FFD42AE3$??0,0,0,2q?5     $??Center=?5     }?. $??Caliber)?5     $??16(?5     $ 60??5     $??1??6   $??1??6)   .??6z   ??5     ?? 5     " ??6    5     ??%_   '??       ?? 5     " ??6    .?5     ??  ?@??CornerRadius$ 10??6=   5     5     5     .??5      5!     ?? 5"  
   $??473,279,0,0q?5#     $
??Left=?5$     $	??Top=?5%     
??????? .  $"??Product Quantity For Selling??5(     $??1??61   $??1??6>   $??16??6N   $	??161??6Z   ??5)     ?? 5*     " ??6   .?5+     ??  ? y?$ 	Collapsed=?63    5,     ?? 5-      6&   ?? *Text+$" ProductCountQuantity_TextBox??  6i   .a?5.     ??  ? y?$ Visible=?6;   5/     51     53     ?? 54  
   $??1??6   $??0??6   $	??126??55     $	??128??56     $??396,115,0,0q?57     $
??Left=?58     $	??Top=?59     $
 Hand??5:     $??/Images/Arrow_2.png??5;     $??2??6*   $ 0.5,0.5&?6>   z?5<     V? 5=     .~?5>     ?? ?? 5?     ?? 5@     ' ?? Angle$' 180.717Q?6&   T? 5A     5B     5D     5G     5H     