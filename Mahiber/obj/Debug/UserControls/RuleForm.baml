   M S B A M L   `   `   `  ����B  >Mahiber, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Mahiber.UserControlsMahiber.UserControls  5      #    Mahiber.UserControls.RuleForm   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Mahiber.UserControls     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  TrainsitionigContentSlide��5
   +   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6N   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromRight+   Duration$ 0:0:1.1X�.��5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $	��250 �6#   .+�5      �� $��1��6   ���#2E4151
�������$	��250��6S   .��5      �� .+�5      � $	��550��6   $��20 0 0 0q�6)    � RowDefinitions 5      �� 5      $��86 �6,   �� 5      $	��52* �6,   �� 5      $	��150 �6,   �� 5      $	��42* �6,   �� 5      $	��43* �6,   �� 5      $	��54* �6,   �� 5      $	��38* �6,   �� 5      $	��37* �6,   �� 5      $	��100 �6,   .+�5      �� 
�������$��Rule Registration Form��63   $��0��6T   $��19(�6a   $��Center=�6o   $��Center=�6�   �� 5!      -   5        $��RuleName��5!   #   $��1��63   $��11(�6@   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
 Rule Name��6N    %  !MaterialDesignFloatingHintTextBox#��[  6z   �� 5"      -   5        $��FirstFin��5"   #   $��3��63   $��11(�6@   $ 
 First Fin��6N   #��[  6z   �� 5#      -   5        $��	SecondFin��5#   #   $��4��64   $��11(�6A   $  Medium Fin��6O   #��[  6|   �� 5$      -   5        $��FinalFin��5$   #   $��5��63   $��11(�6@   $ 
 Final Fin��6N   #��[  6z   �� 5(      -   5        $��Description��5(   /   $��2��6"    * &MaterialDesignOutlinedTextFieldTextBox#��[ 5)      $	��Top=�5*      $��12(�6   $	��100��5+       �� AcceptsReturn . $	��0 6q�5,       �� TextWrapping$
 Wrap=�5-      " �� VerticalScrollBarVisibility$
 Auto=�5.      $ Description��5/      �� 52      $��8��6%   $��3��62   	 �� Orientation$	 
Horizontal=�6C   .+�54      �� -   5        $��AddBtn��54   &     MaterialDesignRaisedButton#��[ 55      $��60��56      ��58   "   '  !MaterialDesignThemes.Wpf.PackIcon  59   &   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]
   Kind$	
 Add=�6>   5;      �� 5<      -   5        $��EditBtn��5<   &   $
��10 0q�6K   #��[ 5=      $��60��5>      ��5@   "     5A   &   $

 Edit=�6>   5C      �� 5D      -	   5        $��	DeleteBtn��5D   &   #��[ 5E      $��60��5F      ��5H   "     5I   &   $
 Delete=�6>   5K      5L      5M      9� 5N      $��0 0 0 50q�6   $��Stretch=�5O      
��� ���$��Violation Report Form��5P      .��5Q      �� $	 Vertical=�5R        MaterialDesignBody#���  5S      $��24,8,24,160q�5T      .+�5U      �� -
   5        $��Fundamental��5U   5   $��12(�6'   $��0,0,0,8q�6�   .��6�   Fundamental Rule Violated5W      �� 5Y      -   5        $��ViolatedRuleId��5Y   '   $ Violated Rule Id��5Z      $��12(�65    �� SelectedValuePath$ Id��6[    �� DisplayMemberPath$
 Name��6r    & "MaterialDesignFloatingHintComboBox#��[ 5[      ��5Z   C   �� 5^      �� 5_      -   5        $��MemName��5_   4   $��12(�6&   $ Member Name��5`      #��[  5a      �� 5b      -   5        $��MemId��5b   4   $��12(�6&   $ 	Member Id��5c      #��[  5d      �� 5e      -   5        $��ViolationDescription��5e   3   $��2��6&   #��[ 5f      $	��Top=�5g      $��12(�6   $	��100��5h      
