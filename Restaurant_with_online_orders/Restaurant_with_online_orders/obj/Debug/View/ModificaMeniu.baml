   M S B A M L   `   `   `  ����X  TRestaurant_with_online_orders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Restaurant_with_online_orders.View"Restaurant_with_online_orders.View  5      a5clr-namespace:Restaurant_with_online_orders.ViewModel'Restaurant_with_online_orders.ViewModel  5      c6clr-namespace:Restaurant_with_online_orders.Converters(Restaurant_with_online_orders.Converters  5      6    0Restaurant_with_online_orders.View.ModificaMeniu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:Restaurant_with_online_orders.View     5      Hlocal15clr-namespace:Restaurant_with_online_orders.ViewModel     5      QlocalConverter6clr-namespace:Restaurant_with_online_orders.Converters     5        � DataContext  5      7  1Restaurant_with_online_orders.ViewModel.AngajatVM  5   
   6   .��5      � ���	#FF9CE9C5 � 	Resources 5   
   ?   9Restaurant_with_online_orders.Converters.AngajatConverter   angajatConvert@  :Restaurant_with_online_orders.Converters.AdaugareConverter  adaugareConvert��%:   &	        &	        5      6.     5      6/   5      .+�5   
   �� -   5        $��preparateGrid��5      $
��Left=�6)   $	��344��6D   $��	10,19,0,0q�6Q   $	��Top=�6d   $	��348��6|   $��Visible=�6�   ��6�   �� *ListPreparate+ �� View 5      �� 5      .P�5      �� $��	Categorie��6%    �� DisplayMemberBinding 68   �� *	Categorie+�� 5      $��Denumire��6%    67   �� *
Denumire+�� 5      $
��Pret��6%    63   �� *Pret+�� 5      $��Cantitate per portie��6%    6C   �� *CantitatePortie+�� 5      $��Cantitate in restaurant��6%    6F   �� *CantitateTotala+�� 5      $��Url Fotografie��6&    �� Width$ 90��6>    �� CellTemplate 5      �� 5      .R�5   "   �� ��6(   �� *
Fotografie+5      5!      �� 5#      $��Alergeni��6%    5$      �� 5%      .R�5&   "   �� ��6*   �� *
Alergeni+5'      5)      5*      5,      �� 5-   
   -   5        $��categorieTxt��5-      $
��Left=�6&   $��23��6A   $��
523,60,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6v   $	��216��6�   ��5.      ��  �� ElementName$ preparateGrid�� �� Path$ SelectedItem.Categorie�	 �� UpdateSourceTrigger$	 PropertyChanged=��� 5/   
   $��Categorie :��6   $
��Left=�6&   $��
432,57,0,0q�6A   $	��Top=�6U   $
��Bold"�6m   $��Times New Roman)�6   $��14(�6�   
 J� RenderTransformOrigin$
 0.498,0.263&�6�   �� 50   
   $��Denumire preparat :��6   $
��Left=�6.   $��
375,88,0,0q�6I   $	��Top=�6]   $
��Bold"�6u   $��Times New Roman)�6�   $��14(�6�   �� 51   
   -   5         ��Name$ denumireTxt��51      $
��Left=�6'   $��23��6B   $��
523,88,0,0q�6N   $
 Wrap=�6b   $	��Top=�6w   $	��216��6�   ��52      �� $ preparateGrid��$ SelectedItem.Denumire�$	 PropertyChanged=��� 53   
   ���	#FF0DE97C$��Adauga��6(   $
��Left=�69   $��
372,19,0,0q�6T   $	��Top=�6h   $	��105��6�   $��29��6�   $
��Bold"�6�   ��6�   �� *
AddCommand+��54      `� 55       `� 	Converter# [ 6   .1�56      �� $ denumireTxt��6   $
 Text�68   �� 57      $ categorieTxt��6   $
 Text�69   �� 58      $ pretTxt��6   $
 Text�64   �� 59      $ cantitatePortieTxt��6   $
 Text�6?   �� 5:      $ cantitateTotalaTxt��6   $
 Text�6?   �� 5;      $ uriTxt��6   $
 Text�63   �� 5<      $ unutxt��6   $
 Text�63   �� 5=      $ doitxt��6   $
 Text�63   �� 5>      $ treitxt��6   $
 Text�64   �� 5?      $ patrutxt��6   $
 Text�65   �� 5@      $ cincitxt��6   $
 Text�65   �� 5A      $ sasetxt��6   $
 Text�64   �� 5B      $ saptetxt��6   $
 Text�65   �� 5C      $ opttxt��6   $
 Text�63   5D      5F      �� 5H   
   ���	#FF0DE97C$��Modifica��6(   $
��Left=�6;   $��
523,19,0,0q�6V   $	��Top=�6j   $	��105��6�   $��29��6�   $
��Bold"�6�   ��6�   �� *ModifyCommand+��5I      `� 5J      # [  6   .1�5K      �� $ id��6   $
 Text�6/   �� 5L      $ denumireTxt��6   $
 Text�68   �� 5M      $ categorieTxt��6   $
 Text�69   �� 5N      $ pretTxt��6   $
 Text�64   �� 5O      $ cantitatePortieTxt��6   $
 Text�6?   �� 5P      $ cantitateTotalaTxt��6   $
 Text�6?   �� 5Q      $ uriTxt��6   $
 Text�63   �� 5R      $ unutxt��6   $
 Text�63   �� 5S      $ doitxt��6   $
 Text�63   �� 5T      $ treitxt��6   $
 Text�64   �� 5U      $ patrutxt��6   $
 Text�65   �� 5V      $ cincitxt��6   $
 Text�65   �� 5W      $ sasetxt��6   $
 Text�64   �� 5X      $ saptetxt��6   $
 Text�65   �� 5Y      $ opttxt��6   $
 Text�63   5Z      5\      �� 5]   
   ���	#FF0DE97C$��Sterge��6(   $
