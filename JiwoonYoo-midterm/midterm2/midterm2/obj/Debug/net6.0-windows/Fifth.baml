   M S B A M L   `   `   `  ����C  ?midterm2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:midterm2midterm2  5   	       midterm2.Fifth   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:midterm2     5   	     � Title$   ��5   	   $	��600��6   $	��830��6   .��5	      ��  �� Orientation$ 
Horizontal=�6   
�������.+�5
   
   �� .+�5      o� $	��Top=�6   .@�5      m� $
��Left=�6   $	��Top=�66   $��_File��6N   .@�5      m� -   5         m�Name$ mnuNew��5   -   $
��_New��6    m� InputGestureText$ Ctrl+N��6=   6W   m� 5      -   5        $ mnuSave��5   .   $��_Save��6   $ Ctrl+S��6?   6Y   m� 5      -   5        $ 	mnuQuitAs��5   .   $��_Quit��6   $ Ctrl+Q��6A   6[   5      m� 5      $
��Left=�6   $	��Top=�66   $��_Edit��6N   .@�5      m� -   5        $ mnuAdd��5   -   $
��_Add��6   $ Ctrl+A��6=   6W   m� 5      -   5        $ 	mnuUpdate��5   0   $��_Update��6   $ Ctrl+U��6C   6]   m� 5      -   5        $ 	mnuDelete��5   0   $��_Delete��6   $ Ctrl+D��6C   6]   5      m� 5      $
��Left=�6   $	��Top=�66   $��_Help��6N   .@�5      m� -   5        $ mnuHelp��5   .   $��_Help��6   $ Ctrl+H��6?   6Y   5      5      �� 5      -   5         ��Name$ lstEducation��5      $	��350��6D   
����·���6,   �� 6k   &   System.Windows.Controls.DataGrid  5      -	   5          Name$ 	selection��5      $	��100��6*   5      �� 5    
   .+�5!      �� $��
Person Id:��6   �� 5"      -
   5         ��Name$ txtPersonId��5"      $��5q�6+   �� 5#      $��Name:��6   �� 5$      -   5        $ txtName��5$      $��5q�6'   64   �� 5%      $��Address:��6   �� 5&      -   5        $ 
txtAddress��5&      $��5q�6*   67   �� 5'      $��Email:��6   �� 5(      -   5        $ txtEmail��5(      $��5q�6(   65   �� 5)      $
��Age:��6   �� 5*      -   5        $ txtAge��5*      $��5q�6&   63   �� 5+      $��	BirthDay:��6   �� 5,      -   5        $ txtBirthDay��5,      $��5q�6+   68   �� 5.      $��EducationId:��6   $	��250��6+   �� 5/      -   5        $ txtEducationId��5/      $��5q�6.   �� 50      $��Course Name:��6   �� 51      -   5        $ txtCourseName��51      $��5q�6-   6:   �� 52      $��Course Grade:��6   �� 53      -   5        $ txtCourseGrade��53      $��5q�6.   6;   �� 54      $��	Comments:��6   �� 55      -   5        $ 
txtComment��55      $��5q�6*   67   56      �� 58   
   .+�59      �� -   5         ��Name$ btnAdd��59      $��Add New��6%   $��20q�67   $	��150��6D   
����İ�6n   �� 5:      -   5        $ 	btnUpdate��5:      $��Update��6(   $��20q�69   
����İ�6c   �� 5;      -   5        $ 	btnDelete��5;      $��Delete��6(   $��20q�69   
����İ�6c   5<      5>      5?      