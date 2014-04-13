using UnityEngine;
using System.Collections;

public class EventosBotonesFe_C5H5N_6 :    MonoBehaviour,
                                            IVirtualButtonEventHandler
{

    
    private GameObject Fe_C5H5N_6;
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
        Fe_C5H5N_6 =GameObject.Find("Fe(C5H5N)6");
		Fe_C5H5N_6.SetActiveRecursively(true);
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
		Debug.Log(EventosBotonesFe_C5H5N_6.activo);
		if(EventosBotonesFe_C5H5N_6.activo){
			if(menu==1){
				Debug.Log("Esta mostrando el boton ejes");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Eje C3(a)")){
					Fe_C5H5N_6.animation.PlayQueued("eje_C3a");
					Fe_C5H5N_6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 15, 150, 50), "Eje C3(a)-2")){
					Fe_C5H5N_6.animation.PlayQueued("eje_C3-2a");
					Fe_C5H5N_6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(325, 15, 150, 50), "Eje C3(b)")){
					Fe_C5H5N_6.animation.PlayQueued("eje_C3b");
					Fe_C5H5N_6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 70, 150, 50), "Eje C3(b)-2")){
					Fe_C5H5N_6.animation.PlayQueued("eje_C3-2b");
					Fe_C5H5N_6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 70, 150, 50), "Eje C3(c)")){
					Fe_C5H5N_6.animation.PlayQueued("eje_C3c");
					Fe_C5H5N_6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(325, 70, 150, 50), "Eje C3(c)-2")){
					Fe_C5H5N_6.animation.PlayQueued("eje_C3-2c");
					Fe_C5H5N_6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 125, 150, 50), "Eje C3(d)")){
					Fe_C5H5N_6.animation.PlayQueued("eje_C3d");
					Fe_C5H5N_6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 125, 150, 50), "Eje C3(d)-2")){
					Fe_C5H5N_6.animation.PlayQueued("eje_C3-2d");
					Fe_C5H5N_6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 180, 150, 50), "Eje C2(a)")){
					Fe_C5H5N_6.animation.PlayQueued("eje_C2a");
					Fe_C5H5N_6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 180, 150, 50), "Eje C2(b)")){
					Fe_C5H5N_6.animation.PlayQueued("eje_C2b");
					Fe_C5H5N_6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(325, 180, 150, 50), "Eje C2(c)")){
					Fe_C5H5N_6.animation.PlayQueued("eje_C2c");
					Fe_C5H5N_6.animation.PlayQueued("quieto");
				}
			}
			else if(menu==2){
				Debug.Log("esta mostrando el boton planos");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Plano Oh(a)")){
						Fe_C5H5N_6.animation.PlayQueued("plano_Oha");
				}
				if(GUI.Button(new Rect(170, 15, 150, 50), "Plano Oh(b)")){
						Fe_C5H5N_6.animation.PlayQueued("plano_Ohb");
				}
				if(GUI.Button(new Rect(325, 15, 150, 50), "Plano Oh(c)")){
						Fe_C5H5N_6.animation.PlayQueued("plano_Ohc");
				}
				if(GUI.Button(new Rect(15, 70, 150, 50), "Todos los Planos")){
						Fe_C5H5N_6.animation.PlayQueued("plano_todos");
				}
				if(GUI.Button(new Rect(170, 70, 150, 50), "Quitar Planos")){
						Fe_C5H5N_6.animation.PlayQueued("quieto");
				}
			}
			else if(menu==3){
				Debug.Log("Esta mostrando el boton Inversion");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Centro de inversion")){
					Fe_C5H5N_6.animation.PlayQueued("sphere");
					Fe_C5H5N_6.animation.PlayQueued("quieto");
				}
			}
		}	
	}
}
