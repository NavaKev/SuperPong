using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar : MonoBehaviour
{
	public IAComputadora iaScrip1;
	public IAComputadora iaScrip2;
    // Start is called before the first frame update
	void awake(){
		iaScrip1.enabled = true;
		iaScrip2.enabled = true;
	}
	

    // Update is called once per frame
    void Update()
	{
    	
		if (Niveles.LadoDeJuego == 2){
			iaScrip2.enabled = false;
		}
		
		if (Niveles.LadoDeJuego == 1){
			iaScrip1.enabled = false;
		}
		
		if(Configuracion.tipoJuego == 3 ){
			iaScrip2.enabled = false;
			iaScrip1.enabled = false;
			
		}
        
    }
}
