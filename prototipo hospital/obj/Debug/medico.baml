   M S B A M L   `   `   `  ����M  Iprototipo hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:prototipo_hospitalprototipo_hospital  5   	       prototipo_hospital.medico   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:prototipo_hospital     5   	     � Title$  Gestión Médica��5      $	��720��6   $
��1280��6%   .��5      � .+�5   
   � $
��Left=�6   $	��689��6*   $	��Top=�67   $
��1272��6O   .+�5      � $
��Left=�6   $	��638��6.   $��0,46,0,0q�6;   $	��Top=�6M   $
��1272��6e   .+�5      o� -   5        $��menuPrincipal��5      $
��Left=�6,   $
��auto��6G   $	��Top=�6U   $
��1272��6m   .@�5      �� -   5         ��Name$ BotonGestionpaciente��5      $��Gestionar Paciente��6;   $
��Left=�6X   $	��Top=�6s   $	��119��6�   $
��auto��6�   $��0,0,0,0q�6�   6�   �� 5      -   5        $ botonGuardarCambios��5      $��Guardar Cambios��6:   $
��Left=�6T   $	��Top=�6o   $	��119��6�   $
��auto��6�   $y�Visible=�6�   $��0,0,0,0q�6�   6�   �� 5      -   5        $ 
botonCitas��5      $��Citas Pendientes��61   $
��Left=�6L   $	��Top=�6g   $	��119��6   $
��auto��6�   $y�Visible=�6�   6�   �� 5      -   5        $ botonSalida��5      $��Salida��62   $
��Left=�6C   $	��Top=�6^   $	��119��6v   $
��auto��6�   $y�Visible=�6�   $��0,0,0,0q�6�   6�   5      �� 5      -   5        $��datosPaciente��5      $
��Left=�62   $	��600��6M   $��0,38,0,0q�6Z   $	��Top=�6l   $
��1272��6�   $y�Visible=�6�   .@�5      �� $��Datos del Paciente��6   .��5      � ���	#FFE5E5E5.+�5      �� $
��Edad��6$   $
��Left=�63   $��0,92,0,0q�6N   $	��Top=�6`   �� 5      -   5        $
��Edad��5   &   $
��Left=�62   $��23��6M   $��	91,96,0,0q�6Y    �� TextWrapping$
 Wrap=�6l   $��TextBox��6�   $	��Top=�6�   $	��120��6�   {�.  6�   �� 5!      $��Nombre��6$   $
��Left=�65   $	��Top=�6P   $��0,30,0,0q�6h   �� 5"      -   5        $��Nombre��5"   &   $
��Left=�64   $��23��6O   $��	91,34,0,0q�6[   $
 Wrap=�6n   $��TextBox��6�   $	��Top=�6�   $	��120��6�   {�.  6�   �� 5$      $��	Apellidos��6$   $
��Left=�68   $	��Top=�6S   $��0,61,0,0q�6k   �� 5%      -	   5        $��	Apellidos��5%   &   $
��Left=�67   $��23��6R   $��	91,65,0,0q�6^   $
 Wrap=�6q   $��TextBox��6�   $	��Top=�6�   $	��120��6�   {�.  6�   �� 5'      $��Habitación��6$   $
��Left=�69   $	��Top=�6T   $��
603,92,0,0q�6l   �� 5(      -
   5        $��
Habitacion��5(   '   $
��Left=�69   $��
730,96,0,0q�6T   $	��Top=�6h   $	��120��6�   �� 5+      $��Observaciones��6$   $
��Left=�6<   $	��Top=�6W   $��	0,238,0,0q�6o   �� 5,      -   5        $��Observaciones��5,   &   $
��Left=�6;   $	��251��6V   $��
10,269,0,0q�6c   $
 Wrap=�6w   $��TextBox��6�   $	��Top=�6�   $	��924��6�   �� 5.      $��Fecha de ingreso��6$   $
��Left=�6?   $	��Top=�6Z   $��
603,30,0,0q�6r   (  "System.Windows.Controls.DatePicker  5/      -   5        $��fechaIngreso��5/   )   $
��Left=�6=   $��
730,31,0,0q�6X   $	��Top=�6l   �� 51      $��Fecha de alta��6$   $
��Left=�6<   $	��Top=�6W   $��
603,61,0,0q�6o     52      -   5        $��	fechaAlta��52   )   $
��Left=�6;   $��
730,63,0,0q�6V   $	��Top=�6j   �� 54      $
��Sexo��6$   $
��Left=�63   $��	0,123,0,0q�6N   $	��Top=�6a   �� 55      -   5        $
��Sexo��55   &   $
��Left=�62   $��23��6M   $��
91,127,0,0q�6Y   $
 Wrap=�6m   $��TextBox��6�   $	��Top=�6�   $	��120��6�   {�.  6�   �� 57      $��Fecha de nacimiento��6$   $
��Left=�6B   $��	0,154,0,0q�6]   $	��Top=�6p     58      -   5        $��fechaNacimiento��58   )   $
��Left=�6@   $��
91,185,0,0q�6[   $	��Top=�6o   {�.  6�   �� 5:      $��
Dirección��6$   $
��Left=�68   $��
280,30,0,0q�6S   $	��Top=�6g   �� 5;      -   5        $��	direccion��5;   &   $
��Left=�67   $��23��6R   $��
380,34,0,0q�6^   $
 Wrap=�6r   $��TextBox��6�   $	��Top=�6�   $	��120��6�   {�.  6�   �� 5=      $��	Teléfono��6$   $
��Left=�67   $��
280,61,0,0q�6R   $	��Top=�6f   �� 5>      -   5        $��telefono��5>   &   $
��Left=�66   $��23��6Q   $��
380,65,0,0q�6]   $
 Wrap=�6q   $��TextBox��6�   $	��Top=�6�   $	��120��6�   {�.  6�   5@      5A      �� 5D      $��
Medicacion��6   .��5E      � ���	#FFE5E5E5$��0,0,0,0q�66   .+�5F      �� -   5        $��añadirMedicacion��5F   %   $��Añadir Medicacion��6=   $
��Left=�6Y   $��480,508,0,0q�6t   $	��Top=�6�   $	��114��6�   &   System.Windows.Controls.DataGrid  5G      -   5        $��listaMedicacion��5G   '   $
��Left=�6>   $	��440��6Y   $��	60,32,0,0q�6f   $	��Top=�6y   $	��613��6�   5I      �� 5J      -   5        $��nuevaReceta��5J   %   $��Nueva Receta��68   $
��Left=�6O   $��670,508,0,0q�6j   $	��Top=�6   $��84��6�   5K      5L      �� 5O      $��Curas��6   .��5P      � ���	#FFE5E5E5$��0,0,0,0q�66   .+�5Q        $
��Left=�6)   $��
157,74,0,0q�6D   $	��Top=�6X   �� 5R      $
��Left=�6&   $��23��6A   $��381,198,0,0q�6M   $
 Wrap=�6b   $��TextBox��6v   $	��Top=�6�   $	��120��6�   �� 5S      $��Button��6%   $
��Left=�66   $��170,177,0,0q�6Q   $	��Top=�6f   $��75��6~   5T      5U      �� 5X      $��Dieta��6   .��5Y      � ���	#FFE5E5E5$��0,0,0,0q�66   5Z      �� 5[      $��Pruebas recientes��6   .��5\      � ���	#FFE5E5E5$��0,0,0,0q�66   .+�5]        -   5        $��listaPruebas��5]   '   $
��Left=�6;   $	��440��6V   $��	60,32,0,0q�6c   $	��Top=�6v   $	��613��6�   5_      5`      5a      �� 5b      $��Historial Medico��6   .��5c      � ���	#ffe5e5e5$��0,0,0,0q�66   .+�5d      �� -   5        $��nuevaConsulta��5d   %   $��Nueva Consulta��6:   $
��Left=�6S   $��415,366,0,0q�6n   $	��Top=�6�   $	��103��6�   6�   5f      5g      �� 5k      $��Cirugias��6   .��5l      � ���	#ffe5e5e5$��0,0,0,0q�66   5n      5o      5r      5t      5u      ]� 5v   
   -   5        $��
dockPanell��5v      $��Stretch=�6'   $��46��6E   $��0,0,0,0q�6Q   $	��Top=�6b   $
��auto��6z   .+�5w      o� -   5        $��menuGestionMedica��5w      $��23��6,   $	��Top=�68   $
��1272��6P   .@�5x      m� $��23��6   $��_Archivo��6'   .@�5y      m� -   5        $��gestionarPaciente��5y      $��_Gestión de Pacientes��68   6W   m� 5z      -   5        $��Salir��5z      $��_Salir��6,   6<   5|      m� 5~      $��23��6   $��Ayuda��6'   .@�5      m� -   5        $��ayuda��5      $��Manual��6,   5�      5�      �� 5�      -   5        $��nombreMedico��5�      $��nombreMedico��6(   $��23��6?   $��Bottom=�6K   $
��Left=�6f   $��
-200,0,0,0q�6�   $
��auto��6�   $��Right=�6�   �� 5�      -   5        $��idMedico��5�      $��idMedico��6$   $��23��67   $��Bottom=�6C   $��Right=�6^   $��
-100,0,0,0q�6z   $
��auto��6�   $��Right=�6�   5�      5�      5�      