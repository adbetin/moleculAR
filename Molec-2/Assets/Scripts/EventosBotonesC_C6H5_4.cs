using UnityEngine;
using System.Collections;

public class EventosBotonesC_C6H5_4 :    MonoBehaviour,
                                            IVirtualButtonEventHandler
{

    
    private GameObject C_C6H5_4;
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
        C_C6H5_4 =GameObject.Find("C(C6H5)4");
		C_C6H5_4.SetActiveRecursively(true);
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
		Debug.Log(EventosBotonesC_C6H5_4.activo);
		if(EventosBotonesC_C6H5_4.activo){
			if(menu==1){
				Debug.Log("Esta mostrando el boton ejes");
				GUI.Label(new Rect (15, 15, 150, 50), "Ejes Propios");

				if(GUI.Button(new Rect(15, 70, 150, 50), "Eje C2")){
					C_C6H5_4.animation.PlayQueued("eje_C2");
					C_C6H5_4.animation.PlayQueued("quieto");
				}
				
				GUI.Label(new Rect (15, 125, 150, 50), "Ejes Impropios");
				
				if(GUI.Button(new Rect(15, 180, 150, 50), "Eje S4")){
					C_C6H5_4.animation.PlayQueued("eje_S4");
					C_C6H5_4.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 180, 150, 50), "Eje S4-3")){
					C_C6H5_4.animation.PlayQueued("eje_S4-3");
					C_C6H5_4.animation.PlayQueued("quieto");
				}
			}			
		}	
	}
}
