   M S B A M L   `   `   `  ����G  CcomplaintBox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:complaintBoxcomplaintBox  5   	       complaintBox.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:complaintBox     5   	   -   5          � Title$  Window1��5   	   $	��450��6   $	��380��6&    � AllowsTransparency . 
������  � WindowStyle$
 None=�5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��0* �6   �� 5      .+�5   
   � $��2��6   $��
0,0,0,-0.4q�6#    5      �� 5      $	��47* �6#   �� 5      $	��51* �6#   .+�5      ��  �� CornerRadius$ 10��6    J� RenderTransformOrigin$ 0.497,0.604&�6'   $
��Left=�6K   $	��380��6f   $��2��6r   $��0,0,-86.4,0.8q�6�   ��5      �� 5      .��5      �  � Color$ #7be9f6��6'    � Offset$	 0.0Q�67   � 5      $ #f083da��6'   $ 1Q�67   5      ._�5      �� -   5        $��Registration��5       � ToolTip$ Registration��6,   $��-10,-28,10,-84.2q�6C   5!      5#      �� 5$      -   5        	 ��Name$	 label��5$      $��14(�6$   $��Please select from Below:��62   $��106,197,110,209q�6V   $��2��6o   $ 0.643,0.501&�6�   �� 5%      $��Resources/logo.png��5&      $��106,-19,101,290q�60   $��2��6I   �� 5(      $��Complaints Module��5)      $��24(�6-   $��86,133,43,270q�6;   $��2��6R   $ 0.643,0.501&�6f   5,      �� 5-      $��Center=�6   $��2��64   $��0,135,-0.4,135.8q�6H   �� 5.      -   5        
 ��Name$
 closeButton��5.      $
��Left=�6+   $��41��6F   $��Bottom=�6R   $��40��6m   $��0q�6x   $��157.6,0,0,409q�6�   $��1��6�   ��5/      �� 50       �� ImageSource$ Resources/close.png��6!   52      �� 53      -   5        $
 button��53      $��Admin��6%   $
��Left=�65   $	��Top=�6P   $��75��6h   $��1��6s   $��43.6,260,0,0q�6�   6�   �� 54      -   5        $
 button_Copy��54      $
��User��6*   $
��Left=�69   $	��Top=�6T   $��75��6l   $��
66,260,0,0q�6w   6�   55      56      57      