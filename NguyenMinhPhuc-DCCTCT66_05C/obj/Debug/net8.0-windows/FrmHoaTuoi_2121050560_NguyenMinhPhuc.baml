   M S B A M L   `   `   `  ����V  RNguyenMinhPhuc-DCCTCT66_05C, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:NguyenMinhPhuc_DCCTCT66_05CNguyenMinhPhuc_DCCTCT66_05C  5   	   F    @NguyenMinhPhuc_DCCTCT66_05C.FrmHoaTuoi_2121050560_NguyenMinhPhuc   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:NguyenMinhPhuc_DCCTCT66_05C     5   	     � Title$  Quản Lý Hoa Tươi��5   	   $	��500��6"   $	��900��6/   .��5	      � $��-122,0,0,14q�6    � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��261* �6   �� 5      $	��86* �6   �� 5      $	��30* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��Tìm kiếm��6   $��0��6%   $��2��62   $��	0,0,0,260q�6F   $��2��6Y   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��txtMaHoaTuoi��5      $	��100��6.   $��5q�6:   $��Mã hoa tươi��6E   �� 5      -   5        $��txtTenHoaTuoi��5      $	��200��6/   $��5q�6;   $��Tên hoa tươi��6F   �� 5      -   5        $��
btnTimKiem��5      $��Tìm kiếm��6+   $	��100��6>   $��5q�6J   6U   5      5      &   System.Windows.Controls.DataGrid  5    
   -   5        $��dgvDanhSach��5       $��1��6&   $��0��63   $��2��6C      AutoGenerateColumns$
 True��5!      $��2��6^   �� 5$   
   -   5        $��
grbChiTiet��5$      $��
Chi tiết��6%   $��1��67   $��1��6D   $��2��6T   .��5%      �� $��
150,0,-2,0q�6   $	��349��6-   .+�5&      �� -   5        $��txtMaHoaTuoiChiTiet��5&       �� 
IsReadOnly$
 True��65   $��5q�6G   $��Mã hoa tươi��6R   �� 5'      -   5        $��txtTenHoaTuoiChiTiet��5'      $��5q�66   $��Tên hoa tươi��6A   (  "System.Windows.Controls.DatePicker  5(      -   5        $��	dtpNgaySX��5(      $��5q�6.     5)      -	   5        $��	dtpNgayHH��5)      $��5q�6.   �� 5*      -
   5         ��Name$ txtDonVi��5*      $��
Đơn vị��6,   $��23��6:   $	��849��6F   �� 5+      -   5        $��	txtDonGia��5+      $��5q�6+   $��
Đơn giá��66   �� 5,      -   5        $��	txtGhiChu��5,      $��5q�6+   $��Ghi chú��66   �� 5-      $ 
Horizontal=�6   $	��843��66    J� RenderTransformOrigin$ 
0.497,3.47&�6B   .+�5.      �� -   5         ��Name$ btnLuu��5.      $
��Lưu��6-   $��75��6;   $��5q�6F   6Q   �� 5/      -   5        $ btnHuy��5/      $��Huỷ��6-   $��75��6;   $��5q�6F   6Q   50      51      52      �� 55   
   $ 
Horizontal=�6   $��1��6.   $
��Left=�6;   $��160,322,0,54q�6V   $��2��6l   $��2��6�   .+�56      �� -   5        $��btnThem��56      $��Thêm��6$   $	��100��63   $��5q�6?   $ 0.5,0.5&�6`   z�57      V� 58      .~�59      �� �� 5:      �� 5;      	 �� Angle$	 -0.829Q�6*   T� 5<      5=      5?      �� 5@      -   5        $��btnSua��5@      $��Sửa��6#   $	��100��61   $��5q�6=   6H   �� 5A      -   5        $��btnXoa��5A      $
��Xoá��6#   $	��100��61   $��5q�6=   6H   5B      5C      5D      