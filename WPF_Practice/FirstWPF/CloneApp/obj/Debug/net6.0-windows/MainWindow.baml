   M S B A M L   `   `   `  ����C  ?CloneApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CloneAppCloneApp  5   	   9!clr-namespace:CloneApp.ViewModelsCloneApp.ViewModels  5   	       CloneApp.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:CloneApp     5   	   4mainVM!clr-namespace:CloneApp.ViewModels     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	     � Title$  
MainWindow��5
   	   $	��600��6   $	��920��6)   
������  � AllowsTransparency$
 True��5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � DataContext 5      '   !CloneApp.ViewModels.MainViewModel  5   
   .��5      �� $��2q�6    �� CornerRadius$ 10��5      ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$ 1, 0.6&�63   .��5      �    winBorderColor1 � Color# [  6   	 � Offset$	 0Q�6H   � 5        winBorderColor2# [ 6   $	 1Q�6H   � 5        winBorderColor3# [ 6   $	 2Q�6H   5      ._�5   
   � 
 � ColumnDefinitions
 5      �� 5      $	��250 �6#   �� 5       $��* �6#   .+�5%      �� $��0��6   $ 10, 0, 0, 10��5&      ��5'      �� 5(      $	 0,0&�6*   $ 1, 0.8&�6;   .��5)      �   primaryBackColor1# [ 6'   $	 0Q�6^   � 5*        primaryBackColor2# [ 6'   $	 1Q�6^   5+      ._�5.      �� .+�5/      ��  �� Orientation$ 
Horizontal=�6!   $��35��50   %   $��15, 25, 0 ,40q�51   %   .+�52      �� $��Image/Image.jpg��6    $��40��69   �� 53      $��Message App��6      plainTextColor1#��[ 66   $��18(�54   $   $��10, 0q�55   $   $��Medium"�56   $   57      	� 5:      -   5          
menuButton#��[ 5:   "    
 color1
 � Tag# [ 5;   &    d� 	IsChecked$
 TrueY�5=   "   ��5<   "   �� *ShowHomeView+.��5>      �� $ 
Horizontal=�6%   .+�5?      !  FontAwesome.Sharp.IconBlock  �  �FontAwesome.Sharp.IconBlockBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=�6+     menuIcon#��[ 67   �� 5@       	 menuButtonText#��[	 6(   $
��Home��6P   5A      5B      	� 5D      #��[ 6"    

 color2# [
 5E   &   ��5F   "   �� *ShowDashboardView+.��5G      �� $ 
Horizontal=�6%   .+�5H        $ 	Chartline=�6+   #��[ 6<   �� 5I      #��[	 6(   $��	Dashboard��5J   ,   5K      5L      	� 5N      #��[ 6"    
 color3# [ 5O   &   ��5P   "   �� *ShowStoryView+.��5Q      �� $ 
Horizontal=�6%   .+�5R        $	 Pen=�6+   #��[ 66   �� 5S      #��[	 6(   $��Story��5T   ,   5U      5V      	� 5X      #��[ 6"    
 color4# [ 5Y   &   ��5Z   "   �� *ShowAPIView+.��5[      �� $ 
Horizontal=�6%   .+�5\        $
 Book=�6+   #��[ 67   �� 5]      #��[	 6(   $	��API��5^   ,   5_      5`      	� 5b      #��[ 6"    
 color5# [ 5c   &   .��5d      �� $ 
Horizontal=�6%   .+�5e        $ Envelope=�6+   #��[ 6;   �� 5f      #��[	 6(   $��Contact��5g   ,   5h      5i      	� 5k      #��[ 6"    
 color6# [ 5l   &   .��5n      �� $ 
Horizontal=�6%   .+�5o        $ Phone=�6+   #��[ 68   �� 5p      #��[	 6(   $��About��5q   ,   5r      5s      5u      5x      �� 5z      $��1��6   $ 0, 10, 10, 0��5{      ��5|      �� 5}      $	 0,0&�6*   $ 1, 0.8&�6;   .��5~      � # [ 6'   $	 0Q�6^   � 5      # [ 6'   $	 1Q�6^   5�      5�      � 5�      $��1��6    � RowDefinitions 5�      �� 5�      $��30 �6$   �� 5�      $��50 �6$   �� 5�      $��* �6$   .+�5�      �� $��0��6   $ 
Horizontal=�5�      $��Right=�5�      $��RightToLeft=�5�      $
��10,0q�5�      .+�5�      �� -   5          controlButton#��[ 5�      # [ 5�      .��5�      �� $	��❌��6$   5�      5�      � 5�      $��1��6   
 5�      �� 5�      $��* �6+   �� 5�      $��* �6+   .+�5�      �� $
��Left=�6!   $ 
Horizontal=�5�   !   $��0��5�   !   .+�5�          
headerIcon#��[ 5�   '   # [
 5�   '    5�   '   �� *Icon+5�   '   �� 5�        
headerText#��[ 6;   ��6$   �� *Title+6;   5�      �� 5�      $��Right=�6!   $ 
Horizontal=�5�   !   $��RightToLeft=�5�   !   $��1��5�   !   .+�5�      ��   userInfo#��[ 6D   ��6$   �� *_User.Username+6D   5�      5�      �� 5�      $��2��6   .+�5�      �� 5�      5�      5�      5�      5�      