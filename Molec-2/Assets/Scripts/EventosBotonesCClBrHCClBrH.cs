using UnityEngine;
using System.Collections;

public class EventosBotonesCClBrHCClBrH :    MonoBehaviour,
                                            IVirtualButtonEventHandler
{

    
    private GameObject CClBrHCClBrH;
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
        CClBrHCClBrH =GameObject.Find("CClBrHCClBrH");
		CClBrHCClBrH.SetActiveRecursively(true);
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
		Debug.Log(EventosBotonesCClBrHCClBrH.activo);
		if(EventosBotonesCClBrHCClBrH.activo){
			if(menu==3){
				Debug.Log("Esta mostrando el boton Inversion");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Centro de inversion")){
					CClBrHCClBrH.animation.PlayQueued("sphere");
					CClBrHCClBrH.animation.PlayQueued("quieto");
				}
			}
		}	
	}
}
