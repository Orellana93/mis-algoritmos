Algoritmo ClasificaNota	
	Definir resultado como real
	Definir ok Como Logico
	Repetir
		ok <- Verdadero
		Escribir "Ingresar 2 nros para operar:"
		Leer nro1
		Leer nro2
		Escribir "Ingresar a hora el operador, donde 1=Suma, 2=Resta, 3=Multiplicación y 4=División"
		Leer operador
		si nro2 <= 0 & operador = 4 entonces
			Escribir "Para una División, ingrese un número mayor a Cero en el Divisor"
		SiNo			
			Segun operador Hacer
				1:
					resultado <- nro1 + nro2					
				2:
					resultado <- nro1 - nro2			
				3:
					resultado <- nro1 * nro2					
				4:
					resultado <- nro1 / nro2					
				De Otro Modo:
					Escribir "Operador ingresado no es válido"					
					ok <- Falso
			Fin Segun		
			si Ok = Verdadero Entonces
				Escribir "El resultado es: " resultado
			FinSi			
		FinSi		
	Hasta Que operador <= 4 & operador >= 1
FinAlgoritmo
