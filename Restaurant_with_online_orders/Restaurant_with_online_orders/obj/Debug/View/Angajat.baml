   M S B A M L   `   `   `  ����X  TRestaurant_with_online_orders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Restaurant_with_online_orders.View"Restaurant_with_online_orders.View  5   	   a5clr-namespace:Restaurant_with_online_orders.ViewModel'Restaurant_with_online_orders.ViewModel  5   	   c6clr-namespace:Restaurant_with_online_orders.Converters(Restaurant_with_online_orders.Converters  5   	   0    *Restaurant_with_online_orders.View.Angajat   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:Restaurant_with_online_orders.View     5   	   Hlocal15clr-namespace:Restaurant_with_online_orders.ViewModel     5   	   QlocalConverter6clr-namespace:Restaurant_with_online_orders.Converters     5   	     � 
ResizeMode$  CanMinimize=�5
   	    � Title$ Angajati��5   	   $	��450��6   $	��800��6'    � WindowStartupLocation$ CenterScreen=�63    � Icon$! Images_MainWindow/icon .png��5   	    � DataContext 5      7  1Restaurant_with_online_orders.ViewModel.AngajatVM  5   
   .��5      � ���	#FF9CE9C5.+�5   
   o� $
��Left=�6   $��34��6*   $	��Top=�66   $	��793��6N   ���	#FFBA7474.@�5      m� -   5        $��Modifica Meniu��5      $��	Bodoni MT)�6/   $��16(�6F   ���#493B5C$	��116��6i   $��34��6u   ���	#FF0DE97C$
��Bold"�6�    m� CommandParameter$ 1��6�    m� Command 6�   �� *OpenWindowCommand+6�   m� 5      -   5        $��Vizualizare comenzi��5      $��	Bodoni MT)�64   $��16(�6K   ���#493B5C$	��144��6n   $��34��6z   ���	#FF0DE97C$
��Bold"�6�   $ 2��6�    6�   �� *OpenWindowCommand+6�   m� 5      -   5        $ ��Vizualizare comenzi active��5      $��	Bodoni MT)�6;   $��16(�6R   ���#493B5C$	��186��6u   $��34��6�   ���	#FF0DE97C$
��Bold"�6�   $ 3��6�    6�   �� *OpenWindowCommand+6�   m� 5      -   5        $,��&Preparate care se apropie de terminare��5      $��	Bodoni MT)�6G   $��16(�6^   ���#493B5C$	��268��6�   $��34��6�   ���	#FF0DE97C$
��Bold"�6�   $ 4��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�    6�   �� *OpenWindowCommand+6  5      � 5   
   -   5        $��	MainFrame��5      $y�Visible=�6    $
��Left=�65   $	��388��6P   $��0,34,-0.333,0q�6]   $	��Top=�6t   $	��795��6�   .+�5      �� -   5         ��Name$	 img��5      $y�Visible=�6!   $
��Left=�66   $	��340��6R   $��127,26,-40,0q�6_   $	��Top=�6u   $	��708��6�   $&�� Images_MainWindow/restaurant.jpg��6�   5      � 5   
   -   5        $��comenzi��5      $y�Hidden=�6   $
��Left=�62   $	��388��6M   $	��Top=�6Z   $	��795��6r   $��0,34,-0.333,0q�6~    5      >  8Restaurant_with_online_orders.ViewModel.ToateComenzileVM  5       .+�5"      �� -   5        $��listcomenzi��5"      $
��Left=�6*   $	��355��6E   $��	10,10,0,0q�6R   $	��Top=�6e   $	��475��6}   ��6�   �� *ListComenzi+	 �� View	 5#      �� 5$      .P�5%      �� $��Data comenzii ��6)   
 �� DisplayMemberBinding
 6A   �� *DataComenzii+�� 5&      $��Codul comenzii��6)   
 6A   �� *Cod+�� 5'      $��Produsele comandate��6)    �� CellTemplate 5(      �� 5)   "   .R�5*   &   �� ��6.   �� *	Produse+5+   #   5-      �� 5.      $��Pret comanda��6)   
 6?   �� *Pret+�� 5/      $��Starea comenzii��6)   
 6B   �� *Stare+�� 50      $��Ora livrarii��6)   
 6?   �� *OraLivrarii+51      53      �� 55      $��Client ��6   $
��Left=�6&   $��
609,34,0,0q�6A   $	��Top=�6U   $
��Bold"�6m   $��Times New Roman)�6   $��22(�6�   ���	#FF145F176�   �� 56      $��Nume :��6   $
��Left=�6%   $��
517,86,0,0q�6@   $	��Top=�6T   $
��Bold"�6l   �� 57      $��	Prenume :��6   $
��Left=�6(   $��500,134,0,0q�6C   $	��Top=�6X   $
��Bold"�6p   �� 58      $��Nr. Telefon :��6   $
��Left=�6,   $��489,183,0,0q�6G   $	��Top=�6\   $
��Bold"�6t   �� 59      $��Adresa :��6   $
��Left=�6'   $��512,235,0,0q�6B   $	��Top=�6W   $
��Bold"�6o   �� 5:       �� 
IsReadOnly . $
��Left=�6(   $��23��6C   $��
575,89,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6x   $	��191��6�   ��5;      ��  �� ElementName$ listcomenzi�� �� Path$ SelectedItem.Nume� �� UpdateSourceTrigger$ PropertyChanged=��� 5<       . $
��Left=�6(   $��23��6C   $��575,137,0,0q�6O   $
 Wrap=�6d   $	��Top=�6y   $	��191��6�   ��5=      �� $ listcomenzi��$ SelectedItem.Prenume�$ PropertyChanged=��� 5>       . $
��Left=�6(   $��23��6C   $��575,186,0,0q�6O   $
 Wrap=�6d   $	��Top=�6y   $	��191��6�   ��5?      �� $ listcomenzi��$ SelectedItem.Nr_Telefon�$ PropertyChanged=��� 5@       . $
��Left=�6(   $��53��6C   $��575,235,0,0q�6O   $
 Wrap=�6d   $	��Top=�6y   $	��191��6�   ��5A      �� $ listcomenzi��$ SelectedItem.Adresa�$ PropertyChanged=�5B      � 5C   
   -	   5        $��comenziActive��5C      $y�Hidden=�6$   $
��Left=�68   $	��388��6S   $��0,34,-0.333,0q�6`   $	��Top=�6w   $	��795��6�    5D        5E       � 	Resources 5G      A  ;Restaurant_with_online_orders.Converters.StareNouaConverter   stareConvert��%   &	          5H      64   5I      .+�5J      �� -
   5        $��listcomenziActive��5J      $
