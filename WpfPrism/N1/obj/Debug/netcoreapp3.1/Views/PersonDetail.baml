   M S B A M L   `   `   `  ����=  9N1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:N1.ViewsN1.Views  5          N1.Views.PersonDetail   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:N1.Views     5      S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59Z VPrism.DryIoc.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  66   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��First Name:��6   $��5q�6'   �� 5   
   $��1��6   $��5q�6$   ��6/   �� *SelectedPerson.FirstName+�� 5   
   $��1��6   $��
Last Name:��6!   $��5q�63   �� 5   
   $��1��6   $��1��6!   $��5q�62   ��6=   �� *SelectedPerson.LastName+�� 5   
   $��2��6   $
��Age:��6!   $��5q�6-   �� 5    
   $��2��6   $��1��6!   $��5q�62   ��6=   �� *SelectedPerson.Age+5!      5"      