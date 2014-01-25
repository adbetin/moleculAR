using UnityEngine;

public class EventosBotonesCO2 :    MonoBehaviour,
                                            IVirtualButtonEventHandler
{

    
    private GameObject CO2;
	int flag;
    void Start()
    {
        // Register with the virtual buttons TrackableBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterEventHandler(this);
        }

        // Get handle to the teapot object
        CO2 =GameObject.Find("CO2(A)");
		
		flag=0;
    }


    // Called when the virtual button has just been pressed:
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed");

        
        // Apply the new texture:
        switch (vb.VirtualButtonName)
        {
            case "rotar":
				if(flag==0){
                CO2.animation.PlayQueued("girar");
			}else{
				CO2.animation.PlayQueued("girarPlano");
				CO2.animation.PlayQueued("quieto");
				flag=0;
			}
                break;

            case "planos":
				if(flag==0){
                CO2.animation.PlayQueued("plano");
				flag=1;
			}
                break;
        }
    }


    // Called when the virtual button has just been released:
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
      

       
    }


   
}