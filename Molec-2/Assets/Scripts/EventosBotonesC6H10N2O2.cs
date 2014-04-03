using UnityEngine;
using System.Collections;

public class EventosBotonesC6H10N2O2 :    MonoBehaviour,
                                            IVirtualButtonEventHandler
{

    
    private GameObject C6H10N2O2;
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
        C6H10N2O2 =GameObject.Find("C6H10N2O2");
		//teoriaAudio.audio.Stop();
		C6H10N2O2.SetActiveRecursively(true);
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
		Debug.Log(EventosBotonesC6H10N2O2.activo);
		if(EventosBotonesC6H10N2O2.activo){
			if(menu==3){
				Debug.Log("Esta mostrando el boton Inversion");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Centro de inversion")){
					C6H10N2O2.animation.PlayQueued("sphere");
					C6H10N2O2.animation.PlayQueued("quieto");
				}
			}
		}	
	}
}