��Left=�60   $	��355��6K   $��	10,10,0,0q�6X   $	��Top=�6k   $	��475��6�   ��6�   �� *ListComenzi+	 5K      �� 5L      .P�5M      �� $��Data comenzii ��6)   
 6A   �� *DataComenzii+�� 5N      -   5        cod��$��Codul comenzii��5N   6   
 6N   �� *Cod+�� 5O      $��Produsele comandate��6)    5P      �� 5Q   "   .R�5R   &   �� ��6.   �� *	Produse+5S   #   5U      �� 5V      $��Pret comanda��6)   
 6?   �� *Pret+�� 5W      $��Starea comenzii��6)   
 6B   �� *Stare+5X      5Z      �� 5[      $��Client ��6   $
��Left=�6&   $��
610,10,0,0q�6A   $	��Top=�6U   $
��Bold"�6m   $��Times New Roman)�6   $��22(�6�   ���	#FF145F176�   �� 5\      $��Nume :��6   $
��Left=�6%   $��
517,43,0,0q�6@   $	��Top=�6T   $
��Bold"�6l   �� 5]      $��	Prenume :��6   $
��Left=�6(   $��
500,69,0,0q�6C   $	��Top=�6W   $
��Bold"�6o   �� 5^      $��Nr. Telefon :��6   $
��Left=�6,   $��490,100,0,0q�6G   $	��Top=�6\   $
��Bold"�6t   �� 5_      $��Adresa :��6   $
��Left=�6'   $��513,131,0,0q�6B   $	��Top=�6W   $
��Bold"�6o   �� 5`       . $
��Left=�6(   $��23��6C   $��
572,43,0,0q�6O   $
 Wrap=�6c   $	��Top=�6x   $	��191��6�   ��5a      �� $ listcomenziActive��$ SelectedItem.Nume�$ PropertyChanged=��� 5b       . $
��Left=�6(   $��23��6C   $��
572,71,0,0q�6O   $
 Wrap=�6c   $	��Top=�6x   $	��191��6�   ��5c      �� $ listcomenziActive��$ SelectedItem.Prenume�$ PropertyChanged=��� 5d       . $
��Left=�6(   $��23��6C   $��572,103,0,0q�6O   $
 Wrap=�6d   $	��Top=�6y   $	��191��6�   ��5e      �� $ listcomenziActive��$ SelectedItem.Nr_Telefon�$ PropertyChanged=��� 5f       . $
��Left=�6(   $��53��6C   $��573,131,0,0q�6O   $
 Wrap=�6d   $	��Top=�6y   $	��191��6�   ��5g      �� $ listcomenziActive��$ SelectedItem.Adresa�$ PropertyChanged=��� 5h      $��Stare comanda : ��6   $
��Left=�6/   $��513,189,0,0q�6J   $	��Top=�6_   $
��Bold"�6w   $��Times New Roman)�6�   $��22(�6�   ���	#FF145F176�   �� 5i      -   5         ��Name$
 text��5i   (    . $
��Left=�66   $��23��6Q   $��572,229,0,0q�6]   $
 Wrap=�6r   $	��Top=�6�   $	��149��6�   ��5j      �� $ listcomenziActive��$ SelectedItem.Stare�$ PropertyChanged=��� 5k      -   5        $	��unu��5k      $��inregistrata��6"   $
��Left=�69   $��525,270,0,0q�6T   $	��Top=�6i   $
��Bold"�6�   �� 5l      -   5         ��Name$	 doi��5l      $��se pregateste��6$   $
��Left=�6<   $��525,291,0,0q�6W   $	��Top=�6l   $
��Bold"�6�   �� 5m      -   5        $
 trei��5m      $��a plecat la client��6%   $
��Left=�6B   $��525,312,0,0q�6]   $	��Top=�6r   $
��Bold"�6�   �� 5n      -   5        $ patru��5n      $��livrata��6&   $
��Left=�68   $��664,274,0,0q�6S   $	��Top=�6h   $
��Bold"�6�   �� 5o      -   5        $ cinci��5o      $��anulata��6&   $
��Left=�68   $��664,300,0,0q�6S   $	��Top=�6h   $
��Bold"�6�   �� 5p      -   5        $ text1��5p   <   $y�Hidden=�6    . $
��Left=�6K   $��23��6f   $��572,229,0,0q�6r   $
 Wrap=�6�   $	��Top=�6�   $	��149��6�   ��5q      �� $ listcomenziActive��$ SelectedItem.Id_Comanda�$ PropertyChanged=��� 5s      $��Schimba starea comenzii��6   $
��Left=�67   $��573,339,0,0q�6R   $	��Top=�6g   $	��148��6   $��26��6�   ���	#FF0DE97C$
��Bold"�6�   ��6�   �� *ModifyStare+��5t      `� 5u       `� 	Converter# [  6#   .1�5v      �� $ text1��6"   $
 Text�66   �� 5w      $
 text��6"   $
 Text�65   5x      5z      5|      � 5}   
   -   5         �Name$ 	totalGrid��5}      $
��Left=�6"   $y�Hidden=�6=   $	��388��6Q   $��0,34,-0.333,0q�6^   $	��Top=�6u   $	��795��6�    5~      ?  9Restaurant_with_online_orders.ViewModel.AproapedeTermenVM  5       � ColumnDefinitions 5�      �� 5�      $
��157* �6#   �� 5�      $
��108* �6#   .+�5�      �� -   5         ��Name$ total��5�      $
��Left=�6&   $	��264��6A   $��
148,78,0,0q�6N   $	��Top=�6b   $	��496��6z   $��2��6�   ��6�   �� *ListPreparate+	 5�      �� 5�      .P�5�      �� $��Nume preparat��6)    �� Width$	 200��6@   
 6L   �� *
Denumire+�� 5�      $��Cantitate totala��6)   $	 100��6C   
 6O   �� *CantitateTotala+5�      5�      �� 5�      $<��6Preparate care se apropie de terminare in restaurant :��6   $
��Left=�6U   $��
135,28,0,0q�6p   $	��Top=�6�   $��2��6�   $	��526��6�   $
��Bold"�6�   $��Times New Roman)�6�   $��22(�6�   ���	#FF175F676�   5�      5�      5�      