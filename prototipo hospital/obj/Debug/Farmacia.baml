   M S B A M L   `   `   `  ����M  Iprototipo hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:prototipo_hospitalprototipo_hospital  5   	   !    prototipo_hospital.Farmacia   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:prototipo_hospital     5   	   -   5          � Title$  Farmacia��5   	   $	��720��6   $
��1280��6'   .��5
      � $
��Left=�6   $	��689��6&   $	��Top=�63   $
��1272��6K   .+�5   
   � $
��Left=�6   $	��638��6*   $��0,46,0,0q�67   $	��Top=�6I   $
��1272��6a   .+�5      o� $
��Left=�6   $
��auto��6.   $	��Top=�6<   $
��1262��6T   .@�5      �� -   5        $��botomGesPacientes��5   7   $��Gestionar Pacientes��6   $
��Left=�6P   $	��Top=�6k   $	��120��6�   $��23��6�   �� 5      -   5        $��botonGesFarmacos��5   6   $��Gestionar Farmacos��6   $
��Left=�6N   $	��Top=�6i   $	��120��6�   $��23��6�   �� 5      -   5        $��
botonSalir��5   )   $��Salir��6   $
��Left=�6;   $	��Top=�6V   $��40��6n   $��23��6y   6�   5      �� 5      $
��Left=�6   $	��598��64   $��0,30,0,0q�6A   $	��Top=�6S   $
��1262��6k   .@�5      �� $��Almacen��6   .��5      � ���	#FFE5E5E5.+�5      &   System.Windows.Controls.DataGrid  -   5        $��medicamentos��5   #      AutoGenerateColumns . $	��550��6R   $
��Left=�6_   $��	10,10,0,0q�6z   $	��Top=�6�   $
��1226��6�   5      5      �� 5      $��	Pacientes��6   .��5      � ���	#FFE5E5E5.+�5        -   5        $��habitaciones��5   #    . $
��Left=�6R   $	��550��6m   $��	10,10,0,0q�6z   $	��Top=�6�   $	��600��6�     5      -   5        $��datosPacientes��5   #    . $
��Left=�6T   $	��550��6o   $��
636,10,0,0q�6|   $	��Top=�6�   $	��600��6�   5      5      5       5!      ]� 5"   
   -   5        $��
dockPanell��5"      $
��auto��6'   $	��Top=�65   .+�5#      o� -	   5        $��menuGestionMedica��5#      $��23��6,   $	��Top=�68   $
��1272��6P   $	��Top=�6]   .@�5$      m� $��23��6   $��_Archivo��6'   $
��Auto��69   .@�5%      m� -
   5        $��gestionarPaciente��5%      $��Gestión de _Pacientes��68   m� 5&      -   5        $��gestionarFarmacos��5&      $��Gestión de _Farmacos��68   m� 5'      -   5        $��salir��5'      $��_Salir��6,   5(      m� 5)      $��23��6   $��Ayuda��6'   .@�5*      m� -   5        $��ayuda��5*      $��_Manual��6,   5+      5,      �� 5-      -   5        $��nombreFarmaceutico��5-      $��nombreFarmaceutico��6.   $��24��6K   $��Bottom=�6W   $��Right=�6r   $��0,0,0,0q�6�   $
��auto��6�   $��Right=�6�   �� 5.      -   5        $��idFarmaceutico��5.      $��idFarmaceutico��6*   $��24��6C   $��Bottom=�6O   $��Right=�6j   $��0,0,10,0q�6�   $��62��6�   5/      50      51      