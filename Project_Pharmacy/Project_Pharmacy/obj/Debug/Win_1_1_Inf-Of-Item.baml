   M S B A M L   `   `   `  ����K  GProject_Pharmacy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Project_PharmacyProject_Pharmacy  5   	   *    $Project_Pharmacy.Win_1_1_Inf_Of_Item   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Project_Pharmacy     5   	   -   5          � Title$0  *Информация о предметах��5   	   $��450.229��6(   $��412.214��69   .��5	      � 
�������$��0,0,2,1q�6%    � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   .+�5   
   �� -   5        $��Поиск по ID��5      $
��Left=�6)   $	��Top=�6D    d� 	IsChecked$ FalseY�6\   $��1��6�   $��10,5,0,0q�6�   $��15��6�   $��86��6�   �� 5   
   -   5        $;��5Поиск по наименованию товара��5      $
��Left=�6:   $��10,4,0,0q�6U   $	��Top=�6g   $ FalseY�6   $��2��6�   $��15��6�   $	��200��6�   �� 5   
   -   5         ��Name$ SearchTextId��5   0    �� TextWrapping$ NoWrap=�6   $�� ��6(   $��1��6F   $��
27,25,56,6q�6S   $	��300��6g   $��15��6s   �� 5   
   -   5        $��
Назад��5      
�������$��Right=�64   $	��Top=�6P   $	��105��6h   $��40��6t   $��Times New Roman)�6�   $��20(�6�   $��3��6�   $��	0,10,-7,0q�6�   ��5      
� 5      .��5      �  � Color$ 	#FF6DE82C��6#    � Offset$ 0Q�65   � 5      $ 	#FF9AEB6F��6#   $ 1Q�65   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Suppl��5   �   	   AutoGenerateColumns	 . $��Center=�6.   $	��221��6K   $��	10,10,0,0q�6X   $��Center=�6k   $	��372��6�   5      �� 5    
   -   5        $��Обновить��5       
�������$
��Left=�67   $	��Top=�6R   $	��104��6j   $��40��6v   $��Times New Roman)�6�   $��20(�6�   $��3��6�   $��	10,10,0,0q�6�   
 J� RenderTransformOrigin$
 -0.977,0.317&�6�   ��5!      
� 5"      .��5#      � $ 	#FF6DE82C��6#   $ 0Q�65   � 5$      $ 	#FF9AEB6F��6#   $ 1Q�65   5%      5'      �� 5(   
   -   5        $ SearchTextName��5(   D   $ NoWrap=�6   $�� ��6(   $��
28,19,56,7q�60   $��2��6\   $��15��6i   $	��300��6u   5)      5*      