��Left=�69   $��
662,19,0,0q�6T   $	��Top=�6h   $	��105��6�   $��29��6�   $
��Bold"�6�   ��5^      �� *DeleteCommand+��63   �� $ preparateGrid��$ SelectedItem��� 5_   
   $��Pret :��6   $
��Left=�6!   $��463,114,0,0q�6<   $	��Top=�6Q   $
��Bold"�6i   $��Times New Roman)�6{   $��14(�6�   $
 0.546,0.186&�6�   �� 5`   
   -   5        $ pretTxt��5`      $
��Left=�6#   $��23��6>   $��523,119,0,0q�6J   $
 Wrap=�6_   $	��Top=�6t   $	��216��6�   ��5a      �� $ preparateGrid��$ SelectedItem.Pret�$	 PropertyChanged=��� 5b   
   $��Cantitate per portie :��6   $
��Left=�61   $��372,140,0,0q�6L   $	��Top=�6a   $
��Bold"�6y   $��Times New Roman)�6�   $��14(�6�   �� 5c   
   -   5        $ cantitatePortieTxt��5c      $
��Left=�6.   $��23��6I   $��523,147,0,0q�6U   $
 Wrap=�6j   $	��Top=�6   $	��216��6�   ��5d      �� $ preparateGrid��$" SelectedItem.CantitatePortie�$	 PropertyChanged=��� 5e   
   $��Cantitate in restaurant :��6   $
��Left=�64   $��363,175,0,0q�6O   $	��Top=�6d   $
��Bold"�6|   $��Times New Roman)�6�   $��14(�6�   �� 5f   
   -   5        $ cantitateTotalaTxt��5f      $
��Left=�6.   $��23��6I   $��523,175,0,0q�6U   $
 Wrap=�6j   $	��Top=�6   $	��216��6�   ��5g      �� $ preparateGrid��$" SelectedItem.CantitateTotala�$	 PropertyChanged=��� 5h   
   $��
Alergeni :��6   $
��Left=�6%   $��408,271,0,0q�6@   $	��Top=�6U   $
��Bold"�6m   $��Times New Roman)�6   $��14(�6�   �� 5j   
   $��Url imagine preparat :��6   $
