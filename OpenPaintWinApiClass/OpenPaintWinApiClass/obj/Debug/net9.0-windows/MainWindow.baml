   M S B A M L   `   `   `  ����O  KOpenPaintWinApiClass, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:OpenPaintWinApiClassOpenPaintWinApiClass  5   	   %    OpenPaintWinApiClass.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:OpenPaintWinApiClass     5   	     � Title$  
Aplicație��5   	   $	��500��6   $	��800��6(    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	    � AllowsTransparency$
 True��5   	   
������ $��0q�5   	    � 	Resources 5         ButtonHoverOn �� TargetProperty	 W� To g� Duration W� EasingFunction-  'System.Windows.Media.Animation.BackEase7  1System.Windows.Media.Animation.EasingFunctionBase	   
EasingMode
   	Amplitude  ButtonHoverOff �� 
TargetType �� Property �� Value �� ScaleX �� ScaleY �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value �� Triggers :� RoutedEvent  CloseButtonStyle��%�
  &	        &	 �    '��     7   7  &	 �    �� 5   
   .��5      W� $9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�6    1.055      $ 0:0:0.2D�6(    5        5      $	 EaseOut=�6   $	
 0.3Q�64   5      W� 5      $9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�6    1.055      $ 0:0:0.2D�6(    5        5      $	 EaseOut=�6   $	
 0.3Q�64   5      5      �� 5   
   .��5      W� $9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�6    1.05       $ 0:0:0.2D�6'    5!        5"      $	 EaseOut=�6   $	
 0.3Q�64   5$      W� 5%      $9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�6    1.05&      $ 0:0:0.2D�6'    5'        5(      $	 EaseOut=�6   $	
 0.3Q�64   5*      5+      �� 5-   
   " ��6   .�5.      ��  � �� �#3498db6+   �� 5/       � ��
 �����6+   �� 50       � ��$ 16(�6)   �� 51       � ��$ SemiBold"�6+   �� 52       � ��$ 15q�6(   �� 53       � ��$ 0q�60   �� 54       � ��$ 10q�6'   �� 55       � ��$	 200��6&   �� 56       � ��$ 80��6'   �� 57       �@J�RenderTransformOrigin$ 0.5,0.5&�66   �� 58       � z� 59      �� 5:      $ 1Q�6%   $ 1Q�60   5<      �� 5=       � �� 5>      �� 5?      " ��6&   .R�5@      �� #��z��6!   $ 8��5A   !   #��z��5B   !   #��z��5C   !   ._�5D      �� $��Center=�6/   $��Center=�6L   5E       5F      P� 5G       �@J�IsMouseOver$
 True��6=   . �5H   "   ��  � �� �#2980b96?   �� 5I   "    �@�Cursor$
 Hand��6;   5J      P� 5K       � ��$
 True��6;   . �5L   "   ��  � �� �#1f618d6?   5M      5O      5Q       5R      :� 5S      $ 
MouseEnter��6   .[�5T      �� 8��  6&   5U      :� 5V      $ 
MouseLeave��6   .[�5W      �� 8�� 6&   5X      5Z      �� 5\   
   " ��6)   .�5]      ��  � ��
 ���� 6+   �� 5^       � ��
 �����6+   �� 5_       � ��$ 14(�6)   �� 5`       � ��$ 8q�6(   �� 5a       � ��$ 0q�60   �� 5b       � ��$ 30��6&   �� 5c       � ��$ 30��6'   �� 5d       � �� 5e      �� 5f      " ��6&   .R�5g      �� #��z��6!   $ 15��6K   ._�5h      �� $��Center=�6/   $��Center=�6L   5i       5j      P� 5k       �@J�IsMouseOver$
 True��6=   . �5l   "   ��  � �� �#e74c3c6?   �� 5m   "    �@�Cursor$
 Hand��6;   5n      P� 5o       � ��$
 True��6;   . �5p   "   ��  � �� �#c0392b6?   5q      5s      5u      5v      5w      .��5y      �� $ 10��6   ���#F0F0F0$��1q�64   ���#2c3e50._�5z   
   �  � RowDefinitions 5{      �� 5|      $
��Auto �6    �� 5}      $��* �6    .+�5�      �� -   5        $��0��5�      ���#2c3e50 �� Padding$ 10q�67   $ 	10,10,0,0��6D   ._�5�      � .+�5�      �� $��Panou de Control��6    $��24(�68   $
��Bold"�6F   
�������$��Center=�6k   �� 5�      -   5         ��Name$ BtnClose��5�      $	��✕��6/   $��Right=�6;   #��[ 6W   6�   5�      5�      � 5�      $��1��6   .+�5�      �� $��Center=�6   $��Center=�68   .+�5�      �� -   5        $��
BtnNotepad��5�      .��5�      ��  �� Orientation$ 
Horizontal=�6%   .+�5�      �� $��Segoe MDL2 Assets)�6(   $	����6G   $��24(�6W   $��Center=�6e   $��0,0,10,0q�6�   �� 5�      $��Notepad��6(   $��Center=�67   5�      5�      �� 5�      -   5        $��BtnPaint��5�      ���#e74c3c.��5�      �� $ 
Horizontal=�6%   .+�5�      �� $��Segoe MDL2 Assets)�6(   $	����6G   $��24(�6W   $��Center=�6e   $��0,0,10,0q�6�   �� 5�      $��Paint��6(   $��Center=�65   5�      5�      �� 5�      -   5        $��BtnBrowseNotepad��5�      ���#27ae60.��5�      �� $ 
Horizontal=�6%   .+�5�      �� $��Segoe MDL2 Assets)�6(   $	����6G   $��24(�6W   $��Center=�6e   $��0,0,10,0q�6�   �� 5�      $��Browse Files��6(   $��Center=�6<   5�      5�      5�      5�      5�      5�      5�      