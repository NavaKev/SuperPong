using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Configuracion : MonoBehaviour {
	
	public Text Op1, Op2;
	public static int tipoJuego = 1; // 1- Vs la computadora, 2-Contra otra persona
	public static int ladoJuego = 1; // 1- Izquierda, 2- derecha.
	// public static int jugadorComputadora; //1-Computadora es el jugador de la Izq, 2-Computadora es el jugador de la derecha 3-Ambos son la computadora

    // Start is called before the first frame update
	void Awake(){
		tipoJuego = 1;
		Op1.gameObject.SetActive(true);
		Op2.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
	void Update(){
		if (Input.GetKey(KeyCode.Alpha1)){
			BorraSubrayado();
			Op1.gameObject.SetActive(true);
			tipoJuego = 1;
		
		}
		
		if (Input.GetKey(KeyCode.Alpha2)){
			BorraSubrayado();
			Op2.gameObject.SetActive(true);
			tipoJuego = 3;
		}
		if (Input.GetKey(KeyCode.Space)){
			if (tipoJuego == 1)
			SceneManager.LoadScene("Niveles");
		}
		if (Input.GetKey(KeyCode.Space)){
			if (tipoJuego == 3)
			SceneManager.LoadScene("Main");
		}
			
	
		}
	
		
	public void BorraSubrayado(){
		Op1.gameObject.SetActive(false);
		Op2.gameObject.SetActive(false);
	
	}
        
}
