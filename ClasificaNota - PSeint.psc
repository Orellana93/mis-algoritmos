Algoritmo ClasificaNota	
	Repetir
		Escribir "Ingrese la nota de 0 a 20"
		Leer nota
		si nota <= 20 & nota >= 0 Entonces
			Si nota >= 11 Entonces
				si nota = 20 Entonces			
					Escribir "Excelente"
				SiNo
					Escribir "Aprobado"
				fin si			
			SiNo
				Escribir "Desaprobado"
			Fin Si					
		SiNo		
			Escribir "Nota ingresada es incorrecta"
		Fin si
	Hasta Que nota <= 20 & nota >= 0
FinAlgoritmo
