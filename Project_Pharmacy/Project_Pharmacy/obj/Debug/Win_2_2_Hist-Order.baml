   M S B A M L   `   `   `  ����K  GProject_Pharmacy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Project_PharmacyProject_Pharmacy  5   	   )    #Project_Pharmacy.Win_2_2_Hist_Order   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Project_Pharmacy     5   	   -   5          � Title$  История��5   	   $	��400��6   $	��400��6&   .��5	      � 
�������.+�5
   
   �� -   5        $-��'Поиск по ID покупателя��5
      $
��Left=�64   $��
14,227,0,0q�6�   $	��Top=�6�    J� RenderTransformOrigin$ 0.277,1.219&�6�   �� 5   
   -   5        $)��#Поиск по Id продавца��5      $
��Left=�6q   $��
14,269,0,0q�6�   $	��Top=�6�   �� 5   
   -   5         ��Name$ SearchTextName��5   -   $
��Left=�6   $��16��6E   $��
14,289,0,0q�6Q    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��294��6�   $��Times New Roman)�6�   �� 5   
   -   5        $��Поиск по дате��5      $
��Left=�6+   $��
10,248,0,0q�6F   $	��Top=�6�   �� 5   
   -   5        $��
Назад��5      
�������$
��Left=�64   $��278,319,0,0q�6O   $	��Top=�6d   $	��104��6|   $��40��6�   $��Times New Roman)�6�   $��20(�6�   ��5      
� 5      .��5      �  � Color$ 	#FF6DE82C��6#    � Offset$ 0Q�65   � 5      $ 	#FF9AEB6F��6#   $ 1Q�65   5      5      �� 5   
   -   5        $�� ��5      $
��Left=�6   $��152,310,0,0q�67   $	��Top=�6L   $��89��6d   $��49��6o   ��5      �� 5       �� ImageSource$ ShoppingCart.png��6   5      �� 5   
   -   5        $��Обновить��5      
�������$
��Left=�67   $	��Top=�6i   $	��104��6�   $��40��6�   $��Times New Roman)�6�   $��20(�6�   $��
10,319,0,0q�6�   $ -0.977,0.317&�6�   ��5      
� 5      .��5      � $ 	#FF6DE82C��6#   $ 0Q�65   � 5      $ 	#FF9AEB6F��6#   $ 1Q�65   5       5"      �� 5#   
   -	   5        $ SearchTextDate��5#   -   $
��Left=�6   $��16��6E   $��113,248,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��261��6�   $��Times New Roman)�6�   �� 5$   
   -
   5        $ SearchTextId��5$   -   $
��Left=�6   $��16��6C   $��171,227,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��203��6�   $��Times New Roman)�6�   &   System.Windows.Controls.DataGrid  5%   
   -   5          Name$ Suppl��5%   �      AutoGenerateColumns . $��Center=�6.   $	��212��6K   $��10,10,10,147q�6X   $��Center=�6n   $	��372��6�   6�   5&      5'      