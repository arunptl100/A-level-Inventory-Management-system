   M S B A M L   `   `   `  ����T  PInventoryManagementALEVEL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:InventoryManagementALEVELInventoryManagementALEVEL  5   	   *    $InventoryManagementALEVEL.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:InventoryManagementALEVEL     5   	   -   5          � Title$  
MainWindow��5   	   $	��800��6   $��1200.314��6)   
������  � WindowStyle$
 None=�6T    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5	   	   $	��683��5
   	   $	��860��6    � 
ResizeMode$ CanResizeWithGrip=�6(    � 	Resources 5         SideBarButtons �� 
TargetType �� Property �� Value	 �� 
TargetType
 �� Triggers P� Property P� Value  CloseButton��%�  &	        &	 e    �� 5   
   " ��6'   .�5      ��  � ��
 ���� 6+   �� 5       � ��
 �����6+   �� 5       � ��$ 15(�6)   �� 5       � �� 5      �� 5      "	 ��6&   .R�5      �� #��z��6!   ._�5      � .+�5   "   �� $��Center=�63   $��Center=�6P   5      5      
 5      P� 5       �@J�IsMouseOver . . �5   "   ��  � �� �	#FF61ABE86?   �� 5   "    � ��
 �����6?   5      P� 5       � �� . . �5   "   ��  � �� �	#FF1C8DEA6?   �� 5    "    � ��
 �����6?   5!      5#      5%      5&      �� 5'   
   " ��6$   .�5(      ��  � ��
 ���� 6+   �� 5)       � ��
 �����6+   �� 5*       � ��$ 15(�6)   �� 5+       � �� 5,      �� 5-      "	 ��6&   .R�5.      �� #��z��6!   ._�5/      � .+�50   "   �� $��Center=�63   $��Center=�6P   51      52      
 54      P� 55       �@J�IsMouseOver . . �56   "   ��  � �� �	#FF61ABE86?   �� 57   "    � ��
 �����6?   58      P� 59       � �� . . �5:   "   ��  � �� �	#FF1C8DEA6?   �� 5;   "    � ��
 �����6?   5<      5>      5@      5A      5B      .��5E      �� 
���   �$	��0.5q�6!   ._�5F   
   � $��Stretch=�6   $��Stretch=�6+    � RowDefinitions 5G      �� 5H      $��24 �6    �� 5I      $
��775* �6     � ColumnDefinitions 5K      �� 5L      $	��102 �6#   �� 5M      $��1000* �6#   �� 5N      $��32 �6#   �� 5O      $��32 �6#   �� 5P      $��32 �6#   .+�5R      �� -   5         ��Name$ topbar_Rectangle��5R      ���	#FFD8D8D8$��Stretch=�6C   $��Stretch=�6a   $��0��6~   $��5��6�   6�   �� 5S      -   5         ��Name$ mainContentControl��5S      $��Stretch=�69   $��Stretch=�6W   $��1��6s   $��1��6�   $��4��6�   �� 5T      -   5         ��Name$ close_button��5T      $��X��6+   $��1,0,-1,0q�67   
������ #��[ 6f   $��0q�6�   $��0��6�   $��4��6�   $��24��6�   �� 5U      -   5        $ maximize_button��5U      $	��▲��6.   
������ #��[ 6Y   $��0q�6~   $��0��6�   $��3��6�   $��24��6�   $
��Left=�6�   $��32��6�   6�   �� 5V      -   5        $ minimize_button��5V      $	��▼��6.   
������ #��[ 6Y   $��0q�6~   $��0��6�   $��2��6�   $��24��6�   $
��Left=�6�   $��32��6�   6�   �� 5W      -   5         ��Name$ windowtitle��5W      $
��Left=�6-   $��2,2,0,0q�6H   $
��Wrap=�6Y   $��INVENTORY_MAIN_SCREEN��6m   $	��Top=�6�    J� RenderTransformOrigin$ 0.336,0.322&�6�   $	��539��6�   $��10.667(�6�   $��0��6�   $��2��6  $��14��6   ��6�   Z� 6   � 5X      $��Stretch=�6   $��1��61   ���	#FFB2B1B1 5Y      �� 5Z      $
��194* �6$   �� 5[      $
��194* �6$   �� 5\      $
��194* �6$   �� 5]      $
��194* �6$   .+�5`      �� -   5        $ Main_Menu_button��5`      $��	Main Menu��64   $��Stretch=�6I   $��0q�6f   $��17(�6z   #��[  6�   $��0��6�   �� 5a      -	   5        $ Inventory_button��5a      $��	Inventory��63   $��Stretch=�6H   $��0q�6e   $��17(�6y   #��[  6�   $��1��6�   �� 5b      -
   5        $ For_Sale_button��5b      $��For sale��62   $��Stretch=�6G   $��0q�6d   $��17(�6x   #��[  6�   $��2��6�   �� 5c      -   5        $ Performance_button��5c      $��Performance��65   $��Stretch=�6L   $��0q�6h   $��17(�6|   #��[  6�   $��3��6�   5d      5e      5g      5h      