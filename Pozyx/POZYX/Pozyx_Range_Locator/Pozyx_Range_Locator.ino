#include <Pozyx.h>
#include <Pozyx_definitions.h>

/// Libraries
#include <Pozyx.h>
#include <Pozyx_definitions.h>
#include <Wire.h>
//wsx

////////////////////////////////////////////////
////////////////// PARAMETERS //////////////////
////////////////////////////////////////////////
//Serial data recieve


// recieving data variable
const byte numChars = 40;
char receivedChars[numChars]; // an array to store the received data
boolean newData = false;
boolean range = true;

// define number of tags and ID for each
//required for both sets of code
int num_tags = 4;
uint16_t tags[4] = {0x6972, 0x696d, 0x6e2b, 0x690c};                        


// Anchor setup and definition
// Required of for positioning piece only

uint8_t num_anchors = 4;                                    // the number of anchors
uint16_t anchors[4] = {0x6e67, 0x6e74, 0x6e77, 0x6925};     // the network id of the anchors: change these to the network ids of your anchors.
uint8_t algorithm = POZYX_POS_ALG_UWB_ONLY;             // positioning algorithm to use
uint8_t dimension = POZYX_3D;                           // positioning dimension
int32_t height = 710;                                  // height of device, required in 2.5D positioning  <--- Update Everytime

////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Setup
void setup(){
  Serial.begin(115200);
  Serial.flush();
  Serial.println("");
   if(Pozyx.begin() == POZYX_FAILURE){
    Serial.println(F("ERROR: Unable to connect to POZYX shield"));
    Serial.println(F("Reset required"));
    delay(100);
    abort();
  }
  /////GEt data from Serial monitor
  int coordinate[13];
  String abc;
  while (abc == "") 
  abc = Serial.readString();//Serial.read();
  char incomingByte[100];   
  abc.toCharArray(incomingByte, 100) ;
  char *p = incomingByte;
  char *str;
  int i = 0;
  String temp[14];
  while ((str = strtok_r(p, ";", &p)) != NULL){ // delimiter is the semicolon
    temp[i]= (str);
    i++;
   }
  for (int i= 1; i<14; i++){
   coordinate[i-1]= temp[i].toInt();
  }   
  if (coordinate[0]== 1){
    range = true;
  }
  else
   { range = false;
   }
  ///// configures all remote tags and prints the success of their configuration.
  if(range==true)  {
  }else{
    int32_t anchors_x[4] = {coordinate[1], coordinate[2],coordinate[3],coordinate[4]};               // anchor x-coorindates in mm
    int32_t anchors_y[4] = {coordinate[5],coordinate[6],coordinate[7],coordinate[8]};                  // anchor y-coordinates in mm
    int32_t heights[4] = {coordinate[9],coordinate[10],coordinate[11],coordinate[12]};              // anchor z-coordinates in mm  setAnchorsManual(anchors_x,anchors_y,heights);
  delay(2000);
  }
}
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// LOOP

void loop(){
  if(range==true)  {
    Range();
  }else{
    Position();
  }
}
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
  //////Ranging
void Range(){
  device_range_t range;
  int status = 0;
  String temp="";
  for (int i = 0; i < num_tags; i++){
    device_range_t range;
    int status = Pozyx.doRanging(tags[i],&range);
    if (status == POZYX_SUCCESS){
    // prints out the result
     temp = temp+ String(range.distance)+";";
    }else{
      // prints out the error code
      temp = temp+ "  N/A;";
    }
  }
  Serial.flush();
  Serial.println(temp);
  delay(50);
}
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
  //// Positioning
  // prints the coordinates for either humans or for processing
   void printCoordinates(coordinates_t coor, uint16_t network_id){
      String ID =String(network_id, HEX);
      String value= "ID 0x" + ID +";"+coor.x+";"+coor.y+";"+coor.z;
      Serial.println(value);
   }

  void Position(){
     for (int i = 0; i < num_tags; i++){
    coordinates_t position;
    int status = Pozyx.doRemotePositioning(tags[i], &position, dimension, height, algorithm);
    if (status == POZYX_SUCCESS){
    printCoordinates(position, tags[i]);
    }
  }
  }
// function to manually set the anchor coordinates
void setAnchorsManual(int32_t anchors_x[4],int32_t anchors_y[4] ,int32_t heights[4]){
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

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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




