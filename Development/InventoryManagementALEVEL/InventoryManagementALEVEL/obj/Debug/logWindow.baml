   M S B A M L   `   `   `  ����T  PInventoryManagementALEVEL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:InventoryManagementALEVELInventoryManagementALEVEL  5   	   )    #InventoryManagementALEVEL.logWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:InventoryManagementALEVEL     5   	   -   5          � Title$	  Log��5      $	��400��6   $	��550��6   
������  � WindowStyle$
 None=�6E    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ CanResizeWithGrip=�6/    � 	Resources 5
      :  4System.Windows.Controls.Primitives.DatePickerTextBox �� 
TargetType �� Property �� Value��%�   '        �� 5   
   "  6   .�5      ��  � ��$* $Show log entries after selected date��6%   �� 5       �@��
IsReadOnly . 6+   5      5      .��5      �� 
���   �$��1q�6!   ._�5   
   � 	 � ColumnDefinitions	 5      �� 5      $��7 �6#   �� 5      $
��509* �6#   �� 5      $��25 �6#   �� 5      $��7 �6#   
 � RowDefinitions
 5      �� 5      $��20.186 �6    �� 5      $��22.814 �6    �� 5      $
��441* �6    �� 5      $��11 �6    .+�5      �� -   5         ��Name$ maintitle_TextBlock��5      $��
Action log��65   $
��Left=�6G   $	��Top=�6b   $��22(�6{   $��	Underline{�6�   $��3,1,0,0q�6�   $��1��6�   $��2��6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ log_dataGrid��5      $��Stretch=�6-   $��Stretch=�6L   $��2��6i   $��1��6v   $��3,27,2,0q�6�      AutoGenerateColumns .     CanUserAddRows .     HeadersVisibility$ Column=�5    J      CanUserSortColumns .     
IsReadOnly . ��. $
��Auto=�5!   8   $
��Auto=�6h   $��2��6�      Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .     Header$ Action��5%         Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5'      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5&      ��  �� Path$ Action�5'        5)       .  $ 
First name��5+      $ * 5-       5,      �� $ 	FirstName�5-        5/       .  $ Date of action��51      $ * 53       52      �� $ TimeOfAction� �� StringFormat$ {0:dd/MM/yy}��53      58      (  "System.Windows.Controls.DatePicker  59      -   5          Name$ log_DatePicker��59      $��1��61   $��Stretch=�6A   $��3,2,1,0q�6_   $	��Top=�6q   $��2��6�   $��2��6�   �� 5:      -   5         ��Name$ close_button��5:      $��X��6+   $��Stretch=�68   $��Stretch=�6V   
������ $��0q�6�   $��0��6�   $��2��6�   $��24��6�   6�   5<      5=      5>      