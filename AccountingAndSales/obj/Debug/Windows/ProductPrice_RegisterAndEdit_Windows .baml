   M S B A M L   `   `   `  ????M  IAccountingAndSales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:AccountingAndSales.WindowsAccountingAndSales.Windows  5      E    ?AccountingAndSales.Windows.ProductPrice_RegisterAndEdit_Windows   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v22.2, Version=22.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aU QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:AccountingAndSales.Windows     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          ? Title$,  &ProductPrice_RegisterAndEdit_Windows .??5      $	??500??5	      $	??450??5
       ? AllowsTransparency . 
??????  ? WindowStartupLocation$ CenterScreen=?5       ? WindowState$ Normal=?5       ? WindowStyle$
 None=?5       ? Triggers 5      :? 5   
    :? RoutedEvent$ Loaded??6   .[?5      ?? .??5      ??  ?? TargetProperty$ Opacity?6    g? Duration$ 00:00:00:01D?6A   .??5      W? 	 W? From$	 0X?6&   	
 W? To$
 3X?6/   5      5      5      .??5      ? .+?5   
   ?? -   5         ??Name$ 	rectang_0??5      $	??500??5      $	??450??5       $??	-7,30,0,0q?5!      $
??Left=?5"      $	??Top=?5#      
??????? J? Opacity$ 0Q?5%       ?? RadiusX$ 15??5&       ?? RadiusY$ 15??5'      
???   ?$??2??5)      ?? 5*   
   -   5        $ 	rectang_1??5+      $	??500??5,      $	??100??5-      $??Center=?5.      $	??Top=?5/      ???	#FF34495E$ 15??52      $ 15??53      
???   ?54      ?? 55   
   $??89,4,0,0q?56      $
??Left=?57      $	??Top=?58      $&?? Accounting And Sales Application??59      $??Calibri Light)?5:      $??22(?5;      $??Normal$?5<      $
??Bold"?5=      
???????5>      ?? 5?   
   -   5        $.??(LabelProductPrice_RegisterAndEdit_Header??5@      $??
139,43,0,0q?5A      $
??Left=?5B      $	??Top=?5C      $??Product Price Save??5D      $??Calibri Light)?5E      $??18(?5F      $??Normal$?5G      $
??Bold"?5H      
???????5I      ?? 5J   
   $??79??5K      $??84??5L      $??8,5,0,0q?5M      $
??Left=?5N      $	??Top=?5O      $??/Images/LoginLock_1.png??5P      ?? 5Q   
   $??49??5R      $??45??5S      $??	94,36,0,0q?5T      $
??Left=?5U      $	??Top=?5V      $??/Images/UserLogin.png??5W      ?? 5Y   
   -   5        $ 	rectang_2??5Z      $	??500??5[      $	??345??5\      $??	0,100,0,0q?5]      $
??Left=?5^      $	??Top=?5_      ???#FDFEFE$ 15??5a      $ 15??5b      
???   ?$??2??5d      ?? 5f   
   -   5        $??84??5g      $??79??5h      $??
411,10,0,0q?5i      $
??Left=?5j      $	??Top=?5k       ? Cursor$
 Hand??5l       J? RenderTransformOrigin$ 0.492,0.501&?5n      $??/Images/Exit.png??5o      ?? 5t   
   -   5         ??Name$ PriceSellingTextBox??5u      $??13,213,237,211q?5v      $??5,3,3,3q?5w      ???	#FFD42AE3$??0,0,0,2q?5y      }?. $??Calibri)?5{      $??16(?5|       ?? 	MaxLength$ 11??5}      .??5~   D   ??5      ?? 5?       ?? 
TargetType" ??6    ?? 	Resources 5?       ?? Property ?? Value??%_   '??       ?? 5?      " ??6    .?5?      ??  ?@??CornerRadius$ 10??6=   5?      5?      5?      .??5?      5?      ?? 5?   
   $??23,0,0,0q?5?      $
??Left=?5?      $??Center=?5?      
??????? J? IsHitTestVisible .  $??Price Selling??5?      ??5?      ?? 5?      " ??6   .?5?      ??  ? y?$ 	Collapsed=?63    ?? Triggers 5?      ?? 5?       ?? Binding 6&   ?? *Text+ ?? ElementName$ PriceSellingTextBox?? ?? Value  6`   .a?5?      ??  ? y?$ Visible=?6;   5?      5?      5?      ?? 5?   
   -   5        $ DescriptionTextBox??5?      $??18,272,232,96q?5?      $??5,3,3,3q?5?      ???	#FFD42AE3$??1,1,1,2q?5?      }?. $??Calibri)?5?      $??16(?5?      $	 250??5?      .??6   ??5?      ?? 5?      " ??6    5?      ??%_   '??       ?? 5?      " ??6    .?5?      ??  ?@??CornerRadius$ 10??6=   5?      5?      5?      .??5?      5?      ?? 5?   
   $??
