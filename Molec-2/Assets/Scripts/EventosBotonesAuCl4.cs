using UnityEngine;
using System.Collections;

public class EventosBotonesAuCl4 :    MonoBehaviour,
                                            IVirtualButtonEventHandler
{

    
    private GameObject AuCl4;
	public static bool activo=false;
	/*private GameObject txtX;
	private GameObject txtY;
	private GameObject txtZ;*/
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
        AuCl4 =GameObject.Find("AuCl4");
		//teoriaAudio.audio.Stop();
		AuCl4.SetActiveRecursively(true);
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
				Debug.Log("Presiono eje_c2");
				//H2O.animation.PlayQueued("eje");
				//H2O.animation.PlayQueued("quieto");
				if(menu==1){
					menu=0;
				}else{
					menu=1;
				}			
				break;
			case "planos":
				Debug.Log("Presiono plano_sigma1");
				//H2O.animation.PlayQueued("planos");
				//H2O.animation.PlayQueued("quieto");
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
		Debug.Log(EventosBotonesAuCl4.activo);
		if(EventosBotonesAuCl4.activo){
			if(menu==1){
				Debug.Log("Esta mostrando el boton ejes");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Eje C4")){
					AuCl4.animation.PlayQueued("eje_C4");
					AuCl4.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 15, 150, 50), "Eje C2 a")){
					AuCl4.animation.PlayQueued("eje_C2a");
					AuCl4.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 70, 150, 50), "Eje C2 b")){
					AuCl4.animation.PlayQueued("eje_C2b");
					AuCl4.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 70, 150, 50), "Eje C2 c")){
					AuCl4.animation.PlayQueued("eje_C2c");
					AuCl4.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 125, 150, 50), "Eje C2 d")){
					AuCl4.animation.PlayQueued("eje_C2d");
					AuCl4.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 125, 150, 50), "Eje C2 e")){
					AuCl4.animation.PlayQueued("eje_C2e");
					AuCl4.animation.PlayQueued("quieto");
				}
			}
			else if(menu==2){
				Debug.Log("esta mostrando el boton planos");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Plano O(a)")){
						AuCl4.animation.PlayQueued("plano_Oa");
					
				}
				if(GUI.Button(new Rect(170, 15, 150, 50), "Plano O(b)")){
						AuCl4.animation.PlayQueued("plano_Ob");
						
				}
				if(GUI.Button(new Rect(15, 70, 150, 50), "Plano O(c)")){
						AuCl4.animation.PlayQueued("plano_Oc");
						
				}
				if(GUI.Button(new Rect(170, 70, 150, 50), "Plano O(d)")){
						AuCl4.animation.PlayQueued("plano_Od");
						
				}
				if(GUI.Button(new Rect(15, 125, 150, 50), "Plano O(e)")){
						AuCl4.animation.PlayQueued("plano_Oe");
						
				}
				if(GUI.Button(new Rect(170, 125, 150, 50), "Todos los Planos")){
						AuCl4.animation.PlayQueued("plano_todos");
				}
				if(GUI.Button(new Rect(15, 180, 150, 50), "Quitar Planos")){
						AuCl4.animation.PlayQueued("quieto");
				}
			}
			
		}	
	}
}