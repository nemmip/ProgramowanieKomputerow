   M S B A M L   `   `   `  ����N  JEmployeeManager.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:EmployeeManager.Wpf.ControlsEmployeeManager.Wpf.Controls  5      K*clr-namespace:EmployeeManager.Wpf.ControlsEmployeeManager.Wpf.Controls  5      $    EmployeeManager.WPF.MainWindow   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ?controls*clr-namespace:EmployeeManager.Wpf.Controls     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:EmployeeManager.Wpf.Controls     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  
MainWindow��5	      $	��800��5
      $	��550��5      $��18(�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      .+�5   
   0   *EmployeeManager.Wpf.Controls.HeaderControl  $��2��6!   � 5   
   $��1��6    5      �� 5      $
��Auto �6    �� 5      .+�5!      �� $��10q�6   $��Refresh��6!   �� 5"      $��1��5#       �� DisplayMemberPath$ 	FirstName��5$      ��5%      �� *	Employees+ �� Mode$ OneWay=� �� SelectedItem 5&      �� *SelectedEmployee+$ TwoWay=�5'      � 5*   
   $��1��5+      $��1��5,      y�5-      �� *IsEmployeeSelected+$ OneWay=� 5.      �� 5/      $
��Auto �6    �� 50      $
��Auto �6    �� 51      $
��Auto �6    �� 52      $
��Auto �6    �� 53      $
��Auto �6    �� 54      $
��Auto �6    �� 55      $
��Auto �6    �� 56      .+�59      �� $��
10,10,10,0q�6   	Firstname67   �� 5:      $��1��5;      $��10q�5<      ��5=      �� *SelectedEmployee.FirstName+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5>      $��2��6   $��
10,10,10,0q�6%   
Entry date6E   (  "System.Windows.Controls.DatePicker  5?      $��3��5@      $��10q�5A         SelectedDate 5B      �� *SelectedEmployee.EntryDate+$ TwoWay=��� 5C      $��4��6   $��
10,10,10,0q�6%   
Job role6C   �� 5D      $��5��5E      $��10q�5F      $��Stretch=�5G      $ RoleName��5H       �� SelectedValuePath$ Id��5K      ��5I      �� *
JobRoles+$ OneWay=�	 �� SelectedValue	 5J      �� *SelectedEmployee.JobRoleId+$ TwoWay=�5K      �� 5L      $��6��5M      $��10q�5N      $��Is coffee drinker��5O      
 d� 	IsChecked
 5P      �� *" SelectedEmployee.IsCoffeeDrinker+$ TwoWay=��� 5Q      $��7��5R      $��10,10,10,30q�5S      $
��Left=�5T      $��Bottom=�5U      $
��Save��5V      {�5W      �� *SelectedEmployee.CanSave+$ OneWay=�5X      5Z      5\      