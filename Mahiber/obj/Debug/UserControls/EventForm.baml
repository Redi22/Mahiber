   M S B A M L   `   `   `  ����B  >Mahiber, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Mahiber.UserControlsMahiber.UserControls  5      $    Mahiber.UserControls.EventForm   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Mahiber.UserControls     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      
�������.��5
      �   � ColumnDefinitions  5   
   �� 5      $��* �6   �� 5      $	��250 �6   .+�5   
   �� $��1��6   
����������#2E4151.��5      � $	��800��6   $��20 0 0 0q�6!    � RowDefinitions 5      �� 5      $	��100 �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��70 �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5       $��* �6$   �� 5!      $��* �6$   �� 5"      $	��100 �6$   .+�5$      �� 
�������$��Event Registration Form��6+   $��0��6M   $��19(�6Z   $��Center=�6h   $��Center=�6�   �� 5&      -   5        $��	EventName��5&   5   $��1��6   $��12(�6'   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Event Name��5'       %  !MaterialDesignFloatingHintTextBox#��[  5(      (  "System.Windows.Controls.DatePicker  5*      -   5        $��	EventDate��5*   8   $��2��6   $��12(�6*   $	��200��5+      $ 
Event Date��5,       ( $MaterialDesignFloatingHintDatePicker#��[ 5-      �� 5.      -   5        $��
EventPlace��5.   5   $��3��6   $��12(�6'   $ Place��5/      #��[  50      )  #MaterialDesignThemes.Wpf.TimePicker  51      -   5        $��	EventTime��51   ,   $	��200��52      $��4��6   $��12(�6    ( $MaterialDesignFloatingHintTimePicker#��[ 53      $ 
Event Time��54      �� 55      -   5        $��EventFin��55   5   $��5��6   $��12(�6'   $
  Fin��56      #��[  57      �� 58      -   5        $��Description��58       * &MaterialDesignOutlinedTextFieldTextBox#��[ 59      $��6��5:      $��2��6   $��12(�6#   $	��Top=�5;      $	��100��5<       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5>      " �� VerticalScrollBarVisibility$
 Auto=�5?      $ Event Description��5@      5A      �� 5B       �� Orientation$ 
Horizontal=�6   $��10��66   .+�5C      �� -   5        $��AddBtn��5C      $
��11 0q�6A    � ToolTip$ One with custom opacity��5D      ��5E      '  !MaterialDesignThemes.Wpf.PackIcon  5F      �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$	 Add=�66   5H      �� 5I      -   5        $��EditBtn��5I      $
��11 0q�6D   $	 Two��5J      ��5K        5L      $
 Edit=�66   5N      �� 5O      -	   5        $��	DeleteBtn��5O      $
��11 0q�6G   $ Three��6U   ��5P        5Q      $ Delete=�66   5S      5T      5W      5X      �� 5Y   
   .+�5Z      �� $ 
Horizontal=�6   $��30q�62   .+�5[      �� $��Events��6   $��Center=�6*   $
��30 0q�6E   
����  �$��22(�6f   �� 5\      -
   5        $��Search��5\   -   
���   �$	��200��6P   $��12(�6\   #��[  5]      .��6?    5^      �� 5_      $ 
Horizontal=�6%   .+�5`        $ Search=�66   $��40��6D   $��30��6P   �� 5a      $��Search��6(   $��Center=�66   5b      .��5c   6   5d      �� 5f      -   5        $��
refreshBtn��5f   1   
����� �
�������$��	20 30 0 0q�6�   ��6   Z� .��5h        $ Refresh=�5i      $��24��5j      $��24��5k      5l      5n      &   System.Windows.Controls.DataGrid  5p      -   5        	  Name$	 	EventGrid��5p   m   $��0 ��6   
   AutoGenerateColumns
 .  *  $MaterialDesignThemes.Wpf.ThemeAssist   Theme$ Light=�6D      
IsReadOnly .    Columns 5q      0  *System.Windows.Controls.DataGridTextColumn  5r      -   5        
NameColunm��,	  &System.Windows.Controls.DataGridColumn 	  Header$ 
Event Name��5r   =   1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 6Q   �� *Name+  5s      -   5        
DateColunm��$ Date and Time��5s   =    6T   �� *Date+  5t      -   5        PlaceColunm��$ Place��5t   >    6M   �� *Place+  5u      -   5        	FinColunm��$	 Fin��5u   <    6I   �� *Fin+  5v      -   5        DescriptionColunm��$ 
Desciption��5v   D    6X   �� *Description+5x      �� 5y      .+�5{      �� -   5        $��
Attendance��5{      $��7q�6+   $
��Left=�66    * &MaterialDesignFloatingActionMiniButton#��[ 6k   $ 
Attendance��5|      .��5}        $
 File=�5~      $��24��5      $��24��5�      5�      �� 5�      .��5�      � -   5        $��AttendanceForm��5�      5�      5�      5�      5�      5�      5�      