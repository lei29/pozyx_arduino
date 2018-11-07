#include <Pozyx.h>
#include <Pozyx_definitions.h>

// Please read the ready-to-localize tuturial together with this example.
// https://www.pozyx.io/Documentation/Tutorials/ready_to_localize
/**
  The Pozyx ready to local/////////////////////////////////////////////////////ize tutorial (c) Pozyx Labs
  
  Please read the tutorial that accompanies this sketch: https://www.pozyx.io/Documentation/Tutorials/ready_to_localize/Arduino
  
  This tutorial requires at least the contents of the Pozyx Ready to Localize kit. It demonstrates the positioning capabilities
  of the Pozyx device both locally and remotely. Follow the steps to correctly set up your environment in the link, change the
  parameters and upload this sketch. Watch the coordinates change as you move your device around!
*/
#include <Pozyx.h>
#include <Pozyx_definitions.h>
#include <Wire.h>
#include <math.h>
////////////////////////////////////////////////
////////////////// PARAMETERS //////////////////
////////////////////////////////////////////////
int counterloop=0;

int num_tags = 4;
uint16_t tags[4] = {0x6746, 0x6748, 0x6911,0x6972};                        

boolean use_processing = false;                         // set this to true to output data for the processing sketch   
uint8_t num_anchors = 4;                                    // the number of anchors
uint16_t anchors[4] = {0x6e67, 0x6e74, 0x6e77, 0x6925};     // the network id of the anchors: change these to the network ids of your anchors.
int32_t anchors_x[4] = {0, 0, 5560,5560 };               // anchor x-coorindates in mm
int32_t anchors_y[4] = {0, 6120, 6120, 0};                  // anchor y-coordinates in mm
int32_t heights[4] = {1400, 2160, 1730, 2340};              // anchor z-coordinates in mm

uint8_t algorithm = POZYX_POS_ALG_UWB_ONLY;             // positioning algorithm to use
uint8_t dimension = POZYX_3D;                           // positioning dimension
int32_t height = 710;                                  // height of device, required in 2.5D positioning


////////////////////////////////////////////////

void setup(){
  Serial.begin(9600);
  
  if(Pozyx.begin() == POZYX_FAILURE){
    Serial.println(F("ERROR: Unable to connect to POZYX shield"));
    Serial.println(F("Reset required"));
    delay(100);
    abort();
  }

  Serial.println(F("----------POZYX POSITIONING V1.0----------"));
  Serial.println(F("NOTES:"));
  Serial.println(F("- No parameters required."));
  Serial.println();
  Serial.println(F("- System will auto start anchor configuration"));
  Serial.println();
  Serial.println(F("- System will auto start positioning"));
  Serial.println(F("----------POZYX POSITIONING V1.0----------"));
  Serial.println();
  Serial.println(F("Performing manual anchor configuration:"));
  
  // configures all remote tags and prints the success of their configuration.
  setAnchorsManual();
  delay(2000);
  
  Serial.println(F("Starting positioning: "));
  Header();
  Serial.println();
  String lable = "LABEL,Current time, A_x,A_y,A_z,B_x,B_y,B_z,C_x,C_y,C_z,AB dist, AC dist, BC dist";
  Serial.print("LABEL,Current time,");
  for(int i=0;i<num_tags;i++){
        Serial.print("0x");
        Serial.print(tags[i],HEX);
        Serial.print("_x,");
        Serial.print("0x");
        Serial.print(tags[i],HEX);
        Serial.print("_y,");
        Serial.print("0x");
        Serial.print(tags[i],HEX);
        Serial.print("_z,");
        
        
  }
  for (int i=0; i < num_tags;i++){  
    for (int j=i+1;j<num_tags;j++){
      Serial.print("0x");
      Serial.print(tags[i],HEX);
      Serial.print("-0x");
      Serial.print(tags[j],HEX);
      if(i==num_tags-2 && j ==num_tags-1){
        Serial.print("_dist");  
      }else{
        Serial.print("_dist,");
      }
    }
  }
  Serial.println("\n");

}
void loop(){
  /*
  for (int i = 0; i < num_tags; i++){
    coordinates_t position;
    int status = Pozyx.doRemotePositioning(tags[i], &position, dimension, height, algorithm);
    if (status == POZYX_SUCCESS){
    // prints out the result
    printCoordinates(position, tags[i],counterloop);
    
    }else{
      // prints out the error code
     // printErrorCode("positioning", tags[i]);
    }
  }
  */
//Serial.print("In loop!!\n");
//declaration
long distancesqr; 
long distance;
//int status;
coordinates_t position[num_tags]; //malloc memory for coordinates for each tag
Serial.print("DATA, ");
Serial.print("TIME, ");
//get position(coordinates) for each tag
for (int i=0; i < num_tags;i++){
  int status = Pozyx.doRemotePositioning(tags[i], &position[i], dimension, height, algorithm);
  if (status == POZYX_SUCCESS){
    // prints out the result
    printCoordinates(position[i], tags[i],counterloop);
    if(i!=num_tags-1){
      Serial.print(",  ");  
    }
  }
}

//using coordinates of each to calculate the distance between them
for (int i=0; i < num_tags;i++){  
  int status = Pozyx.doRemotePositioning(tags[i], &position[i], dimension, height, algorithm);
  if (status == POZYX_SUCCESS){
    for (int j=i+1;j<num_tags;j++){
      int status = Pozyx.doRemotePositioning(tags[j], &position[j], dimension, height, algorithm);
      if (status == POZYX_SUCCESS){
         long x_dist = (position[i].x - position[j].x);
         long y_dist = (position[i].y - position[j].y);
         long z_dist = (position[i].z - position[j].z);
         x_dist = abs(x_dist);
         y_dist = abs(y_dist);
         z_dist = abs(z_dist);
         /*
         Serial.print("x_dist:");
         Serial.print(x_dist);
         Serial.print("    y_dist:");
         Serial.print(y_dist);
         Serial.print("    z_dist:");
         Serial.print(z_dist);
         */
         long x_sqr = x_dist*x_dist;
         long y_sqr = y_dist*y_dist;
         long z_sqr = z_dist*z_dist;
         distancesqr = x_sqr+y_sqr+z_sqr; 
/*
          Serial.print("\n");
         Serial.print("x_sqr:");
         Serial.print(x_sqr);
         Serial.print("y_srq:");
         Serial.print(y_sqr);
         Serial.print("z_sqr:");
         Serial.print(z_sqr);
         // distancesqr = pow((position[i].x - position[j].x) , 2.0) + pow((position[i].y - position[j].y) , 2.0)+pow((position[i].z - position[j].z) , 2.0);  
          Serial.print ("DISTANCE sq: ");
          Serial.print(distancesqr,DEC);
          */
          distance = pow(distancesqr,0.5);
          /*
          Serial.print (tags[i], HEX);
          Serial.print(" ");
          Serial.print(tags[j], HEX);
          Serial.print (" Distance: ");
          Serial.print (distance,DEC);
          Serial.println("");
          */
          Serial.print (",");
          Serial.print (distance,DEC);
          
        }
    }  
  }
}
Serial.println("");
  if (counterloop < 30000)
  counterloop=counterloop+1;
  else
  counterloop=0;
}

