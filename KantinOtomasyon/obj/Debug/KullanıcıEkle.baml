   M S B A M L   `   `   `  ����J  FKantinOtomasyon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:KantinOtomasyonKantinOtomasyon  5   	   %    KantinOtomasyon.KullanıcıEkle   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:KantinOtomasyon     5   	     � Title$  KullanıcıEkle��5   	   $	��450��6   $��954.496��6,   .��5	      � .+�5
   
   �� $��Kullanıcı Ekle��6   $��20(�6)   $
��Left=�67   $��	41,10,0,0q�6R   $	��Top=�6e   $	��170��6}   $��32��6�   �� 5   
   $
��Adı��6   $
��Left=�6   $��	41,74,0,0q�69   $	��Top=�6L   $��82��6d   �� 5   
   $��Soyadı��6   $
��Left=�6!   $��
41,105,0,0q�6<   $	��Top=�6P   $��82��6h   �� 5   
   $��Kullanıcı Adı��6   $
��Left=�6(   $��
41,131,0,0q�6C   $	��Top=�6W   $��82��6o   �� 5   
   $��Kart Numarası��6   $
��Left=�6(   $��
41,162,0,0q�6C   $	��Top=�6W   $��99��6o   �� 5   
   $��Şifre��6   $
��Left=�6    $��
41,193,0,0q�6;   $	��Top=�6O   $��82��6g   �� 5   
   $��Kullanıcı Tipi��6   $
��Left=�6)   $��
41,224,0,0q�6D   $	��Top=�6X   $��82��6p   �� 5   
   -   5        $��txtName��5      $
��Left=�6!   $��23��6<   $��
158,78,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $	��120��6�   �� 5   
   -   5        $��
txtSurname��5      $
��Left=�6$   $��23��6?   $��158,109,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   -   5        $��txtUserName��5      $
��Left=�6%   $��23��6@   $��158,137,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $��txtCardNumber��5      $
��Left=�6'   $��23��6B   $��158,166,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5   
   -   5        $��txtPassword��5      $
��Left=�6%   $��23��6@   $��158,197,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5         ��Name$ 
cbUserType��5      $
��Left=�6'   $��158,228,0,0q�6B   $	��Top=�6W   $	��120��6o   .@�5      �� -   5        $��	Öğrenci��5      $
��Left=�6-   $	��118��6H   6T   �� 5      $��
Öğretmen��6   $
��Left=�6.   $	��118��6I   �� 5      $��İdari��6   $
��Left=�6+   $	��118��6F   �� 5      $��Diğer��6   $
��Left=�6+   $	��118��6F   5      �� 5   
   -   5        $��Kaydet��5      $
��Left=�6"   $��158,269,0,0q�6=   $	��Top=�6R   $	��120��6j   6v   &   System.Windows.Controls.DataGrid  5   
   -	   5          Name$ dataGridView1��5      $
��Left=�6*   $	��318��6E   $��
318,74,0,0q�6R   $	��Top=�6f   $	��601��6~      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Adı��6C      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$
 Name�6P     5       $ Soyadı��6F   $
 Auto 6V    6%   �� $ Surname�6V     5!      $ 	Sınıfı��6O   $
 Auto 6_    6%   �� $ AcademicYearName�6_     5"      $ 	Veli Adı��6I   $
 Auto 6[    6%   �� $ 
ParentName�6[     5#      $ 	Okul Adı��6I   $
 Auto 6[    6%   �� $ 
SchoolName�6[   5%      5'      5(      