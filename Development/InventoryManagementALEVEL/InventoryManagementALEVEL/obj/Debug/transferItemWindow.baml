   M S B A M L   `   `   `  ����T  PInventoryManagementALEVEL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:InventoryManagementALEVELInventoryManagementALEVEL  5   	   2    ,InventoryManagementALEVEL.transferItemWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:InventoryManagementALEVEL     5   	   -   5          � Title$  Transfer Item��5   
   $��173.429��6    $	��405��61   
������  � WindowStyle$
 None=�6W    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�6�    � 
ResizeMode$ NoResize=�6�   .��5	      �� 
���   �$��1q�6!   ._�5
   
   � .+�5      �� -   5         ��Name$ maintitle_TextBlock��5      $"��Make item available for sale��65   $
��Left=�6Y   $	��Top=�6t   $��22(�6�   $��	Underline{�6�   $��10,1,0,0q�6�   �� 5      -   5         ��Name$ itemname_label��5      $��
Item name:��6,   $
��Left=�6A   $��	10,76,0,0q�6\   $	��Top=�6o   $��68��6�   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ sellbydate_datepicker��5      $
��Left=�68   $��
10,107,0,0q�6S   $	��Top=�6g   $	��383��6   �� 5      -   5        $ info_textBlock��5      $
��Left=�60   $��	10,30,0,0q�6K   $
��Wrap=�6^   $	��Top=�6r   $��46��6�   $	��383��6�   ><The following item you have selected requires a sell by date5      �� 5      -   5         ��Name$ itemname_textBox��5      	 �� 
IsReadOnly	 . $
��Left=�6B   $��23��6]   $��	78,79,0,0q�6i   
 �� TextWrapping$

 Wrap=�6|   $	��Top=�6�   $	��315��6�   �� 5      -   5         ��Name$ submit_button��5      
������ $��Submit��6F   $
��Left=�6W   $��
10,141,0,0q�6r   $	��Top=�6�   $��75��6�   6�   5      5      5      