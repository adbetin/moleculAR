using UnityEngine;
using System.Collections;

public class EventosBotonesHOCH2CH2OH :    MonoBehaviour,
                                            IVirtualButtonEventHandler
{

    
    private GameObject HOCH2CH2OH;
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
        HOCH2CH2OH =GameObject.Find("HOCH2CH2OH");
		HOCH2CH2OH.SetActiveRecursively(true);
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
			case "inv":
				Debug.Log("Presiono inv");
				if(menu==3){
					menu=0;
				}else{
					menu=3;
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
		Debug.Log(EventosBotonesHOCH2CH2OH.activo);
		if(EventosBotonesHOCH2CH2OH.activo){
			if(menu==1){
				Debug.Log("Esta mostrando el boton ejes");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Eje C2")){
					HOCH2CH2OH.animation.PlayQueued("eje_C2");
					HOCH2CH2OH.animation.PlayQueued("quieto");
				}
			}
			else if(menu==2){
				Debug.Log("esta mostrando el boton planos");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Plano Oh")){
						HOCH2CH2OH.animation.PlayQueued("plano_Oh");
				}
				if(GUI.Button(new Rect(170, 15, 150, 50), "Quitar Planos")){
						HOCH2CH2OH.animation.PlayQueued("quieto");
				}
			}
			else if(menu==3){
				Debug.Log("Esta mostrando el boton Inversion");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Centro de inversion")){
					HOCH2CH2OH.animation.PlayQueued("sphere");
					HOCH2CH2OH.animation.PlayQueued("quieto");
				}
			}
			
		}	
	}
}
