   M S B A M L   `   `   `  ����T  PInventoryManagementALEVEL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:InventoryManagementALEVELInventoryManagementALEVEL  5   	   7    1InventoryManagementALEVEL.AddNewItemWindowForSale   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:InventoryManagementALEVEL     5   	   -   5          � Title$  AddNewItemWindowForSale��5   	   $��224.821��6*   $	��405��6;   
������  � WindowStyle$
 None=�6a    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�6�    � 
ResizeMode$ NoResize=�6�    � 	Resources 5	      :  4System.Windows.Controls.Primitives.DatePickerTextBox �� 
TargetType �� Property �� Value��%\   '        �� 5
   
   "  6   .�5      ��  � ��$ Sell by date��6%   5      5      .��5      �� 
���   �$��1q�6!   ._�5   
   � .+�5      �� -   5        	 ��Name$	 maintitle_TextBlock��5      $(��"Add new item to the For Sale table��65   $
��Left=�6_   $	��Top=�6z   $��22(�6�   $��	Underline{�6�   $��10,1,0,0q�6�   �� 5      $
��Left=�6   $	��137��64   $��	10,35,0,0q�6A   $	��Top=�6T   $	��385��6l   .+�5      �� -   5        
 ��Name$
 ItemName_textBox��5      $��23��64   $��0,0,0,0q�6@    �� TextWrapping$
 Wrap=�6Q   $��	Item name��6e   6v   �� 5      -   5        $
 Quantity_textBox��5      $��23��64   $��0,10,0,0q�6A   $
 Wrap=�6S   $��Quantity��6g   6w   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ SellByDate_datePicker��5      $��0,10,0,0q�6<   {�.  6N   �� 5      -   5         ��Name$ Category_comboBox��5      $��0,10,0,0q�66    �� SelectedIndex$ 0��6H   6Z   5      �� 5      -   5         ��Name$ 
add_button��5      $	��Add��6)   $
��Left=�67   $��
13,195,0,0q�6R   $	��Top=�6f   $��75��6~   
������ $��0q�6�   6�   �� 5      -   5        $ reset_button��5      $��Reset��6+   $
��Left=�6;   $��108,195,0,0q�6V   $	��Top=�6k   $��75��6�   
������ $��0q�6�   6�   �� 5      -	   5        $ cancel_button��5      $��Cancel��6,   $
��Left=�6=   $��202,195,0,0q�6X   $	��Top=�6m   $��75��6�   
������ $��0q�6�   6�   5      5      5      