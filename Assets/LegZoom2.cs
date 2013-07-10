using UnityEngine;
using System.Collections;



public class LegZoom2 : MonoBehaviour {

	public GameObject body;
	public GameObject player;
	public GameObject legcamera;
	public GameObject medcamera;
	public GUITexture backbutton;
	public GUITexture simtest;
	public GUITexture simpract;
	public GUIText simtext;
	public GUITexture menu;
	public string[] myStrings; 
	public int currIndex;
	public GUITexture steps;
	public Texture2D[] pracstep = new Texture2D[25];
	public int step= -1;
	
	
	

	
	// Use this for initialization
	void Start () {
		
		
		Screen.showCursor = true;
	
	}
	
	
	// Update is called once per frame
	void Update () {
	
		Vector3 StartPos = legcamera.transform.position;
		Vector3 EndPos = new Vector3 (6.1f, 9.1f, -4.017f);

		
		

		
	if(((body.transform.position.x)-(player.transform.position.x)) <= 2.6f) {
		print ("Change into mode 2");
		
		legcamera.camera.depth =1;
		legcamera.SetActive(true);
		player.GetComponent<AudioSource>().enabled = false;
		legcamera.transform.position = Vector3.Lerp (StartPos, EndPos, Time.deltaTime * 2);
		
			
			
			
			
		
		}
		
	else { 
			medcamera.SetActive(false);
			medcamera.transform.position = new Vector3(8.917773f, 9.703301f, -4.485284f);
			legcamera.SetActive(false);
			legcamera.transform.position = new Vector3(4.54f, 9.434f, -3.932f);
			simtest.enabled = true;
			simpract.enabled = true;
			simtext.enabled = false;
			menu.enabled = false;
			steps.enabled = false;
			}
			
		if (simtest.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)){
			
			simtext.enabled = true;
			simtest.enabled = false;
			simpract.enabled = false;
			menu.enabled = true;
		
		}
		
		if(simpract.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)){
			simtest.enabled = false;
			simpract.enabled = false;
			menu.enabled = true;
			steps.enabled = true;
			
			
			
			
		}
			
		
		/*if (menu.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)){
			
			medcamera.SetActive(false);
			legcamera.SetActive(true);
			simtest.enabled = true;
			simpract.enabled = true;
			simtext.enabled = false;
			menu.enabled = false;
			steps.enabled = false;
			currIndex = 0;
			step = -1;
			simtext.text = myStrings[currIndex];
		
			
		}*/
		
		
		
		if (steps.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)){
			
			
			step++;
			steps.guiTexture.texture = pracstep[step];
	
			}
		
	 	/*Vector3 Start = new Vector3(6.1f, 9.1f, -4.017f);
		Vector3 End = new Vector3(7.792827f, 9.159904f, -4.073456f);
		Quaternion StartRot = new Quaternion(11.57439f, 93.0267f,-360,0);
		Quaternion EndRot = new Quaternion(11.57439f, 270,0,0);
		
		
		
		if (step == 14){
			
			legcamera.transform.position = Vector3.Lerp (Start, End, Time.deltaTime * 2);
			legcamera.transform.rotation = Quaternion.Lerp(StartRot, EndRot, Time.deltaTime *2);
		}
		*/
	
		
		
	myStrings= new string[]{"Lateral Incision", "Mark Incision", "Incise skin & \nSubcutaneous Tissue", "Perform 'H-cut'; \nwatch for peroneal nerve", "Lateral Incision Complete", "Medial Incision", "Mark Incision", "Expose and free Muscles", "Fasciotomy Complete"};
		
		if (simtext.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0)){
			
			currIndex++;
			simtext.text = myStrings[currIndex];
		}
		
		
		
		
	
			
			//legcamera.transform.position = Vector3.Lerp (Start, End, Time.deltaTime * 2);
			//legcamera.transform.rotation = Quaternion.Lerp(StartRot, EndRot, Time.deltaTime *2);
		
	
		}
	

}
			
		
	
			
		
	
		
		
		
	

		


			
	
