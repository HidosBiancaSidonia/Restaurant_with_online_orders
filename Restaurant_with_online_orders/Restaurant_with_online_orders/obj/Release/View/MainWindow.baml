   M S B A M L   `   `   `  ���� X  TRestaurant_with_online_orders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Restaurant_with_online_ordersRestaurant_with_online_orders  a5clr-namespace:Restaurant_with_online_orders.ViewModel'Restaurant_with_online_orders.ViewModel  .    (Restaurant_with_online_orders.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     =local+clr-namespace:Restaurant_with_online_orders     Hlocal15clr-namespace:Restaurant_with_online_orders.ViewModel       � 
ResizeMode$  CanMinimize=� � Title$ 
Restaurant��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=� � Icon$! Images_MainWindow/icon .png�� � DataContext 8  2Restaurant_with_online_orders.ViewModel.MainViewVM  .��� -   $
��main�����	#FF9CE9C5.+�o� $
��Left=�$��34��$	��Top=�$	��793�����	#FFBA7474.@�m� $��_Meniul Restaurantului��$��	Bodoni MT)�$��16(����#493B5C$	��167��$��34�����	#FF0DE97C$
��Bold"� m� CommandParameter$ 1�� m� Command �� *OpenWindowCommand+m� -   $��
cautareBtn��$��   Cauta in meniu��$��	Bodoni MT)�$��16(����#493B5C$	��162��$��34�����	#FF0DE97C$
��Bold"�$ 2�� �� *OpenWindowCommand+ m� Icon �� $"��Images_MainWindow/search.png�� J� RenderTransformOrigin$ 7.708,0.403&�$��
10,0,-10,0q��� ���	#FF0DE97C$��1q�$
��Left=�$	��292��$��	22,95,0,0q�$	��Top=�$	��435�����	#FF0DE97C�� $&�� Images_MainWindow/tasty_food.jpg��$��Center=�$	��282��$��-57,99,247.333,0q�$	��Top=�$	��603���� $#��Images_MainWindow/welcome.png��$
��Left=�$��56��$��
238,39,0,0q�$	��Top=�$	��308��� $��504,134,38.333,63.667q����	#FF2CA4A4.+��� -   $��	logareBtn��$��Logare��$
��Left=�$��	43,56,0,0q�$	��Top=�$	��146�����	#FF0DE97C���	#FF206DE8$��45��$
��Bold"�$��Segoe UI Black)�$��14(�$��3����Z� ���� *OpenWindowCommand+	 � ToolTip	 _� .���� $!��Images_MainWindow/login.png��$��30��$��30���� $��~ Pentru a va loga :��$
��Left=�$��	30,19,0,0q�$	��Top=�$��Segoe UI Symbol)�$
��Bold"��� -   $��	creareBtn��$��Creare cont��$
��Left=�$��
43,156,0,0q�$	��Top=�$	��146�����	#FF0DE97C���	#FF206DE8$��45��$
��Bold"�$��Segoe UI Black)�$��14(�$��4����Z� ���� *OpenWindowCommand+	 _� .���� $*��$Images_MainWindow/create-account.png��$��30��$��30���� $ ��~ Pentru a crea cont nou :��$
��Left=�$��
30,119,0,0q�$	��Top=�$��Segoe UI Symbol)�$	��196��$
��Bold"��� ���	#FF0DE97C$��1q�$
��Left=�$	��223��$��504,134,38.333,63.667q�$	��Top=�$	��251���� $!��Images_MainWindow/happy.png��$
��Left=�$��90��$��
658,43,0,0q�$	��Top=�$��74��$ 0.5,0.5&�z�V� .~��� 
 �� ScaleX$
 -1Q��� �� T� �� $!��Images_MainWindow/login.png��$
��Left=�$��17��$��551,193,0,0q�$	��Top=�$��17��$ 0.444,0.506&��� $*��$Images_MainWindow/create-account.png��$
��Left=�$��15��$��551,295,0,0q�$	��Top=�$��15��$ 0.444,0.506&