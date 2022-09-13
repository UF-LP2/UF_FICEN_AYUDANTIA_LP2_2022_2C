#!/bin/bash

dotnet build
clear && echo ""

$MODE_
read -p "[1]: Greedy Algorithm - [ENTER]: Dynamic Programming Algorithm: " MODE_
echo "Ingreso el valor ${MODE_}"
clear && echo ""

read -p "Ingresar valor mayor a 0: " VALUE_
echo "Ingreso el valor ${VALUE_}"
clear && echo ""

if [[ -n $MODE_ ]] ; then

  echo "Greedy Algorithm"
  echo -e "Código en Python >> "
  time python problema_vuelto.py $VALUE_

  echo "" && echo "--------------------------" && echo ""

  echo -e "Código en C# >> "
  time ./bin/Debug/net6.0/Problema_Del_Vuelto $VALUE_

else 

  echo "Dynamic Programming Algorithm"
  echo -e "Código en C# >> "
  time ./bin/Debug/net6.0/Problema_Del_Vuelto $VALUE_ 2

fi