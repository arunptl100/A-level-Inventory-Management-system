   M S B A M L   `   `   `  ����T  PInventoryManagementALEVEL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:InventoryManagementALEVELInventoryManagementALEVEL  5   	   Dclr-namespace:InventoryManagementALEVEL.User_controls.Login_controls6InventoryManagementALEVEL.User_controls.Login_controls  5   	   %    InventoryManagementALEVEL.Login   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:InventoryManagementALEVEL     5   	   YcontrolsDclr-namespace:InventoryManagementALEVEL.User_controls.Login_controls     5   	   -   5          � Title$  Login��5	   	   $	��212��6   $	��405��6$   
������  � WindowStyle$
 None=�6J    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�6w    � 
ResizeMode$ NoResize=�6�    � 	Resources 5
         MouseOverLabelStyle �� 
TargetType �� Property �� Value	 �� 
TargetType
 �� Triggers P� Property P� Value��%E  &	        �� 5   
   " ��6,   .�5      ��  � �� 5      �� 5      "	 ��6&   .R�5      �� 
������ ._�5      �� 5      5      5      �� 5       � �� �	#FF3176D86?   
 5      P� 5       �@J�IsMouseOver . . �5      ��  � ��
 � � �63   5      5      5      .��5      �� 
���   �$	��0.5q�6!   ._�5   
   � .+�5       �� $
��Left=�6   $	��211��64   $	��Top=�6A   $	��124��6Y   ���	#FFA0A0A0.+�5!      �� -   5         ��Name$ title_label��5!      $��Inventory management��6-   $
��Left=�6L   $	��Top=�6g   $��0��6   $��0��6�   $��10.667(�6�   
���   �6�   �� 5"      -   5         ��Name$$ forgotten_password_left_button��5"      $��forgotten password?��6A   $
��Left=�6_   $��10,0,0,0q�6z   $	��Top=�6�   $��10.667(�6�   $��Italic$�6�   #��[  6�   $��20��6�   6  �� 5#      -   5        $ help_button��5#      $
��Help��6.   $
��Left=�6=   $��10,0,0,0q�6X   $	��Top=�6j   $��10.667(�6�   $��Italic$�6�   #��[  6�   $��20��6�   6�   �� 5$      -   5        $ about_button��5$      $��About��6/   $
��Left=�6?   $��10,0,0,0q�6Z   $	��Top=�6l   $��10.667(�6�   $��Italic$�6�   #��[  6�   $��20��6�   6�   �� 5%      -   5        $ create_button��5%      $��Create Account��60   $
��Left=�6I   $��10,0,0,0q�6d   $	��Top=�6v   $��10.667(�6�   $��Italic$�6�   #��[  6�   $��20��6�   6�   �� 5&      -   5        $ home_button��5&      $
��Home��6.   $
��Left=�6=   $��10,0,0,0q�6X   $	��Top=�6j   $��10.667(�6�   $��Italic$�6�   #��[  6�   $��20��6�   6�   5'      �� 5(      -   5         ��Name$ mainContentControl��5(      $��	124,0,0,0q�69   5)      5*      5+      