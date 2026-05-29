Algoritmo CalculadoraIMC		
	Definir IMC Como real
	Repetir		
		Escribir "Para medir su IMC, ingrese su peso y luego la altura"
		Leer peso
		Leer altura		
		si peso <= 0 Entonces			
			Mostrar "Ingrese un peso aceptable mayor a 0"			
		SiNo			
			si altura <= 0 Entonces
				Mostrar "Ingrese una altura aceptable mayor a 0"			
			SiNo				
				IMC <- (peso / (altura)^2)
				Si IMC < 18.5 Entonces
					mostrar "Usted se encuentra bajo de peso" 
				sino 
					Si IMC < 25 Entonces
						mostrar "Usted se encuentra con un peso normal"
					sino 
						Si IMC < 30
							mostrar "Usted se encuentra con Sobrepeso"
						SiNo
							mostrar "Usted se encuentra con Obesidad"
						FinSi
					FinSi
				FinSi
				Mostrar "Su IMC es " IMC
			FinSi				
		FinSi		
	Hasta Que peso > 0 | altura > 0
FinAlgoritmo