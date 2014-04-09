using UnityEngine;
using System.Collections;

public class EventosBotonesH2O :    MonoBehaviour,
                                            IVirtualButtonEventHandler
{

    
    private GameObject H2O;
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
        H2O =GameObject.Find("H2O");
		H2O.SetActiveRecursively(true);
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
		Debug.Log(EventosBotonesH2O.activo);
		if(EventosBotonesH2O.activo){
			if(menu==1){
				Debug.Log("Esta mostrando el boton ejes");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Animacion eje 1")){
					H2O.animation.PlayQueued("eje");
					H2O.animation.PlayQueued("quieto");
				}
			}
			else if(menu==2){
				Debug.Log("esta mostrando el boton planos");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Planos")){
						H2O.animation.PlayQueued("planos");
				}
				if(GUI.Button(new Rect(15, 70, 150, 50), "Quitar Planos")){
						
						H2O.animation.PlayQueued("quieto");
				}
			}
			
		}	
	}
	
	void Update(){
		Debug.Log("Va a actualizar");
  		if (Input.GetKeyDown(KeyCode.Escape)) 
   			Application.Quit(); 
	}
}
