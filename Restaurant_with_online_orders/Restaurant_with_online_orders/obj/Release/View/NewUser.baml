   M S B A M L   `   `   `  ���� X  TRestaurant_with_online_orders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Restaurant_with_online_orders.View"Restaurant_with_online_orders.View  a5clr-namespace:Restaurant_with_online_orders.ViewModel'Restaurant_with_online_orders.ViewModel  c6clr-namespace:Restaurant_with_online_orders.Converters(Restaurant_with_online_orders.Converters  0    *Restaurant_with_online_orders.View.NewUser   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Blocal0clr-namespace:Restaurant_with_online_orders.View     Hlocal15clr-namespace:Restaurant_with_online_orders.ViewModel     QlocalConverter6clr-namespace:Restaurant_with_online_orders.Converters       � 
ResizeMode$  CanMinimize=� � Title$ Creare cont��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=� � Icon$! Images_MainWindow/icon .png�� � DataContext 4  .Restaurant_with_online_orders.ViewModel.UserVM  .��� ���	#FF9CE9C5.+�� ���	#FFD5A2E6$
��Left=�$	��299��$��168,13,0,110q�$��Center=�$	��461�� � 	Resources @  :Restaurant_with_online_orders.Converters.NewUserConverters   userConvert��%   &	          .+��� $=��7Introduceti datele dumneavoastra pentru a crea contul :��$
��Left=�$��	25,10,0,0q�$	��Top=�$��36��$	��426��$��Britannic Bold)�$��16(��� $��Email :��$
��Left=�$��
90,118,0,0q�$	��Top=�$
��Bold"�$��14(��� $��Nume :��$
��Left=�$��	80,63,0,0q�$	��Top=�$
��Bold"�$��14(��� $��	Prenume :��$
��Left=�$��	61,88,0,0q�$	��Top=�$
��Bold"�$��14(��� $��Parola :��$
��Left=�$��
84,147,0,0q�$	��Top=�$
��Bold"�$��14(��� $��	Telefon :��$
��Left=�$��
84,181,0,0q�$	��Top=�$
��Bold"�$��14(� J� RenderTransformOrigin$ 0.485,0.407&��� $��Adresa de livrare:��$
��Left=�$��
25,206,0,0q�$	��Top=�$
��Bold"�$��14(��� -   $
��nume��$
��Left=�$��23��$��
154,63,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��279���� -   $��prenume��$
��Left=�$��23��$��
154,94,0,0q�$
 Wrap=�$	��Top=�$	��279���� -   $��email��$
��Left=�$��23��$��154,125,0,0q�$
 Wrap=�$	��Top=�$	��279���� -   $��telefon��$
��Left=�$��23��$��154,178,0,0q�$
 Wrap=�$	��Top=�$	��279���� -   $��adresa��$
��Left=�$��40��$��154,211,0,0q�$
 Wrap=�$	��Top=�$	��279��G� -   $��parola��$
��Left=�$��154,153,0,0q�$	��Top=�$	��279��$��20���� $��Creare cont��$
��Left=�$��181,256,0,0q�$	��Top=�$	��103�����	#FF9CE9C5$��Britannic Bold)�$��33������ *	AddClient+��`�  `� 	Converter# [  .1��� 	 �� ElementName$
	 nume��
 �� Path$

 Text��� $	 prenume��$

 Text��� $	 email��$

 Text��� $	 parola��$.
 ((localConverter:PasswordHelper.Password)��� $	 telefon��$

 Text��� $	 adresa��$

 Text��� -   $��Inapoi��$
��Left=�$��	10,10,0,0q�$	��Top=�$	��103�����	#FFD5A2E6$��Britannic Bold)�$��33���� $��Images_LogIn/desert.jpg��$
��Left=�$	��221��$��638,190,0,0q�$	��Top=�$	��140��$ 0.514,0.661&��� $��Images_LogIn/desert1.jpg��$
��Left=�$	��197��$��	10,69,0,0q�$	��Top=�$	��144���� $��Images_LogIn/desert2.jpg��$
��Left=�$	��145��$��
10,266,0,0q�$	��Top=�$	��144���� $��Images_LogIn/desert3.jpg��$
��Left=�$	��123��$��
645,31,0,0q�$	��Top=�$	��133���� $��Images_LogIn/desert4.jpg��$
��Left=�$��99��$��327,323,0,0q�$	��Top=�$	��139���� $��Images_LogIn/desert.png��$
��Left=�$��68��$��205,323,0,0q�$	��Top=�$��75���� $
��Left=�$��61��$��540,339,0,0q�$	��Top=�$��32��$��Images_LogIn/cupcake.png��