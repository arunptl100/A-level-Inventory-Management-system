   M S B A M L   `   `   `  ����  InventoryManagementALEVELM    GInventoryManagementALEVEL.User_controls.MainWindow_controls.MainForSale   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5
      � -   5        ��5   
   �� 5        �� ImageSource$R  L/InventoryManagementALEVEL;component/Resources/MainPageBackImageBlueOver.jpg��6    j� Stretch$ UniformToFill=�6t    � RowDefinitions 5   
   �� 5      $	��127 �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ for_sale_dataGrid��5      $��Stretch=�6/   $��Stretch=�6M      AutoGenerateColumns .     CanUserAddRows .     HeadersVisibility$ Column=�6�      CanUserSortColumns .  ��. $
��Auto=�6�   $
��Auto=�6'  $��1��6Y  ��5      �� 5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   
IsReadOnly	 .  
   Header$
 	Item Name��5         Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      ��  �� Path$ ItemName�5        5      	 . $
 Category��5       $ * 5"       5!      �� $ CategoryName�5"        5#      	 .  $
 Quantity��5%      $ * 5'       5&      �� $ Quantity�5'        5)      	 .  $
 Sell by date��5+      $ * 5-       5,      �� $ 
SellByDate� �� StringFormat$ {0:dd/MM/yy}��5-        5/      	 .  $
 ItemID��51      $ * 53         
Visibility$ Hidden=�54       52      �� $ ItemID�54      57      � 58   
   
�������.+�59      � .+�5:      � $��0q�6    � ColumnDefinitions 5;      �� 5<      $��80 �6+   �� 5=      $	��126 �6+   �� 5>      $	��108 �6+   �� 5?      $	��108 �6+   �� 5@       5B      �� 5C      $��32 �6(   �� 5D      $��26 �6(   �� 5E      $��41 �6(   �� 5F      $��23 �6(   .+�5H      �� -   5         ��Name$ maintitle_TextBlock��5H       $!��Inventory management system��6=   $��Stretch=�6`   $��Stretch=�6~   $��Italic$�6�   $��22(�6�   $��	Underline{�6�   $��0��6�   $��5��6�   �� 5I      -   5        $ subtitle_TextBlock��5I       $��For sale table��6<   $��Stretch=�6R   $��Stretch=�6p   $��Italic$�6�   $��19(�6�   $��	Underline{�6�   $��1��6�   $��2��6�   �� 5J      -   5         ��Name$ 
add_button��5J      $��Add new item��61   $��2,3,0,0q�6I   $	��Top=�6Z   $
��Left=�6r   
������ $��0q�6�   $��3��6�   $��0��6�   $��18��6�   $��76��6�   6�   �� 5K      -   5        $ delete_button��5K      $��Delete selected item(s)��64   $��2,3,0,0q�6V   $	��Top=�6g   $
��Left=�6   
������ $��0q�6�   $��3��6�   $��1��6�   $��18��6�   $	��122��6�   6�   �� 5L      -   5        $ submit_changes_button��5L      $��Submit changes��6<   $��2,3,0,0q�6V   $	��Top=�6g   $
��Left=�6   
������ $��0q�6�   $��3��6�   $��2��6�   $��18��6�   $	��103��6�   6�   �� 5M      -   5        $ reset_button��5M      $��Reset��63   $��2,3,0,0q�6D   $
��Left=�6U   $	��Top=�6q   $��18��6�   $��61��6�   
������ $��0q�6�   $��3��6�   $��4��6�   �� 5N      -	   5         ��Name$ editmode_label��5N      $�� ��64   $
��Left=�6?   $��1,16,0,0q�6Z   $	��Top=�6l   $��87��6�   $��9(�6�   $��23��6�   $��Italic$�6�   
���  ��$��2��6�   $��2��6�   5O      � 5P      $��	336,0,0,0q�6   $��Stretch=�6*   $��Stretch=�6F   .+�5Q      �� -
   5        $ filter_title_label��5Q       $��
Filter by:��6<   $
��Left=�6N   $	��Top=�6i   $��58��6�   $��12(�6�   $��23��6�   $��Italic$�6�   $��	Underline{�6�   $��	13,13,0,0q�6�   �� 5R      -   5         ��Name$ category_comboBox��5R      $
��Left=�6:   $��
131,26,0,0q�6U   $	��Top=�6i   $	��107��6�   �� 5S      -   5        $ category_label��5S      $��Category��64   $
��Left=�6G   $��	76,26,0,0q�6b   $	��Top=�6u   $��63��6�   �� 5T      -   5        $ item_name_label��5T      $��
Item order��65   $
��Left=�6J   $��
238,26,0,0q�6e   $	��Top=�6y   $��77��6�   �� 5U      -   5        $ quantity_label��5U      $��Quantity��64   $
��Left=�6G   $��	76,61,0,0q�6b   $	��Top=�6u   $��77��6�   �� 5V      -   5        $ item_order_comboBox��5V      $
��Left=�6<   $��
305,26,0,0q�6W   $	��Top=�6k   $	��107��6�   �� 5W      -   5        $ quantity_comboBox��5W      $
��Left=�6:   $��
131,61,0,0q�6U   $	��Top=�6j   $	��107��6�   �� 5Y      -   5        $ 
name_label��5Y      $
��Name��60   $
��Left=�6?   $��
238,61,0,0q�6Z   $	��Top=�6n   $��77��6�   �� 5Z      -   5         ��Name$ name_textBox��5Z      $
��Left=�64   $��23��6O   $��
305,61,0,0q�6[    �� TextWrapping$
 Wrap=�6o   $	��Top=�6�   $	��107��6�   5[      5\      5]      5^      5_      