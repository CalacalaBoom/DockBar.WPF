   M S B A M L   `   `   `  ����F  BDockMenuPro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DockMenuProDockMenuPro  5          DockMenuPro.DockBar   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:DockMenuPro     5        � 	Resources  5         DockBar.ButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers :� RoutedEvent �� TargetProperty	 W� To	 g� Duration  DockBar.Button.PopupStyle $  DockBar.Button.Popup.BorderStyle ' #DockBar.Button.Popup.TextBlockStyle " DockBar.Button.Popup.PathStyle��%M  &	        &	     &	 '    &	 �    &	 �    �� 5	   
   " ��5
      .�5      ��  � ��$ 50��5      �� 5       � ��$ 50��5      �� 5       � ��$ Center=�5      �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��0q�6!   #��z��5   !   5      5       5      :� 5      $ 
MouseEnter��6   .[�5      �� .��5      �� .��5      W� $ Width�6.    605   .   $	 0:0:0.1D�5   .   W� 5       $ Height�6.    605!   .   $	 0:0:0.1D�5"   .   5#      5$      5%      :� 5&      $ 
MouseLeave��6   .[�5'      �� .��5(      �� .��5)      W� $ Width�6.    505*   .   $	 0:0:0.1D�5+   .   W� 5,      $ Height�6.    505-   .   $	 0:0:0.1D�5.   .   5/      50      51      53      �� 55   
   " �56      .�57      ��  � ��$ 35��58      �� 59       �@�AllowsTransparency$
 True��5:      �� 5;       � ��$ Center=�5<      �� 5=       � ��$	 Top=�5>      �� 5?       �@�VerticalOffset$ -5��5@      5A      �� 5C   
   " ��5D      .�5E      ��  � ��
 �����5F      �� 5G       �@��CornerRadius$ 5��5H      �� 5I       � ��$ 26��5J      5K      �� 5M   
   " ��5N      .�5O      ��  � ��$ 13(�5P      �� 5Q       � ��$
 10,0q�5R      �� 5S       � ��$ Center=�5T      �� 5U       � ��$ Center=�5V      5W      �� 5Y   
   " F�5Z      .�5[      ��  � ��+ ��        � z  z � $�     �        	5\      �� 5]       � ��$ 16��5^      �� 5_       � ��$ 8��5`      �� 5a       � ��
 �����5b      �� 5c       �@��Stretch$
 None=�5d      �� 5e       � ��
 �����5f      �� 5g       � ��$ Bottom=�5h      5i      5j      .��5k      � 
������ .+�5m   
   �� ���	#FF272822
 �� CornerRadius$
 25��5n       J� Opacity$	 0.7Q�5o      � 5q   
   -   5         �Name$ DockGrid��5q      5r      5s      