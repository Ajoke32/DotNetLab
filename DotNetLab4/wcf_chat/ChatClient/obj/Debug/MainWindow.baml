   M S B A M L   `   `   `  ????E  AChatClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ChatClient
ChatClient  5   	       ChatClient.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ChatClient     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ? -   5         ? ColumnDefinitions 5
   
   ?? 5      .+?5   
   ?? -   5         ??Name$ 
tbUserName??5      $
??Left=?6&   $??
153,29,0,0q?6A   $??
enter name??6U    ?? TextWrapping$
 Wrap=?6g   $	??Top=?6{   $	??108??6?   $??25??6?   ?? 5   
   -   5         ??Name$ bthConOrDis??5      $??Connect??6&   $
??Left=?68   $??	25,29,0,0q?6S   $	??Top=?6f   $??25??6~   $	??104??6?   6?   ?? 5   
   -   5         ??Name$ tbChat??5      $??25,73,278,155q?6"   ?? 5   
   -   5        $ 	tbMessage??5      $
??Left=?6%   $??
67,294,0,0q?6@   $
 Wrap=?6T   $	??Top=?6h   $??47??6?    J? RenderTransformOrigin$ 0.5,0.5&?6?   $	??400??6?   .??6?   z?5      V? 5      .~?5      ?? ?? 5       ?? AngleY$ -0.099Q?6$   ?? 5      T? 5       T? Y$ -0.398Q?6)   5      .??5   '   5      ?? 5   
   -   5        $ 
OnlineList??5      $??598,73,27,155q?6&   6=   ?? 5   
   $??Online Users??6   $
??Left=?6'   $??
618,36,0,0q?6B   $	??Top=?6V   $??20(?6n   $	??160??6|   $??32??6?   ?? 5   
   -   5        	 ??Name$	 GlobCh??5      $??Glolal chat??6    $
??Left=?66   $??
371,46,0,0q?6Q   $	??Top=?6e   $??16(?6}   $??33??6?   $	??151??6?   ?? 5   
   -   5        $ SendMsg??5      $??Pick user to send message??6"   $
??Left=?6F   $??598,284,0,0q?6a   $	??Top=?6v   $	??175??6?   {?.  $??20??6?   ?? 5   
   -	   5        $ PersChat??5      $y?Hidden=?6$   $
??Left=?68   $	??195??6S   $??	25,84,0,0q?6`   $	??Top=?6s   $	??497??6?   ?? 5   
   -
   5        $ NotList??5      $??598,337,22,17q?6#   6:   ?? 5    
   $??Notification??6   $??648,311,72,97q?6'   5"      5#      