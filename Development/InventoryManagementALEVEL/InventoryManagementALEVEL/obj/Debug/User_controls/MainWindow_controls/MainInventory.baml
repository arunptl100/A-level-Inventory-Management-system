   M S B A M L   `   `   `  ����  InventoryManagementALEVELO    IInventoryManagementALEVEL.User_controls.MainWindow_controls.MainInventory   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5
      � -   5        ��5   
   �� 5        �� ImageSource$R  L/InventoryManagementALEVEL;component/Resources/MainPageBackImageBlueOver.jpg��6    j� Stretch$ UniformToFill=�6t    � RowDefinitions 5   
   �� 5      $	��127 �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ inventory_dataGrid��5      $��Stretch=�61   $��Stretch=�6O      AutoGenerateColumns .     CanUserAddRows .     HeadersVisibility$ Column=�5   F      CanUserSortColumns .  ��. $
��Auto=�5   8   $
��Auto=�6h   $��1��6�   ��5      �� 5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   
IsReadOnly	 .  
   Header$
 	Item Name��5         Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      ��  �� Path$ ItemName�5        5       	 . $
 Category��5"      $ * 5$       5#      �� $ CategoryName�5$        5%      	 .  $
 Quantity��5'      $ * 5)       5(      �� $ Quantity�5)        5+      	 .  $
 ItemID��5-      $ * 5/         
Visibility$ Hidden=�50       5.      �� $ ItemID�50      53      � 54   
   
�������.+�55      � .+�56      � $��0q�6    � ColumnDefinitions 57      �� 58      $��80 �6+   �� 59      $	��126 �6+   �� 5:      $	��108 �6+   �� 5;      $	��766 �6+    5=      �� 5>      $��32 �6(   �� 5?      $��26 �6(   �� 5@      $��41 �6(   �� 5A      $��23 �6(   .+�5C      �� -   5         ��Name$ maintitle_TextBlock��5C       $!��Inventory management system��6=   $��Stretch=�6`   $��Stretch=�6~   $��Italic$�6�   $��22(�6�   $��	Underline{�6�   $��0��6�   $��4��6�   �� 5D      -   5        $ subtitle_TextBlock��5D       $��Inventory table��6<   $��Stretch=�6S   $��Stretch=�6q   $��Italic$�6�   $��19(�6�   $��	Underline{�6�   $��1��6�   $��2��6�   �� 5E      -   5         ��Name$ 
add_button��5E      $��Add new item��61   $��2,3,0,0q�6I   $	��Top=�6Z   $
��Left=�6r   
������ $��0q�6�   $��3��6�   $��0��6�   $��18��6�   $��76��6�   �� 5F      -   5        $ delete_button��5F      $��Delete selected item(s)��64   $��2,3,0,0q�6V   $	��Top=�6g   $
��Left=�6   
������ $��0q�6�   $��3��6�   $��1��6�   $��18��6  $	��122��6  �� 5G      -   5        $ submit_changes_button��5G      $��Submit changes��6<   $��2,3,0,0q�6V   $	��Top=�6g   $
��Left=�6   
������ $��0q�6�   $��3��6�   $��2��6�   $��18��6	  $	��103��6  �� 5H      -   5        $ transferitems_button��5H      $��Transfer selected items��6;   $��2,3,0,0q�6^   $	��Top=�6o   $
��Left=�6�   
������ $��0q�6�   $��3��6�   $��3��6�   $��18��6�   $	��123��6�   6  �� 5I      -	   5         ��Name$ editmode_label��5I      $�� ��64   $
��Left=�6?   $��1,16,0,0q�6Z   $	��Top=�6l   $��87��6�   $��9(�6�   $��23��6�   $��Italic$�6�   
���  ��$��2��6�   $��2��6�   5J      � 5K      $��	336,0,0,0q�6   $��Stretch=�6*   $��Stretch=�6F   .+�5L      �� -
   5        $ filter_title_label��5L       $��
Filter by:��6<   $
��Left=�6N   $	��Top=�6i   $��58��6�   $��12(�6�   $��23��6�   $��Italic$�6�   $��	Underline{�6�   $��	13,13,0,0q�6�   �� 5M      -   5         ��Name$ category_comboBox��5M      $
��Left=�6:   $��
131,26,0,0q�6U   $	��Top=�6i   $	��107��6�   �� 5N      -   5        $ category_label��5N      $��Category��64   $
��Left=�6G   $��	76,26,0,0q�6b   $	��Top=�6u   $��63��6�   �� 5O      -   5        $ item_name_label��5O      $��
Item order��65   $
��Left=�6J   $��
238,26,0,0q�6e   $	��Top=�6y   $��77��6�   �� 5P      -   5        $ quantity_label��5P      $��Quantity��64   $
��Left=�6G   $��	76,61,0,0q�6b   $	��Top=�6u   $��77��6�   �� 5Q      -   5        $ item_order_comboBox��5Q      $
��Left=�6<   $��
305,26,0,0q�6W   $	��Top=�6k   $	��107��6�   �� 5R      -   5        $ quantity_comboBox��5R      $
��Left=�6:   $��
131,61,0,0q�6U   $	��Top=�6j   $	��107��6�   �� 5S      -   5        $ reset_button��5S      $��Reset��63   $
��Left=�6C   $��108,105,0,0q�6^   $	��Top=�6s   $��61��6�   
������ $��0q�6�   6�   �� 5T      -   5        $ 
name_label��5T      $
��Name��60   $
��Left=�6?   $��
238,61,0,0q�6Z   $	��Top=�6n   $��77��6�   �� 5U      -   5         ��Name$ name_textBox��5U      $
��Left=�64   $��23��6O   $��
305,61,0,0q�6[    �� TextWrapping$
 Wrap=�6o   $	��Top=�6�   $	��107��6�   5V      5W      5X      5Y      5Z      