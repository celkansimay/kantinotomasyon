   M S B A M L   `   `   `  ����J  FKantinOtomasyon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:KantinOtomasyonKantinOtomasyon  5   	       KantinOtomasyon.Ürünler   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:KantinOtomasyon     5   	     � Title$  	Ürünler��5   	   $	��450��6   $	��800��6&   .��5	      � .+�5
   
   �� $��	Ürünler��6   $
��Left=�6"   $��	25,24,0,0q�6=   $	��Top=�6P   $	��118��6h   � 5   
   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��
dgProducts��5      $
��Left=�6)   $	��315��6D   $��	23,75,0,0q�6Q   $	��Top=�6d   $	��740��6|      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Üretici��6O      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6`   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   ��  �� Path$ Manufacturer�6`     5      $ Ürün Adı��6G   $
 Auto 6Y    6)   �� $
 Name�6Y     5      $ Barkod��6J   $
 Auto 6Z    6)   �� $ Barcode�6Z     5      $ Fiyat��6H   $
 Auto 6W    6)   �� $ Price�6W   5      5      �� 5   
   -   5        $��Ürün Ekle��5      $
��Left=�6%   $��
654,30,0,0q�6@   $	��Top=�6T   $	��112��6l   6x   5!      5"      