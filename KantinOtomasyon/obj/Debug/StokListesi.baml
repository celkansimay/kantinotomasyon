   M S B A M L   `   `   `  ����J  FKantinOtomasyon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:KantinOtomasyonKantinOtomasyon  5   	   !    KantinOtomasyon.StokListesi   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:KantinOtomasyon     5   	     � Title$  StokListesi��5   	   $��549.59��6   $	��800��6-   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridView1��5
      $
��Left=�6*   $	��303��6E   $��	23,26,0,0q�6R   $	��Top=�6e   $	��748��6}      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Ürün Adı��6K      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ Manufacturer�6]     5      $ Üretici��6C   $
 Auto 6T    6%   �� $
 Name�6T     5      $ Barkod��6F   $
 Auto 6V    6%   �� $ Barcode�6V     5      $ Fiyat��6D   $
 Auto 6S    6%   �� $ Price�6S     5      $ Stok Sayısı��6I   $
 Auto 6^    6%   �� $ 
StockCount�6^     5      $ Toplam Maliyet��6K   $
 Auto 6c    6%   �� $ TotalMaliyet�6c     5      $ Toplam Gelir��6I   $
 Auto 6_    6%   �� $ 
TotalGelir�6_     5      $ Toplam Öngörülen Kar��6Q   $
 Auto 6o    6%   �� $ ToplamOngorulenKar�6o   5      �� 5   
   $��Toplam Maliyet��6   $
��Left=�6)   $��464,362,0,0q�6D   $	��Top=�6Y   �� 5   
   $��Toplam Gelir��6   $
��Left=�6'   $��464,393,0,0q�6B   $	��Top=�6W   $��91��6o   �� 5   
   $��Raftaki Ürün Toplamı��6   $
��Left=�6/   $��464,424,0,0q�6J   $	��Top=�6_   $	��126��6w   �� 5   
   $��
Toplam Kar��6   $
��Left=�6%   $��464,455,0,0q�6@   $	��Top=�6U   $��91��6m   �� 5   
   -   5        $��txtToplamMaliyet��5      $��Label��6)   $
��Left=�69   $��595,362,0,0q�6T   $	��Top=�6i   �� 5   
   -   5        $��txtToplamGelir��5      $��Label��6&   $
��Left=�66   $��595,393,0,0q�6Q   $	��Top=�6f   �� 5   
   -   5        $��txtRaftakiUrunTop��5      $��Label��6)   $
��Left=�69   $��595,424,0,0q�6T   $	��Top=�6i   �� 5   
   -   5        $��txtToplamKar��5      $��Label��6$   $
��Left=�64   $��595,463,0,0q�6O   $	��Top=�6d   5       5!      