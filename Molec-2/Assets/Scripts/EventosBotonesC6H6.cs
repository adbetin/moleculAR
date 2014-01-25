using UnityEngine;
using System.Collections;

public class EventosBotonesC6H6 :    MonoBehaviour,
                                            IVirtualButtonEventHandler
{

    
    private GameObject C6H6;
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
        C6H6 =GameObject.Find("C6H6");
		//teoriaAudio.audio.Stop();
		C6H6.SetActiveRecursively(true);
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
		Debug.Log(EventosBotonesC6H6.activo);
		if(EventosBotonesC6H6.activo){
			if(menu==1){
				Debug.Log("Esta mostrando el boton ejes");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Eje C6")){
					C6H6.animation.PlayQueued("eje_C");
					C6H6.animation.PlayQueued("eje_C6");
					C6H6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 15, 150, 50), "Eje C6(4)")){
					C6H6.animation.PlayQueued("eje_C");
					C6H6.animation.PlayQueued("eje_C6");
					C6H6.animation.PlayQueued("eje_C6");
					C6H6.animation.PlayQueued("eje_C6");
					C6H6.animation.PlayQueued("eje_C6");
					C6H6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 70, 150, 50), "Eje C3")){
					C6H6.animation.PlayQueued("eje_C");
					C6H6.animation.PlayQueued("eje_C3");
					C6H6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 70, 150, 50), "Eje C3(2)")){
					C6H6.animation.PlayQueued("eje_C");
					C6H6.animation.PlayQueued("eje_C3");
					C6H6.animation.PlayQueued("eje_C3");
					C6H6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 125, 150, 50), "Eje C2")){
					C6H6.animation.PlayQueued("eje_C");
					C6H6.animation.PlayQueued("eje_C2");
					C6H6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 125, 150, 50), "Eje C2 pa")){
					C6H6.animation.PlayQueued("eje_C2pa");
					C6H6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 180, 150, 50), "Eje C2 pb")){
					C6H6.animation.PlayQueued("eje_C2pb");
					C6H6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 180, 150, 50), "Eje C2 pc")){
					C6H6.animation.PlayQueued("eje_C2pc");
					C6H6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 235, 150, 50), "Eje C2 ppa")){
					C6H6.animation.PlayQueued("eje_C2ppa");
					C6H6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 235, 150, 50), "Eje C2 ppb")){
					C6H6.animation.PlayQueued("eje_C2ppb");
					C6H6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 290, 150, 50), "Eje C2 ppc")){
					C6H6.animation.PlayQueued("eje_C2ppc");
					C6H6.animation.PlayQueued("quieto");
				}
			}
			else if(menu==2){
				Debug.Log("esta mostrando el boton planos");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Plano Oh")){
						C6H6.animation.PlayQueued("plano_oh");
				}
				if(GUI.Button(new Rect(170, 15, 150, 50), "Plano Ov(a)")){
						C6H6.animation.PlayQueued("plano_ova");
						
				}
				if(GUI.Button(new Rect(15, 70, 150, 50), "Plano Ov(b)")){
						C6H6.animation.PlayQueued("plano_ovb");
						
				}
				if(GUI.Button(new Rect(170, 70, 150, 50), "Plano Ov(c)")){
						C6H6.animation.PlayQueued("plano_ovc");
						
				}
				if(GUI.Button(new Rect(15, 125, 150, 50), "Plano Od(a)")){
						C6H6.animation.PlayQueued("plano_oda");
						
				}
				if(GUI.Button(new Rect(170, 125, 150, 50), "Plano Od(b)")){
						C6H6.animation.PlayQueued("plano_odb");
						
				}
				if(GUI.Button(new Rect(15, 180, 150, 50), "Plano Od(c)")){
						C6H6.animation.PlayQueued("plano_odc");
						
				}
				if(GUI.Button(new Rect(170, 180, 150, 50), "Todos los Planos")){
						C6H6.animation.PlayQueued("plano_todos");
				}
				if(GUI.Button(new Rect(15, 235, 150, 50), "Quitar Planos")){
						C6H6.animation.PlayQueued("quieto");
				}
			}
			
		}	
	}
}