28,275,0,0q?5?      $
??Left=?5?      $	??Top=?5?      
??????? .  $??Description??5?      ??5?      ?? 5?      " ??6   .?5?      ??  ? y?$ 	Collapsed=?63    5?      ?? 5?       6&   ?? *Text+$ DescriptionTextBox??  6_   .a?5?      ??  ? y?$ Visible=?6;   5?      5?      5?      ?? 5?   
   $??
16,117,0,0q?5?      $
??Left=?5?      $	??Top=?5?      $"??System User Activation Is : ??5?      $??Calibri Light)?5?      $??14(?5?      $??Normal$?5?      $
??Bold"?5?      
???   ?5?      ?? 5?   
   -	   5        $%??UserRegisterationFullName_Label??5?      $	??127??5?      $??181,117,0,0q?5?      $
??Left=?5?      $	??Top=?5?      $??	.........??5?      $??Calibri Light)?5?      $??14(?5?      $??Normal$?5?      $
??Bold"?5?      
???  ??5?      ?? 5?   
   $??273,165,0,0q?5?      $
??Left=?5?      $	??Top=?5?      $??$??5?      $??Calibri Light)?5?      $??18(?5?      $
??Bold"?5?      
????  ?5?      ?? 5?   
   $??273,217,0,0q?5?      $
??Left=?5?      $	??Top=?5?      $??$??5?      $??Calibri Light)?5?      $??18(?5?      $
??Bold"?5?      
????  ?5?      ?? 5?   
   -
   5        $ PriceBuyingTextBox??5?      $??13,161,237,263q?5?      $??5,3,3,3q?5?      ???	#FFD42AE3$??0,0,0,2q?5?      }?. $??Calibri)?5?      $??16(?5?      $ 11??5?      .??5?   =   ??5?      ?? 5?      " ??6    5?      ??%_   '??       ?? 5?      " ??6    .?5?      ??  ?@??CornerRadius$ 10??6=   5?      5?      5      .??5     5     ?? 5  
   $??
23,165,0,0q?5     $
??Left=?5     $	??Top=?5     
??????? .  $??Price Buying??5	     ??5
     ?? 5     " ??6   .?5     ??  ? y?$ 	Collapsed=?63    5     ?? 5      6&   ?? *Text+$ PriceBuyingTextBox??  6_   .a?5     ??  ? y?$ Visible=?6;   5     5     5     ?? 5  
   -   5         ??Name$ ProductNameLable??5     $	??154??5     $??318,118,0,0q?5     $
??Left=?5     $	??Top=?5     $??	.........??5     $??Calibri Light)?5     $??14(?5     $??Normal$?5     $
??Bold"?5     
???  ??5      ?? 5!  
   -   5        $??Btn_SaveAndEdit??5!     $??Save New Pice??5"     $
??Left=?5#     $??107,394,0,0q?5$     
???????$	??Top=?5&        RoundCorner#??[  5'     $	??117??66   $??29??6B   6N   ?? 5(  
   -   5        $
??Exit??5(     $
??Left=?5)     $??258,394,0,0q?5*     
???????$	??Top=?5,     #??[  5-     $	??117??66   $??29??6B   6N   50     51     