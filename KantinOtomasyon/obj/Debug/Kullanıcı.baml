   M S B A M L   `   `   `  ����J  FKantinOtomasyon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:KantinOtomasyonKantinOtomasyon  5   	   !    KantinOtomasyon.Kullanıcı   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:KantinOtomasyon     5   	     � Title$  Kullanıcı��5   	   $	��450��6   $	��800��6(   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��grdusers��5
      $
��Left=�6#   $	��351��6>   $��	48,34,0,0q�6K   $	��Top=�6^   $	��708��6v      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Adı��6C      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$
 Name�6P     5      $ Soyadı��6F   $
 Auto 6V    6%   �� $ Surname�6V     5      $ Kullanıcı Adı��6G   $
 Auto 6^    6%   �� $ UserName�6^     5      $ Kart Numarası��6I   $
 Auto 6`    6%   �� $ 
CardNumber�6`     5      $ Kayıt Tarihi��6I   $
 Auto 6_    6%   �� $ 
InsertDate�6_     5      $ Kullanıcı Tipi��6G   $
 Auto 6_    6%   �� $ AuthType�6_   5      5      5      