   M S B A M L   `   `   `  ���� X  TRestaurant_with_online_orders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Restaurant_with_online_orders.View"Restaurant_with_online_orders.View  a5clr-namespace:Restaurant_with_online_orders.ViewModel'Restaurant_with_online_orders.ViewModel  .    (Restaurant_with_online_orders.View.LogIn   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Clocal10clr-namespace:Restaurant_with_online_orders.View     Glocal5clr-namespace:Restaurant_with_online_orders.ViewModel       � 
ResizeMode$  CanMinimize=� � Title$ Logare��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=� � Icon$ Images_LogIn/icon .png�� � DataContext 8  2Restaurant_with_online_orders.ViewModel.MainViewVM  .��� ���	#FF9CE9C5.+��� $
��Left=�$	��272��$��595,169,-59.667,-20.333q�$	��Top=�$	��258��$��Images_LogIn/desert.jpg���� $
��Left=�$	��288��$��-9,237,0,-104.333q�$	��Top=�$	��254��$��Images_LogIn/food.jpg�� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� ��  �� Angle$ -11.828Q�T� �� $
��Left=�$	��168��$��547,12,-39.667,0q�$	��Top=�$	��286��$��Images_LogIn/food1.jpg��$ 0.5,0.5&�z�V� .~��� �� �� $ 20.848Q�T� �� $
��Left=�$	��226��$��	-5,17,0,0q�$	��Top=�$	��311��$��Images_LogIn/food2.jpg��$ 0.5,0.5&�z�V� .~��� �� �� $ -12.325Q�T� �� $
��Left=�$��53��$��
349,10,0,0q�$	��Top=�$	��120��$��Images_LogIn/desert1.jpg���� $
��Left=�$��50��$��
445,10,0,0q�$	��Top=�$��71��$��Images_LogIn/desert2.jpg��$ 	0.34,0.44&��� -   $��Inapoi��$
��Left=�$��366,373,0,0q�$	��Top=�$	��103�����	#FFD5A2E6$��Britannic Bold)�$��33��� ���	#FFD5A2E6$
��Left=�$	��299��$��235,69,0,54q�$��Center=�$	��355��.+��� $'��!Introduceti datele dumneavoastra:��$
��Left=�$��	25,10,0,0q�$	��Top=�$��36��$	��293��$��Britannic Bold)�$��18(��� $��Nume de utilizator:��$
��Left=�$��	25,46,0,0q�$	��Top=�$
��Bold"�$��16(�$ 0.52,-0.277&��� $��Parola :��$
��Left=�$��
25,117,0,0q�$	��Top=�$
��Bold"�$��16(�$ 0.573,-0.798&��� -   $��nume_utilizator��$��77,87,74,187q����	#FF9CE9C5�� $��Logare��$
��Left=�$��
44,217,0,0q�$	��Top=�$	��103�����	#FF9CE9C5$��Britannic Bold)�$��33������ *LogInCommand+G� -   $
��pass��$
��Left=�$��
77,153,0,0q�$	��Top=�$	��204��$��26�����	#FF9CE9C5�� -   $��Creare cont��$
��Left=�$��215,217,0,0q�$	��Top=�$	��103�����	#FF9CE9C5$��Britannic Bold)�$��33��$��4������ *OpenWindowCommand+