// prints the coordinates for either humans or for processing
void printCoordinates(coordinates_t coor, uint16_t network_id,int counterloop){
  /*
  if(!use_processing){
    Serial.print("POS ID 0x");
    Serial.print(network_id, HEX);
    Serial.print(", x(mm): ");
    Serial.print(coor.x);
    Serial.print(", y(mm): ");
    Serial.print(coor.y);
    Serial.print(", z(mm): ");
    Serial.println(coor.z);
  }else{
    Serial.print("POS,0x");
    Serial.print(network_id, HEX);
    Serial.print(",");
    Serial.print(coor.x);
    Serial.print(",");
    Serial.print(coor.y);
    Serial.print(",");
    Serial.println(coor.z);
  }*/
      String ID =String(network_id, HEX);
      //String value= "ID 0x" + ID +":"+coor.x+","+coor.y+","+coor.z;
      //String value= coor.x+","+coor.y+","+coor.z;
      Serial.print(coor.x);
      Serial.print(",");
      Serial.print(coor.y);
      Serial.print(",");
      Serial.print(coor.z);
}

// error printing function for debugging
void printErrorCode(String operation, uint16_t network_id){
  uint8_t error_code;
  int status = Pozyx.getErrorCode(&error_code, network_id);
  if(status == POZYX_SUCCESS){
    Serial.print("ERROR ");
    Serial.print(operation);
    Serial.print(" on ID 0x");
    Serial.print(network_id, HEX);
    Serial.print(", error code: 0x");
    Serial.println(error_code, HEX);
  }else{
    Pozyx.getErrorCode(&error_code);
    Serial.print("ERROR ");
    Serial.print(operation);
    Serial.print(", couldn't retrieve remote error code, local error: 0x");
    Serial.println(error_code, HEX);
  }
}

// function to manually set the anchor coordinates
void setAnchorsManual(){
  for (int i = 0; i < num_tags; i++){
    int status = Pozyx.clearDevices(tags[i]);
    for(int j = 0; j < num_anchors; j++){
      device_coordinates_t anchor;
      anchor.network_id = anchors[j];
      anchor.flag = 0x1; 
      anchor.pos.x = anchors_x[j];
      anchor.pos.y = anchors_y[j];
      anchor.pos.z = heights[j];
      status &= Pozyx.addDevice(anchor, tags[i]);
    }
    if (status == POZYX_SUCCESS){
      Serial.print("Configuring ID 0x");
      Serial.print(tags[i], HEX);
      Serial.println(" success!");
    }else{
      printErrorCode("configuration", tags[i]);
    }
  }
}



//-----------------------------------------------------------------------------
void Header(){
  //Code below prints header
  for(int i=0; i<num_tags; i++){
    Serial.print("     ");// 5 blankS
    Serial.print("ID: ");// 4 SpotS + id lenght= 4 SpotS
    Serial.print(tags[i], HEX);
  }
  
  Serial.println();
}
