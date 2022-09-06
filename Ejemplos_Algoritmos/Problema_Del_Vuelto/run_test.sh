#!/bin/bash

dotnet build
clear && echo ""

read -p "Ingresar valor mayor a 0: " INPUT
echo "Ingreso el valor ${INPUT}"
clear && echo ""

echo -e "Código en Python >> "
time python problema_vuelto.py $INPUT

echo ""
echo "--------------------------"
echo ""

echo -e "Código en C# >> "
time ./bin/Debug/net6.0/Problema_Del_Vuelto $INPUT