   M S B A M L   `   `   `  ����X  TRestaurant_with_online_orders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Restaurant_with_online_orders.View"Restaurant_with_online_orders.View  5   	   a5clr-namespace:Restaurant_with_online_orders.ViewModel'Restaurant_with_online_orders.ViewModel  5   	   /    )Restaurant_with_online_orders.View.Search   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:Restaurant_with_online_orders.View     5   	   Hlocal15clr-namespace:Restaurant_with_online_orders.ViewModel     5   	     � 
ResizeMode$  CanMinimize=�5	   	    � Title$ Cautari��5
   	   $	��450��6   $	��800��6&    � WindowStartupLocation$ CenterScreen=�62    � Icon$! Images_MainWindow/icon .png��5   	    � DataContext 5      6  0Restaurant_with_online_orders.ViewModel.SearchVM  5   
   .��5      � ���	#FF9CE9C5 5   
     5      .+�5   
   �� -   5        $
��text��5      $
��Left=�6   $��27��69   $��
51,109,0,0q�6E    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6n   $	��251��6�   $
��Bold"�6�   $��MS UI Gothic)�6�   $��20(�6�   ���	#FFBAE2A4 �� TextAlignment$ Center=�6�   �� 5   
   -   5        $
��list��5      $y�Hidden=�6   $
��Left=�63   $	��216��6N   $��
389,26,0,0q�6[   $	��Top=�6o   $	��365��6�   ��6�   �� *ListPreparate+ �� UpdateSourceTrigger$ PropertyChanged=� �� View 5      �� 5      .P�5      �� $��	Categorie��6%   	 �� DisplayMemberBinding	 68   �� *	Categorie+�� 5      $��Denumire��6%   	 67   �� *
Denumire+�� 5      $��Cantitate in grame��6%   	 6A   �� *	Cantitate+�� 5      $��Pret in lei��6%   	 6:   �� *Pret+5      5      �� 5   
   $%��Introduceti cuvantul dupa care ��6   $
��Left=�6:   $��	47,26,0,0q�6U   $	��Top=�6h   $
��Bold"�6�   $��Times New Roman)�6�   $��18(�6�   $	��292��6�   �� 5    
   -   5        $��alergen��5       $��Sa contina acest alergen��6"   $
��Left=�6E   $��
51,170,0,0q�6`   $	��Top=�6t   $	��226��6�   $
��Bold"�6�   $��MS UI Gothic)�6�   $��16(�6�   6�   �� 5!   
   -   5        $��
nu_alergen��5!      $!��Sa nu contina acest alergen��6%   $
��Left=�6K   $��
51,226,0,0q�6f   $	��Top=�6z   $	��226��6�   $
��Bold"�6�   $��MS UI Gothic)�6�   $��16(�6�   6�   �� 5"   
   -   5        $��
ingredient��5"      $!��Sa contina acest incredient��6%   $
��Left=�6K   $��
51,288,0,0q�6f   $	��Top=�6z   $	��243��6�   $��MS UI Gothic)�6�   $
��Bold"�6�   $��16(�6�   6�   �� 5#   
   -   5        $��nu_ingredient��5#      $$��Sa nu contina acest incredient��6(   $
��Left=�6Q   $��
51,350,0,0q�6l   $	��Top=�6�   $	��243��6�   $��MS UI Gothic)�6�   $
��Bold"�6�   $��16(�6�   6�   �� 5$   
   $0��*faceti cautarea in meniul restaurantului :��6   $
��Left=�6E   $��	21,62,0,0q�6`   $	��Top=�6s   $
��Bold"�6�   $��Times New Roman)�6�   $��18(�6�   �� 5%   
   $
��Fill=�6p   $
��Left=�6   $	��146��6�   $��389,247,0,0q�6�   $	��Top=�6�   $	��172��6�   ��6   �� 
 �� ElementName$

 list�� �� Path$ SelectedItem.Img�$ PropertyChanged=�6�   �� 5&   
   $
��Left=�6   
������ 
������ $	��124��6`   $��597,288,0,0q�6m   $	��Top=�6�   $	��157��6�    J� RenderTransformOrigin$ 0.541,0.549&�6  ��6�   �� $

 list��$ SelectedItem.ListAlergeni�$ PropertyChanged=�6  �� 5'   
   -   5        $��alergeni��5'      $y�Hidden=�6    $��Lista alergeni:��64   $
��Left=�6N   $��597,259,0,0q�6i   $	��Top=�6~   $
��Bold"�6�   $��	MS Gothic)�6�   $��14(�6�   �� 5(   
   -   5        $
��poza��5(      $
��Left=�6   $	��383��67   $��414,10,-46.333,0q�6D   $	��Top=�6^   $	��427��6v   $��Images_Meniu/bucatar.jpeg��6�   5*      5+      