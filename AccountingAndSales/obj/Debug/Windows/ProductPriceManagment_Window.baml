   M S B A M L   `   `   `  ????M  IAccountingAndSales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:AccountingAndSales.WindowsAccountingAndSales.Windows  5      =    7AccountingAndSales.Windows.ProductPriceManagment_Window   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v22.2, Version=22.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aU QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:AccountingAndSales.Windows     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          ? Title$"  ProductPriceManagment_Window??5      $	??900??5	      $	??668??5
       ? AllowsTransparency . 
??????  ? WindowStartupLocation$ CenterScreen=?5       ? WindowState$ Normal=?5       ? WindowStyle$
 None=?5       ? Triggers 5      :? 5   
    :? RoutedEvent$ Loaded??6   .[?5      ?? .??5      ??  ?? TargetProperty$ Opacity?6    g? Duration$ 00:00:00:01D?6A   .??5      W? 	 W? From$	 0X?6&   	
 W? To$
 3X?6/   5      5      5      .??5      ? .+?5   
   ?? -   5         ??Name$ 	rectang_0??5      $	??900??5      $	??668??5       $??Center=?5!      $??Center=?5"      
??????? J? Opacity$ 0Q?5$       ?? RadiusX$ 15??5%       ?? RadiusY$ 15??5&      
???   ?$??2??5(      ?? 5)   
   -   5        $ 	rectang_1??5*      $	??900??5+      $	??100??5,      $??Center=?5-      $	??Top=?5.      ???	#FF34495E$ 15??51      $ 15??52      
???   ?53      ?? 54   
   $??89,4,0,0q?55      $
??Left=?56      $	??Top=?57      $&?? Accounting And Sales Application??58      $??Calibri Light)?59      $??22(?5:      $??Normal$?5;      $
??Bold"?5<      
???????5=      ?? 5>   
   $??
139,43,0,0q?5?      $
??Left=?5@      $	??Top=?5A      $??Product Price Managmetn??5B      $??Calibri Light)?5C      $??18(?5D      $??Normal$?5E      $
??Bold"?5F      
???????5G      ?? 5H   
   $??79??5I      $??84??5J      $??8,5,0,0q?5K      $
??Left=?5L      $	??Top=?5M      $??/Images/LoginLock_1.png??5N      ?? 5O   
   $??49??5P      $??45??5Q      $??	94,36,0,0q?5R      $
??Left=?5S      $	??Top=?5T      $??/Images/UserLogin.png??5U      ?? 5W   
   -   5        $??77??5X      $??79??5Y      $??	813,5,0,0q?5Z      $
??Left=?5[      $	??Top=?5\       ? Cursor$
 Hand??5]      $??/Images/Exit.png??5_      ?? 5c   
   -   5        $ 	rectang_2??5d      $	??900??5e      $??	0,100,0,0q?5f      $??Center=?5g      ???#FDFEFE$ 15??5i      $ 15??5j      
???   ?$??2??5l      &   System.Windows.Controls.DataGrid  5p   
   -   5        $*??$ShowingProductPriceManagmentDataGrid??5q      $??4,156,7,344q?5r         AutoGenerateColumns .   J? RenderTransformOrigin$ 0.5,0.5&?5t      z?5u      V? 5v      .~?5w      ?? ?? 5x       ?? AngleY$ -0.297Q?6$   ?? 5y      T? 5z       T? Y$ -2.382Q?6)   5{       J? Effect 5~      3  -System.Windows.Media.Effects.DropShadowEffect  5         Columns 5?      0  *System.Windows.Controls.DataGridTextColumn  5?      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 5?         Header$ ID??5?      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5?      ?? *ProductPiceManagment_ID+   HeaderStyle 5?      ?? 5?       ?? 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6    .?5?      ??  ?? Property ? ?? ?? Value$ Calibri)?6;   ?? 5?       ? ??$ 16(?69   ?? 5?       ? ??$
 Bold"?6;   ?? 5?       ? ??$ Center=?6K   ?? 5?       ? ??
 ?   ?6;   5?         ElementStyle 5?      ?? 5?      " ??6    .?5?      ??  ? ?? ?#17202A6;   ?? 5?       ? ??$ Calibri)?6;   ?? 5?       ? ??$ 13(?69   ?? 5?       ? ??$ Center=?6D   ?? 5?       ? ??$
 Bold"?6;   5?      5?        5?      $	 150 5?      $ Purchase Price??5?       5?      ?? *ProductPiceManagment_Buying+ 5?      ?? 5?      "  6    .?5?      ??  ? ??$ Calibri)?6;   ?? 5?       ? ??$ 16(?69   ?? 5?       ? ??$
 Bold"?6;   ?? 5?       ? ??$ Center=?6K   ?? 5?       ? ??
 ?   ?6;   5?       5?      ?? 5?      " ??6    .?5?      ??  ? ?? ?#17202A6;   ?? 5?       ? ??$ Calibri)?6;   ?? 5?       ? ??$ 13(?69   ?? 5?       ? ??$ Center=?6D   ?? 5?       ? ??$
 Bold"?6;   5?      5?        5?      $	 150 5?      $ Selling Price??5?       5?      ?? *ProductPiceManagment_Selling+ 5?      ?? 5?      "  6    .?5?      ??  ? ??$ Calibri)?6;   ?? 5?       ? ??$ 16(?69   ?? 5?       ? ??$
 Bold"?6;   ?? 5?       ? ??$ Center=?6K   ?? 5?       ? ??
 ?   ?6;   5?       5?      ?? 5?      " ??6    .?5?      ??  ? ?? ?#17202A6;   ?? 5?       ? ??$ Calibri)?6;   ?? 5?       ? ??$ 13(?69   ?? 5?       ? ??$ Center=?6D   ?? 5?       ? ??$
 Bold"?6;   5?      5?        5?      $	 150 5?      $
 Date??5?       5?      ?? *ProductPiceManagment_Date+ 5?      ?? 5?      "  6    .?5?      ??  ? ??$ Calibri)?6;   ?? 5?       ? ??$ 16(?69   ?? 5?       ? ??$
 Bold"?6;   ?? 5?       ? ??$ Center=?6K   ?? 5?       ? ??
 ?   ?6;   5?       5?      ?? 5?      " ??6    .?5?      ??  ? ?? ?#E74C3C6;   ?? 5?       ? ??$ Calibri)?6;   ?? 5?       ? ??$ 13(?69   ?? 5?       ? ??$ Center=?6D   ?? 5?       ? ??$
 Bold"?6;   5?      5?        5?      $	 250 5?      $ Description??5?       5?      ?? *ProductPiceManagment_Dsc+ 5?      ?? 5?      "  6    .?5?      ??  ? ??$ Calibri)?6;   ?? 5?       ? ??$ 16(?69   ?? 5?       ? ??$
 Bold"?6;   ?? 5?       ? ??$ Center=?6K   ?? 5?       ? ??
 ?   ?6;   5?       5?      ?? 5?      " ??6    .?5?      ??  ? ?? ?#17202A6;   ?? 5?       ? ??$ Calibri)?6;   ?? 5?       ? ??$ 13(?69   ?? 5?       ? ??$ Center=?6D   ?? 5?       ? ??$
 Bold"?6;   5     5       5     $	 100 5     $ Registered User??5      5     ?? *Register_User+ 5	     ?? 5
     "  6    .?5     ??  ? ??$ Calibri)?6;   ?? 5      ? ??$ 16(?69   ?? 5      ? ??$
 Bold"?6;   ?? 5      ? ??$ Center=?6K   ?? 5      ? ??
 ?   ?6;   5      5     ?? 5     " ??6    .?5     ??  ? ?? ?#17202A6;   ?? 5      ? ??$ Calibri)?6;   ?? 5      ? ??$ 13(?69   ?? 5      ? ??$ Center=?6D   ?? 5      ? ??$
 Bold"?6;   5     5     5#     ?? 5%  
   -   5        $	??133??5&     $??34??5'     $??124,525,0,0q?5(     $
??Left=?5)     $	??Top=?5*     ???	#FF2865DE???	#FF517A90$??New Product Price??5.     $
??Bold"?5/     
???????   RoundCorner#???   51     ?? 52  
   -   5        $	??137??53     $??34??54     $??325,524,0,0q?55     $
??Left=?56     $	??Top=?57     ???	#FF2865DE???	#FF517A90$??Edit Product Price??5:     $
??Bold"?5;     
???????#???   5=     63   ?? 5>  
   $	??114??5?     $??34??5@     $??518,524,0,0q?5A     $
??Left=?5B     $	??Top=?5C     ???	#FF2865DE???	#FF517A90$??Delete Product??5F     $
??Bold"?5G     
???????#???   5I     ?? 5J  
   $??
14,113,0,0q?5K     $
??Left=?5L     $	??Top=?5M     $ ??The Prices Of The Product:??5N     $??Calibri Light)?5O     $??18(?5P     $??Normal$?5Q     $
??Bold"?5R     
???   ?5S     ?? 5T  
   -	   5        $??LabelProductName??5U     $??240,113,0,0q?5V     $
??Left=?5W     $	??Top=?5X     $??.......??5Y     $??Calibri Light)?5Z     $??18(?5[     $
??Bold"?5\     
???   ?5]     5`     5a     