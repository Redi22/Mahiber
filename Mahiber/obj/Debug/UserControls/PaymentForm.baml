   M S B A M L   `   `   `  ����B  >Mahiber, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Mahiber.UserControlsMahiber.UserControls  5      &     Mahiber.UserControls.PaymentForm   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Mahiber.UserControls     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   .��5
      �� .+�5   
   �� -   5        $��PaymentMainGrid��5   ,     �� Orientation$  Vertical=�6   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��MemberDataGrid��5   \      AutoGenerateColumns .  *  $MaterialDesignThemes.Wpf.ThemeAssist   Theme$ Light=�63   $��
13,20,-3,5q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        IDColumn��,  &System.Windows.Controls.DataGridColumn   Header$ ID��5   ;      Width5  /System.Windows.Controls.DataGridLengthConverter$ 70 6G   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6R   �� *Id+  5      -   5        FirstNameColumn��$ 
First Name��5   B   $	 120 6V    6b   �� *	FirstName+  5      -   5        LastNameColumn��$ 	Last Name��5   A   $	 120 6T    6`   �� *
LastName+  5      -   5        MiddleNameColumn��$ Debit��5   C   $	 120 6R    6^   �� *Debit+4  .System.Windows.Controls.DataGridCheckBoxColumn  5      -   5        CheckboxColumn��$ Paid?��5   E   $	 120 6T   5      �� 5      $  
Horizontal=�6   .+�5      �� -   5        $��Start��5      $��80��6*   $
��Left=�65   $��	50 30 0 0q�6P   6c   �� 5      -	   5        $��Finish��5      $��80��6*   $
��Left=�65   $��	30 30 0 0q�6P   6c   5      5      #  MaterialDesignThemes.Wpf.Card  5   
   $	��300��6   +	  %MaterialDesignThemes.Wpf.ShadowAssist 	  ShadowDepth$ Depth3=�6*   $ Light=�6[   
��� ���$
��Left=�5      $	��40 q�61   .��5!      9� $��Full Payments��5"      
����� �.��5$      �� $  Vertical=�5%   	      MaterialDesignBody#���   5&   	   $��
24,8,24,16q�5'   	   .+�5(      �� -
   5        $��MemberId��5)   .   $��12(�5(      )
  #MaterialDesignThemes.Wpf.HintAssist 
  Hint$ 	Member Id��5)      	 �� DisplayMemberPath$	 Id��6r   
 �� SelectedValuePath$
 Id��6�    & "MaterialDesignFloatingHintComboBox#��[ 5*      ��5)   >   �� *Id+5*      �� 5+      -   5        $��
amountPaid��5+   -   $��12(�6   $��8��6?   $ Amount��6L    % !MaterialDesignFloatingHintTextBox#��[ 6t   �� 5-      -   5        $��FullPay��5-   )   $��30q�6    $  MaterialDesignRaisedAccentButton#��[ 5.      $	��100��5/       � ToolTip$5 /Resource name: MaterialDesignRaisedAccentButton��50      .��6?   
Debit Paid52      53      54      55      56      57      