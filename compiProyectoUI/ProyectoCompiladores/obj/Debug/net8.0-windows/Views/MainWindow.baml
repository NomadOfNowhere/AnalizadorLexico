   M S B A M L   `   `   `  ����O  KProyectoCompiladores, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ProyectoCompiladores.ViewsProyectoCompiladores.Views  5   	   Q-clr-namespace:ProyectoCompiladores.ViewModelsProyectoCompiladores.ViewModels  5   	   %    ProyectoCompiladores.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:ProyectoCompiladores.Views     5   	   C	viewModel-clr-namespace:ProyectoCompiladores.ViewModels     5   	   X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5	   	     � Title$  Analizador Léxico��5
   	   $	��700��6#   $
��1300��60    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency$
 True��5   	    � DataContext 5      3   -ProyectoCompiladores.ViewModels.MainViewModel  5   
    � 	Resources 5       �� DataType:   4ProyectoCompiladores.ViewModels.CrearBasicoViewModel0   *ProyectoCompiladores.Views.CrearBasicoView��%G   (��       5      *, +)�� 6
   "  6   .R�5        5      5      .��5      ��  �� CornerRadius$ 10��6   $��1q�5      ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"   	 �� EndPoint$		 1,1&�63   .��5      �    winBorderColor1
 � Color#
 [  6    � Offset$ 0Q�6H   � 5         winBorderColor2#
 [ 6   $	 0.5Q�6H   � 5!        winBorderColor3#
 [ 6   $ 1Q�6H   5"      ._�5%   
   �  � ColumnDefinitions 5&      �� 5(      $	��250 �6#   �� 5*      $��* �6#   .+�5.      �� $ 	10,0,0,10��6   $��0��5/      ��50      �� 51      $	 0,0&�6*   $	 1,0.7&�6;   .��52      �   primaryBackColor1#
 [ 6'   $ 0Q�6R   � 53        primaryBackColor2#
 [ 6'   $ 1Q�6R   54      ._�57      �� .+�5:      ��  �� Orientation$ 
Horizontal=�6!   $��70��5;   !   $��
15,25,0,40q�5<   !   .+�5=      �� $��/Images/Logo.png��6    $��70��6:   �� 5>        titleColor2#��[ 5?   $   $��30(�5@   $   $��
Montserrat)�5A   $   $��Medium"�5B   $   $��Center=�5C   $   $��10,0,0,0q�5D   $   �� 67   $�
Analizador��6;   �� 6O   �� 6[   $�Léxico��6_   �� 6o   $� ��6s   6   5E      	� 5H      -   5          
menuButton#��[ 5H   "    
 color1
 � Tag# [ 5I   "    d� 	IsChecked$
 TrueY�5J   "   ��5K   "   �� *ShowCrearBasicoViewCommand+.��5M      �� $ 
Horizontal=�6%   .+�5N      ��   menuButtonIcon#��[ 6$   $��/Images/CrearBasico.png��6L   $��50��6m   $��50��6y   �� 5O      $��Crear AFN básico��6(   $��17(�6@    	 menuButtonText#��[	 6O   5P      5Q      	� 5S      #��[ 6"    

 color2# [
 5T   "   .��5W      �� $ 
Horizontal=�6%   .+�5X      �� #��[ 6$   $��/Images/Icono2.png��6L   �� 5Y      $��
Unir AFN's��6(   $��17(�6:   #��[	 6I   5Z      5[      	� 5]      #��[ 6"    
 color3# [ 5^   "   .��5a      �� $ 
Horizontal=�6%   .+�5b      �� #��[ 6$   $��/Images/Icono3.png��6L   �� 5c      $��Concatenar AFN's��6(   $��17(�6@   #��[	 6O   5d      5e      	� 5g      #��[ 6"    
 color4# [ 5h   "   .��5j      �� $ 
Horizontal=�6%   .+�5k      �� #��[ 6$   $��/Images/Icono4-1.png��6L   �� 5l      $��Cerradura de Kleen��6(   $��17(�6B   #��[	 6Q   5m      5n      	� 5p      #��[ 6"    
 color5# [ 5q   "   .��5s      �� $ 
Horizontal=�6%   .+�5t      �� #��[ 6$   $��/Images/Icono4-2.png��6L   �� 5u      $��
Cerradura+��6(   $��17(�6:   #��[	 6I   5v      5w      	� 5y      #��[ 6"    
 color6# [ 5z   "   .��5|      �� $ 
Horizontal=�6%   .+�5}      �� #��[ 6$   $��/Images/Icono5.png��6L   �� 5~      $��Opcional��6(   $��17(�68   #��[	 6G   5      5�      	� 5�      #��[ 6"    
 color7# [ 5�   "   .��5�      �� $ 
Horizontal=�6%   .+�5�      �� #��[ 6$   $��/Images/Icono6.png��6L   �� 5�      $��
Unir AFN's��6(   $��17(�6:   #��[	 6I   5�      5�      	� 5�      #��[ 6"    
 color8# [ 5�   "   .��5�      �� $ 
Horizontal=�6%   .+�5�      �� #��[ 6$   $��/Images/Icono6.png��6L   �� 5�      $��Convertir AFN->AFD��6(   $��17(�6B   #��[	 6Q   5�      5�      	� 5�      #��[ 6"    
 color9# [ 5�   "   .��5�      �� $ 
Horizontal=�6%   .+�5�      �� #��[ 6$   $��/Images/Icono6.png��6L   �� 5�      $��Analizador Léxico��6(   $��17(�6A   #��[	 6P   5�      5�      5�      5�      �� 5�      $ 	0,10,10,0��6   $��1��5�      ��5�      �� 5�      $	 1,1&�6*   $		 0,0&�6;   .��5�      � #
 [ 6'   $ 0Q�6R   � 5�      #
 [ 6'   $ 1Q�6R   5�      ._�5�      �  � RowDefinitions 5�      �� 5�      $��25 �6(   �� 5�      $��55 �6(   �� 5�      $��* �6(   .+�5�      �� -   5         ��Name$ pnlControlBar��5�   !   $��0��5�   !   $ 
Horizontal=�5�   !   $��RightToLeft=�5�   !   
������ $��0,0,5,0q�5�   !   .+�5�      �� -   5         ��Name$ btnClose��5�   !     controlButton#��[ 5�   !   # [ 5�   !   .��5�      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Xmark=�6+     controlButtonIcon#��[ 68   5�      �� 5�      -   5        $ btnMaximize��5�   !   #��[ 5�   !   # [ 5�   !   .��5�        $ Square=�6+   #��[ 69   5�      �� 5�      -   5        $ btnMinimize��5�   !   #��[ 5�   !   # [ 5�   !   .��5�        $ WindowMinimize=�6+   $��12��6A   #��[ 6L   5�      5�      � 5�      $��1��6    5�      �� 5�      5�      .+�5�      �� $��0��6%   $ 
Horizontal=�5�   )   $��Center=�5�   )   $	��100��6D   .+�5�      �� $��58��5�   $   $��67��5�   $   $��
35,-5,10,0q�5�   $   ��5�   $   �� *
IconPath+5�   $   �� 5�      #��[ 5�   (   $��40(�5�   (   $��
Montserrat)�5�   (   $��Medium"�5�   (   $��Center=�5�   (   ��5�   (   �� *	Caption+5�   (   5�      �� 5�      $��1��6%   $ 
Horizontal=�5�   %   $��RightToLeft=�5�   %   $��Center=�5�   %   $��0,0,10,0q�5�   %   $	��100��67   .+�5�      ��   
iconButton#��[ 6%   # [ 5�   %   .��5�   "     $ 	AngleDown=�6/   $��12��5�   /   $��12��6;     iconButtonIcon#��[ 5�   /   5�      �� 5�      $��Señor Oddie��6(     titleColor3#��[ 5�   (   $��
Montserrat)�5�   (   $��12(�5�   (   $��Center=�5�   (   A� 5�      $��40��6&   $��40��62   #��[
 5�   &   $��2��5   &   $��	10,0,10,0q�5  &   ��5  "   �� 5  &    �� ImageSource$ /Images/Oddie.png��61   5     �� 5     #��[ 6%   # [ 5  %   .��5	  "     $ Clock=�6/   #��[ 6<   5
     �� 5     #��[ 6%   # [ 5  %   .��5  "     $ Envelope=�6/   #��[ 6?   5     �� 5     #��[ 6%   # [ 5  %   .��5  "     $
 Bell=�6/   #��[ 6;   5     5     5     �� 5     $��2��5  %   $��25q�5  %   ��5  %   �� *CurrentChildView+5  %   5     5!     5"     5$     5%     