   M S B A M L   `   `   `  ����  InventoryManagementALEVELQ    KInventoryManagementALEVEL.User_controls.MainWindow_controls.MainPerformance   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      $��9 �6   �� 5      $
��607* �6   �� 5      $��9 �6    � RowDefinitions 5   
   �� 5      $��75 �6   �� 5      $��15 �6   �� 5      $	��173 �6   �� 5      $��15 �6   �� 5      $	��173 �6   �� 5      $��15 �6   �� 5      $	��173 �6   �� 5      ��5   
   �� 5       �� ImageSource$R L/InventoryManagementALEVEL;component/Resources/MainPageBackImageBlueOver.jpg��6    j� Stretch$ UniformToFill=�6t   .+�5   
   � 
�������$��3��6"   $��0��66   $��Stretch=�6C   $��Stretch=�6_    5      �� 5      $��30 �6    �� 5      $��32 �6    �� 5       .+�5"      �� -   5         ��Name$ maintitle_TextBlock��5"      $!��Inventory management system��65   $��Italic$�6Y   $��22(�6l   $��	Underline{�6z   $��0��6�   �� 5#      -   5        $ subtitle_TextBlock��5#      $��Performance Analysis��64   $��Italic$�6Q   $��19(�6d   $��	Underline{�6r   $��1��6�   5$      � 5%   
   $��1,2,0,0q�6   $��Stretch=�6    $��Stretch=�6<   
�������$��2��6m   $��1��6z     5&      �� 5'      $
��238* �6#   �� 5(      $	��53* �6#   �� 5)      $	��12* �6#    5+      �� 5,      $��25 �6    �� 5-      $
��124* �6    .+�5/      �� 
���   �$��1q�6)   $��2��6=   $��3��6N   �� 50      -   5        $  maintitleTopFive_TextBlock��50      $*��$Top five performing items this month��6<   $��Italic$�6i   $��17(�6|   $��	Underline{�6�   $��0��6�   $��3,0,-3,0q�6�   $��3��6�   &   System.Windows.Controls.DataGrid  51      -   5          Name$ TopFive_dataGrid��51      $��Stretch=�61   $��Stretch=�6O      AutoGenerateColumns .     CanUserAddRows .     HeadersVisibility$ Column=�52   F   	   CanUserSortColumns	 .  ��. $
��Auto=�53   8   $
��Auto=�6h   $��1��6�   $��3��6�   
   Columns
 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ 	Item Name��57         Width5  /System.Windows.Controls.DataGridLengthConverter$ * 59      1  +System.Windows.Controls.DataGridBoundColumn   Binding 58      ��  �� Path$ ItemName�59        5;       . $ 	Transfers��5=      $ * 5?       5>      �� $ 	Transfers�5?      5B      �� 5C      -   5         ��Name$ topfive_refresh_button��5C      $��Refresh��65   $��Stretch=�6G   $��0��6f   $��1��6s   $��0q�6�   
������ $��Center=�6�   6�   5D      � 5F   
   $��1,2,0,0q�6   $��Stretch=�6    $��Stretch=�6<   
�������$��4��6m   $��1��6z     5G      �� 5H      $
��238* �6#   �� 5I      $	��53* �6#   �� 5J      $	��12* �6#    5L      �� 5M      $��25 �6    �� 5N      $
��124* �6    .+�5P      �� 
���   �$��1q�6)   $��2��6=   $��3��6N   �� 5Q      -   5        $% maintitleTopFiveWorst_TextBlock��5Q      $,��&Worst five performing items this month��6A   $��Italic$�6p   $��17(�6�   $��	Underline{�6�   $��0��6�   $��3,0,-3,0q�6�   $��3��6�   �� 5R      -   5        $! topfiveworst_refresh_button��5R      $��Refresh��6:   $��Stretch=�6L   $��0��6k   $��1��6x   $��0q�6�   
������ $��Center=�6�   6�     5S      -   5        $ TopFiveWorst_dataGrid��5S      $��Stretch=�66   $��Stretch=�6T    .   .  $ Column=�5T   F   	 .  ��. $
��Auto=�5U   8   $
��Auto=�6h   $��1��6�   $��3��6�   
 5V        5W       . $ 	Item Name��5Y      $ * 5[       5Z      �� $ ItemName�5[        5]       . $ 	Transfers��5_      $ * 5a       5`      �� $ 	Transfers�5a      5d      5f      � 5g   
   $��1��6   $��6��6    $��Stretch=�6-   
�������$��Stretch=�6\     5h      �� 5i      $	��232 �6#   �� 5j      $	��125 �6#   �� 5k      $	��125 �6#   �� 5l      $
��125* �6#   �� 5m      $��5 �6#    5o      �� 5p      $��25 �6    �� 5q      $	��25* �6    �� 5r      $
��118* �6    �� 5s      $��5* �6    .+�5u      �� 
���   �$��1q�6)   $��4��6=   $��5��6N   5x      �� 5y      -	   5        $% maintitlePerfAnalysis_TextBlock��5y      $��Performance Analysis��6A   $��Italic$�6^   $��17(�6q   $��	Underline{�6   $��0��6�   $��3,0,-3,0q�6�   $��5��6�   �� 5z      -
   5         ��Name$ search_textBox��5z       �� TextWrapping$
 Wrap=�6.   $��Enter Item Name��6B   $��4,0,71,0q�6Y   $��1��6k   6x   �� 5{      -   5        $ submit_search_button��5{      $��Search��63   $��Stretch=�6D   $��1��6c   $��0q�6p   
������ $��Center=�6�   $��	166,5,2,2q�6�   6�     5}      -   5        $ SearchResults_dataGrid��5}      $��Stretch=�67   $��Stretch=�6U    .   .  $ Column=�5~   F   	 .  ��. $
��Auto=�5   8   $
��Auto=�6h   $��2��6�   $��4,5,2,5q�6�   
 5�        5�       . $ 	Item Name��5�      $ * 5�       5�      �� $ ItemName�5�      5�      �� 5�      -   5        $ generate_graph_button��5�      {�.  $��Generate Graph��6G   $��Stretch=�6`   $��1��6   $��0q�6�   
������ $��Center=�6�   $��5,4,4,3q�6�   $��2��6�   6�   �� 5�      -   5        $ selectItem_button��5�      $��Select Item��60   $��Stretch=�6F   $��1��6e   $��0q�6r   
������ $��Center=�6�   $��7,5,4,2q�6�   $��1��6�   6�   �� 5�      -   5        $ report_textBox��5�      
���   �$��Stretch=�6B   $��Stretch=�6`   $
 Wrap=�6|   $��3��6�   $��1��6�   $��2��6�   $��7,0,0,0q�6�   5�      5�      5�      