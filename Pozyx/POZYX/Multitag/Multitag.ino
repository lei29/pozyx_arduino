/**
  The Pozyx ready to range tutorial (c) Pozyx Labs
  Please read the tutorial that accompanies this sketch: https://www.pozyx.io/Documentation/Tutorials/ready_to_range/Arduino

  This demo requires two Pozyx devices and one Arduino. It demonstrates the ranging capabilities and the functionality to
  to remotely control a Pozyx device. Place one of the Pozyx shields on the Arduino and upload this sketch. Move around
  with the other Pozyx device.
*/
#include <Wire.h>
#include <Pozyx_definitions.h>
#include <Pozyx.h>



////////////////////////////////////////////////
////////////////// PARAMETERS //////////////////
////////////////////////////////////////////////

int num_tags = 17;
uint16_t tags[17] = {0x6972, 0x696d, 0x6e2b, 0x690c,0x674c,0x6749,0x6758,0x6704,0x6745,0x6775,0x6746,0x6748,0x675f,0x677c,0x6765,0x695b,0x6911};   

//uint8_t ranging_protocol = POZYX_RANGE_PROTOCOL_PRECISION; // ranging protocol of the Pozyx.
////////////////////////////////////////////////

void setup(){
  Serial.begin(9600);
  Serial.flush();
  
   if(Pozyx.begin() == POZYX_FAILURE){
    Serial.println(F("ERROR: Unable to connect to POZYX shield"));
    Serial.println(F("Reset required"));
    delay(100);
    abort();
  }

  Serial.println(F("----------POZYX POSITIONING V1.0----------"));
  Serial.println(F("NOTES:"));
  Serial.println(F("- No Inputs required."));
  Serial.println();
 // Serial.println(F("- System will auto start anchor configuration"));
 // Serial.println();
  Serial.println(F("- System will auto start ranging (positioning not confirgured)"));
  Serial.println(F("----------POZYX POSITIONING V1.0----------"));
  Serial.println();
  Serial.println(F("Performing manual TAG configuration:"));
  // configures all remote tags and prints the success of their configuration.
  setAnchorsManual();
  delay(2000);
  Serial.println(F("Starting positioning: "));

//Code below prints header
  for(int i=0; i<num_tags; i++){
    Serial.print("     ");// 5 blankS
    Serial.print("ID: ");// 4 SpotS + id lenght= 4 SpotS
    Serial.print(tags[i], HEX);
  }
  
  Serial.println();
  Serial.print("LABEL,Current time, Distance(mm)\n");
}
/////////////////////Setup Complete


void loop(){
  /*device_range_t range;
  int status = 0;
  for (int i = 0; i < num_tags; i++){
    device_range_t range;
    
    int status = Pozyx.doRanging(tags[i],&range);
    
    if (status == POZYX_SUCCESS){
    // prints out the result
     Serial.print("     ");
     Serial.print(range.distance);
     Serial.print("mm");
     for(int i=0; i<(8-String(range.distance).length()+2); i++){
      Serial.print(" ");// blank
     }      
    }else{
      // prints out the error code
      Serial.print("    ");
      Serial.print("   N/A   "); 
      //printErrorCode("positioning", tags[i]);
    }
  }
  Serial.println();
*/
    //device_range_t range;
  int status = 0;
    device_range_t range;
    
    status = Pozyx.doRemoteRanging(tags[2],tags[3],&range);
    
    if (status == POZYX_SUCCESS){
    // prints out the result
     Serial.print("DATA,");
     Serial.print("TIME,");
     Serial.print(range.distance);
     //Serial.print("mm");
     for(int i=0; i<(8-String(range.distance).length()+2); i++){
      Serial.print(" ");// blank
     }      
    }else{
      //prints out the error code
      //Serial.print("    ");
      //Serial.print("   N/A   "); 
      //printErrorCode("positioning", tags[i]);
     Serial.print("DATA,");
     Serial.print("TIME,");
     Serial.print("-1");
    }
    delay(1000);//delay for one second for output ranging(1 output/sec)
  Serial.println();
  // read out the temperature
  //int8_t temperature;
  //Pozyx.regRead(POZYX_TEMPERATURE, &temperature, 1);
  //Serial.print("temprature:");
  //Serial.print(temperature);
  //Serial.println();
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


// function to manually set the tags coordinates
void setAnchorsManual(){
  for (int i = 0; i < num_tags; i++){
    int status = Pozyx.clearDevices(tags[i]);
    if (status == POZYX_SUCCESS){
      Serial.print("Configuring ID 0x");
      Serial.print(tags[i], HEX);
      Serial.println(" success!");
    }else{
      printErrorCode("configuration", tags[i]);
    }
  }
}
