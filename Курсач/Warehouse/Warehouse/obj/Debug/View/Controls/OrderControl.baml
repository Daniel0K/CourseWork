   M S B A M L   `   `   `  ����  	Warehouse*    $Warehouse.View.Controls.OrderControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      f bDevExpress.Xpf.Grid.v13.2.Core, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   5      a ]DevExpress.Xpf.Core.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  5         OrderWindowViewModel  � DataContext#  [  5	      .��5      � ���	#FF3F8ACD � ColumnDefinitions 5   
   �� 5      $
��129* �6   �� 5      $
��883* �6    � RowDefinitions 5   
   �� 5      $
��219* �6   �� 5      $	��20* �6   .+�5   
   %  DevExpress.Xpf.Grid.GridControl  )  #DevExpress.Xpf.Grid.DataControlBase#   EnableSmartColumnsGeneration . $
��Left=�6]   $	��Top=�6x   $��2��6�   $	��428��6�   $
��1012��6�      ItemsSource 6   �� *Orders+   View 5      #  DevExpress.Xpf.Grid.TableView  5         Columns 5      $  DevExpress.Xpf.Grid.GridColumn  5      $  DevExpress.Xpf.Grid.BaseColumn   Header)  #DevExpress.Xpf.Core.ObjectConverter$ № партии 6!      VisibleIndex$ 0��6R   $  DevExpress.Xpf.Grid.ColumnBase	   Binding	 63   �� *
consigment+6R     5      $ ID поставщика 6!   $ 1��6Z   	 68   �� *id_contractor+6Z     5      $ 
Сумма 6!   $ 2��6I   	 60   �� *summ+6I     5      $ Дата заказа 6!   $ 3��6U   
   UnboundType] YDevExpress.Data.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a8  2DevExpress.Utils.Design.UnboundColumnTypeConverter$
 DateTime 6f   	 66   �� *
date_order+6f     5      $ Дата привоза 6!   $ 4��6W   $
 DateTime 6h   	 67   �� *date_import+   EditSettings 5      6	  0DevExpress.Xpf.Editors.Settings.DateEditSettings	  5      5!        5"      $  Ответственный 6!   $ 5��6T   	 68   �� *	id_user+6T   5$      �� 5%   
   $��Создать заказ��6   $��
10,0,10,10q�6)   $��1��6=   ��6J   �� *CreateOrder+5&      5'      