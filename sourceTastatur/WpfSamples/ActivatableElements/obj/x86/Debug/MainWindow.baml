   M S B A M L   `   `   `  ����H  DEyeXFramework, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullL6clr-namespace:EyeXFramework.Wpf;assembly=EyeXFrameworkEyeXFramework.Wpf  5   	   N JActivatableElements, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ActivatableElementsActivatableElements 5	   	   $   ActivatableElements.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   GeyeX6clr-namespace:EyeXFramework.Wpf;assembly=EyeXFramework     5   	   0ae!clr-namespace:ActivatableElements     5	   	   -   5          � Title$  
MainWindow��5   	   $	��600��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65    � WindowState$ 	Maximized=�6Z    � DataContext 5      )  #ActivatableElements.MainWindowModel  5   
    � 	Resources 5         ButtonStyle �� 
TargetType �� Property �� Value  ButtonStyle2  ButtonStyle3  ButtonStyleSpace  EyeXActivatableButtonStyle �� BasedOn    EyeXFramework.Wpf.Behavior	 �� Triggers
 P� Property P� Value  EyeXActivatableButtonStyle2  EyeXActivatableButtonStyle3 # EyeXActivatableButtonStyleSpace��%p  &	        &	 �     &	 *    &	 �    &	 T    7   &	 C    7  &	 2    7  &	 !    7  �� 5   
   " ��6$   .�5      ��  � ��$	 120��6&   �� 5       � ��$	 120��6'   �� 5       � ��$
 Bold"�6+   6:   �� 5       � ��$ 20(�6)   5      �� 5   
   " ��6%   .�5      ��  � ��$ 40��6&   �� 5       � ��$	 120��6'   5      �� 5   
   " ��6%   .�5      ��  � ��$ 80��6&   �� 5       � ��$	 120��6'   5      �� 5    
   " ��6)   .�5!      ��  � ��$	 480��6&   �� 5"       � ��$	 120��6'   �� 5#       � ��$
 Bold"�6+   6:   �� 5$       � ��$ 20(�6)   5%      �� 5&   
   8   " ��6Z   .�5'      ��  �@ Activatable$ Default=�6:   -   5        	 5)      P� 5*      
 �@ ActivationFocus$ HasActivationFocus=�6C   . �5+      ��  � ��
 �����64   5,      5.      �� 5/   
   8   " ��6\   .�50      ��  �@ Activatable$ Default=�6:   -   5        	 52      P� 53      
 �@ ActivationFocus$ HasActivationFocus=�6C   . �54      ��  � ��
 �����64   55      57      �� 58   
   8   " ��6\   .�59      ��  �@ Activatable$ Default=�6:   -   5        	 5;      P� 5<      
 �@ ActivationFocus$ HasActivationFocus=�6C   . �5=      ��  � ��
 �����64   5>      5@      �� 5A   
   8   " ��6d   .�5B      ��  �@ Activatable$ Default=�6:   -   5        	 5D      P� 5E      
 �@ ActivationFocus$ HasActivationFocus=�6C   . �5F      ��  � ��
 �����64   5G      5I      5J       J� CommandBindings 5L      )  #System.Windows.Input.CommandBinding  5M   
   -   5           Command$ Close��5M      5O      .��5R      � $��50q�6    � RowDefinitions 5S   
   �� 5T      $	��10* �6   �� 5U      $	��10* �6   �� 5V      $	��80* �6   .+�5Y   
   �� -   5         ��Name$ sentenceTextBlock��5Y      $
��Wrap=�6/   $��30(�6C   
���   �6Q   �� 5[   
   -   5         ��Name$ messageTextBox��5[      $��1��6*    �� TextWrapping$
 Wrap=�67   $��30(�6K   6Y   �� 5]   
   $��2��6   5�      5�      5�      