   M S B A M L   `   `   `  ����K  GAssignment2_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Assignment2_MVVMAssignment2_MVVM  5   	   G(clr-namespace:Assignment2_MVVM.ViewModelAssignment2_MVVM.ViewModel  5   	   !    Assignment2_MVVM.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Assignment2_MVVM     5   	   7vm(clr-namespace:Assignment2_MVVM.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5      0   *Assignment2_MVVM.ViewModel.PersonViewModel   PersonViewModel��%   &	          5      6   5      .��5      �  � DataContext 6   ��  �� Source# [   � RowDefinitions 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5      �� 5      $
��Auto �6   �� 5      $��* �6   .+�5      �� $��0��6   $��0��6   $��
First Name��6-   $��Center=�6?   �� 5      $��0��6   $��1��6   $	��100��6+   
�������$��Center=�6N   ��6k   �� *Person.FName+ �� Mode$ TwoWay=��� 5      $��1��6   $��0��6   $��
First Name��6-   $��Center=�6?   �� 5      $��1��6   $��1��6   $	��100��6+   
�������$��Center=�6N   ��6k   �� *Person.LName+$ TwoWay=��� 5      $��Submit��6   $��Center=�6@   $��2��6]   $��0��6j   ��6   �� *SubmitCommand+6j   �� 5       $��3��6/   $��1��6<   $
��Auto��6L   ��6   �� *	Persons+ �� View 5!      �� 5"   
   .P�5#      �� $��
First Name��6    �� Width$
 Auto��6V   	 �� DisplayMemberBinding	 6/   �� *FName+6V   �� 5$      $��
First Name��6   $
 Auto��6V   	 6/   �� *LName+6V   �� 5%      $��
First Name��6   $
 Auto��6Y   	 6/   �� *
FullName+6Y   5&      5(      5)      5*      