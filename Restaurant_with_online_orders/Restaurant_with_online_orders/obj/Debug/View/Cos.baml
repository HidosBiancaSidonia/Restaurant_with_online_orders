   M S B A M L   `   `   `  ����X  TRestaurant_with_online_orders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Restaurant_with_online_orders.View"Restaurant_with_online_orders.View  5   	   a5clr-namespace:Restaurant_with_online_orders.ViewModel'Restaurant_with_online_orders.ViewModel  5   	   ,    &Restaurant_with_online_orders.View.Cos   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:Restaurant_with_online_orders.View     5   	   Hlocal15clr-namespace:Restaurant_with_online_orders.ViewModel     5   	   -   5          � 
ResizeMode$  CanMinimize=�5	   	    � Title$	 Cos��5
   	   $	��450��6   $	��800��6"    � WindowStartupLocation$ CenterScreen=�6.    � Icon$ Images_LogIn/icon .png��5   	    � DataContext 5      7  1Restaurant_with_online_orders.ViewModel.ComenziVM  5   
   .��5      � ���	#FF9CE9C5.+�5   
   �� $
��Left=�6   $��93��6+   $��	105,0,0,0q�67   $	��Top=�6J   $	��269��6b   $��Images_Meniu/citat.png��6n   �� 5   
   -   5        $
��list��5      $
��Left=�6   $	��244��6:   $��	27,71,0,0q�6G   $	��Top=�6Z   $	��409��6r   ��6~   �� *	ListCos+ �� UpdateSourceTrigger$ PropertyChanged=� �� View 5      �� 5      .P�5      �� $��Denumire��6%    �� DisplayMemberBinding 67   �� *
Denumire+�� 5      $��Cantitate in grame��6%    6A   �� *	Cantitate+�� 5      $��Pret in lei��6%    6:   �� *Pret+5      5      �� 5   
   -   5         ��Name$ comanda��5      $��COMANDA��6"   {�.  $
��Left=�6F   $��541,349,0,0q�6a   $	��Top=�6v   $	��133��6�   $��44��6�   $
��Bold"�6�   ���	#FFBAE2A4���	#FFEB2F2F���	#FFE91C1C��6�   �� *ComandaCommand+6!  �� 5   
   $��Total pret:��6   $
��Left=�6&   $��105,349,0,0q�6A   $	��Top=�6V   $
��Bold"�6n   $��Times New Roman)�6�   $��18(�6�   �� 5   
   ���	#FFED2323$��1q�6)   $
��Left=�6=   $��52��6X   $��231,341,0,0q�6d   $	��Top=�6y   $��91��6�   ._�5      �� -   5        	 ��Name$	 	pretTotal��5   =   
 �� 
IsReadOnly
 .  �� TextWrapping$
 Wrap=�6(   $��Times New Roman)�6P   $
��Bold"�6m   $��18(�6   ���	#FFBAE2A4 �� TextAlignment$ Center=�6�   5       �� 5!   
   $'��!Daca pretul total depaseste suma ��6   $
��Left=�6<   $��
470,25,0,0q�6W   $	��Top=�6k   $
��Bold"�6�   $��Times New Roman)�6�   $��20(�6�   $��37��6�   �� 5"   
   $!��de 200 de lei va oferim un ��6   $
��Left=�66   $��
497,67,0,0q�6Q   $	��Top=�6e   $
��Bold"�6}   $��Times New Roman)�6�   $��20(�6�   $��37��6�   �� 5#   
   $��discount de 10%.��6   $
��Left=�6+   $��541,104,0,0q�6F   $	��Top=�6[   ���	#FFE02929$��Times New Roman)�6�   $��20(�6�   $��37��6�   $
��Bold"�6�   �� 5$   
   -   5        $ discount��5$      $��Adauga discount��6#   $
��Left=�6=   $��565,141,0,0q�6X   $	��Top=�6m   $	��133��6�   $��36��6�   ���	#FFBAE2A4$
��Bold"�6�   6�   �� 5%   
   ���	#FFED2323$��1q�6)   $
��Left=�6=   $��53��6X   $��675,262,0,0q�6d   $	��Top=�6y   $��91��6�   ._�5&      �� -   5        $	 pretTotalCuFaraD��5&   =   
 . $
 Wrap=�6(   $��Times New Roman)�6W   $
��Bold"�6t   $��18(�6�   ���	#FFBAE2A4$ Center=�6�   5'      �� 5(   
   $��Pretul total al comenzii:��6   $
��Left=�64   $��470,284,0,0q�6O   $	��Top=�6d   $
��Bold"�6|   $��Times New Roman)�6�   $��18(�6�   �� 5)   
   $
��Left=�6   $��64��6+   $��403,337,0,0q�67   $	��Top=�6L   $��79��6d   $!��Images_MainWindow/happy.png��6o    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5*      V� 5+      .~�5,      ��  �� ScaleX$ -1Q�6%   �� 5-      �� 5.      T� 5/      50      52      �� 53   
   $<��6~ Daca pretul total nu depaseste valoarea de 80 de lei��6   $
��Left=�6Q   $��457,196,0,0q�6l   $	��Top=�6�   $
��Bold"�6�   �� 54   
   $=��7se va percepe o taxa de transport in valoare de 15 lei.��6   $
��Left=�6R   $��470,222,0,0q�6m   $	��Top=�6�   $
��Bold"�6�   55      56      