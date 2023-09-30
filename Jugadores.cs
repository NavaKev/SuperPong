using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugadores : MonoBehaviour {
	
	public KeyCode teclaArriba,teclaAbajo;
	private Rigidbody2D rbd2d;
	
	
	void Start(){
    	
		rbd2d = GetComponent<Rigidbody2D>();
        
    }

	void Update() {
		if(Input.GetKey(teclaArriba) && Pelota.numToques <= 20){ //Numero de Toques 
			rbd2d.MovePosition(rbd2d.position + (Vector2.up * Time.deltaTime * Juego.velJugador) + new Vector2(0,(float)Pelota.numToques/100.0f));
			
		}
		
		if(Input.GetKey(teclaAbajo) && Pelota.numToques <= 20){
			rbd2d.MovePosition(rbd2d.position + (Vector2.down * Time.deltaTime * Juego.velJugador) - new Vector2(0,(float)Pelota.numToques/100.0f));
			
		}
    	
        
    }
}
