   M S B A M L   `   `   `  ����J  FKaspyBankCredit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:KaspyBankCreditKaspyBankCredit  5   	   (    "KaspyBankCredit.RegistrationWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:KaspyBankCredit     5   	     � Title$  RegistrationWindow��5   	   $��336.678��6$   $	��350��65   .��5	      � ���	#FFCA0014.+�5
   
   �� $��Регистрация��6   $
��Left=�6&   $��
116,10,0,0q�6A   $	��Top=�6U   $��18(�6m   �� 5   
   -   5        $��	nameLabel��5      $��Имя:��6!   $
��Left=�60   $��	11,48,0,0q�6K   $	��Top=�6^   �� 5   
   -   5        $��surnameLabel��5      $��Фамилия:��6%   $
��Left=�68   $��	11,79,0,0q�6S   $	��Top=�6f   �� 5   
   -   5        $��	bDayLabel��5      $��Дата рождения��6"   $
��Left=�6:   $��
11,110,0,0q�6U   $	��Top=�6i   �� 5   
   -   5        $��nameTextBox��5      $
��Left=�6&   $��24��6A   $��	52,48,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��280��6�   �� 5   
   -   5        $��surnameTextBox��5      $
��Left=�6(   $��24��6C   $��	78,79,0,0q�6O   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��254��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��dateOfBirthDatePicker��5      $
��Left=�62   $��111,110,0,0q�6M   $	��Top=�6b   $��24��6z   $	��221��6�      DisplayDateEnd$ 
2017-10-27X�6�      DisplayDateStart$ 
1920-01-01X�6�      Text$ ff��6�      IsTodayHighlighted .  6�   �� 5   
   -   5        $��telephoneLabel��5      $��Телефон��6'   $
��Left=�69   $��
11,139,0,0q�6T   $	��Top=�6h   �� 5   
   -   5        $��telephoneTextBox��5      $
��Left=�6*   $��24��6E   $��
78,139,0,0q�6Q   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��254��6�   �� 5   
   -	   5        $��PINLabel��5      $��ИИН��6!   $
��Left=�6/   $��
10,168,0,0q�6J   $	��Top=�6^   �� 5   
   -
   5        $��
PINTextBox��5      $
��Left=�6$   $��24��6?   $��
51,168,0,0q�6K   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��281��6�   �� 5   
   -   5        $��passwordLabel��5      $��Пароль��6&   $
��Left=�67   $��
10,197,0,0q�6R   $	��Top=�6f   �� 5   
   -   5        $��passwordTextBox��5      $
��Left=�6)   $��23��6D   $��
66,197,0,0q�6P   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��266��6�   �� 5   
   $)��#Подтвердите пароль��6   $
��Left=�6-   $��
11,226,0,0q�6H   $	��Top=�6\   �� 5   
   -   5        $��confirmPasswordTextBox��5      $
��Left=�60   $��24��6K   $��140,226,0,0q�6W   $
 Wrap=�6l   $�� ��6�   $	��Top=�6�   $	��192��6�   �� 5   
   -   5        $��registerButton��5      $��Подтвердить��6'   $
��Left=�6=   $��198,255,0,0q�6X   $	��Top=�6m   $	��134��6�   $��41��6�   6�   �� 5   
   -   5        $��
errorLabel��5      $�� ��6"   $
��Left=�6-   $��
11,255,0,0q�6H   $	��Top=�6\   $	��182��6t   $��42��6�   �� 5   
   $
��Left=�6   $��32��6+   $��	25,10,0,0q�67   $	��Top=�6J   $��81��6b   $��logo.jpg��6m   5      5      