@echo off 
del Dibujo/Figura.svg 
dot -Tsvg Dibujo/Figura.dot -o Dibujo/Figura.svg