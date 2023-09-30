using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Juego : MonoBehaviour {
	
	public AudioSource audio;
	public AudioClip sndsilbato, endGame;
	public Text TxTGameOver;
	
	private GameObject TxTMarcador;
	private GameObject pelota; 
	
	
	public static float  velBola = 6.0f, velJugador = 10f;
	private int signoX, signoY, velocidad = 4;
	private float movHor, movVer;
	public GameObject JugadorIzq, JugadorDer;
	
	
	void Start(){
		TxTGameOver.gameObject.SetActive(false);
		audio = GetComponent<AudioSource>();
		pelota = GameObject.Find("Pelota"); 
		TxTMarcador = GameObject.Find("TxTMarcador"); // Equivalente 
		TxTMarcador.GetComponent<Text>().text = "0-0"; // Equivalente 
		
		movHor = Random.Range(0 ,10);
		Debug.Log("Mov horizontal: " + movHor.ToString());
		if (movHor > 5) { // Variable aleatoria que nos permitirá mover la pelota a la izquierda o la derecha 
			signoX = 1;
			
		} else{
			
			signoX = -1;		
		}
        
		StartCoroutine(ArbitoPitaInicio());
    }

	void Update() {
		if (Input.GetKey(KeyCode.Escape)){
			SceneManager.LoadScene("Inicio");
		}
		if (Pelota.golesJugadorDer == 5 || Pelota.golesJugadorIzq == 5) {
			if (Input.anyKey){
				Pelota.golesJugadorDer = 0;
				Pelota.golesJugadorIzq = 0;
				SceneManager.LoadScene("Inicio");
				
			}	
		}    
	}
	
	public void EscrirbeMarcador(){
		TxTMarcador.GetComponent<Text>().text = Pelota.golesJugadorIzq.ToString() + " - " + Pelota.golesJugadorDer.ToString();
		if (Pelota.golesJugadorDer == 5 || Pelota.golesJugadorIzq == 5) {
			TxTGameOver.gameObject.SetActive(true);
			audio.clip = endGame;
			audio.Play();
		}else{
			JugadorDer.transform.position = new Vector2(JugadorDer.transform.position.x,0);
			JugadorIzq.transform.position = new Vector2(JugadorIzq.transform.position.x, 0);
			StartCoroutine(ArbitoPitaInicio());
		
		}
	}
	
	IEnumerator ArbitoPitaInicio() { // Determinar el tiempo de espera antes de que el arbitro pite inicio
		
		yield return new WaitForSeconds(2.0f);
		// Se ejecuta despues de la pausa 
		LanzaPelota();
	}
	
	public void LanzaPelota(){
		audio.clip = sndsilbato; 
		audio.Play();
		pelota.transform.position = gameObject.transform.position = new Vector2(0,0);
		movVer = Random.Range(0,10);
		Debug.Log("Mov Vertical : " + movVer.ToString());
		if (movVer > 5 ) { 
			signoY = 1;
		}else {
			signoY = -1;
		}
		
		pelota.GetComponent<Rigidbody2D>().velocity = new Vector2(signoX * velocidad, signoY * velocidad);
			
	}
		
}
