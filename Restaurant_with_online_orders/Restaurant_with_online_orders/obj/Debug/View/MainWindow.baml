   M S B A M L   `   `   `  ����X  TRestaurant_with_online_orders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Restaurant_with_online_ordersRestaurant_with_online_orders  5   	   a5clr-namespace:Restaurant_with_online_orders.ViewModel'Restaurant_with_online_orders.ViewModel  5   	   .    (Restaurant_with_online_orders.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:Restaurant_with_online_orders     5   	   Hlocal15clr-namespace:Restaurant_with_online_orders.ViewModel     5   	     � 
ResizeMode$  CanMinimize=�5	   	    � Title$ 
Restaurant��5
   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65    � Icon$! Images_MainWindow/icon .png��5   	    � DataContext 5      8  2Restaurant_with_online_orders.ViewModel.MainViewVM  5   
   .��5      � -   5        $
��main��5      ���	#FF9CE9C5.+�5   
   o� $
��Left=�6   $��34��6*   $	��Top=�66   $	��793��6N   ���	#FFBA7474.@�5      m� -   5        $��meniu1��5      $��_Meniul Restaurantului��6%   $��	Bodoni MT)�6E   $��16(�6\   ���#493B5C$	��167��6   $��34��6�   ���	#FF0DE97C$
��Bold"�6�    m� CommandParameter$ 1��6�    m� Command 6�   �� *OpenWindowCommand+6�   m� 5      -   5         m�Name$ 
cautareBtn��5      $��   Cauta in meniu��6+   $��	Bodoni MT)�6F   $��16(�6]   ���#493B5C$	��162��6�   $��34��6�   ���	#FF0DE97C$
��Bold"�6�   $ 2��6�    6�   �� *OpenWindowCommand+ m� Icon 5      �� 5      $"��Images_MainWindow/search.png��6   	 J� RenderTransformOrigin$	 7.708,0.403&�6B   $��
10,0,-10,0q�6f   5      m� 5      -   5        $ meniu2��5      $y�Hidden=�6'   $��_Meniul Restaurantului��6;   $��	Bodoni MT)�6[   $��16(�6r   ���#493B5C$	��167��6�   $��34��6�   ���	#FF0DE97C$
��Bold"�6�   6�   m� 5      -   5        $ comenzi��5      $y�Hidden=�6(   $��Comenzile mele��6<   $��	Bodoni MT)�6T   $��16(�6k   ���#493B5C$	��119��6�   $��34��6�   ���	#FF0DE97C$
��Bold"�6�   6�   5      �� 5   
   ���	#FF0DE97C$��1q�6)   $
��Left=�6=   $	��292��6X   $��	22,95,0,0q�6e   $	��Top=�6x   $	��435��6�   ���	#FF0DE97C6�   �� 5   
   $&�� Images_MainWindow/tasty_food.jpg��6   $��Center=�6:   $	��282��6W   $��-57,99,247.333,0q�6d   $	��Top=�6~   $	��603��6�   �� 5   
   $#��Images_MainWindow/welcome.png��6   $
��Left=�67   $��56��6R   $��
238,39,0,0q�6^   $	��Top=�6r   $	��308��6�   �� 5   
   $��Hello,��6   $
��Left=�6!   $��504,215,0,0q�6<   $	��Top=�6Q   $	 0.316,0.564&�6i   $��51��6�   $��69��6�   $
��Bold"�6�   $��Times New Roman)�6�   $��18(�6�   ���	#FF0E45186�   �� 5   
   -   5        $��emaill��5      $
��Left=�6   $��552,215,0,0q�69   $	��Top=�6N   $	 0.316,0.564&�6f   $��51��6�   $	��212��6�   $
��Bold"�6�   $��Times New Roman)�6�   $��18(�6�   ���	#FF0E45186�   � 5!   
   -   5        $��initial��5!   $   $y�Visible=�6   $��504,134,38.333,63.667q�63   ���	#FF2CA4A4.+�5"      �� -   5        $��	logareBtn��5"      $��Logare��6&   $
��Left=�67   $��	43,56,0,0q�6R   $	��Top=�6e   $	��146��6}   ���	#FF0DE97C���	#FF206DE8$��45��6�   $
��Bold"�6�   $��Segoe UI Black)�6�   $��14(�6  $��3��6<  ��6�   Z� ��6  �� *OpenWindowCommand+
 � ToolTip
 5#      _� 5$      .��5%      �� $!��Images_MainWindow/login.png��6    $��30��6E   $��30��6P   6^   5&      5(      �� 5)      $��~ Pentru a va loga :��6   $
��Left=�63   $��	30,19,0,0q�6N   $	��Top=�6a   $��Segoe UI Symbol)�6y   $
��Bold"�6�   �� 5*      -	   5        $��	creareBtn��5*      $��Creare cont��6&   $
��Left=�6<   $��
43,156,0,0q�6W   $	��Top=�6k   $	��146��6�   ���	#FF0DE97C���	#FF206DE8$��45��6�   $
��Bold"�6�   $��Segoe UI Black)�6�   $��14(�6  $��4��6B  ��6�   Z� ��6  �� *OpenWindowCommand+
 5+      _� 5,      .��5-      �� $*��$Images_MainWindow/create-account.png��6    $��30��6N   $��30��6Y   6g   5.      50      �� 51      $ ��~ Pentru a crea cont nou :��6   $
��Left=�69   $��
30,119,0,0q�6T   $	��Top=�6h   $��Segoe UI Symbol)�6�   $	��196��6�   $
��Bold"�6�   53      �� 54   
   -
   5        $��border��54      $y�Visible=�6   ���	#FF0DE97C$��1q�6L   $
��Left=�6`   $	��223��6{   $��504,134,38.333,63.667q�6�   $	��Top=�6�   $	��251��6�   �� 56   
   $!��Images_MainWindow/happy.png��6   $
��Left=�65   $��90��6P   $��
658,43,0,0q�6\   $	��Top=�6p   $��74��6�   $	 0.5,0.5&�6�   z�57      V� 58      .~�59      ��  �� ScaleX$ -1Q�6%   �� 5:      �� 5;      T� 5<      5=      5?      �� 5@   
   -   5        $	��log��5@   5   $!��Images_MainWindow/login.png��6   $y�Visible=�6@   $
��Left=�6U   $��17��6p   $��551,193,0,0q�6|   $	��Top=�6�   $��17��6�   $	 0.444,0.506&�6�   �� 5A   
   -   5        $��creere��5A      $y�Visible=�6   $*��$Images_MainWindow/create-account.png��63   $
��Left=�6a   $��15��6|   $��551,295,0,0q�6�   $	��Top=�6�   $��15��6�   $	 0.444,0.506&�6�   �� 5B   
   $
��Left=�6   $	��100��6+   $��-269,310,0,0q�68   $	��Top=�6N   $	��100��6f   5D      5E      