   M S B A M L   `   `   `  ����N  JOpenFileWinApiClass, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:OpenFileWinApiClassOpenFileWinApiClass  5   	   $    OpenFileWinApiClass.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:OpenFileWinApiClass     5   	     � Title$  OpenFile��5   
   $	��450��6   $	��800��6(   ���#f4f4f4.��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ 	BtnSearch��5      $��Caută��5      $	��120��5      $��40��5      $��20q�5      $��16(�5      $
��Bold"�5      
����������#007ACC
������  � Cursor$
 Hand��5      $
��Left=�5      $	��Top=�5      ��5       �� 5!       �� 
TargetType" ��6   .�5"      ��  �� Property � �� �� Value �#007ACC63   �� 5#       � ��
 �����63   �� 5$       � ��$
 Bold"�63   �� 5%       � ��
 ���� 64   �� 5&       �@�Cursor$
 Hand��6/   �� 5'       � ��$ 10q�60   �� 5(       � ��$ 16(�61   �� 5)       �@J�Effect 5*      3  -System.Windows.Media.Effects.DropShadowEffect  5+         
BlurRadius$ 10Q�6/      Opacity$	 0.3Q�6?   5-      	 �� Triggers	 5.      P� 5/      
 P� Property
 �@J�IsMouseOver P� Value$
 True��69   . �50      ��  � �� �#005F996;   51      53      55      �� 57   
   -   5         ��Name$ 	LblStatus��57      $�� ��58      
��� � �$��14(�5:      $
��Bold"�5;      $��	20,70,0,0q�5<      $
��Left=�5=      $	��Top=�5>      �� 5@   
   -   5         ��Name$ RtbText��5@      $��2��5A      $��20q�5B      $��10q�5C      
�������$��1q�5E      
�������$��14(�5G      
���   �" �� VerticalScrollBarVisibility$
 Auto=�5I      . �5J      /� .T�5K      J� .*�6   .*�5L      �� $� ��6   5M      5N      5O      5P      5Q      