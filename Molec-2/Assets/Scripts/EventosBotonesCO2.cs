using UnityEngine;
using System.Collections;

public class EventosBotonesCO2 :    MonoBehaviour,
                                            IVirtualButtonEventHandler
{

    
    private GameObject CO2;
	public static bool activo=false;
	int menu=0;
    void Start()
    {
        // Register with the virtual buttons TrackableBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterEventHandler(this);
        }

        // Get handle to the teapot object
        CO2 =GameObject.Find("CO2");
		CO2.SetActiveRecursively(true);
		menu=0;
		Debug.Log("termino de Iniciar");
    }


    // Called when the virtual button has just been pressed:
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed");

        
        // Apply the new texture:
        switch (vb.VirtualButtonName)
        {
           case "ejes":
				Debug.Log("Presiono ejes");
				if(menu==1){
					menu=0;
				}else{
					menu=1;
				}			
				break;
			case "planos":
				Debug.Log("Presiono planos");
				if(menu==2){
					menu=0;
				}else{
					menu=2;
				}	
				break;			
			case "play":
				Debug.Log("Presiono Play");
				audio.Play();
				break;
			
			case "pause":
				Debug.Log("Presiono pause");
				audio.Pause();
				break;
			
			case "stop":
				Debug.Log("Presiono stop");
				audio.Stop();
				break;
        }
    }


    // Called when the virtual button has just been released:
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
    }

	 public void OnMouseEnter() {
        //if (!H2O.animation.IsPlaying("plano"))
        	//txtZ.SetActiveRecursively(true);
    }
	
	private void OnGUI(){
		Debug.Log(EventosBotonesCO2.activo);
		if(EventosBotonesCO2.activo){
			if(menu==1){
				Debug.Log("Esta mostrando el boton ejes");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Eje inf-C2")){
					CO2.animation.PlayQueued("eje_infC2");
					CO2.animation.PlayQueued("quieto");	
				}
				if(GUI.Button(new Rect(15, 70, 150, 50), "Eje C-inf")){
					CO2.animation.PlayQueued("eje_Cinf");
					CO2.animation.PlayQueued("quieto");	
				}
			}
			else if(menu==2){
				Debug.Log("esta mostrando el boton planos");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Plano inf-O")){
						CO2.animation.PlayQueued("plano_infO");
				}
				if(GUI.Button(new Rect(170, 15, 150, 50), "Plano Od")){
						CO2.animation.PlayQueued("plano_Od");
				}
				if(GUI.Button(new Rect(15, 70, 150, 50), "Todos los Planos")){
						CO2.animation.PlayQueued("plano_todos");
				}
				if(GUI.Button(new Rect(170, 70, 150, 50), "Quitar Planos")){
						CO2.animation.PlayQueued("quieto");
				}
			}
			
		}	
	}
}