��Left=�61   $��364,206,0,0q�6L   $	��Top=�6a   $
��Bold"�6y   $��Times New Roman)�6�   $��14(�6�   �� 5k   
   -   5        $ uriTxt��5k      $
��Left=�6"   $��66��6=   $��523,203,0,0q�6I   $
 Wrap=�6^   $	��Top=�6s   $	��216��6�   ��5l      �� $ preparateGrid��$ SelectedItem.Fotografie�$	 PropertyChanged=��� 5m   
   -   5         ��Name$	 unu��5m      $��nu contine alergeni��6    $
��Left=�6>   $��405,305,0,0q�6Y   $	��Top=�6n   6�   �� 5n   
   -	   5        $	 doi��5n      $��gluten��6    $
��Left=�61   $��405,326,0,0q�6L   $	��Top=�6a   6y   �� 5o   
   -
   5        $
 trei��5o      $	��oua��6!   $
��Left=�6/   $��405,347,0,0q�6J   $	��Top=�6_   6w   �� 5p   
   -   5        $ patru��5p      $��lactoza��6"   $
��Left=�64   $��523,326,0,0q�6O   $	��Top=�6d   6|   �� 5q   
   -   5        $ cinci��5q      $��mustar��6"   $
��Left=�63   $��523,351,0,0q�6N   $	��Top=�6c   6{   �� 5r   
   -   5        $
 sase��5r      $��	crustacee��6!   $
��Left=�65   $��648,326,0,0q�6P   $	��Top=�6e   6}   �� 5s   
   -   5        $ sapte��5s      $��telina��6"   $
��Left=�63   $��648,351,0,0q�6N   $	��Top=�6c   6{   �� 5t   
   -   5        $	 opt��5t      $��peste��6    $
��Left=�60   $��649,305,0,0q�6K   $	��Top=�6`   6x   �� 5u   
   -   5        $ unutxt��5u      $y�Hidden=�6"   $
��Left=�66   $��23��6Q   $��523,274,0,0q�6]   $
 Wrap=�6r   $	��Top=�6�   $	��120��6�   �� 5v   
   -   5        $ doitxt��5v      $y�Hidden=�6"   $
��Left=�66   $��23��6Q   $��523,274,0,0q�6]   $
 Wrap=�6r   $	��Top=�6�   $	��120��6�   �� 5w   
   -   5        $ treitxt��5w      $y�Hidden=�6#   $
��Left=�67   $��23��6R   $��523,274,0,0q�6^   $
 Wrap=�6s   $	��Top=�6�   $	��120��6�   �� 5x   
   -   5        $ patrutxt��5x      $y�Hidden=�6$   $
��Left=�68   $��23��6S   $��523,274,0,0q�6_   $
 Wrap=�6t   $	��Top=�6�   $	��120��6�   �� 5y   
   -   5        $ cincitxt��5y      $y�Hidden=�6$   $
��Left=�68   $��23��6S   $��523,274,0,0q�6_   $
 Wrap=�6t   $	��Top=�6�   $	��120��6�   �� 5z   
   -   5        $ sasetxt��5z      $y�Hidden=�6#   $
��Left=�67   $��23��6R   $��523,274,0,0q�6^   $
 Wrap=�6s   $	��Top=�6�   $	��120��6�   �� 5{   
   -   5        $ saptetxt��5{      $y�Hidden=�6$   $
��Left=�68   $��23��6S   $��523,274,0,0q�6_   $
 Wrap=�6t   $	��Top=�6�   $	��120��6�   �� 5|   
   -   5        $ opttxt��5|      $y�Hidden=�6"   $
��Left=�66   $��23��6Q   $��523,274,0,0q�6]   $
 Wrap=�6r   $	��Top=�6�   $	��120��6�   �� 5}   
   -   5        $ id��5}      $y�Hidden=�6   $
��Left=�62   $��23��6M   $��523,274,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��120��6�   ��5~      �� $ preparateGrid��$ SelectedItem.IdPreparat�$	 PropertyChanged=�5�      5�      