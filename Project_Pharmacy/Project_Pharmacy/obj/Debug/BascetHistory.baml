   M S B A M L   `   `   `  ����K  GProject_Pharmacy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Project_PharmacyProject_Pharmacy  5   	   $    Project_Pharmacy.BuscetHistory   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Project_Pharmacy     5   	   -   5          � Title$  BuscetHistory��5   	   $	��461��6   $	��800��6,   .��5	      � 
�������$��0,0,2,-2q�6%    � ColumnDefinitions 5
   
   �� 5      $
��159* �6   �� 5      $
��631* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ Suppl��5   �      AutoGenerateColumns . $��Center=�6.   $	��235��6K   $��44,24,59,173q�6X   $��Center=�6n   $	��687��6�   $��2��6�   �� 5   
   -   5        $%��Поиск по ID товара��5      $
��Left=�60   $	��Top=�6K    d� 	IsChecked$ FalseY�6c   $��
44,264,0,0q�6�   $��14��6�   $	��129��6�   $��2��6�   �� 5   
   -   5        $;��5Поиск по наименованию товара��5      $
��Left=�6:   $��
44,310,0,0q�6U   $	��Top=�6i   $ FalseY�6�   $��15��6�   $	��200��6�   $��2��6�    J� RenderTransformOrigin$ 	0.505,1.4&�6�   �� 5   
   -   5         ��Name$ SearchTextId��5   0    �� TextWrapping$ NoWrap=�6   $�� ��6(   $��62,283,445,127q�6F   $��2��6^   �� 5   
   -   5        $ SearchTextName��5   G   $ NoWrap=�6   $�� ��6(   $��62,330,445,82q�60   $��2��6_   �� 5   
   -   5        $%��Поиск по Id Заказа��5      $
��Left=�60   $��
44,355,0,0q�6K   $	��Top=�6_   $ FalseY�6w   $��15��6�   $	��200��6�   $��2��6�   �� 5   
   -   5        $ SearchTextIdOrd��5   G   $ NoWrap=�6   $�� ��6(   $��62,375,445,35q�60   $��2��6`   �� 5   
   -	   5        $��
Назад��5      
�������$
��Left=�64   $��489.941,365,0,0q�6O   $	��Top=�6h   $	��131��6�   $��46��6�   $��Times New Roman)�6�   $��20(�6�   $��1��6�   ��5      
� 5      .��5      �  � Color$ 	#FF6DE82C��6#   	 � Offset$	 0Q�65   � 5      $ 	#FF9AEB6F��6#   $	 1Q�65   5      5      �� 5   
   -
   5        $��Обновить��5      
�������$
��Left=�67   $��262,304,0,0q�6R   $	��Top=�6g   $	��131��6   $��46��6�   $��Times New Roman)�6�   $��20(�6�   $��1��6�   ��5      
� 5      .��5       � $ 	#FF6DE82C��6#   $	 0Q�65   � 5!      $ 	#FF9AEB6F��6#   $	 1Q�65   5"      5$      5%      5&      