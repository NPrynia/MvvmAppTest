   M S B A M L   `   `   `  ����C  ?MVVMTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MVVMTest.ViewsMVVMTest.Views  5      $    MVVMTest.Views.MakeReservation   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:MVVMTest.Views     5      .��5	      � .+�5
   
   �� .+�5      �� $-��'Создать бронирование��6   $��35(�64   �� 5      $��0 30 0 0q�6   $��20(�6*   $��Имя��68   �� 5      $	��300��6   $��0 10 0 0q�6"   $��25��64   $
��Left=�5      $��20(�61   
���   ���5      �� *
Username+  �� UpdateSourceTrigger$  PropertyChanged=�5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� .+�5      �� $��0 30 0 0q�6    $��20(�62   $��Этаж��6@   �� 5      $	��110��6   $��0 10 0 0q�6*   $��25��5      $
��Left=�6*   $��20(�5      
���   ���5      �� *	FloorID+5   ,   5      �� 5      $��30 0 0 0q�6   .+�5      �� $��0 30 0 0q�6    $��20(�62   $��
Номер��6@   �� 5      $	��110��6   $��0 10 0 0q�6*   $��25��5!      $
��Left=�6*   $��20(�5"      
���   ���5       �� *
RoomNumber+5"   ,   5$      5%      �� 5'      $ 
Horizontal=�6   .+�5(      �� .+�5*      �� $��0 30 0 0q�6    $��20(�62   $��Начало��6@   (  "System.Windows.Controls.DatePicker  5,      $	��110��6!   $��0 10 0 0q�6-   $��25��5.   !   $
��Left=�6-   
���   �   SelectedDate 5-   !   �� *	StartTime+5/   !   51      �� 53      $��30 0 0 0q�6   .+�55      �� $��0 30 0 0q�6    $��20(�62   $��
Конец��6@     57      $	��110��6!   $��0 10 0 0q�6-   $��25��5:   !   $
��Left=�6-   
���   � 59   !   �� *	EndTime+5;   !   5=      5>      �� 5@      $ 
Horizontal=�6   $��0 30 0 0q�62   .+�5A      �� $��Добавить��6   $	��100��5C      $��25��6%   $��0 0 30 0q�5D      ��5B      �� *addReservationCommand+5D      �� 5F      $��Отменить��6   $	��100��5G      $��25��5J      ��5I      �� *cancelReservationCommand+5J      5K      5M      5O      5P      