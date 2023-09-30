using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Niveles : MonoBehaviour
{
	// Variables de clases
	public Text op1,op2, op3, izquierda, derecha; // Subraya todas las opciones 
	public static int niveles;// Vs Principiante, 2 Intermedio, 3 Avanzado 
	public static int LadoDeJuego; //  Lado Izquierdo, 6-lado derecho 
	
	void start(){
		
		niveles = 1;
		LadoDeJuego = 1;
	}
	
	void Awake(){
		niveles = 1;
		LadoDeJuego = 1;
		op1.gameObject.SetActive(true);
		op2.gameObject.SetActive(false);
		op3.gameObject.SetActive(false);
		izquierda.gameObject.SetActive(true);
		derecha.gameObject.SetActive(false);
	}
 
	void Update(){
		if (Input.GetKey(KeyCode.Alpha1)){
			BorrarSubrayado();
			op1.gameObject.SetActive(true);
			niveles = 1;
		}
		
		if (Input.GetKey(KeyCode.Alpha2)){
			BorrarSubrayado();
			op2.gameObject.SetActive(true);
			niveles = 2;
			
		}
		
		if (Input.GetKey(KeyCode.Alpha3)){
			BorrarSubrayado();
			op3.gameObject.SetActive(true);
			niveles = 3;
		}
		
		if (Input.GetKey(KeyCode.I)){
			SubrayadoLado();
			izquierda.gameObject.SetActive(true);
			LadoDeJuego = 1;
		
		}
		
		if (Input.GetKey(KeyCode.D)){
			SubrayadoLado();
			derecha.gameObject.SetActive(true);
			LadoDeJuego = 2;
			
		}
		
		if (Input.GetKey(KeyCode.Space)){
			SceneManager.LoadScene("Main");
		}
        
	}
    
	public void BorrarSubrayado(){
		op1.gameObject.SetActive(false);
		op2.gameObject.SetActive(false);
		op3.gameObject.SetActive(false);
	
	}
	
	public void SubrayadoLado(){
		izquierda.gameObject.SetActive(false);
		derecha.gameObject.SetActive(false);
	}
}

