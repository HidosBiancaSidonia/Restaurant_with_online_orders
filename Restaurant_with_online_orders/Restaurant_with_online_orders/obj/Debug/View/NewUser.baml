   M S B A M L   `   `   `  ����X  TRestaurant_with_online_orders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Restaurant_with_online_orders.View"Restaurant_with_online_orders.View  5   	   a5clr-namespace:Restaurant_with_online_orders.ViewModel'Restaurant_with_online_orders.ViewModel  5   	   c6clr-namespace:Restaurant_with_online_orders.Converters(Restaurant_with_online_orders.Converters  5   	   0    *Restaurant_with_online_orders.View.NewUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:Restaurant_with_online_orders.View     5   	   Hlocal15clr-namespace:Restaurant_with_online_orders.ViewModel     5   	   QlocalConverter6clr-namespace:Restaurant_with_online_orders.Converters     5   	     � 
ResizeMode$  CanMinimize=�5
   	    � Title$ Creare cont��5   	   $	��450��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�66    � Icon$! Images_MainWindow/icon .png��5   	    � DataContext 5      4  .Restaurant_with_online_orders.ViewModel.UserVM  5   
   .��5      � ���	#FF9CE9C5.+�5   
   � ���	#FFD5A2E6$
��Left=�6'   $	��299��6B   $��168,13,0,110q�6O   $��Center=�6e   $	��461��6�    � 	Resources 5      @  :Restaurant_with_online_orders.Converters.NewUserConverters   userConvert��%   &	          5      63   5      .+�5      �� $=��7Introduceti datele dumneavoastra pentru a crea contul :��6   $
��Left=�6V   $��	25,10,0,0q�6q   $	��Top=�6�   $��36��6�   $	��426��6�   $��Britannic Bold)�6�   $��16(�6�   �� 5      $��Email :��6   $
��Left=�6&   $��
90,118,0,0q�6A   $	��Top=�6U   $
��Bold"�6m   $��14(�6   �� 5      $��Nume :��6   $
��Left=�6%   $��	80,63,0,0q�6@   $	��Top=�6S   $
��Bold"�6k   $��14(�6}   �� 5      $��	Prenume :��6   $
��Left=�6(   $��	61,88,0,0q�6C   $	��Top=�6V   $
��Bold"�6n   $��14(�6�   �� 5      $��Parola :��6   $
��Left=�6'   $��
84,147,0,0q�6B   $	��Top=�6V   $
��Bold"�6n   $��14(�6�   �� 5      $��	Telefon :��6   $
��Left=�6(   $��
84,181,0,0q�6C   $	��Top=�6W   $
��Bold"�6o   $��14(�6�    J� RenderTransformOrigin$ 0.485,0.407&�6�   �� 5      $��Adresa de livrare:��6   $
��Left=�61   $��
25,206,0,0q�6L   $	��Top=�6`   $
��Bold"�6x   $��14(�6�   �� 5      -   5        $
��nume��5      $
��Left=�6"   $��23��6=   $��
154,63,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $	��Top=�6r   $	��279��6�   �� 5      -   5        $��prenume��5      $
��Left=�6%   $��23��6@   $��
154,94,0,0q�6L   $
 Wrap=�6`   $	��Top=�6u   $	��279��6�   �� 5      -   5        $��email��5      $
��Left=�6#   $��23��6>   $��154,125,0,0q�6J   $
 Wrap=�6_   $	��Top=�6t   $	��279��6�   �� 5      -   5        $��telefon��5      $
��Left=�6%   $��23��6@   $��154,178,0,0q�6L   $
 Wrap=�6a   $	��Top=�6v   $	��279��6�   �� 5       -   5        $��adresa��5       $
��Left=�6$   $��40��6?   $��154,211,0,0q�6K   $
 Wrap=�6`   $	��Top=�6u   $	��279��6�   G� 5!      -   5        $��parola��5!      $
��Left=�6(   $��154,153,0,0q�6C   $	��Top=�6X   $	��279��6p   $��20��6|   =  7Restaurant_with_online_orders.Converters.PasswordHelper   Attach . 	   Password	 6�   �� 
 �� Path$
 Password��� 5"      $��Creare cont��6   $
��Left=�6+   $��181,256,0,0q�6F   $	��Top=�6[   $	��103��6s   ���	#FF9CE9C5$��Britannic Bold)�6�   $��33��6�   ��6�   �� *	AddClient+��5#      `� 5$       `� 	Converter# [  6#   .1�5%      ��  �� ElementName$
 nume��6"   $

 Text�65   �� 5&      $ prenume��6"   $

 Text�68   �� 5'      $ email��6"   $

 Text�66   �� 5(      $ parola��6"   $.
 ((localConverter:PasswordHelper.Password)�67   �� 5)      $ telefon��6"   $

 Text�68   �� 5*      $ adresa��6"   $

 Text�67   5+      5-      5/      �� 50   
   -   5        $��Inapoi��50      $
��Left=�6"   $��	10,10,0,0q�6=   $	��Top=�6P   $	��103��6h   ���	#FFD5A2E6$��Britannic Bold)�6�   $��33��6�   6�   �� 51   
   $��Images_LogIn/desert.jpg��6   $
��Left=�61   $	��221��6L   $��638,190,0,0q�6Y   $	��Top=�6n   $	��140��6�   $ 0.514,0.661&�6�   �� 52   
   $��Images_LogIn/desert1.jpg��6   $
��Left=�62   $	��197��6M   $��	10,69,0,0q�6Z   $	��Top=�6m   $	��144��6�   �� 53   
   $��Images_LogIn/desert2.jpg��6   $
��Left=�62   $	��145��6M   $��
10,266,0,0q�6Z   $	��Top=�6n   $	��144��6�   �� 54   
   $��Images_LogIn/desert3.jpg��6   $
��Left=�62   $	��123��6M   $��
645,31,0,0q�6Z   $	��Top=�6n   $	��133��6�   �� 55   
   $��Images_LogIn/desert4.jpg��6   $
��Left=�62   $��99��6M   $��327,323,0,0q�6Y   $	��Top=�6n   $	��139��6�   �� 56   
   $��Images_LogIn/desert.png��6   $
��Left=�61   $��68��6L   $��205,323,0,0q�6X   $	��Top=�6m   $��75��6�   �� 57   
   $
��Left=�6   $��61��6+   $��540,339,0,0q�67   $	��Top=�6L   $��32��6d   $��Images_LogIn/cupcake.png��6o   59      5:      