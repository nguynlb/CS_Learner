   M S B A M L   `   `   `  ����C  ?CloneApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CloneApp.ViewsCloneApp.Views  5   	   9!clr-namespace:CloneApp.ViewModelsCloneApp.ViewModels  5   	        CloneApp.Views.LoginWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:CloneApp.Views     5   	   7	viewModel!clr-namespace:CloneApp.ViewModels     5   	     � Title$  LoginWindow��5	   	   $	��600��6   $	��450��6*    � DataContext 5
      '   !CloneApp.ViewModels.MainViewModel  5   
   .��5      � .+�5   
   �� $��Center=�6   $��30q�5      .+�5      �� $��Login��6   $��30(�5      $
��Bold"�5      
���   �$��Center=�5      $��20q�5      �� 5      $��
Username :��6   $��15(�5      $��0 10 0 0q�5      �� 5      $��1q�6   
���   �$��8q�5      ��5      �� *_User.Username+ �� UpdateSourceTrigger$ PropertyChanged=��� 5       $��
Password :��6   $��15(�5!      $��0 10 0 0q�5"      �� 5#      $��1q�6   
���   �$��8q�5%      ��5&      �� *_User.Password+$ PropertyChanged=��� 5-      $��Login��6   $��20, 40q�5.      $��20, 10q�5/      $��18(�50      $��Medium"�51      
���   �
������� � Cursor$
 Hand��54      ��55      �� *LoginCommand+59      5:      5;      