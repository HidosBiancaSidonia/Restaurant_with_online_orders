   M S B A M L   `   `   `  ����X  TRestaurant_with_online_orders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Restaurant_with_online_orders.View"Restaurant_with_online_orders.View  5   	   a5clr-namespace:Restaurant_with_online_orders.ViewModel'Restaurant_with_online_orders.ViewModel  5   	   c6clr-namespace:Restaurant_with_online_orders.Converters(Restaurant_with_online_orders.Converters  5   	   .    (Restaurant_with_online_orders.View.LogIn   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal10clr-namespace:Restaurant_with_online_orders.View     5   	   Glocal5clr-namespace:Restaurant_with_online_orders.ViewModel     5   	   QlocalConverter6clr-namespace:Restaurant_with_online_orders.Converters     5   	     � 
ResizeMode$  CanMinimize=�5
   	    � Title$ Logare��5   	   $	��450��6   $	��800��6%    � WindowStartupLocation$ CenterScreen=�61    � Icon$ Images_LogIn/icon .png��5   	    � DataContext 5      8  2Restaurant_with_online_orders.ViewModel.MainViewVM  5   
   .��5      � ���	#FF9CE9C5.+�5   
   �� $
��Left=�6   $	��272��6+   $��595,169,-59.667,-20.333q�68   $	��Top=�6Y   $	��258��6q   $��Images_LogIn/desert.jpg��6}   �� 5   
   $
��Left=�6   $	��288��6+   $��-9,237,0,-104.333q�68   $	��Top=�6S   $	��254��6k   $��Images_LogIn/food.jpg��6w    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -11.828Q�6&   T� 5      5      5      �� 5   
   $
��Left=�6   $	��168��6+   $��547,12,-39.667,0q�68   $	��Top=�6R   $	��286��6j   $��Images_LogIn/food1.jpg��6v   $ 0.5,0.5&�6�   z�5      V� 5       .~�5!      �� �� 5"      �� 5#      $ 20.848Q�6&   T� 5$      5%      5'      �� 5(   
   $
��Left=�6   $	��226��6+   $��	-5,17,0,0q�68   $	��Top=�6K   $	��311��6c   $��Images_LogIn/food2.jpg��6o   $ 0.5,0.5&�6�   z�5)      V� 5*      .~�5+      �� �� 5,      �� 5-      $ -12.325Q�6&   T� 5.      5/      51      �� 52   
   $
��Left=�6   $��53��6+   $��
349,10,0,0q�67   $	��Top=�6K   $	��120��6c   $��Images_LogIn/desert1.jpg��6o   �� 53   
   $
��Left=�6   $��50��6+   $��
445,10,0,0q�67   $	��Top=�6K   $��71��6c   $��Images_LogIn/desert2.jpg��6n   $ 	0.34,0.44&�6�   �� 54   
   -   5        $��Inapoi��54      $
��Left=�6"   $��366,373,0,0q�6=   $	��Top=�6R   $	��103��6j   ���	#FFD5A2E6$��Britannic Bold)�6�   $��33��6�   6�   � 56   
   ���	#FFD5A2E6$
��Left=�6'   $	��299��6B   $��235,69,0,54q�6O   $��Center=�6d   $	��355��6    � 	Resources 57      =  7Restaurant_with_online_orders.Converters.LogInConverter   logInConvert��%   &	          58      60   59       5:      4  .Restaurant_with_online_orders.ViewModel.UserVM  5;      .+�5=      �� $'��!Introduceti datele dumneavoastra:��6   $
��Left=�6@   $��	25,10,0,0q�6[   $	��Top=�6n   $��36��6�   $	��293��6�   $��Britannic Bold)�6�   $��18(�6�   �� 5>      $��Nume de utilizator:��6   $
��Left=�62   $��	25,46,0,0q�6M   $	��Top=�6`   $
��Bold"�6x   $��16(�6�   $ 0.52,-0.277&�6�   �� 5?      $��Parola :��6   $
��Left=�6'   $��
25,117,0,0q�6B   $	��Top=�6V   $
��Bold"�6n   $��16(�6�   $ 0.573,-0.798&�6�   �� 5@      -   5        $��nume_utilizator��5@      $��77,87,74,187q�6-   ���	#FF9CE9C56C   G� 5A      -   5        $
��pass��5A      $
��Left=�6&   $��
77,153,0,0q�6A   $	��Top=�6U   $	��204��6m   $��26��6y   ���	#FF9CE9C5=  7Restaurant_with_online_orders.Converters.PasswordHelper   Attach . 	   Password	 6�   �� 
 �� Path$
 Password��� 5C      -   5        $��Creare cont��5C      $
��Left=�6+   $��215,217,0,0q�6F   $	��Top=�6[   $	��103��6s   ���	#FF9CE9C5$��Britannic Bold)�6�   $��33��6�   $��4��6�   ��6�   �� *OpenWindowCommand+6�   �� 5D      $��Logare��6   $
��Left=�6&   $��
48,217,0,0q�6A   $	��Top=�6U   $	��103��6m   ���	#FF9CE9C5$��Britannic Bold)�6�   $��33��6�   ��6�   �� *LogInCommand+��5E      `� 5F       `� 	Converter# [  6#   .1�5G      ��  �� ElementName$ nume_utilizator��6"   $

 Text�6@   �� 5H      $
 pass��6"   $.
 ((localConverter:PasswordHelper.Password)�65   5I      5K      5L      5N      5P      