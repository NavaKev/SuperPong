using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAComputadora : MonoBehaviour {

	public GameObject miPelota;
	Vector3 posicionPelota;
	float velocidad = 1.0f;
	private static GameObject jugador1, jugador2;

	void Start() {
		jugador1 = GameObject.Find("JugadorIzq").gameObject;
		jugador2 = GameObject.Find("JugadorDer").gameObject;
	}

	void Update() {
		if (Configuracion.tipoJuego == 1 && Niveles.niveles == 1){
			float deltaY = (velocidad * 2) * Time.deltaTime + (float)Pelota.numToques / 1000; //Velocidad computadora 
				posicionPelota = miPelota.gameObject.transform.position;
				if (posicionPelota.x >= -675 && posicionPelota.x >= -660) { //Pelota dentro del terreno de juego
					transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x, posicionPelota.y, 0), deltaY);

				} else {
					
					jugador2.transform.position = new Vector3(-659, -412, 10);
					jugador1.transform.position = new Vector3(-659, -412, 10);
				}
			
		}
		
		if (Configuracion.tipoJuego == 1 && Niveles.niveles == 2 ) {
			float deltaY = (velocidad * 3) * Time.deltaTime + (float)Pelota.numToques / 400f; //Velocidad computadora 
				posicionPelota = miPelota.gameObject.transform.position;

				if (posicionPelota.x >= -675 && posicionPelota.x >= -660) { //Pelota dentro del terreno de juego
					transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x, posicionPelota.y, 0), deltaY);

				} else {
					jugador2.transform.position = new Vector3(-674, -412, 10);
					jugador1.transform.position = new Vector3(-674, -412, 10);
				}
			}
		
		if (Configuracion.tipoJuego == 1 && Niveles.niveles == 3 ) {
			float deltaY = (velocidad * 4) * Time.deltaTime + (float)Pelota.numToques / 200.0f; //Velocidad computadora 
				posicionPelota = miPelota.gameObject.transform.position;

				if (posicionPelota.x >= -675 && posicionPelota.x >= -660) { //Pelota dentro del terreno de juego
					transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x, posicionPelota.y, 0), deltaY);

				} else {
					
					jugador2.transform.position = new Vector3(-674, -412, 10);
					jugador1.transform.position = new Vector3(-674, -412, 10);
				
			}
		}
	}
}
			
			

			
