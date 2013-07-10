using UnityEngine;
using System.Collections;

public enum Swipe{Left,Right,Up,Down};

public class SwipeTest : MonoBehaviour {
        float screenDiagonalSize;
        float minSwipeDistancePixels;
        bool touchStarted;
        Vector2 touchStartPos;
        public float minSwipeDistance = .1f;
        public static event System.Action<Swipe> OnSwipeDetected;
	
	
        
        void Start() {
                screenDiagonalSize = Mathf.Sqrt(Screen.width * Screen.width + Screen.height * Screen.height);
                minSwipeDistancePixels = minSwipeDistance * screenDiagonalSize; 
				print ("HELLO MegaWorldPathDeform");
        }
        
        void Update() {
                if (Input.touchCount > 0) {
                                var touch = Input.touches[0];
                                
                                switch (touch.phase) {
                                
                                case TouchPhase.Began:
                                        touchStarted = true;
                                        touchStartPos = touch.position;
                                        break;
                                        
                                case TouchPhase.Ended:
                                        if (touchStarted) {
                                                this.TestCorrectSwipeGesture(touch);
                                                touchStarted = false;
                                        }
                                        break;
                                        
                                case TouchPhase.Canceled:
                                        touchStarted = false;
                                        break;
                                        
                                case TouchPhase.Stationary:
                                        break;

                                case TouchPhase.Moved:
                                        break;
                        }
                }               
        }
        
        void TestCorrectSwipeGesture(Touch touch){
                        Vector2 lastPos = touch.position;
                        float distance = Vector2.Distance(lastPos, touchStartPos);
                        
						if (TestSwipeDirection(touch, 1)){
							if (TestSwipeLocation(touch, 1)){
								if (TestSwipeDistance(touch, 1)){
									callNewAnimation();
								}
							}
		              }
                
        }
	
			bool TestSwipeDirection(Touch touch, int testNum){
				Vector2 lastPos = touch.position;
		        float distance = Vector2.Distance(lastPos, touchStartPos);            
		        if (distance > minSwipeDistancePixels) {
					float dy = lastPos.y - touchStartPos.y;
					float dx = lastPos.x - touchStartPos.x;
		            float angle = Mathf.Rad2Deg * Mathf.Atan2(dx, dy);
					print("Angle is: " + angle);
				}  
				return true;
			}
			
			bool TestSwipeLocation(Touch touch, int testNum){
		        Vector2 lastPos = touch.position;         
				Vector2 midPoint = new Vector2((touchStartPos.x + lastPos.x)/2,(touchStartPos.y + lastPos.y)/2);
				print ("midPoint is " + midPoint);
				return true;
				
			}
			
			bool TestSwipeDistance(Touch touch, int testNum){  //Tests the Swipe Distance to see if it correpsonds to the 
				Vector2 lastPos = touch.position;
				float distance = Vector2.Distance(lastPos, touchStartPos);
				print("distance is " + distance);
				return true;
			}
		
			void callNewAnimation(){
				
			}
	
}