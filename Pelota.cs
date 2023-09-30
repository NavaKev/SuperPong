using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
	//Variables de clase 
	Juego miJuego; // Instancia de la clase Juego 
	private AudioSource audio; // Reproductor de sonidos 
	public AudioClip snd1, snd2, sndgol, sndPared; // Clips de audio a ser cargados de forma dinamica 
	
	public static int numToques = 0, golesJugadorIzq = 0, golesJugadorDer = 0;
    
	void Start() {
		audio = GetComponent<AudioSource>();
		miJuego = GameObject.Find("Juego").gameObject.GetComponent<Juego>(); //Acede al componente del objeto y accedo a la clase 
		
	}
	
	
	private void OnTriggerEnter2D(Collider2D colision){
		float compX = 0, compY = 0;
		
		
		// Checa la colision de las porterias 
		if (colision.CompareTag("gol")){
			audio.clip = sndgol;
			audio.Play();
			numToques = 0;
			
			GameObject nombrePorteria = colision.gameObject;
			if (nombrePorteria.name == "PorteriaIzq"){
				golesJugadorDer ++;
			} else if (nombrePorteria.name == "PorteriaDer"){
				golesJugadorIzq ++;
				
			}
			
			miJuego.EscrirbeMarcador();
		}
		
		// Checa la colision del jugador izquierdo
		
		if (colision.CompareTag("jugadorizq")){
			audio.clip = snd1;
			audio.Play();
			numToques++;
			
			float alturaColisionIzq = GameObject.Find("JugadorIzq").gameObject.transform.position.y - transform.position.y;
			compX = Mathf.Cos(alturaColisionIzq);
			compY = Mathf.Sin(alturaColisionIzq);
			
			if ( alturaColisionIzq >= 0){
				GetComponent<Rigidbody2D>().velocity = new Vector2(compX * Juego.velBola + numToques , compY * (Juego.velBola * -1 ) - (float)numToques/2);
				
			}else{
				GetComponent<Rigidbody2D>().velocity = new Vector2(compX * Juego.velBola + numToques , compY * (Juego.velBola * -1 ) + (float)numToques/2);
				
			}	
		}
		
		// Checa la colision del Jugador derecho
		
		if (colision.CompareTag("jugadorder")){
			audio.clip = snd2;
			audio.Play();
			numToques++;
			
			float alturaColisionDer = GameObject.Find("JugadorDer").gameObject.transform.position.y -transform.position.y;
			compX = Mathf.Cos(alturaColisionDer);
			compY = Mathf.Sin(alturaColisionDer);
			
			if ( alturaColisionDer >= 0){
				GetComponent<Rigidbody2D>().velocity = new Vector2(compX * (Juego.velBola * - 1 ) - numToques , compY * (Juego.velBola * -1 ) - (float)numToques/2);
				
			}else{
				GetComponent<Rigidbody2D>().velocity = new Vector2(compX * (Juego.velBola * - 1 ) - numToques , compY * (Juego.velBola * -1 ) + (float)numToques/2);
				
			}
		}
		
		// Checa las colisiones de la pared 
		if (colision.CompareTag("pared")){
			audio.clip = sndPared;
			audio.Play();
		}
	}
		
}