���   � . $	��0 6q�5i      $
 Wrap=�5j      $
 Auto=�5k      $ Description��5l      �� 5n      -   5        $��	ReportBtn��5n   %   #��[ 5o      $	��100��5p       � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5q      .��69   Report5s      5t      5u      5v      5x      �� 5y      $��0��6   .��5|      �� .+�5}      �� $	 
Horizontal=�6!   $��30 0 0 0q�6:   .+�5~      �� $	 
Horizontal=�6%   $��30q�6>   .+�5      �� $��Rules��6(   $��Center=�65   $
��30 0q�6P   
����  �$��22(�6q   �� 5�      -   5        $��Search��5�   &   $	��200��64   $��12(�6@   #��[  5�      .��6?    5�   "   �� 5�   &   $	 
Horizontal=�61   .+�5�   *     $
 Search=�6B   $��40��6P   $��30��6\   �� 5�   *   $��Search��64   $��Center=�6B   5�   '   .��5�   B   5�      �� 5�      -   5        $��
refreshBtn��5�   =   
����� �
�������$��	20 30 0 0q�6�   ��6%   Z� .��5�   "     $
 Refresh=�5�      $��24��5�      $��24��5�      5�      5�      5�      �� 5�      $��30 15q�6   $��Fundamental Rules��6+   $��18(�6G   
�������6U   #  MaterialDesignThemes.Wpf.Card  5�        MaterialDesignBackground#���  5�      .��5�      �� .+�5�      9� $��12(�6'   
�������$��Stretch=�5�      $��Expander Example 2a��5�      .��5�   "   �� $	 Vertical=�5�   	   #���  5�   	   $��
24,8,24,16q�5�   	   .+�5�   &   �� 
���   �$��Your Content��5�      �� 5�   &    J� Opacity$	 .68Q�5�      
���   �$����Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.��5�      $
��Wrap=�5�      5�   #   5�      �� 5�        MaterialDesignDivider#���  5�      $��1��5�      $��Stretch=�5�       J� SnapsToDevicePixels . 5�      9� 5�      $��12(�6'   
�������$��Stretch=�5�      $��Expander Example 2b��5�      .��5�   "   �� $	 Vertical=�5�   	   #���  5�   	   $��
24,8,24,16q�5�   	   .+�5�   &   �� 
���   �$��Your Content��5�      �� 5�   &   $	 .68Q�5�      
���   �$����Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.��5�      $
��Wrap=�5�      5�   #   5�      �� 5�      #���  5�      $��1��5�      $��Stretch=�5�       . 5�      9� 5�      $��12(�6'   
�������$��Stretch=�5�      $��Expander Example 2c��5�      .��5�   "   �� $	 Vertical=�5�   	   #���  5�   	   $��
24,8,24,16q�5�   	   .+�5�   &   �� 
���   �$��Your Content��5�      �� 5�   &   
���   �$	 .68Q�5�      $����Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.��5�      $
��Wrap=�5�      5�   #   5�      5�      5�      �� 5�      $��30 15q�6   $��Customized Rules��6+   $��18(�6F   
�������6T   &   System.Windows.Controls.DataGrid  5�      -   5        $��	RulesGrid��5�      *	  $MaterialDesignThemes.Wpf.ThemeAssist 	  Theme$ Light=�60      Columns 5�      0
  *System.Windows.Controls.DataGridTextColumn
  5�      -   5        
NameColunm��,  &System.Windows.Controls.DataGridColumn   Header$ 	Rule Name��5�   E   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6X   �� *Name+
  5�      -   5        
DateColunm��$ Registered Date��5�   E    6^   �� *RegisteredDate+
  5�      -   5        	ffine��$ 	First Fin��5�   @    6S   �� *
FirstFin+
  5�      -   5        PlaceColunm��$ 
Second Fin��5�   F    6Z   �� *	SecondFin+
  5�      -   5        	FinColunm��$ 
Second Fin��5�   D    6X   �� *	LastFin+
  5�      -   5        DescriptionColunm��$ 
Desciption��5�   L    6`   �� *Description+5�      5�      5�      5�      5�      5�      