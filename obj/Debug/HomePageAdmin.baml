   M S B A M L   `   `   `  ����G  CcomplaintBox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:complaintBoxcomplaintBox  5   	        complaintBox.HomePageAdmin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:complaintBox     5   	   -   5          � Title$  
MainWindow��5   	   $	��550��6   $	��980��6)    � AllowsTransparency . 
������  � WindowStyle$
 None=�5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��0* �6   �� 5      .+�5   
   � $��2��6   $��
0,0,0,-0.4q�6#    5      �� 5      $	��47* �6#   �� 5      $	��51* �6#   .+�5      ��  �� CornerRadius$ 10��6    J� RenderTransformOrigin$ 0.497,0.604&�6'   $
��Left=�6K   $	��980��6f   $��2��6r   $��	0,0,0,0.8q�6�   ��5      �� 5      .��5      �  � Color$ #7be9f6��6'    � Offset$	 0.0Q�67   � 5      $ #f083da��6'   $ 1Q�67   5      ._�5      �� -   5        $��Registration��5       � ToolTip$ Registration��6,   $��-10,-28,10,-84.2q�6C   5#      5%      �� 5'      $��Resources\logo.png��5(      $��102,17,138,383.4q�60   $��2��6J   �� 5*      $��Center=�6   $��2��64   $��0,135,-0.4,135.8q�6H   �� 5+      -   5        	 ��Name$	 closeButton��5+      $
��Left=�6+   $��41��6F   $��Bottom=�6R   $��40��6m   $��0q�6x   $��460,0,0,506.4q�6�   $��1��6�   ��5,      �� 5-      
 �� ImageSource$
 Resources\close.png��6!   5/      �� 50      -   5        $	 
btnGetData��50      $��View Complaints��6)   $
��Left=�6C   $��406,192,0,0q�6^   $	��Top=�6s   $	��109��6�   $��33��6�   $��2��6�   �� 51      -   5        $��Logout��51      $��1��6&   $
��Left=�66   $��
333,17,0,0q�6Q   $	��Top=�6e   $��75��6}   6�   &   System.Windows.Controls.DataGrid  52      -   5        $��	data_grid��52   m   $y�Hidden=�6      CanUserAddRows .     AutoGenerateColumns .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6]   $
��Left=�6~   $	��221��6�   $��102,275,0,0q�6�   $	��Top=�6�   $	��776��6�   $��2��6�   53      �� 54   
   -   5         ��Name$ id��54      $��ID��6   $
��Left=�6)   $��4,10,0,0q�6D   $	��Top=�6V   $��63��6n   $��27��6y   $ 0.145,-1.444&�6�   $��2��6�   �� 55   
   -   5        $
 name��55      $
��Name��6   $
��Left=�6-   $��4,42,0,0q�6H   $	��Top=�6Z   $��63��6r   $��27��6}   $ 0.145,-1.444&�6�   $��2��6�   �� 56   
   -	   5        $
 date��56      $
��Date��6   $
��Left=�6-   $��
813,65,0,0q�6H   $	��Top=�6\   $	��137��6t   $��27��6�   $ 0.145,-1.444&�6�   $��2��6�   57      58      