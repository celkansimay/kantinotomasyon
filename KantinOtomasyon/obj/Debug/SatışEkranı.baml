   M S B A M L   `   `   `  ����J  FKantinOtomasyon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:KantinOtomasyonKantinOtomasyon  5   	   $    KantinOtomasyon.SatışEkranı   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:KantinOtomasyon     5   	     � Title$  SatışEkranı��5   	   $��605.401��6   $��794.389��6.   .��5	      � $��0,0,-142,-75q�6   .+�5
   
   �� $��Ürün Satış Ekranı��6   $
��Left=�6,   $��	26,10,0,0q�6G   $	��Top=�6Z   $	��136��6r   �� 5   
   $��Ürün Barkod No��6   $
��Left=�6)   $��	26,68,0,0q�6D   $	��Top=�6W   $	��136��6o   �� 5   
   -   5        $��
txtBarcode��5      $
��Left=�6$   $��23��6?   $��
142,72,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��190��6�   6�   �� 5   
   $
��Ekle��6   $
��Left=�6    $��
352,74,0,0q�6;   $	��Top=�6O   $��75��6g   &   System.Windows.Controls.DataGrid  5   
   -   5        $
��Left=�5      $��26,109,0,225q�6.   $	��727��6D      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Barkod No��6K      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ Manufacturer�6^     5      $ Marka��6C   $
 Auto 6R    6%   �� $
 Name�6R     5      $ Ürün Adı��6F   $
 Auto 6X    6%   �� $ Barcode�6X     5      $
 Adet��6D   $
 Auto 6R    6%   �� $ Price�6R     5      $ Fiyat��6D   $
 Auto 6S    6%   �� $ Price�6S   5      �� 5   
   $��Kart Numarası��6   $
��Left=�6(   $��
26,433,0,0q�6C   $	��Top=�6W   $	��136��6o   �� 5   
   -   5        $��txtCardNumber��5      $
��Left=�6'   $��23��6B   $��142,433,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��190��6�   6�   �� 5   
   $��Toplam Fiyat��6   $
��Left=�6'   $��508,429,0,0q�6B   $	��Top=�6W   $	��136��6o   �� 5   
   -   5        $��Satışı Gerçekleştir��5      $
��Left=�6/   $��
26,488,0,0q�6J   $	��Top=�6^   $	��113��6v   $��43��6�   6�   �� 5   
   -   5        $��Temizle��5      $
��Left=�6#   $��314,488,0,0q�6>   $	��Top=�6S   $	��113��6k   $��43��6w   6�   �� 5   
   $��Kapat��6   $
��Left=�6!   $��577,488,0,0q�6<   $	��Top=�6Q   $	��113��6i   $��43��6u   �� 5   
   -   5        $��lblTotalPrice��5      $�� ��6S   $
��Left=�6^   $��652,429,0,0q�6y   $	��Top=�6�    J� RenderTransformOrigin$ 1.185,0.138&�6�    �� Target 6%   �� 	 �� ElementName$	 lblTotalPrice��6�   5      5      